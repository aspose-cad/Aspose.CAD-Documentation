---
title: FBX 绘图
type: docs
weight: 110
url: /zh/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **导出 FBX 格式到 PDF**

Aspose.CAD for Python 允许开发者将 [FBX](https://docs.fileformat.com/3d/fbx/) 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。 [FBX](https://docs.fileformat.com/3d/fbx/) 转 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下所示：

1. 使用 **Image.load** 工厂方法加载 [FBX](https://docs.fileformat.com/3d/fbx/) 绘图文件。
1. 创建 **CadRasterizationOptions** 类的对象，并设置 **PageHeight** 和 **PageWidth** 属性。
1. 创建 **PdfOptions** 类的对象，并设置 **vector_rasterization_options** 属性。
1. 调用 **Image.save**，同时将 **PdfOptions** 的对象作为第二个参数传入。

## 示例代码

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
