using System;
using System.IO;
using Aspose.Docs.AssetLinksFixer;

#if DEBUG
args = new[]
{
    @"c:\code\ASP2\docs.aspose.com\Aspose.CAD-Documentation\content\",
    @"c:\code\ASP2\docs.aspose.com\Aspose.CAD-Documentation\content\en\_assets\"
};
#endif

string rootDir = args[0];
if (!Directory.Exists(rootDir))
{
    Console.WriteLine("Error: Directory with MD files was not found");
    return;
}

string assetsDir = args[1];
if (!Directory.Exists(assetsDir))
{
    Console.WriteLine("Error: Directory with asset files was not found");
    return;
}

var processor = new AssetLinksProcessor(rootDir, assetsDir);
processor.Process();