using System.Text.RegularExpressions;

namespace Aspose.Docs.MdUrlsSynchronizer;

public class MdUrlsSynchronizer
{
    private readonly string _contentDir;
    private static readonly Regex UrlRegex = new(@"^url:\s*(.+)$", RegexOptions.Multiline | RegexOptions.Compiled);
    
    public MdUrlsSynchronizer(string contentDir)
    {
        _contentDir = contentDir;
    }
    
    public void Process()
    {
        string enDir = Path.Combine(_contentDir, "en");
        if (!Directory.Exists(enDir))
        {
            Console.WriteLine("English content directory not found.");
            return;
        }
        
        var enFiles = Directory.GetFiles(enDir, "*.md", SearchOption.AllDirectories);
        foreach (var enFile in enFiles)
        {
            string enContent = File.ReadAllText(enFile);
            Match enMatch = UrlRegex.Match(enContent);
            if (!enMatch.Success) continue;
            
            string enUrl = enMatch.Groups[1].Value.Trim();
            string relativePath = Path.GetRelativePath(enDir, enFile);
            
            foreach (var langDir in Directory.GetDirectories(_contentDir))
            {
                string langCode = Path.GetFileName(langDir);
                if (langCode == "en") continue;
                
                string langFile = Path.Combine(langDir, relativePath);
                if (!File.Exists(langFile)) continue;
                
                string langContent = File.ReadAllText(langFile);
                Match langMatch = UrlRegex.Match(langContent);
                if (!langMatch.Success) continue;
                
                string newUrl = $"/{langCode}{enUrl}";
                newUrl = newUrl.Replace("//", "/"); // Ensure no double slashes
                string updatedContent = UrlRegex.Replace(langContent, $"url: {newUrl}");
                File.WriteAllText(langFile, updatedContent);
                
                Console.WriteLine($"Updated: {langFile}");
            }
        }
    }
}