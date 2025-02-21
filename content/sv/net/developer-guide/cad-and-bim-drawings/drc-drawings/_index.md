---  
title: DRC Ritningar  
type: docs  
weight: 15  
url: /sv/net/developer-guide/cad-and-bim-drawings/drc-drawings/  
---  

## **Exportera DRC Ritningar till PDF**  

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) ritningsentiteter och rendera dem som en hel ritning till [PDF](https://docs.fileformat.com/pdf/) format. [DRC](https://docs.fileformat.com/3d/drc/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar enligt följande:  

1. Ladda [DRC](https://docs.fileformat.com/3d/drc/) ritningsfilen med hjälp av [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabriksmetoden.  
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).  
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).  
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.  

### Exempel på kod  

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.  

  
{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
