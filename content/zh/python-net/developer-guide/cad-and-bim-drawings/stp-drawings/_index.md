---
title: STP 图纸
type: docs
weight: 160
url: /zh/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **导出 STP 格式为 PDF**

Aspose.CAD for Python 允许开发者将 [STP](https://docs.fileformat.com/3d/stp/) 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。[STP](https://docs.fileformat.com/3d/stp/) 到 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下：

1. 使用 **Image.load** 工厂方法加载 [STP](https://docs.fileformat.com/3d/stp/) 图纸文件。
1. 创建 **CadRasterizationOptions** 类的对象，并设置 **page_height** 和 **page_width** 属性。
1. 创建 **PdfOptions** 类的对象并设置 **vector_rasterization_options** 属性。
1. 调用 **Image.save**，并将 **PdfOptions** 对象作为第二个参数传递。

## 示例代码

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
