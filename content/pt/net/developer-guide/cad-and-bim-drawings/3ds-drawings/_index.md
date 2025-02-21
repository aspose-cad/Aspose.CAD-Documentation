---
title: Desenhos 3DS
type: docs
weight: 70
url: /pt/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Exportando o Formato 3DS para PDF**

Aspose.CAD para .NET permite que desenvolvedores exportem um arquivo [3DS](https://docs.fileformat.com/3d/3ds/) para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [3DS](https://docs.fileformat.com/3d/3ds/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho [3DS](https://docs.fileformat.com/3d/3ds/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
