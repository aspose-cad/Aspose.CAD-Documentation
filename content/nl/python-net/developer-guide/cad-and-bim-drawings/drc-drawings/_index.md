---
title: DRC Tekeningen
type: docs
weight: 40
url: /nl/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC-formaat naar PDF exporteren**

Aspose.CAD voor Python stelt ontwikkelaars in staat om een [DRC](https://docs.fileformat.com/3d/drc/) bestand naar [PDF](https://docs.fileformat.com/pdf/) indeling te exporteren. De conversiemethode van [DRC](https://docs.fileformat.com/3d/drc/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het DRC-tekeningbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** & **page_width** in.
1. Maak een object van de **PdfOptions** klasse en stel de eigenschap **VectorRasterizationOptions** in.
1. Roep **Image.save** aan en geef een object van **PdfOptions** door als tweede parameter.

## Voorbeeldcode


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
