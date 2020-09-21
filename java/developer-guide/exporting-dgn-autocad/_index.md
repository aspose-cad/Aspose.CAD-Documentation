---
title: Exporting DGN AutoCAD
type: docs
weight: 50
url: /java/exporting-dgn-autocad/
---

## **Exporting DGN AutoCAD Format To PDF**

Aspose.CAD for Java API has introduced the functionality to load a [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD file and convert it to [PDF](https://docs.fileformat.com/pdf/) format. [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) class serves the purpose.

You need to load an existing DGN file as [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set different properties. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) class and pass the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) instance. Now call the [**save**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method of [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) class instance.

### Sample Code

Following is the code demonstration to convert/export DGN to PDF format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exporting DGN AutoCAD Format To Raster Image Format**

Aspose.CAD for Java API has introduced the functionality to load a [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD file and convert it to a raster image. The [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) class serves the purpose.

You need to load an existing DGN file as [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set different properties. Create an instance of [**JpegOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) class and pass the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) instance. Now call the [**save**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method of [**DgnImage**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) class instance.

### Sample Code

Following is the code demonstration to convert/export [DGN](https://docs.fileformat.com/cad/dgn/) to [JPEG](https://docs.fileformat.com/image/jpeg/) image.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
