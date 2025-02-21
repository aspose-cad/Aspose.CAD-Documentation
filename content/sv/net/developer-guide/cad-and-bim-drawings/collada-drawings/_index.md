---
title: COLLADA Ritningar
type: docs
weight: 70
url: /sv/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportera COLLADA-format till PDF**

Aspose.CAD för .NET låter utvecklare exportera en [COLLADA](https://docs.fileformat.com/3d/dae/) fil till [PDF](https://docs.fileformat.com/pdf/) format. Konverteringsmetoden från [COLLADA](https://docs.fileformat.com/3d/dae/) till [PDF](https://docs.fileformat.com/pdf/) fungerar som följer:

1. Ladda [COLLADA](https://docs.fileformat.com/3d/dae/) ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du passerar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som det andra parametern.

## Exempel på kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
