---
title: Exportando DGN AutoCAD
type: docs
weight: 50
url: /pt/java/developer-guide/exporting-dgn-autocad/
---

## **Exportando o formato DGN AutoCAD para PDF**

A API Aspose.CAD para Java introduziu a funcionalidade de carregar um arquivo [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e convertê-lo para o formato [PDF](https://docs.fileformat.com/pdf/). A classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) serve a esse propósito.

Você precisa carregar um arquivo DGN existente como [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina diferentes propriedades. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) e passe a instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Agora, chame o método [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) da instância da classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exemplo de Código

A seguir está a demonstração do código para converter/exportar DGN para o formato PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exportando o formato DGN AutoCAD para o formato de imagem raster**

A API Aspose.CAD para Java introduziu a funcionalidade de carregar um arquivo [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e convertê-lo para uma imagem raster. A classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) serve a esse propósito.

Você precisa carregar um arquivo DGN existente como [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina diferentes propriedades. Crie uma instância da classe [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) e passe a instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Agora, chame o método [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) da instância da classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exemplo de Código

A seguir está a demonstração do código para converter/exportar [DGN](https://docs.fileformat.com/cad/dgn/) para imagem [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
