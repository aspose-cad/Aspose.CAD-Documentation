---
title: DWF-tekeningen
type: docs
weight: 50
url: /nl/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF-tekeningen exporteren naar PDF**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [PDF](https://docs.fileformat.com/pdf/) formaat te renderen. De conversiebenadering van [DWF](https://docs.fileformat.com/cad/dwf/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met behulp van de **Image.load** fabriek methode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** en **page_width** in.
1. Maak een object van de **PdfOptions** klasse en stel de eigenschap **vector_rasterization_options** in.
1. Roept **Image.save** aan terwijl je een object van **PdfOptions** als de tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande voorbeeldcode toont hoe je een bestand kunt converteren met de standaardinstellingen.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF-tekeningen exporteren naar BMP**

Aspose.CAD biedt de mogelijkheid om AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) tekenentiteiten te laden en deze als een volledige tekening naar [BMP](https://docs.fileformat.com/image/bmp/) formaat te renderen. De conversiebenadering van [DWF](https://docs.fileformat.com/cad/dwf/) naar [BMP](https://docs.fileformat.com/image/bmp/) werkt als volgt:

1. Laad het [DWF](https://docs.fileformat.com/cad/dwf/) tekenbestand met behulp van de **Image.load** fabriek methode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** en **page_width** in.
1. Maak een object van de **BmpOptions** klasse en stel de eigenschap **vector_rasterization_options** in.
1. Roept **Image.save** aan terwijl je een object van **BmpOptions** als de tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande voorbeeldcode toont hoe je een [DWF](https://docs.fileformat.com/cad/dwf/) bestand kunt converteren naar [BMP](https://docs.fileformat.com/image/bmp/) met de standaardinstellingen.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
