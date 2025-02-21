---
title: DXB Tekeningen
type: docs
weight: 90
url: /nl/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exporteren van DXB-formaat naar PDF**

Aspose.CAD voor Python stelt ontwikkelaars in staat om een DXB-bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De DXB naar [PDF](https://docs.fileformat.com/pdf/) conversiebenadering werkt als volgt:

1. Laad het DXB-tekeningbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de **page_height** en **page_width** eigenschappen in.
1. Maak een object van de **PdfOptions** klasse en stel de **vector_rasterization_options** eigenschap in.
1. Roep **Image.save** aan terwijl je een object van **PdfOptions** als de tweede parameter doorgeeft.

## Voorbeeldcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
