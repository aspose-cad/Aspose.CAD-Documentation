---
title: Desenhos DWF
type: docs
weight: 20
url: /pt/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportando Desenhos DWF para PDF**

Aspose.CAD oferece o recurso de carregar entidades de desenho AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizá-las como um desenho inteiro para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [DWF](https://docs.fileformat.com/cad/dwf/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte forma:

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parâmetro.

### Código de Exemplo

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extraindo Camadas do Desenho DWF**

Aspose.CAD oferece o recurso de carregar entidades de desenho AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizá-las como um desenho inteiro para o formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Extraia o nome das camadas usando o objeto [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) como segundo parâmetro.

### Código de Exemplo

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Suporte a Camadas em DWF**

Aspose.CAD oferece o recurso de carregar entidades de desenho AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizá-las como um desenho inteiro para o formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Adicione as camadas desejadas.
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) como segundo parâmetro.

### Código de Exemplo

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportando Desenhos DWF para BMP**

Aspose.CAD oferece o recurso de carregar entidades de desenho AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizá-las como um desenho inteiro para o formato [BMP](https://docs.fileformat.com/image/bmp/). A abordagem de conversão de [DWF](https://docs.fileformat.com/cad/dwf/) para [BMP](https://docs.fileformat.com/image/bmp/) funciona da seguinte forma:

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crie um objeto da classe [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) como segundo parâmetro.

### Código de Exemplo

O exemplo de código abaixo mostra como converter um arquivo [DWF](https://docs.fileformat.com/cad/dwf/) para [BMP](https://docs.fileformat.com/image/bmp/) usando as configurações padrão.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
