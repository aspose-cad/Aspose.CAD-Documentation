---
title: FBX Tekeningen
type: docs
weight: 110
url: /nl/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exporteren van FBX-formaat naar PDF**

Aspose.CAD voor Python stelt ontwikkelaars in staat om een [FBX](https://docs.fileformat.com/3d/fbx/) bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De conversie van [FBX](https://docs.fileformat.com/3d/fbx/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [FBX](https://docs.fileformat.com/3d/fbx/) tekenbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **PageHeight** en **PageWidth** in.
1. Maak een object van de **PdfOptions** klasse en stel de eigenschap **vector_rasterization_options** in.
1. Roep **Image.save** aan en geef een object van **PdfOptions** door als de tweede parameter.

## Voorbeeldcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
