---
title: Desenhos DWG
type: docs
weight: 40
url: /pt/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportando Desenhos DWG para PDF**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato [DWG](https://docs.fileformat.com/cad/dwg/) e convertê-los para [PDF](https://docs.fileformat.com/pdf/). Este tópico explica o uso da API Aspose.CAD para alcançar a conversão de DWG para o formato PDF através de passos simples, conforme definido a seguir.

{{% alert color="primary" %}}

A API suporta as seguintes revisões do DWG do AutoCAD:

- versão 16.0, lançamento 18, DWG 2004 
- versão 16.1, DWG 2005 
- versão 18.0, DWG 2010 
- versão 19.0, DWG 2013 

{{% /alert %}}

### **Formato de Arquivo DWG**

Um [DWG](https://docs.fileformat.com/cad/dwg/) é um arquivo binário que contém dados de imagem vetorial e metadados. Os dados de imagem vetorial fornecem instruções para a aplicação CAD sobre como exibir o DWG; os metadados podem conter uma variedade de informações sobre o arquivo, incluindo dados específicos de localização e também dados do cliente. Especificações Abertas para o formato de arquivo DWG podem ser encontradas [neste PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Converter Arquivos DWG para PDF**

Os seguintes passos simples são necessários para converter [DWG](https://docs.fileformat.com/cad/dwg/) para [PDF](https://docs.fileformat.com/pdf/).

1. Carregar o arquivo DWG em uma instância de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Criar um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e definir as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Criar um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e definir a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chamar [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) enquanto passa um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

O exemplo de código abaixo mostra como exportar desenhos DWG para PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Criar um PDF Único com Tamanhos de Layout Diferentes**

Aspose.CAD para .NET permite que você converta um arquivo DWG em um único PDF com tamanhos de layout diferentes. Esta abordagem funciona da seguinte forma:

1. Carregar um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Criar uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e definir a altura e largura da página resultante.
1. Adicionar os [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) necessários para o objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Criar uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e definir sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar a imagem para PDF usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como criar um único [PDF](https://docs.fileformat.com/pdf/) com layouts diferentes.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Primitivas Suportadas do AutoCAD**

As seguintes primitivas do AutoCAD são suportadas.

- TEXTO
- MTEXTO
- ATTDEF
- ATRIB
- ARCO
- ELLIPSE
- HATCH
- LIDER
- PONTO
- VÉRTICE 2D
- VÉRTICE 3D
- POLILINHA 2D
- LWPOLYLINE
- RAI
- CÍRCULO
- DIMENSÃO ORDINADA
- DIMENSÃO LINEAR
- DIMENSÃO ALINHADA
- DIMENSÃO ÂNGULO 3Pt
- DIMENSÃO ÂNGULO 2Ln
- DIMENSÃO RAIO
- DIMENSÃO DIÂMETRO
- FORMA
- SÓLIDO
- SPLINE
- MLINE
- LINHA
- XLINE
- ESTILO
- DIMSTYLE
- LTYPE
- MLINESTYLE
- CAMADA
- VIEWPORT
- LAYOUT

## **Exportando Layout Específico DWG para PDF**

Esta abordagem funciona da seguinte forma:

1. Carregar um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Criar uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e definir a altura e largura da página resultante.
1. Definir a propriedade [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) para o objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Criar uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e definir sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar a imagem para PDF usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como converter um layout específico de DWG para PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Renderizar Documento DWG Especificando Coordenadas**

Aspose.CAD para .NET API agora fornece um recurso para renderizar documentos DWG fornecendo coordenadas da largura e altura do documento.

O exemplo de código abaixo mostra como renderizar um documento DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportando DWG para Raster ou PDF usando Tamanho Fixo**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e convertê-los em PDF ou Raster usando tamanho fixo.

O exemplo de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportando DWG para PDF/A e PDF/E**

Esta abordagem funciona da seguinte forma:

1. Carregar um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Criar uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Criar uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e definir sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Definir a propriedade de conformidade PDF e salvá-la.
1. Exportar a imagem para PDF usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como converter um arquivo DWG para PDF/A e PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Suporte para Linhas Ocultas Arredondadas ao Exportar DWG/DXF para BMP e PDF**

Esta abordagem funciona da seguinte forma:

1. Carregar um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Criar uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e definir a altura e largura da página resultante.
1. Criar uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e definir sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar a imagem para PDF usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Suporte para Definir Área de Impressão para Imagem DWG no PDF Exportado**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e convertê-los em PDF. Este tópico explica o uso da API Aspose.CAD para alcançar o suporte para definir uma área de impressão para a imagem DWG no PDF exportado.

O exemplo de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Suporte para Ler Metadados XREF para Arquivo DWG**

1. Carregar um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Percorrer cada entidade de imagem.
1. Se uma entidade for CadUnderlay, então a entidade XREF com metadados.

O exemplo de código abaixo mostra como alcançar esse recurso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

A propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) é do tipo array de string, para que você possa especificar mais de um layout ao mesmo tempo para possível conversão ao formato PDF. Ao especificar múltiplos layouts para a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), o PDF resultante terá várias páginas, onde cada página representa um layout individual do AutoCAD.

### **Listar Todos os Layouts**

Você pode listar todos os layouts presentes em um desenho AutoCAD usando o seguinte trecho de código.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Acessando Sinalizadores de Subcamada para Formato DWG**

Aspose.CAD para .NET implementou os sinalizadores de subcamada para o formato DWG e permite que os desenvolvedores os acessem. A seguir está a demonstração simples do código.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Suporte para Entidades DWG**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar.

### **Suporte para Entidade MLeader**

Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve um exemplo de trabalho com a entidade MLeader dentro do arquivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Suporte para Exportar Entidade DWG para Imagem**

Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve um exemplo de exportação de uma entidade DWG particular para a imagem.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Suporte para Adicionar Texto em DWG**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar. Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve como podemos adicionar texto dentro do arquivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Suporte para Importar Imagem para Arquivo DWG**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar. Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve como podemos importar imagens dentro do arquivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Suporte para Malha em DWG**

Aspose.CAD para .NET API agora pode acessar as entidades que suportam malha, que incluem os tipos [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) e [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). O seguinte exemplo descreve como podemos acessar os tipos de malha.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Converter Desenhos DWG para DXF**

Aspose.CAD fornece o recurso de carregar um arquivo DWG do AutoCAD e exportá-lo para o formato DXF. A abordagem de conversão de DWG para DXF funciona da seguinte forma:

1. Carregar o arquivo de desenho DWG usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Exportar o desenho DWG para DXF usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como converter um arquivo DWG para o formato DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Converter Desenhos DWG para SVG**

Aspose.CAD para .NET API pode carregar desenhos do AutoCAD no formato DWG e convertê-los para SVG. Este tópico explica o uso da API Aspose.CAD para alcançar a conversão de DWG para o formato SVG através de passos simples, conforme definido abaixo.

1. Carregar o arquivo DWG em uma instância de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Criar um objeto da classe [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) e definir as propriedades requeridas.
1. Exportar o desenho DWG para SVG usando o método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como converter um arquivo DWG para o formato SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Carregar Arquivo DWG Grande**

Aspose.CAD para .NET fornece a facilidade de abrir arquivos DWG muito grandes usando a classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Agora você pode abrir arquivos grandes facilmente com a ajuda do código de amostra abaixo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
