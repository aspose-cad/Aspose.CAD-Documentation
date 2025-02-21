---
title: Desenhos DWF
type: docs
weight: 20
url: /pt/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Exportando Desenhos DWF para PDF**

Aspose.CAD para Java API pode carregar desenhos AutoCAD no formato DWF e convertê-los para PDF. Este tópico explica o uso da API Aspose.CAD para realizar a conversão de DWF para o formato PDF através de passos simples conforme definido a seguir.

### **Converter Arquivos DWF para PDF**

Os seguintes passos simples são necessários para converter DWF em PDF.

1. Carregue o arquivo DWF em uma instância de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina as propriedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crie um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chame [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando um objeto da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como o segundo parâmetro.

O exemplo de código abaixo mostra como exportar um desenho DWF para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Suporte a Camadas em DWF**

Aspose.CAD oferece a funcionalidade de carregar entidades de desenho DWF do AutoCAD e renderizá-las como um desenho completo no formato JPG.

1. Carregue o arquivo de desenho DWF usando o método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crie um objeto da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Adicione as camadas desejadas.
1. Chame [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando um objeto de [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) como segundo parâmetro.

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
