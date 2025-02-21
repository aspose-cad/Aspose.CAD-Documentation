---
title: DXB Ritningar
type: docs
weight: 90
url: /sv/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportera DXB-format till PDF**

Aspose.CAD för Python gör det möjligt för utvecklare att exportera en DXB-fil till [PDF](https://docs.fileformat.com/pdf/) format. DXB till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar på följande sätt:

1. Ladda DXB ritningsfilen med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av **CadRasterizationOptions** klassen och ställ in egenskaperna **page_height** och **page_width**.
1. Skapa ett objekt av **PdfOptions** klassen och ställ in egenskapen **vector_rasterization_options**.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som den andra parametern.

## Exempelkod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
