---
title: Desenhos DWG
type: docs
weight: 40
url: /pt/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Exportando Desenhos DWG para PDF**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e convertê-los para PDF. Este tópico explica o uso da API Aspose.CAD para realizar a conversão de DWG para PDF através de etapas simples conforme definido a seguir.

{{% alert color="primary" %}}

A API suporta as seguintes revisões do AutoCAD DWG:

- Versão DWG 2004 versão 16.0 lançamento 18
- Versão DWG 2005 versão 16.1
- Versão DWG 2010 versão 18.0
- Versão DWG 2013 versão 19.0

{{% /alert %}}

### **Formato de Arquivo DWG**

Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Os dados de imagem vetorial fornecem instruções à aplicação CAD sobre como exibir o DWG; os metadados podem conter uma variedade de informações sobre o arquivo, incluindo dados específicos de localização e também dados do cliente. Especificações abertas para o formato de arquivo DWG podem ser encontradas [neste PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Converter Arquivos DWG para PDF**

As seguintes etapas simples são necessárias para converter DWG em PDF.

1. Carregue o arquivo DWG em uma instância de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chame o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e passe o objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como o segundo parâmetro.

O trecho de código abaixo mostra como exportar desenhos DWG para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Criar um PDF Único com Diferentes Tamanhos de Layout**

Aspose.CAD para Java permite converter o arquivo DWG em um único PDF com diferentes tamanhos de layout. Essa abordagem funciona da seguinte forma:

1. Carregue um arquivo DWG usando o método de fábrica [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina a altura e largura da página resultante.
1. Adicione os [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) necessários para o objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte a imagem para PDF usando o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O trecho de código abaixo mostra como criar um PDF único com diferentes layouts.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Exportando DWG para PDF/A e PDF/E**

As seguintes etapas simples são necessárias para converter DWG em PDF.

1. Carregue o arquivo DWG em uma instância de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chame o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e passe o objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como o segundo parâmetro.

O trecho de código abaixo mostra como exportar desenhos DWG para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Primitivas AutoCAD Suportadas**

As seguintes primitivas AutoCAD são suportadas.

- TEXTO
- MTEXT
- ATTDEF
- ATTRIB
- ARCO
- ELIPSE
- HACHURA
- LIDER
- PONTO
- VERTICE 2D
- VERTICE 3D
- POLILINHA 2D
- LWPOLYLINE
- RAIO
- CÍRCULO
- DIMENSÃO ORDENADA
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

## **Exportando um Layout DWG Específico para PDF**

Essa abordagem funciona da seguinte forma:

1. Carregue um arquivo DWG usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina a altura e largura da página resultante.
1. Defina a propriedade [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) para o objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte a imagem para PDF usando o método [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O trecho de código abaixo mostra como converter um layout específico de DWG para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Exportando DWG para Raster ou PDF Usando Tamanho Fixo**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e convertê-los em PDF ou Raster usando um tamanho fixo.

O trecho de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Suporte para Linhas Ocultas Arredondadas ao Exportar DWG/DXF para BMP e PDF**

Essa abordagem funciona da seguinte forma:

1. Carregue um arquivo DWG usando o método [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) de fábrica.
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina a altura e largura da página resultante.
1. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte a imagem para PDF usando o método [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O trecho de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Suporte para Definir Área de Impressão para Imagem DWG no PDF Exportado**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e convertê-los para PDF. Este tópico explica o uso da API Aspose.CAD para alcançar o suporte para definir uma área de impressão para a imagem DWG no PDF exportado.

O trecho de código abaixo mostra como implementar esse recurso.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Suporte para Ler Metadados XREF para o Arquivo DWG**

1. Carregue um arquivo DWG usando o método [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) de fábrica.
1. Percorra cada entidade de imagem.
1. Se a entidade for [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) então a entidade XREF com metadados.

O trecho de código abaixo mostra como alcançar esse recurso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Documento DWG Especificando Coordenadas**

Aspose.CAD para Java API agora fornece um recurso para renderizar documentos DWG fornecendo coordenadas da largura e altura do documento.

O trecho de código abaixo mostra como renderizar um documento DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

A propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) é de tipo array de string, portanto, você pode especificar mais de um layout ao mesmo tempo para possível conversão para o formato PDF. Ao especificar vários layouts para a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), o PDF resultante terá várias páginas, onde cada página representa um layout individual do AutoCAD.

### **Listar Todos os Layouts**

Você pode listar todos os layouts presentes em um desenho do AutoCAD usando o seguinte trecho de código.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Obter Valor de Atributo de Bloco de Referência Externa**

Aspose.CAD para Java API permite obter uma referência externa de um atributo de bloco. A API Aspose.CAD expõe a propriedade [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) para obter a referência externa de um atributo de bloco em uma coleção [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

O seguinte código demonstra como obter uma referência externa de um atributo de bloco.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Pesquisar Texto em Arquivo DWG AutoCAD**

Aspose.CAD para Java API permite pesquisar texto em um arquivo DWG AutoCAD. A API Aspose.CAD expõe a classe [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) que representa entidades de texto no arquivo DWG AutoCAD. A classe [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) também está incluída na API Aspose.CAD, pois algumas outras entidades podem também conter texto.

O trecho de código a seguir demonstra como pesquisar texto no arquivo DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Pesquisar Texto em Layout Específico**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Acessando Flags de Subjacência para o Formato DWG**

Aspose.CAD para Java implementou as flags de subjacência para o formato DWG e permite que os desenvolvedores acessem elas. Abaixo está a demonstração do código simples.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Suporte para Entidades DWG**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar.

### **Suporte para Entidade MLeader**

Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve um exemplo de como trabalhar com a entidade MLeader dentro do arquivo DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Suporte para Exportar Entidade DWG para Imagem**

Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve um exemplo de como exportar uma entidade DWG específica para a imagem.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Suporte para Importar Imagem para o Arquivo DWG**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar. Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve como podemos importar imagens dentro do arquivo DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Suporte para Adicionar Texto em DWG**

Aspose.CAD para Java API pode carregar desenhos do AutoCAD no formato DWG e suportar diferentes entidades para trabalhar. Um DWG é um arquivo binário que contém dados de imagem vetorial e metadados. Existem diferentes entidades em um arquivo DWG. A seção a seguir descreve como podemos adicionar texto dentro do arquivo DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Suporte para Malha em DWG**

Aspose.CAD para Java API agora pode acessar as entidades que suportam malha, que incluem os tipos [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) e [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). O exemplo a seguir descreve como acessar os tipos de malha.

## **Converter Desenhos DWG para DXF**

Aspose.CAD fornece o recurso para carregar um arquivo DWG do AutoCAD e exportá-lo para o formato DXF. A abordagem de conversão de DWG para DXF funciona da seguinte forma:

1. Carregue o arquivo de desenho DWG usando o método [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) de fábrica.
1. Exporte o desenho DWG para DXF usando o método [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

O trecho de código abaixo mostra como converter um arquivo DWG para o formato DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Converter Desenhos DWG para SVG**

Aspose.CAD API pode carregar desenhos do AutoCAD no formato DWG e convertê-los em SVG. Este tópico explica o uso da API Aspose.CAD para alcançar a conversão de DWG para formato SVG através de etapas simples como definido abaixo.

1. Carregue o arquivo DWG em uma instância de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crie um objeto da classe [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) e defina as propriedades necessárias.
1. Exporte o desenho DWG para SVG usando o método [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

O trecho de código abaixo mostra como converter um arquivo DWG para o formato SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
