---
title: Desenhos STP
type: docs
weight: 70
url: /pt/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportando Formato STP Para PDF**

Aspose.CAD para .NET permite que os desenvolvedores exportem um arquivo [STP](https://docs.fileformat.com/3d/stp/) para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [STP](https://docs.fileformat.com/3d/stp/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho [STP](https://docs.fileformat.com/3d/stp/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
