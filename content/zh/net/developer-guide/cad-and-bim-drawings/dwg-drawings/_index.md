---
title: DWG 绘图
type: docs
weight: 40
url: /zh/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **导出 DWG 绘图到 PDF**

Aspose.CAD for .NET API 可以加载 AutoCAD 绘图，格式为 [DWG](https://docs.fileformat.com/cad/dwg/)，并将其转换为 [PDF](https://docs.fileformat.com/pdf/)。本主题讲解了如何通过以下简单步骤使用 Aspose.CAD API 实现 DWG 转 PDF 的转换。

{{% alert color="primary" %}}

该 API 支持以下 AutoCAD DWG 版本：

- DWG 2004 版本 16.0 发布 18
- DWG 2005 版本 16.1
- DWG 2010 版本 18.0
- DWG 2013 版本 19.0

{{% /alert %}}

### **DWG 文件格式**

[DWG](https://docs.fileformat.com/cad/dwg/) 是一种包含矢量图像数据和元数据的二进制文件。矢量图像数据提供了有关如何显示 DWG 的 CAD 应用程序的指令；元数据可能包含有关文件的各种信息，包括特定位置的数据以及客户数据。有关 DWG 文件格式的开放规范可以在 [此 PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) 中找到。

### **将 DWG 文件转换为 PDF**

将 [DWG](https://docs.fileformat.com/cad/dwg/) 转换为 [PDF](https://docs.fileformat.com/pdf/) 需遵循以下简单步骤。

1. 将 DWG 文件加载到 [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 的实例中。
1. 创建一个 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建一个 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) 方法，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

下面的代码示例展示了如何将 DWG 绘图导出为 PDF。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **使用不同布局尺寸创建单个 PDF**

Aspose.CAD for .NET 允许您将 DWG 文件转换为具有不同布局尺寸的单个 PDF。此方法的工作流程如下：

1. 使用 [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的实例，并设置结果页面的高度和宽度。
1. 为 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 对象添加所需的 [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes)。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将图像导出为 PDF。

下面的代码示例展示了如何创建一个具有不同布局的单个 [PDF](https://docs.fileformat.com/pdf/)。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **支持的 AutoCAD 基元**

支持以下 AutoCAD 基元。

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

## **将特定 DWG 布局导出为 PDF**

此方法的工作流程如下：

1. 使用 [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的实例，并设置结果页面的高度和宽度。
1. 为 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 对象设置 [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将图像导出为 PDF。

下面的代码示例展示了如何将 DWG 的特定布局转换为 PDF。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **通过指定坐标渲染 DWG 文档**

Aspose.CAD for .NET API 现在提供了一种功能，通过指定文档的宽度和高度坐标来渲染 DWG 文档。

下面的代码示例展示了如何渲染 DWG 文档。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **使用固定尺寸导出 DWG 到光栅或 PDF**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并使用固定尺寸将其转换为 PDF 或光栅。

下面的代码示例展示了如何实现此功能。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **导出 DWG 到 PDF/A 和 PDF/E**

此方法的工作流程如下：

1. 使用 [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的实例。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 设置 PDF 合规性属性并保存。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将图像导出为 PDF。

下面的代码示例展示了如何将 DWG 文件转换为 PDF/A 和 PDF/E。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **导出 DWG/DXF 到 BMP 和 PDF 时支持圆角隐藏线**

此方法的工作流程如下：

1. 使用 [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DWG 文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的实例，并设置结果页面的高度和宽度。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将图像导出为 PDF。

下面的代码示例展示了如何实现此功能。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **支持在导出的 PDF 中设置 DWG 图像的打印区域**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并转换为 PDF。本主题讲解了如何使用 Aspose.CAD API 来实现对导出 PDF 中 DWG 图像的打印区域的设置支持。

下面的代码示例展示了如何实现此功能。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **支持读取 DWG 文件的 XREF 元数据**

1. 使用 [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DWG 文件。
1. 遍历每个图像实体。
1. 如果实体为 CadUnderlay，则与元数据的 XREF 实体。

下面的代码示例展示了如何实现此功能。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

属性 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 是字符串数组类型，因此您可以同时指定多个布局以进行可能的 PDF 格式转换。在为 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 属性指定多个布局时，生成的 PDF 将包含多个页面，每个页面代表一个单独的 AutoCAD 布局。

### **列出所有布局**

您可以使用以下代码片段列出 AutoCAD 绘图中存在的所有布局。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **访问 DWG 格式的覆盖旗标**

Aspose.CAD for .NET 已实现 DWG 格式的覆盖旗标，并允许开发人员访问它们。以下是简单的代码演示。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **支持 DWG 实体**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并支持不同的实体进行操作。

### **支持 MLeader 实体**

DWG 是一种包含矢量图像数据和元数据的二进制文件。DWG 文件中存在不同的实体。以下部分描述了如何在 DWG 文件中处理 MLeader 实体的示例。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **支持将 DWG 实体导出为图像**

DWG 是一种包含矢量图像数据和元数据的二进制文件。DWG 文件中存在不同的实体。以下部分描述了将特定 DWG 实体导出为图像的示例。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **支持在 DWG 中添加文本**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并支持不同的实体进行操作。DWG 是一种包含矢量图像数据和元数据的二进制文件。DWG 文件中存在不同的实体。以下部分描述了如何在 DWG 文件中添加文本。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **支持将图像导入到 DWG 文件中**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并支持不同的实体进行操作。DWG 是一种包含矢量图像数据和元数据的二进制文件。DWG 文件中存在不同的实体。以下部分描述了如何将图像导入 DWG 文件中。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **支持在 DWG 中的网格**

Aspose.CAD for .NET API 现在可以访问支持网格的实体，其中包括 [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) 和 [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) 类型。以下示例描述了如何访问网格类型。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **将 DWG 绘图转换为 DXF**

Aspose.CAD 提供了加载 AutoCAD DWG 文件并将其导出为 DXF 格式的功能。DWG 转 DXF 转换方法的工作流程如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法加载 DWG 绘图文件。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将 DWG 绘图导出为 DXF。

下面的代码示例展示了如何将 DWG 文件转换为 DXF 格式。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **将 DWG 绘图转换为 SVG**

Aspose.CAD for .NET API 可以加载 DWG 格式的 AutoCAD 绘图，并将其转换为 SVG。本主题讲解了如何通过以下简单步骤使用 Aspose.CAD API 实现 DWG 转 SVG 的转换。

1. 将 DWG 文件加载到 [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 的实例中。
1. 创建一个 [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) 类的对象，并设置所需的属性。
1. 使用 [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将 DWG 绘图导出为 SVG。

下面的代码示例展示了如何将 DWG 文件转换为 SVG 格式。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **加载大型 DWG 文件**

Aspose.CAD for .NET 提供了使用 [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 类打开大型 DWG 文件的功能。现在，您可以通过下面提供的示例代码轻松打开大型文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
