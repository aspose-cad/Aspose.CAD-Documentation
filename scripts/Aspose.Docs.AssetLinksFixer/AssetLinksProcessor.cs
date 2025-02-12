using System.Text.RegularExpressions;

namespace Aspose.Docs.AssetLinksFixer;

class AssetLinksProcessor
{
    private static readonly Regex ImageRelLinkRegex = new(
        @"!\[(.*?)\]\((?!https?://)(.*?\.(?:png|jpg|jpeg|gif|svg))\)",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private readonly string _mdContentDir;
    private readonly string _assetsPrefix;
    private readonly string _assetsPath;
    private readonly Dictionary<string, string> _assetFiles;
    
    public AssetLinksProcessor(string mdContentDir, string assetsPath)
    {
        _mdContentDir = mdContentDir;
        _assetsPath = assetsPath;
        _assetsPrefix = GetAssetsPrefix(Path.GetFileName(assetsPath.TrimEnd('\\', '/')));
        _assetFiles = Directory
            .GetFiles(_assetsPath, "*.*", SearchOption.AllDirectories)
            .ToDictionary(
                x => GetAssetsMostInnerPath(x), 
                x => GetAssetsRelativePath(x));
    }
    
    public void Process()
    {
        foreach (string file in Directory.EnumerateFiles(_mdContentDir, "*.md", SearchOption.AllDirectories))
        {
            ProcessMdFile(file);
        }
    }
    
    private void ProcessMdFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        
        string updatedContent = ImageRelLinkRegex.Replace(
            content, 
            match =>
            {
                var old = match.Value;
                string altText = match.Groups[1].Value;
                string imgPath = match.Groups[2].Value;
                
                if (imgPath.StartsWith(_assetsPrefix.TrimStart('/')))
                {
                    imgPath = "/" + imgPath;
                }
                else if (!imgPath.StartsWith(_assetsPrefix))
                {
                    imgPath = _assetsPrefix + imgPath;
                }
                
                string imgName = Path.GetFileName(imgPath);
                string innerPath = GetAssetsMostInnerPath(imgPath);
                if (!_assetFiles.ContainsKey(innerPath))
                {
                    var candidates = _assetFiles
                        .Where(x => x.Value.EndsWith(imgName, StringComparison.InvariantCultureIgnoreCase))
                        .ToDictionary(x => x.Key, x => x.Value);
                    
                    if (!candidates.Any())
                    {
                        throw new ($"Warning: No matching file found for {imgPath}");
                    }
                    
                    if (candidates.Count > 1)
                    {
                        var tagsCounts = candidates
                            .ToDictionary(x => x.Key, x => Path.GetDirectoryName(x.Value).Split('/', '\\').ToList())
                            .ToDictionary(x => x.Key, x => x.Value.Where(y => filePath.Contains(y)).ToList())
                            .OrderByDescending(x => x.Value.Count)
                            .ToDictionary(x => x.Key, x => x.Value);
                        
                        var mostMatchedCandidates = tagsCounts
                            .Where(x => x.Value.Count == tagsCounts.First().Value.Count)
                            .ToList();
                        
                        if (mostMatchedCandidates.Count != 1)
                        {
                            throw new (
                                $"Warning: Found multiple files to match {imgPath}:\n"
                                + string.Join(Environment.NewLine, candidates.Select(x => x.Value)));
                        }
                        
                        candidates = new Dictionary<string, string>()
                        {
                            [mostMatchedCandidates.First().Key] = candidates[mostMatchedCandidates.First().Key]
                        };
                    }
                    
                    innerPath = candidates.Single().Key;
                }
                
                string matchedFilePath = _assetFiles[innerPath];
                return $"![{altText}]({matchedFilePath})";
            });
        
        if (content != updatedContent)
        {
            File.WriteAllText(filePath, updatedContent);
            Console.WriteLine($"Updated: {filePath}");
        }
    }
    
    private string GetAssetsRelativePath(string path)
    {
        var unixPath = path.Replace('\\', '/');
        var ind = unixPath.IndexOf(_assetsPrefix);
        var relative = unixPath.Substring(ind);
        return relative;
    }
    
    private string GetAssetsMostInnerPath(string path)
    {
        var fileInfo = new FileInfo(path);
        var dirName = fileInfo.Directory!.Name;
        var fileName = fileInfo.Name;
        if (_assetsPrefix != GetAssetsPrefix(dirName))
        {
            return "/" + dirName + "/" + fileName;
        }
        
        return "/" + fileName;
    }
    
    private static string GetAssetsPrefix(string assetsSlug)
    {
        return $"/{assetsSlug}/";
    }
}