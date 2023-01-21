---
title: Adjusting CAD Drawing Size
type: docs
weight: 10
url: /python/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

By using Aspose.CAD for Python library, developers can adjust the size of CAD drawing during the conversion to any supported format. This topic explains the approach to adjust the size automatically or manually using the **UnitType** enum of the **ImageOptions** class.

{{% /alert %}}

## **Adjusting CAD drawing size**

Aspose.CAD for Python provides the **UnitType** enumeration to adjust the size of the drawing during the conversion of the CAD format. There are two ways to adjust the drawing size.

1. Automatic size adjustment.
1. Adjust size by using the **UnitType** enumeration of the **ImageOptions** class

For automatically adjusting the size, developers do not need to provide the Width and Height properties of the **CadRasterizationOptions** class. Below provided code snippet is an example of automatic sizing.

import aspose.cad as cad

cadImage = cad.Image.load(...)

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
bmpOptions = cad.imageoptions.BmpOptions()

rasterizationOptions.unit_type = cad.imageoptions.UnitType.CENTIMENTER
rasterizationOptions.layouts = ["Model"]

bmpOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.bmp", bmpOptions)

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

The **UnitType** enumeration gives the ability to adjust scaling when Width and Height properties are not set. Below provided code snippet demonstrate how to use **UnitType**.

import aspose.cad as cad

cadImage = cad.Image.load(...)

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
bmpOptions = cad.imageoptions.BmpOptions()

rasterizationOptions.unit_type = cad.imageoptions.UnitType.CENTIMENTER
rasterizationOptions.layouts = ["Model"]

bmpOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.bmp", bmpOptions)
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
