---
title: Adjusting CAD Drawing Size
type: docs
weight: 10
url: /net/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Using Aspose.CAD for .NET, developers can adjust the size of drawing during the conversion of the CAD format. This topic explains the approach to adjust the size automatically or manually using the [**UnitType**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enum of the [**Aspose.CAD.ImageOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions) class.

{{% /alert %}}

## **Adjusting CAD drawing size**

Aspose.CAD for .NET provides the [**UnitType**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration to adjust the size of the drawing during the conversion of the CAD format. There are two ways to adjust the drawing size.

1. Automatic size adjustment.
1. Adjust size by using the [**UnitType**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration of the [**Aspose.CAD.ImageOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions) class

For automatically adjusting the size, developers do not need to provide the Width and Height properties of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) class. Below provided code snippet is an example of automatic sizing.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

The [**UnitType**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration gives the ability to adjust scaling when Width and Height properties are not set. Below provided code snippet demonstrate how to use [**UnitType**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
