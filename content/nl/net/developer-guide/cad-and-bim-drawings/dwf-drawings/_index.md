---
title: DWF-tekeningen
type: docs
weight: 20
url: /nl/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF-tekeningen exporteren naar PDF**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [PDF](https://docs.fileformat.com/pdf/) formaat te renderen. De conversie van [DWF](https://docs.fileformat.com/cad/dwf/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de eigenschap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande codevoorbeeld toont hoe je een bestand kunt converteren met standaardinstellingen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Lagen extraheren uit een DWF-tekening**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [JPEG](https://docs.fileformat.com/image/jpeg/) formaat te renderen.

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) klasse.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse.
1. Extraheer de naam van de lagen met het [JPEG](https://docs.fileformat.com/image/jpeg/) object.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) als tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande codevoorbeeld toont hoe je een bestand kunt converteren met standaardinstellingen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Ondersteuning van lagen in DWF**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [JPEG](https://docs.fileformat.com/image/jpeg/) formaat te renderen.

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse.
1. Voeg de gewenste lagen toe.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) als tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande codevoorbeeld toont hoe je een bestand kunt converteren met standaardinstellingen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **DWF-tekeningen exporteren naar BMP**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [BMP](https://docs.fileformat.com/image/bmp/) formaat te renderen. De conversie van [DWF](https://docs.fileformat.com/cad/dwf/) naar [BMP](https://docs.fileformat.com/image/bmp/) werkt als volgt:

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) klasse en stel de eigenschap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) als tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande codevoorbeeld toont hoe je een [DWF](https://docs.fileformat.com/cad/dwf/) bestand naar [BMP](https://docs.fileformat.com/image/bmp/) kunt converteren met standaardinstellingen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
