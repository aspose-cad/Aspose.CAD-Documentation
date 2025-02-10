using System;
using System.IO;
using Aspose.Docs.PostProcessing;

class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        args = new[] { @"c:\code\ASP2\docs.aspose.com\Aspose.CAD-Documentation\content\" };
#endif
        
        string rootDir = args[0];
        if (!Directory.Exists(rootDir))
        {
            Console.WriteLine("Error: Directory not found");
            return;
        }
        
        var processor = new AssetLinksProcessor(rootDir);
        processor.Process();
    }
}