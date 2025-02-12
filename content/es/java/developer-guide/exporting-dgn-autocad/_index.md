---
title: Exportando DGN AutoCAD
type: docs
weight: 50
url: /es/java/developer-guide/exporting-dgn-autocad/
---

## **Exportando el formato DGN de AutoCAD a PDF**

Aspose.CAD para Java API ha introducido la funcionalidad para cargar un archivo de AutoCAD [DGN](https://docs.fileformat.com/cad/dgn/) y convertirlo a formato [PDF](https://docs.fileformat.com/pdf/). La clase [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) cumple este propósito.

Necesitas cargar un archivo DGN existente como [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crea una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establece diferentes propiedades. Crea una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) y pasa la instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Ahora llama al método [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) de la instancia de la clase [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Código de Ejemplo

A continuación se muestra la demostración de código para convertir/exportar DGN a formato PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exportando el formato DGN de AutoCAD a formato de imagen rasterizada**

Aspose.CAD para Java API ha introducido la funcionalidad para cargar un archivo de AutoCAD [DGN](https://docs.fileformat.com/cad/dgn/) y convertirlo a una imagen rasterizada. La clase [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) cumple este propósito.

Necesitas cargar un archivo DGN existente como [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Crea una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establece diferentes propiedades. Crea una instancia de la clase [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) y pasa la instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Ahora llama al método [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) de la instancia de la clase [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Código de Ejemplo

A continuación se muestra la demostración de código para convertir/exportar [DGN](https://docs.fileformat.com/cad/dgn/) a imagen [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
