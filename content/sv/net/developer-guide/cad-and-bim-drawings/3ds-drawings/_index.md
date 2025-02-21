---
title: 3DS Ritningar
type: docs
weight: 70
url: /sv/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Exportera 3DS-format till PDF**

Aspose.CAD för .NET gör det möjligt för utvecklare att exportera en [3DS](https://docs.fileformat.com/3d/3ds/) fil till [PDF](https://docs.fileformat.com/pdf/) format. Konverteringsmetoden från [3DS](https://docs.fileformat.com/3d/3ds/) till [PDF](https://docs.fileformat.com/pdf/) fungerar som följande:

1. Ladda [3DS](https://docs.fileformat.com/3d/3ds/) ritningsfilen med hjälp av [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrikmetoden.
2. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) och [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som det andra parametern.

## Exempelkod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
