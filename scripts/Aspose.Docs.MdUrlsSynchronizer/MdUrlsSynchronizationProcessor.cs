using System.Text.RegularExpressions;

namespace Aspose.Docs.MdUrlsSynchronizer;

public class MdUrlsSynchronizationProcessor
{
    private static readonly Regex ImageRelLinkRegex = new(
        @"!\[(.*?)\]\((?!https?://)(.*?\.(?:png|jpg|jpeg|gif|svg))\)",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private static readonly Regex UrlRegex = new(@"^url:\s*([^\s]+)", RegexOptions.Multiline | RegexOptions.Compiled);
    
    private readonly string _contentDir;
    
    public MdUrlsSynchronizationProcessor(string contentDir)
    {
        _contentDir = contentDir;
    }
    
    public void Process()
    {
        string enDir = Path.Combine(_contentDir, "en");
        var enFiles = Directory.GetFiles(enDir, "*.md", SearchOption.AllDirectories);
        foreach (var enFile in enFiles)
        {
            string enContent = File.ReadAllText(enFile);
            Match enMatch = UrlRegex.Match(enContent);
            string enUrl = enMatch.Groups[1].Value.Trim();
            
            var relPath = ("/" + Path
                .GetRelativePath(_contentDir, Path.GetDirectoryName(enFile)! + '/')
                .Replace('\\', '/'))
                .Replace("/en/", "/");
            
            if (enUrl != relPath)
            {
                enContent = UrlRegex.Replace(enContent, $"url: {relPath}");
                File.WriteAllText(enFile, enContent);
            }
            
            var enRelImageMatches = ImageRelLinkRegex.Matches(enContent);
            
            string relativePath = Path.GetRelativePath(enDir, enFile);
            
            foreach (var langDir in Directory.GetDirectories(_contentDir).Where(x => !x.EndsWith("en")))
            {
                ProcessLocale(langDir, relativePath, relPath, enRelImageMatches);
            }
        }
    }
    
    private static void ProcessLocale(
        string langDir,
        string relativePath,
        string enUrl,
        MatchCollection enRelImageMatches)
    {
        var localeFiles = Directory.GetFiles(langDir, "*.md", SearchOption.AllDirectories);
        foreach (var localeFile in localeFiles)
        {
            var rel = Path.GetRelativePath(langDir, localeFile);
            var enAbs = Path.Combine(Path.GetDirectoryName(langDir) + "/en/" + rel);
            if (!File.Exists(enAbs))
            {
                File.Delete(localeFile);
            }
        }
        
        string langCode = Path.GetFileName(langDir);
        string langFile = Path.Combine(langDir, relativePath);
        if (!File.Exists(langFile))
        {
            return;
        }
        
        string langContent = File.ReadAllText(langFile);
        var localeRelImageMatches = ImageRelLinkRegex.Matches(langContent);
        
        if (localeRelImageMatches.Count != enRelImageMatches.Count)
        {
            throw new InvalidOperationException();
        }
        
        var hasImgLinksUpdates = false;
        var locEnumerator = localeRelImageMatches.Reverse().GetEnumerator();
        foreach (var enRel in enRelImageMatches.Reverse())
        {
            locEnumerator.MoveNext();
            var locRel = locEnumerator.Current;
            if (locRel.Groups[2].Value != enRel.Groups[2].Value)
            {
                hasImgLinksUpdates = true;
                langContent = langContent
                    .Remove(locRel.Groups[2].Index, locRel.Groups[2].Length)
                    .Insert(locRel.Groups[2].Index, enRel.Groups[2].Value);
            }
        }
        
        string newUrl = $"/{langCode}{enUrl}".Replace("//", "/");
        var old = UrlRegex.Match(langContent).Groups[1].Value;
        string updatedContent = UrlRegex.Replace(langContent, $"url: {newUrl}");
        
        if (old != newUrl || hasImgLinksUpdates)
        {
            Console.WriteLine($"Updated: {langFile}");
            File.WriteAllText(langFile, updatedContent);
        }
    }
}