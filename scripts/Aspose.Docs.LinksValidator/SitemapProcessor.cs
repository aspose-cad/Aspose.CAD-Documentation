using System.Xml.Linq;
using HtmlAgilityPack;

class SitemapProcessor
{
    private readonly HttpClient _httpClient = new HttpClient();
    private readonly HashSet<string> _visitedSitemaps = new HashSet<string>();
    private readonly HashSet<string> _brokenLinks = new HashSet<string>();
    private readonly HashSet<string> _visitedPages = new HashSet<string>();
    private readonly SemaphoreSlim _throttle;

    public SitemapProcessor(int maxRequestsPerSecond = 30)
    {
        _throttle = new SemaphoreSlim(maxRequestsPerSecond, maxRequestsPerSecond);
    }

    public async Task ProcessSitemapAsync(string url)
    {
        if (_visitedSitemaps.Contains(url))
        {
            return;
        }

        _visitedSitemaps.Add(url);

        await _throttle.WaitAsync();
        try
        {
            string sitemapContent = await _httpClient.GetStringAsync(url);
            XDocument sitemap = XDocument.Parse(sitemapContent);

            var urls = sitemap
                .Descendants("url")
                .Select(u => u.Element("loc")?.Value)
                .Where(v => v != null)
                .ToList();

            var nestedSitemaps = sitemap
                .Descendants("sitemap")
                .Select(s => s.Element("loc")?.Value)
                .Where(v => v != null)
                .ToList();

            foreach (var link in urls)
            {
                if (!await IsLinkValid(link!))
                {
                    _brokenLinks.Add(link!);
                    Console.WriteLine($"Broken link: {link}");
                }
                else
                {
                    await ValidateRelativeLinks(link!);
                }
            }

            foreach (var nestedSitemap in nestedSitemaps)
            {
                await ProcessSitemapAsync(nestedSitemap!);
            }
        }
        finally
        {
            _throttle.Release();
        }
    }

    private async Task<bool> IsLinkValid(string url)
    {
        await _throttle.WaitAsync();
        try
        {
            var response = await _httpClient.GetAsync(url);
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
        finally
        {
            _throttle.Release();
        }
    }

    private async Task ValidateRelativeLinks(string pageUrl)
    {
        if (_visitedPages.Contains(pageUrl))
        {
            return;
        }
        _visitedPages.Add(pageUrl);

        await _throttle.WaitAsync();
        try
        {
            var response = await _httpClient.GetStringAsync(pageUrl);
            var doc = new HtmlDocument();
            doc.LoadHtml(response);

            var links = doc.DocumentNode.SelectNodes("//a[@href]")?
                .Select(node => node.GetAttributeValue("href", ""))
                .Where(href => !string.IsNullOrEmpty(href) && !href.StartsWith("http"))
                .ToList() ?? new List<string>();

            foreach (var relativeLink in links)
            {
                string absoluteUrl = new Uri(new Uri(pageUrl), relativeLink).ToString();
                if (!await IsLinkValid(absoluteUrl))
                {
                    _brokenLinks.Add(absoluteUrl);
                    Console.WriteLine($"Broken relative link on {pageUrl}: {absoluteUrl}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing page {pageUrl}: {ex.Message}");
        }
        finally
        {
            _throttle.Release();
        }
    }
}
