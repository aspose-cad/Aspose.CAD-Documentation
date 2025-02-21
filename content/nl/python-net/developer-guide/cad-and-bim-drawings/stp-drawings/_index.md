---
title: STP-tekeningen
type: docs
weight: 160
url: /nl/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP-formaat exporteren naar PDF**

Aspose.CAD voor Python stelt ontwikkelaars in staat om een [STP](https://docs.fileformat.com/3d/stp/) bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De conversiebenadering van [STP](https://docs.fileformat.com/3d/stp/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [STP](https://docs.fileformat.com/3d/stp/) tekenbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** en **page_width** in.
1. Maak een object van de **PdfOptions** klasse en stel de eigenschap **vector_rasterization_options** in.
1. Roep **Image.save** aan terwijl je een object van **PdfOptions** als tweede parameter doorgeeft.

## Voorbeeldcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
