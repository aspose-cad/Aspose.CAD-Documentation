---
title: 将 CAD 图纸转换为 PDF 和栅格图像格式
type: docs
weight: 30
url: /zh/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java 直接在输出文档中写入 API 和版本号的信息。例如，在将文档呈现为 PDF 时，Aspose.CAD for Java 将应用程序字段填充为 'Aspose.CAD'，PDF 生成器字段填充为值，例如 'Aspose.CAD v 17.9'。

请注意，您无法指示 Aspose.CAD for Java 更改或删除此信息。

{{% /alert %}} 
## **将 CAD 图纸转换为栅格图像格式**
Aspose.CAD for Java 能够将支持的栅格图像格式（如 [**DXF**](https://docs.fileformat.com/cad/dxf/) 和 [**DWG**](https://docs.fileformat.com/cad/dwg/)）转换为支持的栅格图像格式，如 [**PNG**](https://docs.fileformat.com/image/png/)、[**BMP**](https://docs.fileformat.com/image/bmp/)、[**TIFF**](https://docs.fileformat.com/image/tiff/)、[**JPEG**](https://docs.fileformat.com/image/jpeg/) 和 [**GIF**](https://docs.fileformat.com/image/gif/)。Aspose.CAD for Java API 提供了高效且易于使用的方法来实现这一目标。
您可以通过以下简单步骤将任何支持的 CAD 图纸格式转换为栅格图像格式。

1. 将 CAD 文件加载到 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 实例中。
1. 创建一个 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 的实例，并设置其必需属性，例如 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 和 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)。
1. 创建一个 **ImageOptionsBase** 的实例，并将其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性设置为前一步创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.save**，传递文件路径（或 MemoryStream 对象）以及前一步创建的 [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



默认情况下，该 API 仅呈现 "Model" 布局。然而，在将 CAD 图纸转换为图像格式时，您也可以指定您选择的布局。
## **自定义 CAD 转换**
CAD 到 [PDF](https://docs.fileformat.com/pdf/) 和 CAD 到栅格图像的转换过程具有高度可配置性，因为 [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实现方式提供了许多可选功能，设置后可以根据应用程序的需要覆盖渲染过程。
### **CadRasterizationOptions 类**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类适用于所有支持的 CAD 格式，如 [**DWG**](https://docs.fileformat.com/cad/dwg/) 和 [DXF](https://docs.fileformat.com/cad/dxf/)，因此本文中分享的信息对这两种 CAD 格式均有效。

最有用的 **CadRasterizationOptions** 类属性包括：

|**属性**|**默认值**|**是否必需**|**描述**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|是|指定页面宽度。|
|**PageHeight**|**0**|是|指定页面高度|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|否|指定绘图是否应自动缩放。默认值自动缩小图像以适应画布大小。切换到 **GrowToFit** 模式，或使用 **None** 设置以禁用自动缩放。|
|**BackgroundColor**|**Color.White**|否|指定输出图像的背景颜色。|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|否|指定实体的着色模式。使用 **UseObjectColor** 选项来使用其原生颜色绘制实体，或使用 **UseDrawColor** 选项来覆盖原生颜色。|
|**DrawColor**|**Color.Black**|否|指定被覆盖实体的颜色（仅当 **DrawType** 设置为 **UseDrawColor** 属性值时）。|
|**AutomaticLayoutsScaling**|False|否|指定是否必须执行自动布局缩放，以匹配模型布局。|
### **设置画布大小和模式**
从 CAD 导出到 PDF 或 CAD 导出到栅格图像格式并不是一项简单的任务。由于生成的 PDF 或图像需要定义画布大小，因此我们需要显式指定 PDF 页面以正确呈现图纸的输出尺寸。明确设置 **CadRasterizationOptions.PageWidth** 和 **CadRasterizationOptions.PageHeight** 属性，否则您可能会遇到 **ImageSaveException**。

此外，您可以指定尺寸缩放选项。缩放选项由 **CadRasterizationOptions.ScaleMethod** 属性设置。使用此选项根据 **CadRasterizationOptions.PageWidth** 和 **CadRasterizationOptions.PageHeight** 值自动调整图像尺寸。默认情况下 **CadRasterizationOptions.ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 模式。此属性定义以下行为：

- 如果 CAD 绘图尺寸大于结果画布大小，则绘图尺寸将缩小以适应结果画布，同时保持纵横比。
- 如果 CAD 绘图尺寸小于结果画布大小，请将 **CadRasterizationOptions.ScaleMethod** 属性设置为 **ScaleType.GrowToFit**，以增加绘图大小以适应 PDF 画布，同时保持纵横比。
- 或者使用 **ScaleType.None** 选项禁用自动缩放。

下面的代码示例展示了自动缩放选项的使用。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **设置背景和绘图颜色**
默认情况下，结果画布的颜色调色板设置为通用文档方案。这意味着 CAD 绘图内的所有实体都用黑色钢笔绘制在纯白色背景上。这些设置可以通过 **CadRasterizationOptions.BackgroundColor** 和 **CadRasterizationOptions.DrawColor** 属性更改。更改 **CadRasterizationOptions.DrawColor** 属性也需要设置 **CadRasterizationOptions.DrawType** 属性，以便使用所用的绘图颜色。**CadRasterizationOptions.DrawType** 属性控制 CAD 实体是否保留其颜色或转换为自定义颜色。要保留实体颜色，请将 **CadRasterizationOptions.DrawType** 设置为 **CadDrawTypeMode.UseObjectColor**，否则请指定 **CadDrawTypeMode.UseDrawColor** 值。

下面的代码示例展示了如何使用不同的颜色属性。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **设置自动布局缩放**
大多数 CAD 图纸在单个文件中存储了多个布局，每个布局可能具有不同的尺寸。在将此类 CAD 图纸呈现为 PDF 时，PDF 的每一页都可能会根据布局大小具有不同的缩放比例。为了使渲染均匀，Aspose.CAD API 提供了 **CadRasterizationOptions.AutomaticLayoutsScaling** 属性。其默认值为 **false**，但当设置为 true 时，API 将尝试为每个单独的布局搜索相应的缩放比例，并通过根据页面大小执行自动调整操作以相应的方式绘制它们。

以下是 **CadRasterizationOptions.AutomaticLayoutsScaling** 属性与 **CadRasterizationOptions.ScaleMethod** 属性协作的工作原理。

1. 如果 **ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 或 **ScaleType.GrowToFit**，同时 **AutomaticLayoutsScaling** 设置为 false，则所有布局（包括模型）将根据第一个选项处理。
1. 如果 **ScaleMethod** 设置为 **ScaleType.ShrinkToFit** 或 **ScaleType.GrowToFit**，同时 **AutomaticLayoutsScaling** 设置为 true，则将根据其大小处理所有布局（模型除外），而模型将根据第一个选项处理。
1. 如果 **ScaleMethod** 设置为 **ScaleType.None**，而 **AutomaticLayoutsScaling** 设置为 true 或 false，则不会执行任何缩放。

下面的代码示例展示了如何设置 CAD 到 PDF 转换的自动布局缩放。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **将 CAD 布局转换为栅格图像格式**
Aspose.CAD for Java API 可以将支持格式（如 DXF 和 DWG）的 CAD 布局转换为 PNG、BMP、TIFF、JPEG 和 GIF 等栅格图像。该 API 还支持将 CAD 绘图的特定布局呈现为不同的 PSD 图层。
Aspose.CAD for Java API 提供了高效且易于使用的方法，以指定所需的 CAD 布局列表并将其呈现为栅格图像格式。您可以通过下列 5 个简单步骤实现相同的目标。

1. 使用工厂方法 **load** 将 CAD 文件加载到 **Image** 的实例中。
1. 创建一个 **CadRasterizationOptions** 的实例，并设置其必需属性，如 **PageWidth** 和 **PageHeight**。
1. 使用 **CadRasterizationOptions.Layouts** 属性指定所需的布局名称。
1. 创建一个 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.Save**，传递文件路径（或 MemoryStream 对象）以及前一步创建的 **ImageOptionsBase** 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

属性 **CadRasterizationOptions.Layouts** 是字符串数组类型，您可以同时指定多个布局以进行可能的图像格式转换。在为 **CadRasterizationOptions.Layouts** 属性指定多个布局时，结果 TIFF 图像将具有多页，而 GIF 图像将具有多个帧，PSD 格式将具有多个图层，每页/帧/图层代表一个单独的 AutoCAD 布局。如果选择其他图像格式（如 PNG、BMP、JPEG）来存储结果，则 API 将仅呈现默认布局，即 "Model"。

{{% /alert %}} 
## **启用 CAD 渲染过程的跟踪**
Aspose.CAD 引入了一系列类和支持的枚举字段，以帮助跟踪 CAD 渲染过程。通过这些更改，CAD 到 PDF 的转换现在可以在启用跟踪的状态下进行，如下所示。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



CAD 渲染过程的跟踪可以检测到以下可能的问题。

1. 缺少或损坏的头信息。
1. 缺少布局信息。
1. 缺少块实体。
1. 缺少尺寸样式。
1. 缺少样式。
## **转换 CAD 图纸时替换字体**
特别的 CAD 图纸可能使用某些在进行 CAD 到 PDF 或 CAD 到栅格图像转换的机器上不可用的特定字体。在这种情况下，Aspose.CAD API 将触发一个适当的异常，以突出缺少的字体并停止转换过程，因为 API 需要这些字体以便正确渲染生成的 PDF 和/或图像。
Aspose.CAD API 提供了一种简单的方法来使用机制将所需的字体替换为可用的字体。**CadImage.Styles** 属性返回 **CadStylesDictionary** 的实例，该实例包含 CAD 绘图中每个样式的 **CadStyleTableObject**，而 **CadStyleTableObject.PrimaryFontName** 可以用于指定可用的字体名称。

以下代码片段演示了如何使用 Aspose.CAD for Java API 更改 CAD 绘图中所有样式的字体。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




通过样式名称访问唯一样式的字体也是可能的。以下代码片段演示了使用这种方法的示例。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **将 CAD 图层转换为栅格图像格式**
Aspose.CAD for Java API 提供了一种高效且易于使用的方法来指定所需 CAD 图层的名称并将其转换为栅格图像格式。您可以通过以下 5 个简单步骤实现。

1. 使用工厂方法 **load** 将 CAD 文件加载到 **Image** 实例中。
1. 创建一个 **CadRasterizationOptions** 的实例，并设置其必需属性，如 **PageWidth** 和 **PageHeight**。
1. 使用 **CadRasterizationOptions.Layers.add** 方法添加所需的图层名称。
1. 创建一个 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.save** 方法，传递文件路径（或 MemoryStream 对象）以及前一步创建的 **ImageOptionsBase** 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **将所有 CAD 图层转换为单独的图像**
您可以使用 **CadImage.Layers** 获取 CAD 绘图中的所有图层，并将每个图层渲染为单独的图像，如下所示。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **将 DWF CAD 图层转换为栅格图像格式**
Aspose.CAD for Java API 提供了一种高效且易于使用的方法来指定所需 CAD 图层的名称并将其转换为栅格图像格式。您可以通过以下 5 个简单步骤实现。

1. 使用工厂方法 **Load** 将 DWF CAD 文件加载到 **Image** 实例中。
1. 创建一个 **CadRasterizationOptions** 的实例，并设置其必需属性，如 **PageWidth** 和 **PageHeight**。
1. 使用 **CadRasterizationOptions.Layers.Add** 方法添加所需的图层名称。
1. 创建一个 **ImageOptionsBase** 的实例，并将其 **VectorRasterizationOptions** 属性设置为前一步创建的 **CadRasterizationOptions** 实例。
1. 调用 **Image.Save** 方法，传递文件路径（或 MemoryStream 对象）以及前一步创建的 **ImageOptionsBase** 实例。

以下是完整的源代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
