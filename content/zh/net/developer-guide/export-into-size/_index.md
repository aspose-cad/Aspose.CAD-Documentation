---
title: 导出 DWG/DXF 图纸和布局到指定大小
type: docs
weight: 40
url: /zh/net/developer-guide/export-into-size/
---

## **导出模型和所有布局为 A4 PDF 大小**

Aspose.CAD API 允许您将 DWG/DXF 文件的所有图纸导出为指定的物理 PDF 大小。

以下示例代码设置 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 对象的大小以实现所需的 PDF 大小。
A4 纸张的大小为 210x297 毫米或 8.27x11.69 英寸，这些值在代码中使用。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **以不同大小将 CAD 布局导出为 PDF**

有时需要将布局导出为其物理大小。下面的示例演示了将图纸导出为多页 PDF，其中每个带有布局内容的页面都有其自己的物理 PDF 大小。此示例使用 [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) 属性。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
