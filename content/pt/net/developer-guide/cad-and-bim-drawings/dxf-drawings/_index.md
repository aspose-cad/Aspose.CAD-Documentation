---
title: Desenhos DXF
type: docs
weight: 60
url: /pt/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportando Desenhos DXF para PDF**

Aspose.CAD fornece o recurso para carregar entidades de desenho DXF do AutoCAD e renderizá-las como um desenho inteiro em formato PDF. A abordagem de conversão de DXF para PDF funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

O exemplo de código abaixo mostra como converter um arquivo usando configurações padrão.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Formatos Suportados**

No momento, suportamos totalmente os formatos de arquivo DXF do AutoCAD 2010. As versões DXF anteriores não são garantidas para serem 100% válidas. Estamos planejando incluir mais formatos e recursos nas futuras versões do Aspose.CAD.

### **Entidades Suportadas**

No momento, apoiamos todas as entidades 2D amplamente utilizadas e seus parâmetros básicos padrão, conforme a seguir:

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
1. Dimensão de Ordenada
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

### **Gerenciamento de Memória**

A propriedade [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) da classe [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) pode ser usada para controlar a realocação de memória. A realocação é mais provável de ocorrer para caches pré-alocados. Isso pode acontecer quando o sistema descobre que o espaço alocado não será suficiente.

- Se [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) estiver configurado para o valor padrão, **Falso**, o espaço é realocado para o mesmo meio.
- Quando definido como **Verdadeiro**, a realocação não pode exceder o espaço máximo especificado. Neste caso, o cache em memória existente alocado (que requer realocação) é liberado e o espaço estendido é alocado no disco.

## **Exportando Camada Específica de Desenhos DXF para PDF**

Esta abordagem funciona da seguinte forma:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie uma instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Adicione camadas ao objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crie uma instância de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chame o método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e passe o objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

O exemplo de código abaixo mostra como converter uma camada específica de DXF para PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Renderizar arquivos PDF como parte de desenhos DXF**

Esta abordagem funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carregue arquivos PDF.
1. defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e salve o arquivo.

O exemplo de código abaixo mostra como renderizar arquivos PDF como parte de desenhos DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Exportar sub-representação DGN incorporada para o formato DXF**

Aspose.CAD fornece o recurso para carregar arquivos DXF do AutoCAD e exportar a sub-representação DGN incorporada para o formato DXF.

O exemplo de código abaixo mostra como atingir os requisitos especificados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Suporte para Salvar Arquivos DXF**

Aspose.CAD fornece o recurso para carregar arquivos DXF do AutoCAD, fazer alterações e salvá-los novamente como um arquivo DXF.

O exemplo de código abaixo mostra como atingir os requisitos especificados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Exportar DXF para WMF**

Esta abordagem funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carregue arquivos PDF.
1. defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e salve o arquivo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportando Layout DXF Específico para PDF**

Esta abordagem funciona da seguinte forma:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie uma instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Especifique o(s) nome(s) de layout desejado(s) usando a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Crie uma instância de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exporte o desenho para PDF chamando o método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e passando o objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como o segundo parâmetro.

O exemplo de código abaixo mostra como converter um layout específico de DXF para PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

A propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) é do tipo array de string, portanto você pode especificar mais de um layout ao mesmo tempo para possível conversão para o formato PDF. Ao especificar vários layouts para a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), o PDF resultante terá várias páginas, onde cada página representa um layout individual do AutoCAD.

{{% /alert %}}

## **Suporte ao Recorte de Blocos**

Aspose.CAD fornece o recurso de Recorte de Blocos. A abordagem de Recorte de Blocos funciona da seguinte forma:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carregue arquivos PDF.
1. Defina as propriedades desejadas de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Chame [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parâmetro e salve o arquivo.

O exemplo de código abaixo mostra como o Recorte de Blocos funciona.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Exportar Imagens para DXF**

Usando Aspose.CAD, você pode exportar imagens para o formato DXF. Usando esta abordagem, você pode realizar as seguintes ações:

1. Definir nova fonte
1. Ocultar entidades
1. Atualizar texto

O seguinte exemplo de código mostra como realizar as ações listadas acima.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportando Camada Específica de Desenhos DXF para Imagem**

Esta abordagem funciona da seguinte forma:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crie uma instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Adicione camadas ao objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crie uma instância de [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exporte o desenho para PDF usando o método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

O exemplo de código abaixo mostra como converter uma camada específica de DXF para uma Imagem.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
