---
title: Desenhos DXF
type: docs
weight: 60
url: /pt/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exportando Desenhos DXF para PDF**

Aspose.CAD oferece o recurso de carregar entidades de desenhos DXF do AutoCAD e renderizá-las como um desenho completo no formato PDF. O método de conversão de DXF para PDF funciona da seguinte maneira:

1. Carregue o arquivo de desenho DXF usando o método de fabrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chame Image.Save passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parâmetro.

O exemplo de código abaixo mostra como converter um arquivo usando configurações padrão.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Formatos Suportados**

No momento, suportamos totalmente os formatos de arquivo DXF 2010 do AutoCAD. As versões DXF anteriores não são garantidas para serem 100% válidas. Estamos planejando incluir mais formatos e recursos nas futuras versões do Aspose.CAD.

### **Entidades Suportadas**

No momento, suportamos todas as entidades 2D amplamente utilizadas e seus parâmetros básicos padrão, conforme segue:

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
1. Dimensão Ordinada
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

A propriedade [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) pode ser usada para controlar a realocação de memória. A realocação é mais provável de ocorrer para caches pré-alocados. Isso pode acontecer quando o sistema descobre que o espaço alocado não será suficiente.

- Se [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) estiver definido como o valor padrão, **False**, o espaço é realocado para o mesmo meio.
- Quando definido como **True**, a realocação não pode exceder o espaço máximo especificado. Nesse caso, o cache existente alocado na memória (que requer realocação) é liberado e um espaço estendido é alocado no disco.

## **Exportando Camada Específica de Desenhos DXF para PDF**

Este método funciona da seguinte maneira:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Adicione camadas ao objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crie uma instância de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte o desenho para PDF usando o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O exemplo de código abaixo mostra como converter uma camada específica de DXF para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportando Camada Específica de Desenhos DXF para Imagem**

Este método funciona da seguinte maneira:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Adicione camadas ao objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crie uma instância de [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte o desenho para PDF usando o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O exemplo de código abaixo mostra como converter uma camada específica de DXF para Imagem.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Renderizar arquivos PDF como parte de desenhos DXF**

Este método funciona da seguinte maneira:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carregue arquivos PDF.
1. defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Chame [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e salve o arquivo.

O exemplo de código abaixo mostra como renderizar arquivos PDF como parte de desenhos DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Exportar DXF para WMF**

Este método funciona da seguinte maneira:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carregue arquivos PDF.
1. defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Chame [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e salve o arquivo.

O exemplo de código abaixo mostra como exportar DXF para WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Suporte para Salvar Arquivos DXF**

Aspose.CAD oferece o recurso de carregar arquivos DXF do AutoCAD, fazer alterações e salvá-los novamente como um arquivo DXF. O exemplo de código abaixo mostra como atender a requisitos especificados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Exportar DGN incorporado como sub-rede para o formato DXF**

Aspose.CAD fornece o recurso de carregar arquivos DXF do AutoCAD e exportar DGN incorporado como sub-rede para o formato DXF.

O exemplo de código abaixo mostra como atender a requisitos especificados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exportando Layout DXF Específico para PDF**

Este método funciona da seguinte maneira:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e especifique as propriedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Especifique o(s) nome(s) do layout desejado usando a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporte o desenho para PDF usando o método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

O exemplo de código abaixo mostra como converter um layout específico de DXF para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

A propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) é do tipo array de strings, portanto, você pode especificar mais de um layout ao mesmo tempo para conversão possível ao formato PDF. Ao especificar múltiplos layouts para a propriedade [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), o PDF resultante terá várias páginas, onde cada página representa um layout individual do AutoCAD.

{{% /alert %}}

## **Acessar objetos ATTRIB e MTEXT**

Este método funciona da seguinte maneira:

1. Abra um arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Acesse as entidades dentro do arquivo CAD.
1. Verifique as entidades [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) e [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Adicione a uma lista temporária para processamento posterior.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Decompor Objetos de Inserção CAD**

Este método funciona da seguinte maneira:

1. Abra um arquivo de desenho **DXF** usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Acesse as entidades dentro do arquivo CAD.
1. Verifique as entidades [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. verifique a lista de tipos de [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Processar as entidades.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Suporte ao Recorte de Blocos**

Aspose.CAD fornece o recurso de Recorte de Blocos. O método de Recorte de Blocos funciona da seguinte maneira:

1. Carregue o arquivo de desenho DXF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carregue arquivos PDF.
1. Defina as propriedades desejadas de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Chame [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando um objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parâmetro e salve o arquivo.

O exemplo de código abaixo mostra como funciona o Recorte de Blocos.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Exportar Imagens para DXF**

Usando Aspose.CAD, você pode exportar imagens para o formato DXF. Usando este método, você pode realizar as seguintes ações:

1. Definir nova fonte.
1. Ocultar entidades.
1. Atualizar texto.

O seguinte trecho de código mostra como realizar as ações listadas acima.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
