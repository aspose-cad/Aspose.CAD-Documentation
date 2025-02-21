---
title: DWG 图纸
type: docs
weight: 40
url: /zh/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **导出 DWG 图纸为 PDF**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸，并将其转换为 PDF。此主题解释了如何使用 Aspose.CAD API 通过以下简单步骤实现 DWG 到 PDF 格式的转换。

{{% alert color="primary" %}}

该 API 支持以下 AutoCAD DWG 修订版本：

- DWG 2004 版本 16.0 发布 18
- DWG 2005 版本 16.1
- DWG 2010 版本 18.0
- DWG 2013 版本 19.0

{{% /alert %}}

### **DWG 文件格式**

DWG 是一种二进制文件，包含矢量图像数据和元数据。矢量图像数据为 CAD 应用程序提供如何显示 DWG 的指令；元数据可能包含关于文件的各种信息，包括特定位置的数据以及用户数据。DWG 文件格式的开放规范可以在 [此 PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) 中找到。

### **将 DWG 文件转换为 PDF**

将 DWG 转换为 PDF 需要以下简单步骤。

1. 将 DWG 文件加载到 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 的实例中。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法，并将 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的对象作为第二个参数传递。

以下代码示例显示了如何将 DWG 图纸导出为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **创建具有不同布局尺寸的单个 PDF**

Aspose.CAD for Java 允许您将 DWG 文件转换为具有不同布局尺寸的单个 PDF。这种方法的工作原理如下：

1. 使用 [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载一个 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例并设置结果页面的高度和宽度。
1. 为 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象添加所需的 [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-)。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将图像导出为 PDF。

以下代码示例显示了如何创建一个具有不同布局的单个 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **将 DWG 导出为 PDF/A 和 PDF/E**

将 DWG 转换为 PDF 所需的简单步骤如下。

1. 将 DWG 文件加载到 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 的实例中。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法，并将 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的对象作为第二个参数传递。

以下代码示例显示了如何将 DWG 图纸导出为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **支持的 AutoCAD 基元**

以下 AutoCAD 基元被支持。

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **导出特定 DWG 布局为 PDF**

这种方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载一个 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例，并设置结果页面的高度和宽度。
1. 为 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象设置 [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将图像导出为 PDF。

以下代码示例显示了如何将特定 DWG 布局转换为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **使用固定大小导出 DWG 为光栅或 PDF**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸，并使用固定大小将其转换为 PDF 或光栅。

以下代码示例显示了如何实现此功能。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **导出 DWG/DXF 到 BMP 和 PDF 时支持圆角隐藏线**

这种方法的工作原理如下：

1. 使用 [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载一个 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例，并设置结果页面的高度和宽度。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将图像导出为 PDF。

以下代码示例显示了如何实现此功能。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **在导出的 PDF 中为 DWG 图像设置打印区域的支持**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸，并将其转换为 PDF。此主题解释了如何使用 Aspose.CAD API 来实现设置导出 PDF 中 DWG 图像的打印区域的支持。

以下代码示例显示了如何实现此功能。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **支持读取 DWG 文件的 XREF 元数据**

1. 使用 [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载一个 DWG 文件。
1. 遍历每个图像实体。
1. 如果实体是 [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay)，则将其视为带有元数据的 XREF 实体。

以下代码示例显示了如何实现此功能。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **通过指定坐标渲染 DWG 文档**

Aspose.CAD for Java API 现在提供了一项功能，通过提供文档宽度和高度的坐标来渲染 DWG 文档。

以下代码示例显示了如何渲染 DWG 文档。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) 属性是字符串数组类型，因此您可以一次指定多个布局以可能转换为 PDF 格式。在为 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 属性指定多个布局时，生成的 PDF 将拥有多个页面，每个页面代表一个单独的 AutoCAD 布局。

### **列出所有布局**

您可以使用以下代码片段列出 AutoCAD 图纸中所有存在的布局。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **获取外部引用的块属性值**

Aspose.CAD for Java API 允许您获取块属性的外部引用。Aspose.CAD API 暴露了 [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) 属性以获取 [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) 集合中块属性的外部引用。

以下代码演示了如何获取块属性的外部引用。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **在 DWG AutoCAD 文件中搜索文本**

Aspose.CAD for Java API 允许您在 DWG AutoCAD 文件中搜索文本。Aspose.CAD API 暴露了 [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) 类，该类表示 DWG AutoCAD 文件中的文本实体。类 [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) 也包含在 Aspose.CAD API 中，因为某些其他实体也可能包含文本。

以下代码演示了如何在 DWG AutoCAD 文件中搜索文本。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **在特定布局中搜索文本**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **访问 DWG 格式的下层标志**

Aspose.CAD for Java 实现了 DWG 格式的下层标志并允许开发者访问它们。以下是简单的代码演示。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **支持 DWG 实体**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸并支持不同实体的工作。

### **对 MLeader 实体的支持**

DWG 是一种二进制文件，包含矢量图像数据和元数据。DWG 文件中有不同的实体。以下部分描述了如何在 DWG 文件中处理 MLeader 实体的示例。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **导出 DWG 实体为图像的支持**

DWG 是一种二进制文件，包含矢量图像数据和元数据。DWG 文件中有不同的实体。以下部分描述了将特定 DWG 实体导出为图像的示例。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **支持图像导入到 DWG 文件**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸并支持不同实体的工作。DWG 是一种二进制文件，包含矢量图像数据和元数据。DWG 文件中有不同的实体。以下部分描述了如何将图像导入到 DWG 文件中。

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **支持在 DWG 中添加文本**

Aspose.CAD for Java API 可以加载 DWG 格式的 AutoCAD 图纸并支持不同实体的工作。DWG 是一种二进制文件，包含矢量图像数据和元数据。DWG 文件中有不同的实体。以下部分描述了如何在 DWG 文件中添加文本。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **支持 DWG 中的网格**

Aspose.CAD for Java API 现在可以访问支持网格的实体，这些实体包括 [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) 和 [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) 类型。以下示例描述了如何访问网格类型。

## **将 DWG 图纸转换为 DXF**

Aspose.CAD 提供了加载 AutoCAD DWG 文件并将其导出为 DXF 格式的功能。DWG 到 DXF 的转换方法如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DWG 图纸文件。
1. 使用 [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将 DWG 图纸导出为 DXF。

以下代码示例显示了如何将 DWG 文件转换为 DXF 格式。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **将 DWG 图纸转换为 SVG**

Aspose.CAD API 可以加载 DWG 格式的 AutoCAD 图纸，并将其转换为 SVG。此主题解释了如何使用 Aspose.CAD API 通过以下简单步骤实现 DWG 到 SVG 格式的转换。

1. 将 DWG 文件加载到 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 的实例中。
1. 创建 [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) 类的对象，并设置所需的属性。
1. 使用 [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将 DWG 图纸导出为 SVG。

以下代码示例显示了如何将 DWG 文件转换为 SVG 格式。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
