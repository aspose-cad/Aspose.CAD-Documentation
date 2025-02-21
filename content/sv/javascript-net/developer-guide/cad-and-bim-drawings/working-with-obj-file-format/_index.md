---
title: Arbeta med OBJ-filformat
type: docs
weight: 120
url: /sv/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD stödjer nu OBJ-filformatet. OBJ-filformatet är en 3D-geometri som innehåller texturkartor, 3D-koordinater, polygonala ytor och annan objektinformation.

{{% /alert %}}

## **Exportera OBJ-format till PNG**

Aspose.CAD för Javascript i Angular tillåter utvecklare att exportera en [OBJ](https://docs.fileformat.com/3d/obj/) fil till [PNG](https://docs.fileformat.com/image/png/) format.
Konverteringsmetoden från [OBJ](https://docs.fileformat.com/3d/obj/) till [PNG](https://docs.fileformat.com/image/png/) fungerar enligt följande:

1. Ladda [OBJ](https://docs.fileformat.com/3d/obj/) ritfilen med hjälp av metoden **Image.load**.
1. Anropa **Image.save** medan du skickar ett objekt av **PngOptions** som den andra parametern.

## Exempel på kod

Koden nedan visar hur man uppnår samma mål med Aspose.CAD för JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
