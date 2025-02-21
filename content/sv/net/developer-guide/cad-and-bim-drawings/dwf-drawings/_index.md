---
title: DWF Ritningar
type: docs
weight: 20
url: /sv/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportera DWF Ritningar till PDF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [PDF](https://docs.fileformat.com/pdf/) format. [DWF](https://docs.fileformat.com/cad/dwf/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar på följande sätt:

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som det andra parametern.

### Exempelkod

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extrahera Lager från DWF Ritning**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [JPEG](https://docs.fileformat.com/image/jpeg/) format.

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa ett objekt av klassen [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Extrahera lagernamn med hjälp av [JPEG](https://docs.fileformat.com/image/jpeg/) objektet.
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) som det andra parametern.

### Exempelkod

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Stöd för Lager i DWF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [JPEG](https://docs.fileformat.com/image/jpeg/) format.

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Lägg till önskade lager.
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) som det andra parametern.

### Exempelkod

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportera DWF Ritningar till BMP**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ritningsenheter och rendera dem som en hel ritning till [BMP](https://docs.fileformat.com/image/bmp/) format. [DWF](https://docs.fileformat.com/cad/dwf/) till [BMP](https://docs.fileformat.com/image/bmp/) konverteringsmetoden fungerar på följande sätt:

1. Ladda [DWF](https://docs.fileformat.com/cad/dwf/) ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) som det andra parametern.

### Exempelkod

Kodexemplet nedan visar hur man konverterar en [DWF](https://docs.fileformat.com/cad/dwf/) fil till [BMP](https://docs.fileformat.com/image/bmp/) med standardinställningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
