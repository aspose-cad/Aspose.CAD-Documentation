---
title: DWF 图纸
type: docs
weight: 20
url: /zh/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **导出 DWF 图纸为 PDF**

Aspose.CAD for Java API 可以加载 DWF 格式的 AutoCAD 图纸，并将其转换为 PDF。此主题解释了如何使用 Aspose.CAD API 通过以下简单步骤实现 DWF 到 PDF 格式的转换。

### **将 DWF 文件转换为 PDF**

转换 DWF 为 PDF 需要以下简单步骤。

1. 将 DWF 文件加载到 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 的一个实例中。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ，并将 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 对象作为第二个参数传递。

下面的代码示例演示了如何将 DWF 图纸导出为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **DWF 中图层的支持**

Aspose.CAD 提供加载 AutoCAD DWF 图纸实体并将它们呈现为完整图纸到 JPG 格式的功能。

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DWF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象。
1. 添加所需的图层。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ，并将 [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) 对象作为第二个参数传递。

下面的代码示例演示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
