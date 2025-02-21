---
title: SVG-tekeningen
type: docs
weight: 170
url: /nl/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exporteren van SVG-formaat naar PDF**

Aspose.CAD voor Python stelt ontwikkelaars in staat om een [SVG](https://docs.fileformat.com/page-description-language/svg/) bestand te exporteren naar [PDF](https://docs.fileformat.com/pdf/) formaat. De conversie van [SVG](https://docs.fileformat.com/page-description-language/svg/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het SVG-tekeningbestand met de **Image.load** fabrieksmethode.
2. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** en **page_width** in.
3. Maak een object van de **PdfOptions** klasse en stel de eigenschap **VectorRasterizationOptions** in.
4. Roep **Image.save** aan terwijl je een object van **PdfOptions** als het tweede parameter doorgeeft.

## Voorbeeldcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
