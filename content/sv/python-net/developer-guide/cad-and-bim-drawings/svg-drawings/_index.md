---
title: SVG-ritningar
type: docs
weight: 170
url: /sv/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportera SVG-format till PDF**

Aspose.CAD för Python tillåter utvecklare att exportera en [SVG](https://docs.fileformat.com/page-description-language/svg/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [SVG](https://docs.fileformat.com/page-description-language/svg/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar som följer:

1. Ladda SVG-ritningsfilen med hjälp av metoden **Image.load**.
1. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in **page_height** & **page_width** egenskaperna.
1. Skapa ett objekt av klassen **PdfOptions** och ställ in **VectorRasterizationOptions** egenskapen.
1. Anropa **Image.save** samtidigt som du skickar ett objekt av **PdfOptions** som andra parameter.

## Exempel på kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
