---
title: DXB 图纸
type: docs
weight: 70
url: /zh/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **导出 DXB 格式到 PDF**

Aspose.CAD for .NET 允许开发者将 DXB 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。DXB 到 [PDF](https://docs.fileformat.com/pdf/) 转换的方式如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 DXB 图纸文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 对象作为第二个参数传递。

## 示例代码

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
