---
title: DXF 图纸
type: docs
weight: 60
url: /zh/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **导出 DXF 图纸为 PDF**

Aspose.CAD 提供加载 AutoCAD DXF 图纸实体并将其渲染为整个图纸到 PDF 格式的功能。DXF 到 PDF 的转换方法如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的实例，并设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 类的实例，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 调用 Image.Save，将 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的对象作为第二个参数传递。

以下代码示例显示如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **支持的格式**

目前我们完全支持 AutoCAD DXF 2010 文件格式。之前的 DXF 版本不保证 100% 有效。我们计划在未来的 Aspose.CAD 版本中包含更多格式和功能。

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
1. 填充
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

如果在解析期间遇到我们不支持的实体或属性，该实体或属性将被静默忽略。

{{% /alert %}}

### **内存管理**

属性 [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) 可以用于控制内存重新分配。重新分配最有可能发生在预分配缓存中。当系统判断已分配的空间不足时，就会发生这种情况。

- 如果 [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) 设置为默认值 **False**，则空间会重新分配到相同的介质。
- 设置为 **True** 时，重新分配不能超过最大指定空间。在这种情况下，已在内存中分配的缓存（需要重新分配）会被释放，并在磁盘上分配扩展空间。

## **导出 DXF 图纸的特定图层为 PDF**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 和 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 属性。
1. 将图层添加到 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象中。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法导出图纸为 PDF。

以下代码示例显示如何转换 DXF 的特定图层为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **导出 DXF 图纸的特定图层为图像**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 和 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 属性。
1. 将图层添加到 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象中。
1. 创建 [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) 的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法导出图纸为 PDF。

以下代码示例显示如何将 DXF 的特定图层转换为图像。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **将 PDF 文件作为 DXF 图纸的一部分进行渲染**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象并加载 PDF 文件。
1. 设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 并保存文件。

以下代码示例显示如何将 PDF 文件作为 DXF 图纸的一部分进行渲染。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **导出 DXF 为 WMF**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象并加载 PDF 文件。
1. 设置 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 和 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 并保存文件。

以下代码示例显示如何将 DXF 导出为 WMF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **支持保存 DXF 文件**

Aspose.CAD 提供加载 AutoCAD DXF 文件并对其进行更改并再次保存为 DXF 文件的功能。以下代码示例显示如何实现指定要求。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **导出嵌入的 DGN 作为 DXF 格式**

Aspose.CAD 提供加载 AutoCAD DXF 文件并导出嵌入的 DGN 作为 DXF 格式的功能。

以下代码示例显示如何实现指定要求。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **导出特定的 DXF 布局为 PDF**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法打开 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 的实例，并指定 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 和 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 属性。
1. 使用 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 属性指定所需的布局名称。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的实例，并设置其 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 属性。
1. 使用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 方法将图纸导出为 PDF。

以下代码示例显示如何将特定的 DXF 布局转换为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

属性 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 是字符串数组类型，因此您可以一次指定多个布局以转换为 PDF 格式。当为 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) 属性指定多个布局时，生成的 PDF 将具有多个页面，每个页面表示一个单独的 AutoCAD 布局。

{{% /alert %}}

## **访问 ATTRIB 和 MTEXT 对象**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法打开 DXF 图纸文件。
1. 访问 CAD 文件中的实体。
1. 检查 [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) 和 [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) 实体。
1. 添加到临时列表以供进一步处理。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **分解 CAD 插入对象**

此方法的工作原理如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法打开 **DXF** 图纸文件。
1. 访问 CAD 文件中的实体。
1. 检查 [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) 实体。
1. 检查 [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) 类型列表。
1. 处理实体。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **支持块裁剪**

Aspose.CAD 提供块裁剪功能。块裁剪的方法如下：

1. 使用 [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 工厂方法加载 DXF 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的对象并加载 PDF 文件。
1. 设置 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 的所需属性。
1. 调用 [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)，并将 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 的对象作为第二个参数传递并保存文件。

以下代码示例显示块裁剪的工作原理。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **导出图像到 DXF**

使用 Aspose.CAD，您可以将图像导出为 DXF 格式。通过这种方法，您可以执行以下操作：

1. 设置新的字体
1. 隐藏实体
1. 更新文本

以下代码示例显示如何执行上述操作。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
