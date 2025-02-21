---
title: DXF图纸
type: docs
weight: 10
url: /zh/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **将DXF图纸导出为PDF**

Aspose.CAD提供了加载AutoCAD DXF图纸实体并将其呈现为整个图纸到PDF格式的功能。DXF到PDF的转换方法如下：

1. 使用**Image.load**工厂方法加载DXF图纸文件。
1. 创建**CadRasterizationOptions**类的对象，并设置**page_height**和**page_width**属性。
1. 创建**PdfOptions**类的对象，并设置**VectorRasterizationOptions**属性。
1. 调用**Image.save**，并将**PdfOptions**对象作为第二个参数传递。

下面的代码示例显示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **支持的格式**

目前我们完全支持AutoCAD DXF 2010文件格式。先前的DXF版本不保证100%有效。我们计划在未来的Aspose.CAD版本中包含更多的格式和功能。

### **支持的实体**

目前我们支持所有广泛使用的2D实体及其基本默认参数，如下所示：

1. 对齐尺寸
1. 角度尺寸
1. 弧
1. 属性
1. 块引用
1. 圆
1. 直径尺寸
1. 椭圆
1. 嵌套
1. 线
1. 多行文本
1. 坐标尺寸
1. 点
1. 线性
1. 径向尺寸
1. 光线
1. 旋转尺寸
1. 表格
1. 文本
1. X线

{{% alert color="primary" %}}

如果在解析过程中遇到一些我们不支持的实体或属性，该实体或属性将被悄悄忽略。

{{% /alert %}}

## **为DXF格式导出嵌入的DGN底图**

Aspose.CAD提供了加载AutoCAD DXF文件并为DXF格式导出嵌入的DGN底图的功能。

下面的代码示例显示了如何实现指定的要求。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **支持保存DXF文件**

Aspose.CAD提供了加载AutoCAD DXF文件并对其进行更改，再次保存为DXF文件的功能。

下面的代码示例显示了如何实现指定的要求。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **将DXF导出为WMF**

此方法如下工作：

1. 使用**Image.load**工厂方法加载DXF图纸文件。
1. 创建**CadRasterizationOptions**类的对象并加载PDF文件。
1. 设置**page_height**和**page_width**属性。
1. 调用**Image.save**并保存文件。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
