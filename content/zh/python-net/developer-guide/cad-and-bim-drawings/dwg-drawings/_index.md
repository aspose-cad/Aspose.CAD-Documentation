---
title: DWG 图纸
type: docs
weight: 70
url: /zh/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **将 DWG 图纸导出为 PDF**

Aspose.CAD for Python API 可以加载 [DWG](https://docs.fileformat.com/cad/dwg/) 格式的 AutoCAD 图纸，并将其转换为 [PDF](https://docs.fileformat.com/pdf/)。本主题解释了使用 Aspose.CAD API 通过以下简单步骤实现 DWG 到 PDF 格式转换的用法。

{{% alert color="primary" %}}

API 支持以下 AutoCAD DWG 版本：

- DWG 2004 版本 16.0 发行版 18
- DWG 2005 版本 16.1
- DWG 2010 版本 18.0
- DWG 2013 版本 19.0

{{% /alert %}}

### **DWG 文件格式**

[DWG](https://docs.fileformat.com/cad/dwg/) 是一个包含矢量图像数据和元数据的二进制文件。矢量图像数据提供了显示 DWG 的指令给 CAD 应用程序；元数据可能包含关于文件的各种信息，包括特定位置的数据和客户数据。 DWG 文件格式的开放规范可以在 [此 PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) 中找到。

### **将 DWG 文件转换为 PDF**

将 [DWG](https://docs.fileformat.com/cad/dwg/) 转换为 [PDF](https://docs.fileformat.com/pdf/) 所需的简单步骤如下：

1. 将 DWG 文件加载到 **Image** 的实例中。
1. 创建 **CadRasterizationOptions** 类的对象，并设置 **page_height** 和 **page_width** 属性。
1. 创建 **PdfOptions** 类的对象，并设置 **VectorRasterizationOptions** 属性。
1. 调用 **Image.save**，并将 **PdfOptions** 的对象作为第二个参数传递。

下面的代码示例演示了如何将 DWG 图纸导出为 PDF。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **支持的 AutoCAD 原语**

支持以下 AutoCAD 原语。

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

## **导出特定 DWG 布局到 PDF**

该方法的工作原理如下：

1. 使用 **Aspose.CAD.Image.load** 工厂方法加载 DWG 文件。
1. 创建 **CadRasterizationOptions** 类的实例，并设置结果页面的高度和宽度。
1. 为 **CadRasterizationOptions** 对象设置 **Layouts** 属性。
1. 创建 **PdfOptions** 类的实例，并设置其 **VectorRasterizationOptions** 属性。
1. 使用 **Image.save()** 方法将图像导出为 PDF。

下面的代码示例演示了如何将 DWG 的特定布局转换为 PDF。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **导出 DWG 到 PDF/A 和 PDF/E**

该方法的工作原理如下：

1. 使用 **Image.load** 工厂方法加载 DWG 文件。
1. 创建 **CadRasterizationOptions** 类的实例。
1. 创建 **PdfOptions** 类的实例，并设置其 **VectorRasterizationOptions** 属性。
1. 设置 PDF 合规性属性并保存。
1. 使用 **Image.save()** 方法将图像导出为 PDF。

下面的代码示例演示了如何将 DWG 文件转换为 PDF/A 和 PDF/E。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **将 DWG 图纸转换为 DXF**

Aspose.CAD 提供加载 AutoCAD DWG 文件并将其导出为 DXF 格式的功能。 DWG 到 DXF 转换方法的工作原理如下：

1. 使用 **Image.load** 工厂方法加载 DWG 图纸文件。
1. 使用 **Image.save()** 方法将 DWG 图纸导出为 DXF。

下面的代码示例演示了如何将 DWG 文件转换为 DXF 格式。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **将 DWG 图纸转换为 SVG**

Aspose.CAD for Python API 可以加载 DWG 格式的 AutoCAD 图纸，并将其转换为 SVG。 本主题解释了使用 Aspose.CAD API 通过以下简单步骤实现 DWG 到 SVG 格式转换的用法。

1. 将 DWG 文件加载到 **Image** 的实例中。
1. 创建 **SvgOptions** 类的对象，并设置所需属性。
1. 使用 **Image.save()** 方法将 DWG 图纸导出为 SVG。

下面的代码示例演示了如何将 DWG 文件转换为 SVG 格式。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
