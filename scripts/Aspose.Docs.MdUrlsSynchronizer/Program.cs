using Aspose.Docs.MdUrlsSynchronizer;

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

var processor = new MdUrlsSynchronizer(rootDir);
processor.Process();