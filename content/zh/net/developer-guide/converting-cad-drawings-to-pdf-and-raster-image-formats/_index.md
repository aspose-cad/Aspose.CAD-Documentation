---
title: DWG DXF 转 PDF C# | 在 C# .NET 中将 Auto CAD 文件转换为 PDF JPEG PNG
type: docs
weight: 30
url: /zh/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG 转 PDF C#, DXF 转 PDF C#, DWF DWT 转 PDF C#, 转换 AutoCAD, 转换 DWG, 转换 DWF, 转换 DWT, 转换 DXF, 将 autocad 转换为 pdf, 将 DWG 转换为 PDF, 将 DWG 转换为 PNG, 将 DWG 转换为 TIFF, 将 DWG 转换为 JPG"
description: 使用 C# .NET 的 AutoCAD 转 PDF 转换器，将 DWG 或 DXF 转换为 PDF。您可以将 DWG、DWF、DWT 和 DXF 转换为 PDF、JPEG、PNG、BMP、GIF 和 TIFF。
---

## **在 C# 中将 DWG 或 DXF 转换为 PNG JPEG BMP GIF 或 TIFF**

Aspose.CAD for .NET 可以将 AutoCAD 绘图格式，如 [DXF](https://docs.fileformat.com/cad/dxf/) 和 [DWG](https://docs.fileformat.com/cad/dwg/) 转换为 [PNG](https://docs.fileformat.com/image/png/)、[BMP](https://docs.fileformat.com/image/bmp/)、[TIFF](https://docs.fileformat.com/image/tiff/)、[JPEG](https://docs.fileformat.com/image/jpeg/) 和 [GIF](https://docs.fileformat.com/image/gif/)。它提供了高效且易于使用的 API 来实现此目标。

您可以使用以下简单步骤将任何受支持的 AutoCAD 绘图格式转换为栅格图像格式。

1. 将 AutoCAD DWG 或 DXF 文件加载到 [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 类中。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 的实例。
1. 使用 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 和 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 设置/更改图像的大小。
1. 创建 [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) 的实例。
1. 将 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性设置为前一步创建的 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 实例。
1. 通过传递文件路径（或 MemoryStream 对象）以及在前一步中创建的 [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) 实例，使用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) 将 AutoCAD 图纸保存为 PDF。

以下是完整的源代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

默认情况下，API 仅渲染“模型”布局。但是，在将 CAD 绘图转换为图像格式时，您也可以指定所需的布局。

## **自定义 CAD 转换**

CAD 到 [PDF](https://docs.fileformat.com/pdf/) 和 CAD 到栅格图像转换过程是高度可配置的，因为 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类是以这种方式实现的，它提供了许多可选功能，您可以设置其以根据应用程序需求覆盖呈现过程。

### **CadRasterizationOptions 类**

**CadRasterizationOptions** 类对于所有受支持的 CAD 格式（如 DWG 和 DXF）都是通用的，因此本文中分享的信息对上述 CAD 格式均有效。

最有用的 **CadRasterizationOptions** 类属性如下：

|**属性**|**默认值**|**是否必填**|**说明**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|是|指定页面宽度。|
|**PageHeight**|**0**|是|指定页面高度|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|否|指定是否应自动缩放图纸。默认值会自动缩小图像以适应画布大小。切换到 **GrowToFit** 模式，或使用 **None** 设置以禁用自动缩放。|
|**BackgroundColor**|**Color.White**|否|指定输出图像的背景颜色。|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|否|指定实体的着色模式。指定 **UseObjectColor** 选项以使用其原生颜色绘制实体，或指定 **UseDrawColor** 选项以重写原生颜色。|
|**DrawColor**|**Color.Black**|否|指定重写的实体颜色（仅在 **DrawType** 设置为 **UseDrawColor** 属性值时）。|
|**AutomaticLayoutsScaling**|False|否|指定是否必须执行自动布局缩放以匹配模型布局。|

### **设置画布大小和模式**

从 CAD 导出到 PDF 或 CAD 到栅格图像格式并不是一项简单的任务。由于生成的 PDF 或图像需要定义画布大小，我们需要具体指定 PDF 页面输出尺寸以正确呈现绘图。如果不是明确设置 **CadRasterizationOptions.PageWidth** 和 **CadRasterizationOptions.PageHeight** 属性，您可能会出现 **ImageSaveException**。

此外，您可以指定尺寸缩放选项。缩放选项由 **CadRasterizationOptions.ScaleMethod** 属性设置。使用此选项可以根据 **CadRasterizationOptions.PageWidth** 和 **CadRasterizationOptions.PageHeight** 的值自动调整图像尺寸。默认情况下，**CadRasterizationOptions.ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 模式。此属性定义了以下行为：

- 如果 CAD 绘图尺寸大于结果画布尺寸，则绘图尺寸将被缩小以适应结果画布，同时保持纵横比。
- 如果 CAD 绘图尺寸小于结果画布尺寸，则将 **CadRasterizationOptions.ScaleMethod** 属性设置为 **ScaleType.GrowToFit** 以增加绘图大小以适应 PDF 画布，同时保持纵横比。
- 或者使用 **ScaleType.None** 选项禁用自动缩放。

以下代码示例展示了自动缩放选项的使用。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **设置背景和绘图颜色**

默认情况下，结果画布的调色板设置为通用文档方案。这意味着 CAD 绘图中的所有实体都用黑色笔在纯白色背景上绘制。这些设置可以通过 **CadRasterizationOptions.BackgroundColor** 和 **CadRasterizationOptions.DrawColor** 属性进行更改。更改 **CadRasterizationOptions.DrawColor** 属性还需设置 **CadRasterizationOptions.DrawType** 属性，以便使用所需的绘图颜色。**CadRasterizationOptions.DrawType** 属性控制 CAD 实体是保留其颜色还是转换为自定义颜色。要保留实体颜色，请将 **CadRasterizationOptions.DrawType** 指定为 **CadDrawTypeMode.UseObjectColor**，否则指定 **CadDrawTypeMode.UseDrawColor** 值。

以下代码示例显示了如何使用不同的颜色属性。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **设置自动布局缩放**

大多数 CAD 绘图在单个文件中存储了多个布局，而每个布局可能具有不同的尺寸。在将此类 CAD 绘图呈现为 PDF 时，PDF 的每个页面都可能根据布局大小具有不同的缩放。为了使呈现变得均匀，Aspose.CAD API 已公开 **CadRasterizationOptions.AutomaticLayoutsScaling** 属性。其默认值为 **false**，但设置为 **true** 时，API 将尝试为每个单独的布局搜索相应的缩放，并以相应的方式绘制它们，通过根据页面大小执行自动调整大小操作。

以下是 **CadRasterizationOptions.AutomaticLayoutsScaling** 属性如何与 **CadRasterizationOptions.ScaleMethod** 属性协同工作的。

1. 如果 **ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 或 **ScaleType.GrowToFit**，且 **AutomaticLayoutsScaling** 设置为 false，则所有布局（包括模型）将根据第一种选项进行处理。
1. 如果 **ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 或 **ScaleType.GrowToFit**，且 **AutomaticLayoutsScaling** 设置为 true，则所有布局（不包括模型）将根据其大小进行处理，而模型将根据第一种选项进行处理。
1. 如果 **ScaleMethod** 设置为 **ScaleType.None**，且 **AutomaticLayoutsScaling** 设置为 true 或 false，则不会执行缩放。

以下代码示例显示了如何为 CAD 到 PDF 转换设置自动布局缩放。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **在 C# 中将 AutoCAD DXF 或 DWG 布局转换为 PNG 或其他图像格式**

Aspose.CAD for .NET API 可以将支持格式的 CAD 布局（如 DXF 和 DWG）转换为 PNG BMP TIFF JPEG 和 GIF。API 还支持将 CAD 绘图的特定布局渲染为不同的 PSD 层。

以下是您可以通过以下简单步骤实现相同目标的方法。

- 使用 **Image** 类加载 AutoCAD DWG 或 DXF 文件。
- 设置/更改图像的宽度和高度。
- 使用 CadRasterizationOptions.Layouts 属性设置所需的布局名称。
- 创建 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步中创建的 **CadRasterizationOptions** 实例。
- 将 CAD 布局保存为 TIFF 或图像。

以下是完整的源代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}}

