---
title: SVG 绘图
type: docs
weight: 70
url: /zh/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **导出 SVG 格式到 PDF**

Aspose.CAD for .NET 允许开发者将 SVG 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。SVG 到 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 SVG 绘图文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

## 示例代码

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
