---
title: DRC图纸
type: docs
weight: 15
url: /zh/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **将DRC图纸导出为PDF**

Aspose.CAD提供加载AutoCAD [DRC](https://docs.fileformat.com/3d/drc/)图形实体并将其渲染为完整图纸到[PDF](https://docs.fileformat.com/pdf/)格式的功能。[DRC](https://docs.fileformat.com/3d/drc/)到[PDF](https://docs.fileformat.com/pdf/)的转换方法如下：

1. 使用[**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)工厂方法加载[DRC](https://docs.fileformat.com/3d/drc/)绘图文件。
1. 创建[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)类的对象，并设置[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)和[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)属性。
1. 创建[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)类的对象，并设置[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)属性。
1. 调用[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)对象作为第二个参数传递。

### 示例代码

下面的代码示例显示了如何使用默认设置转换文件。


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
