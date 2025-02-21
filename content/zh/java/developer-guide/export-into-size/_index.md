---
title: 将 DWG/DXF 图纸和布局导出为指定尺寸
type: docs
weight: 40
url: /zh/java/developer-guide/export-into-size/
---

## **将模型和所有布局导出为 A4 PDF 尺寸**

Aspose.CAD API 允许您将 DWG/DXF 文件的所有工作表导出为指定的物理 PDF 尺寸。
以下示例代码设置 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) 对象的尺寸，以实现所需的 PDF 尺寸。
A4 纸张的尺寸为 210x297 毫米或 8.27x11.69 英寸，这些值在代码中使用。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **以不同尺寸导出 CAD 布局到 PDF**

有时需要将布局导出为其物理尺寸。下面的示例演示将绘图导出为多页 PDF，其中每一页都包含其布局内容，并具有自己的物理 PDF 尺寸。此示例使用 [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) 属性。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
