---
title: DWF-ritningar
type: docs
weight: 50
url: /sv/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportera DWF-ritningar till PDF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [PDF](https://docs.fileformat.com/pdf/) format. [DWF](https://docs.fileformat.com/cad/dwf/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar enligt följande:

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in egenskaperna **page_height** & **page_width**.
1. Skapa ett objekt av klassen **PdfOptions** och ställ in egenskapen **vector_rasterization_options**.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som det andra parametern.

### Exempel på kod

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exportera DWF-ritningar till BMP**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [BMP](https://docs.fileformat.com/image/bmp/) format. [DWF](https://docs.fileformat.com/cad/dwf/) till [BMP](https://docs.fileformat.com/image/bmp/) konverteringsmetoden fungerar enligt följande:

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in egenskaperna **page_height** & **page_width**.
1. Skapa ett objekt av klassen **BmpOptions** och ställ in egenskapen **vector_rasterization_options**.
1. Anropa **Image.save** medan du skickar ett objekt av **BmpOptions** som det andra parametern.

### Exempel på kod

Kodexemplet nedan visar hur man konverterar en [DWF](https://docs.fileformat.com/cad/dwf/) fil till [BMP](https://docs.fileformat.com/image/bmp/) med standardinställningar.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
