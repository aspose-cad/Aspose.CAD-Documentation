using Aspose.Docs.MdUrlsSynchronizer;

/// <summary>
/// Sync 'URL' hugo attributes and IMAGE relative links on LOCALIZED files to 'en'
/// </summary>

#if DEBUG
args = new[]
{
    @"c:\code\ASP2\docs.aspose.com\Aspose.CAD-Documentation\content\"
};
#endif

string rootDir = args[0];
if (!Directory.Exists(rootDir))
{
    Console.WriteLine("Error: Directory with MD files was not found");
    return;
}

var processor = new MdUrlsSynchronizationProcessor(rootDir);
processor.Process();