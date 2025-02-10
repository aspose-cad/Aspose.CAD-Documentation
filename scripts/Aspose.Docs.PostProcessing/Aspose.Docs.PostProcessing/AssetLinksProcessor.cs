using System.Text.RegularExpressions;

namespace Aspose.Docs.PostProcessing;

class AssetLinksProcessor
{
    private static readonly Regex ImageRelLinkRegex = new Regex(
        @"!\[(.*?)\]\((?!https?://)(.*?\.(?:png|jpg|jpeg|gif|svg))\)",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private readonly string _mdContentDir;
    private readonly string _assetsPrefix;
    
    public AssetLinksProcessor(string mdContentDir, string assetsPrefix = "_assets")
    {
        _mdContentDir = mdContentDir;
        _assetsPrefix = $"/{assetsPrefix.Trim('/')}/";
    }
    
    public void Process()
    {
        foreach (string file in Directory.EnumerateFiles(_mdContentDir, "*.md", SearchOption.AllDirectories))
        {
            ProcessFile(file);
        }
    }
    
    private void ProcessFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        string updatedContent = ImageRelLinkRegex.Replace(content, match =>
        {
            var old = match.Value;
            string altText = match.Groups[1].Value;
            string imgPath = match.Groups[2].Value;
            
            if (!imgPath.StartsWith("/_assets/"))
            {
                imgPath = "/_assets/" + imgPath;
            }
            
            return $"![{altText}]({imgPath})";
        });
        
        if (content != updatedContent)
        {
            File.WriteAllText(filePath, updatedContent);
            Console.WriteLine($"Updated: {filePath}");
        }
    }
}