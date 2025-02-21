---
title: 调整CAD绘图大小
type: docs
weight: 10
url: /zh/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

通过使用Aspose.CAD for Python库，开发人员可以在转换为任何支持的格式时调整CAD绘图的大小。本主题说明了使用**ImageOptions**类的**UnitType**枚举自动或手动调整大小的方法。

{{% /alert %}}

## **调整CAD绘图大小**

Aspose.CAD for Python提供了**UnitType**枚举，以在CAD格式转换期间调整绘图的大小。调整绘图大小有两种方法。

1. 自动大小调整。
1. 使用**ImageOptions**类的**UnitType**枚举调整大小。

对于自动调整大小，开发人员无需提供**CadRasterizationOptions**类的宽度和高度属性。以下提供的代码片段是自动大小调整的示例。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType**枚举使得在未设置宽度和高度属性时能够调整缩放。以下提供的代码片段演示了如何使用**UnitType**。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
