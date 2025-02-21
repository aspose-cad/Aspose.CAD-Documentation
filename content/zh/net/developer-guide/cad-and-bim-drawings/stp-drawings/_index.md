---
title: STP 图纸
type: docs
weight: 70
url: /zh/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **导出 STP 格式为 PDF**

Aspose.CAD for .NET 允许开发人员将 [STP](https://docs.fileformat.com/3d/stp/) 文件导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。[STP](https://docs.fileformat.com/3d/stp/) 到 [PDF](https://docs.fileformat.com/pdf/) 的转换方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 [STP](https://docs.fileformat.com/3d/stp/) 绘图文件。
2. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
3. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性。
4. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传入。

## 示例代码

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
