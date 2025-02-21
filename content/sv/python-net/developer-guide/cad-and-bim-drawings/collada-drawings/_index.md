---
title: COLLADA-ritningar
type: docs
weight: 20
url: /sv/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportera COLLADA-format till PDF**

Aspose.CAD för Python tillåter utvecklare att exportera en [COLLADA](https://docs.fileformat.com/3d/dae/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [COLLADA](https://docs.fileformat.com/3d/dae/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar som följer:

1. Ladda [COLLADA](https://docs.fileformat.com/3d/dae/) ritningsfilen med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in egenskaperna **page_height** och **page_width**.
1. Skapa ett objekt av klassen **PdfOptions** och ställ in egenskapen **vector_rasterization_options**.
1. Anropa **Image.save** och skicka ett objekt av **PdfOptions** som den andra parametern.

## Exempelkod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
