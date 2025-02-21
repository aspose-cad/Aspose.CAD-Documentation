---
title: Desenhos DWG
type: docs
weight: 70
url: /pt/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportando Desenhos DWG para PDF**

Aspose.CAD para Python API pode carregar desenhos AutoCAD no formato [DWG](https://docs.fileformat.com/cad/dwg/) e convertê-los para [PDF](https://docs.fileformat.com/pdf/). Este tópico explica o uso da API Aspose.CAD para realizar a conversão de DWG para o formato PDF através de etapas simples, conforme definido a seguir.

{{% alert color="primary" %}}

A API suporta as seguintes revisões DWG do AutoCAD:

- versão 16.0 do DWG 2004 lançamento 18
- versão 16.1 do DWG 2005
- versão 18.0 do DWG 2010
- versão 19.0 do DWG 2013

{{% /alert %}}

### **Formato de Arquivo DWG**

Um [DWG](https://docs.fileformat.com/cad/dwg/) é um arquivo binário que contém dados de imagem vetorial e metadados. Os dados de imagem vetorial fornecem instruções para o aplicativo CAD sobre como exibir o DWG; os metadados podem conter uma variedade de informações sobre o arquivo, incluindo dados específicos de localização e também dados do cliente. Especificações Abertas para o formato de arquivo DWG podem ser encontradas [neste PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Converter Arquivos DWG para PDF**

As seguintes etapas simples são necessárias para converter [DWG](https://docs.fileformat.com/cad/dwg/) para [PDF](https://docs.fileformat.com/pdf/).

1. Carregue o arquivo DWG em uma instância de **Imagem**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **VectorRasterizationOptions**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como segundo parâmetro.

O exemplo de código abaixo mostra como exportar Desenhos DWG para PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Primitivas do AutoCAD Suportadas**

As seguintes primitivas do AutoCAD são suportadas.

- TEXTO
- MTEXTO
- ATTDEF
- ATTRIB
- ARCO
- ELIPSE
- HACHURA
- LÍDER
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
- DIMENSÃO ANG 3Pt
- DIMENSÃO ANG 2Ln
- DIMENSÃO RAIO
- DIMENSÃO DIAMETRO
- FORMA
- SÓLIDO
- SPLINE
- MLINE
- LINHA
- XLINHA
- ESTILO
- DIMSTYLE
- LTYPE
- MLINESTYLE
- CAMADA
- VIEWPORT
- LAYOUT

## **Exportando Layout Específico DWG para PDF**

Esta abordagem funciona da seguinte forma:

1. Carregue um arquivo DWG usando o método de fábrica **Aspose.CAD.Image.load**.
1. Crie uma instância da classe **CadRasterizationOptions** e defina a altura e largura da página resultantes.
1. Defina a propriedade **Layouts** para o objeto **CadRasterizationOptions**.
1. Crie uma instância da classe **PdfOptions** e defina sua propriedade **VectorRasterizationOptions**.
1. Exporte a imagem para PDF usando o método **Image.save()**.

O exemplo de código abaixo mostra como converter um layout específico de DWG para PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Exportando DWG para PDF/A e PDF/E**

Esta abordagem funciona da seguinte forma:

1. Carregue um arquivo DWG usando o método de fábrica **Image.load**.
1. Crie uma instância da classe **CadRasterizationOptions**.
1. Crie uma instância da classe **PdfOptions** e defina sua propriedade **VectorRasterizationOptions**.
1. Defina a propriedade de conformidade do PDF e salve-a.
1. Exporte a imagem para PDF usando o método **Image.save()**.

O exemplo de código abaixo mostra como converter um arquivo DWG para PDF/A e PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Converter Desenhos DWG para DXF**

Aspose.CAD fornece a funcionalidade de carregar um arquivo DWG do AutoCAD e exportá-lo para o formato DXF. A abordagem de conversão de DWG para DXF funciona da seguinte forma:

1. Carregue o arquivo de desenho DWG usando o método de fábrica **Image.load**.
1. Exporte o desenho DWG para DXF usando o método **Image.save()**.

O exemplo de código abaixo mostra como converter um arquivo DWG para o formato DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Converter Desenhos DWG para SVG**

Aspose.CAD para Python API pode carregar desenhos AutoCAD no formato DWG e convertê-los para SVG. Este tópico explica o uso da API Aspose.CAD para realizar a conversão de DWG para o formato SVG através de etapas simples, conforme definido abaixo.

1. Carregue o arquivo DWG em uma instância de **Imagem**.
1. Crie um objeto da classe **SvgOptions** e defina as propriedades necessárias.
1. Exporte o desenho DWG para SVG usando o método **Image.save()**.

O exemplo de código abaixo mostra como converter um arquivo DWG para o formato SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
