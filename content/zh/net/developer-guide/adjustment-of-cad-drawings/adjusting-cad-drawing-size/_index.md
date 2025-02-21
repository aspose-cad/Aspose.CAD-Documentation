---
title: 调整CAD图纸大小
type: docs
weight: 10
url: /zh/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

通过使用Aspose.CAD for .NET库，开发人员可以在转换为任何支持的格式时调整CAD图纸的大小。本主题解释了使用[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)枚举及[**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)类自动或手动调整大小的方法。

{{% /alert %}}

## **调整CAD图纸大小**

Aspose.CAD for .NET提供了[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)枚举，用于在CAD格式转换过程中调整图纸大小。有两种方法可以调整图纸大小。

1. 自动大小调整。
1. 使用[**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)类的[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)枚举调整大小。

对于自动调整大小，开发人员不需要提供[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index)类的宽度和高度属性。下面提供的代码示例是自动调整大小的示例。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)枚举提供了在宽度和高度属性未设置时调整缩放的能力。下面提供的代码示例演示了如何使用[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
