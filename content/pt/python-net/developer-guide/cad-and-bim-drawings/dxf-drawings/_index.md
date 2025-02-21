---
title: Desenhos DXF
type: docs
weight: 10
url: /pt/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportando Desenhos DXF para PDF**

Aspose.CAD fornece a funcionalidade de carregar entidades de desenho DXF do AutoCAD e renderizá-las como um desenho completo no formato PDF. A abordagem de conversão de DXF para PDF funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **VectorRasterizationOptions**.
1. Chame **Image.save**, passando um objeto de **PdfOptions** como o segundo parâmetro.

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Formatos Suportados**

No momento, suportamos totalmente os formatos de arquivos DXF 2010 do AutoCAD. As versões anteriores do DXF não têm garantia de serem 100% válidas. Estamos planejando incluir mais formatos e recursos nas versões futuras do Aspose.CAD.

### **Entidades Suportadas**

No momento, suportamos todas as entidades 2D amplamente utilizadas e seus principais parâmetros padrão, como segue:

1. Dimensão Alinhada
1. Dimensão Angular
1. Arco
1. Atributo
1. Referência de Bloco
1. Círculo
1. Dimensão de Diâmetro
1. Elipse
1. Hachura
1. Linha
1. Texto Multilinha
1. Dimensão de Ordinada
1. Ponto
1. Polilinha
1. Dimensão Radial
1. Raio
1. Dimensão Rotacionada
1. Tabela
1. Texto
1. Xline

{{% alert color="primary" %}}

Se durante a análise encontrarmos alguma entidade ou propriedade que não suportamos, a entidade ou propriedade será ignorada silenciosamente.

{{% /alert %}}

## **Exportar subcamada DGN incorporada para formato DXF**

Aspose.CAD fornece a funcionalidade de carregar arquivos DXF do AutoCAD e exportar subcamada DGN incorporada para o formato DXF.

O exemplo de código abaixo mostra como atender aos requisitos especificados.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Suporte para Salvar Arquivos DXF**

Aspose.CAD fornece a funcionalidade de carregar arquivos DXF do AutoCAD, fazer alterações e salvá-los novamente como um arquivo DXF.

O exemplo de código abaixo mostra como atender aos requisitos especificados.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Exportar DXF para WMF**

Esta abordagem funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e carregue arquivos PDF.
1. Defina as propriedades **page_height** e **page_width**.
1. Chame **Image.save** e salve o arquivo.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
