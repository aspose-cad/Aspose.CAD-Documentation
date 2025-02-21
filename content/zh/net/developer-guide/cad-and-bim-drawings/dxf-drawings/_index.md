---
title: DXF 图纸
type: docs
weight: 60
url: /zh/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **将 DXF 图纸导出为 PDF**

Aspose.CAD 提供了将 AutoCAD DXF 图纸实体加载并将其呈现为整个图纸到 PDF 格式的功能。DXF 到 PDF 的转换方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

以下代码示例演示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **支持的格式**

目前我们完全支持 AutoCAD DXF 2010 文件格式。之前的 DXF 版本不保证 100% 有效。我们计划在未来的 Aspose.CAD 版本中包括更多的格式和功能。

### **支持的实体**

目前我们支持所有广泛使用的 2D 实体及其基本默认参数如下：

1. 对齐尺寸
1. 角度尺寸
1. 弧
1. 属性
1. 块引用
1. 圆
1. 直径尺寸
1. 椭圆
1. 陰影
1. 线
1. 多行文本
1. 坐标尺寸
1. 点
1. 多段线
1. 径向尺寸
1. 射线
1. 旋转尺寸
1. 表格
1. 文本
1. X线

{{% alert color="primary" %}}

如果在解析过程中遇到我们不支持的实体或属性，该实体或属性将被静默忽略。

{{% /alert %}}

### **内存管理**

[**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) 类的属性 [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) 可用于控制内存重新分配。重新分配最有可能发生在预先分配的缓存中。当系统发现分配的空间不足时可能会发生此情况。

- 如果 [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) 被设置为默认值 **False**，则空间将在相同介质上重新分配。
- 当设置为 **True**，重新分配不能超过最大指定空间。在这种情况下，现有的在内存中分配的缓存（需要重新分配）将被释放，并在磁盘上分配扩展空间。

## **将特定层的 DXF 图纸导出为 PDF**

此方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 和 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 属性。
1. 将层添加到 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的对象。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

以下代码示例演示了如何转换 DXF 的特定层到 PDF。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **将 PDF 文件作为 DXF 图纸的一部分进行渲染**

此方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象并加载 PDF 文件。
1. 设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 并保存文件。

以下代码示例演示了如何将 PDF 文件作为 DXF 图纸的一部分进行渲染。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **导出嵌入的 DGN 背景用于 DXF 格式**

Aspose.CAD 提供了加载 AutoCAD DXF 文件并导出嵌入的 DGN 背景用于 DXF 格式的功能。

以下代码示例演示了如何实现指定的要求。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **支持 DXF 文件的保存**

Aspose.CAD 提供了加载 AutoCAD DXF 文件、进行更改并再次将其保存为 DXF 文件的功能。

以下代码示例演示了如何实现指定的要求。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **将 DXF 导出到 WMF**

此方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象并加载 PDF 文件。
1. 设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 并保存文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **将特定 DXF 布局导出为 PDF**

此方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 和 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 属性。
1. 使用 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 属性指定所需的布局名称。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的实例并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法将图纸导出为 PDF，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

以下代码示例演示了如何将特定布局的 DXF 转换为 PDF。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 属性是字符串数组类型，因此您可以一次指定多个布局以可能转换为 PDF 格式。当为 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) 属性指定多个布局时，生成的 PDF 将有多个页面，每个页面代表一个独立的 AutoCAD 布局。

{{% /alert %}}

## **支持块裁剪**

Aspose.CAD 提供了块裁剪的功能。块裁剪方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象并加载 PDF 文件。
1. 设置 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的所需属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递并保存文件。

以下代码示例演示了块裁剪的工作原理。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **将图像导出为 DXF**

使用 Aspose.CAD，您可以将图像导出为 DXF 格式。通过这种方法，您可以执行以下操作：

1. 设置新字体
1. 隐藏实体
1. 更新文本

以下代码示例演示了如何执行上述操作。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **将特定层的 DXF 图纸导出为图像**

此方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 和 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 属性。
1. 将层添加到 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的对象。
1. 创建 [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 的实例并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 属性。
1. 使用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法导出图纸为 PDF。

以下代码示例演示了如何将特定层的 DXF 转换为图像。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
