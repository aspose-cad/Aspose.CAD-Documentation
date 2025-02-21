---
title: DWF 图纸
type: docs
weight: 50
url: /zh/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **导出 DWF 图纸到 PDF**

Aspose.CAD 提供将 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体加载并渲染为整个绘图到 [PDF](https://docs.fileformat.com/pdf/) 格式的功能。[DWF](https://docs.fileformat.com/cad/dwf/) 到 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下：

1. 使用 **Image.load** 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
2. 创建 **CadRasterizationOptions** 类的对象，并设置 **page_height** 和 **page_width** 属性。
3. 创建 **PdfOptions** 类的对象，并设置 **vector_rasterization_options** 属性。
4. 调用 **Image.save**，将 **PdfOptions** 的对象作为第二个参数传递。

### 示例代码

以下代码示例展示了如何使用默认设置转换文件。


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **导出 DWF 图纸到 BMP**

Aspose.CAD 提供将 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体加载并渲染为整个绘图到 [BMP](https://docs.fileformat.com/image/bmp/) 格式的功能。[DWF](https://docs.fileformat.com/cad/dwf/) 到 [BMP](https://docs.fileformat.com/image/bmp/) 的转换方法如下：

1. 使用 **Image.load** 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
2. 创建 **CadRasterizationOptions** 类的对象，并设置 **page_height** 和 **page_width** 属性。
3. 创建 **BmpOptions** 类的对象，并设置 **vector_rasterization_options** 属性。
4. 调用 **Image.save**，将 **BmpOptions** 的对象作为第二个参数传递。

### 示例代码

以下代码示例展示了如何使用默认设置将 [DWF](https://docs.fileformat.com/cad/dwf/) 文件转换为 [BMP](https://docs.fileformat.com/image/bmp/) 。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
