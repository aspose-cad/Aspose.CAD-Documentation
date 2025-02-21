---
title: Desenhos DRC
type: docs
weight: 15
url: /pt/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportando Desenhos DRC para PDF**

Aspose.CAD fornece o recurso para carregar entidades de desenho AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) e renderizá-las como um desenho completo no formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [DRC](https://docs.fileformat.com/3d/drc/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho [DRC](https://docs.fileformat.com/3d/drc/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

### Exemplo de Código

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
