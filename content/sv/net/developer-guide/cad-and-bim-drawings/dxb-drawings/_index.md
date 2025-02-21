---
title: DXB Ritningar
type: docs
weight: 70
url: /sv/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportera DXB-format till PDF**

Aspose.CAD för .NET tillåter utvecklare att exportera en DXB-fil till [PDF](https://docs.fileformat.com/pdf/) format. DXB till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar enligt följande:

1. Ladda DXB ritningsfilen med hjälp av [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrikmetoden.
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du passerar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.

## Exempelkod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
