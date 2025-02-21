---
title: SVG图形
type: docs
weight: 170
url: /zh/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **导出SVG格式为PDF**

Aspose.CAD for Python允许开发人员将[SVG](https://docs.fileformat.com/page-description-language/svg/)文件导出为[PDF](https://docs.fileformat.com/pdf/)格式。[SVG](https://docs.fileformat.com/page-description-language/svg/)到[PDF](https://docs.fileformat.com/pdf/)的转换方法如下：

1. 使用**Image.load**工厂方法加载SVG图形文件。
1. 创建**CadRasterizationOptions**类的对象并设置**page_height**和**page_width**属性。
1. 创建**PdfOptions**类的对象并设置**VectorRasterizationOptions**属性。
1. 调用**Image.save**并将**PdfOptions**对象作为第二个参数传递。

## 示例代码

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
