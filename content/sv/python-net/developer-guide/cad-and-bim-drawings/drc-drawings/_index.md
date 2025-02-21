---
title: DRC Ritningar
type: docs
weight: 40
url: /sv/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportera DRC-format till PDF**

Aspose.CAD för Python gör det möjligt för utvecklare att exportera en [DRC](https://docs.fileformat.com/3d/drc/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [DRC](https://docs.fileformat.com/3d/drc/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar enligt följande:

1. Ladda DRC ritningsfilen med hjälp av **Image.load** fabriksmetoden.
2. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in egenskaperna **page_height** & **page_width**.
3. Skapa ett objekt av klassen **PdfOptions** och ställ in egenskapen **VectorRasterizationOptions**.
4. Anropa **Image.save** medan du passerar ett objekt av **PdfOptions** som den andra parametern.

## Exempelkod


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
