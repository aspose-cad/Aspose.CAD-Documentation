---
title: FBX-ritningar
type: docs
weight: 110
url: /sv/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportera FBX-format till PDF**

Aspose.CAD för Python gör det möjligt för utvecklare att exportera en [FBX](https://docs.fileformat.com/3d/fbx/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [FBX](https://docs.fileformat.com/3d/fbx/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar som följer:

1. Ladda [FBX](https://docs.fileformat.com/3d/fbx/) ritningsfilen med hjälp av **Image.load** fabrikmetoden.
1. Skapa ett objekt av **CadRasterizationOptions**-klassen och ställ in egenskaperna **PageHeight** och **PageWidth**.
1. Skapa ett objekt av **PdfOptions**-klassen och ställ in egenskapen **vector_rasterization_options**.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som den andra parametern.

## Exempelkod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
