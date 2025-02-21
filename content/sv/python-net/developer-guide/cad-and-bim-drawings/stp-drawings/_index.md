---
title: STP Ritningar
type: docs
weight: 160
url: /sv/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportera STP-format till PDF**

Aspose.CAD för Python gör det möjligt för utvecklare att exportera en [STP](https://docs.fileformat.com/3d/stp/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [STP](https://docs.fileformat.com/3d/stp/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetod fungerar som följer:

1. Ladda [STP](https://docs.fileformat.com/3d/stp/) ritningsfilen med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av **CadRasterizationOptions** klassen och ställ in **page_height** & **page_width** egenskaperna.
1. Skapa ett objekt av **PdfOptions** klassen och ställ in **vector_rasterization_options** egenskapen.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som det andra parametern.

## Exempel kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
