---
title: STP Ritningar
type: docs
weight: 70
url: /sv/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportera STP-format till PDF**

Aspose.CAD för .NET låter utvecklare exportera en [STP](https://docs.fileformat.com/3d/stp/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [STP](https://docs.fileformat.com/3d/stp/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar som följer:

1. Ladda [STP](https://docs.fileformat.com/3d/stp/) ritningsfilen med hjälp av [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabriksmetoden.
1. Skapa ett objekt av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klassen och ställ in [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) egenskaperna.
1. Skapa ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klassen och ställ in [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) egenskapen.
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du passerar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.

## Exempel på kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
