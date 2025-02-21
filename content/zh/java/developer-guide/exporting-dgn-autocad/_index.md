---
title: 将 DGN AutoCAD 导出
type: docs
weight: 50
url: /zh/java/developer-guide/exporting-dgn-autocad/
---

## **将 DGN AutoCAD 格式导出为 PDF**

Aspose.CAD for Java API 已引入加载 [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD 文件并将其转换为 [PDF](https://docs.fileformat.com/pdf/) 格式的功能。 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 类用于此目的。

您需要将现有的 DGN 文件加载为 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)。创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例并设置不同的属性。创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) 类的实例并传递 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 实例。现在调用 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 类实例的 [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法。

### 示例代码

以下是将 DGN 转换/导出为 PDF 格式的代码演示。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **将 DGN AutoCAD 格式导出为光栅图像格式**

Aspose.CAD for Java API 已引入加载 [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD 文件并将其转换为光栅图像的功能。 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 类用于此目的。

您需要将现有的 DGN 文件加载为 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)。创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例并设置不同的属性。创建 [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) 类的实例并传递 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 实例。现在调用 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 类实例的 [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法。

### 示例代码

以下是将 [DGN](https://docs.fileformat.com/cad/dgn/) 转换/导出为 [JPEG](https://docs.fileformat.com/image/jpeg/) 图像的代码演示。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
