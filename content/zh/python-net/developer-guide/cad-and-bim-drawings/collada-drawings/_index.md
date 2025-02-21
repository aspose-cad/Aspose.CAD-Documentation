---
title: COLLADA 绘图
type: docs
weight: 20
url: /zh/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **导出 COLLADA 格式到 PDF**

Aspose.CAD for Python 允许开发者将 [COLLADA](https://docs.fileformat.com/3d/dae/) 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。[COLLADA](https://docs.fileformat.com/3d/dae/) 到 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下：

1. 使用 **Image.load** 工厂方法加载 [COLLADA](https://docs.fileformat.com/3d/dae/) 绘图文件。
1. 创建 **CadRasterizationOptions** 类的对象，并设置 **page_height** 和 **page_width** 属性。
1. 创建 **PdfOptions** 类的对象，并设置 **vector_rasterization_options** 属性。
1. 调用 **Image.save**，并将 **PdfOptions** 对象作为第二个参数传递。

## 示例代码

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