属性 **CadRasterizationOptions.Layouts** 类型为字符串数组，因此您可以同时指定多个布局进行可能的图像格式转换。在为 **CadRasterizationOptions.Layouts** 属性指定多个布局时，生成的 TIFF 图像将具有多个页面，GIF 图像将具有多个帧，而 [PSD](https://docs.fileformat.com/image/psd/) 格式将具有多个层，其中每个页面/帧/层表示一个单独的 AutoCAD 布局。如果选择将结果存储为其他图像格式（例如 PNG、BMP、JPEG），则 API 将仅渲染默认布局；即“模型”。

{{% /alert %}}

## **启用 CAD 渲染过程的跟踪**

Aspose.CAD 引入了一系列类和支持的枚举字段，以协助跟踪 CAD 渲染过程。通过这些变化，CAD 到 PDF 转换现在可以在启用跟踪的情况下实现，如下所示。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

CAD 渲染过程的跟踪可以检测到以下可能的问题。

1. 缺少或损坏的头信息。
1. 缺少布局信息。
1. 缺少块实体。
1. 缺少尺寸样式。
1. 缺少样式。

## **在转换 CAD 图纸时替换字体**

特定的 CAD 图纸可能使用某些在进行 CAD 到 PDF 或 CAD 到栅格图像转换时机器上不可用的特定字体。在这种情况下，Aspose.CAD API 将触发适当的异常以突出缺失的字体，并停止转换过程，因为 API 需要这些字体以正确呈现内容到生成的 PDF 或图像中。

Aspose.CAD API 提供了一种简单的方法来使用机制将所需的字体替换为可用字体。**CadImage.Styles** 属性返回 **CadStylesDictionary** 的实例，而它又包含 CAD 绘图中每种样式的 **CadStyleTableObject**，而 **CadStyleTableObject.PrimaryFontName** 可用于指定可用字体名称。

以下代码片段演示了对于 .NET API 如何更改 CAD 绘图中所有样式的字体。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

您还可以通过样式名称访问，仅更改某个特定样式的字体。以下代码片段演示了这种方法的用法。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **将 CAD 图层转换为栅格图像格式**

Aspose.CAD for .NET API 提供了一种高效且易于使用的方式来指定所需的 CAD 图层名称并将其渲染为栅格图像格式。以下是您可以通过以下 5 个简单步骤实现相同目标的方法。

1. 使用工厂方法 **Load** 将 CAD 文件加载到 **Image** 的实例中。
1. 创建 **CadRasterizationOptions** 的实例并设置其必填属性，如 **PageWidth** 和 **PageHeight**。
1. 使用 **CadRasterizationOptions.Layers.Add** 方法添加所需的图层名称。
1. 创建 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步中创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.Save** 方法，传递文件路径（或 MemoryStream 对象）以及在前一步中创建的 **ImageOptionsBase** 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **将所有 CAD 图层转换为单独的图像**

您可以使用 **CadImage.Layers** 获取 CAD 绘图中的所有图层，并将每个图层渲染为单独的图像，如下所示。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **将 DWF CAD 图层转换为栅格图像格式**

Aspose.CAD for .NET API 提供了一种高效且易于使用的方式来指定所需的 CAD 图层名称并将其渲染为栅格图像格式。以下是您可以通过以下 5 个简单步骤实现相同目标的方法。

1. 使用工厂方法 **Load** 将 DWF CAD 文件加载到 **Image** 的实例中。
1. 创建 **CadRasterizationOptions** 的实例并设置其必填属性，如 **PageWidth** 和 **PageHeight**。
1. 使用 **CadRasterizationOptions.Layers.Add** 方法添加所需的图层名称。
1. 创建 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步中创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.Save** 方法，传递文件路径（或 MemoryStream 对象）以及在前一步中创建的 **ImageOptionsBase** 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NET 直接在输出文档中写入有关 API 和版本号的信息。例如，在将文档渲染为 PDF 时，Aspose.CAD for .NET 在应用程序字段中填充 'Aspose.CAD' 的值，在 PDF 生成器字段中填充值，例如 'Aspose.CAD v 17.10'。

请注意，您无法指示 Aspose.CAD for .NET 更改或删除该输出文档中的信息。
