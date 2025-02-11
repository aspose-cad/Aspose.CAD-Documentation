---
title: Ajustar el tamaño del dibujo CAD
type: docs
weight: 10
url: /es/net/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Al usar la biblioteca Aspose.CAD para .NET, los desarrolladores pueden ajustar el tamaño del dibujo CAD durante la conversión a cualquier formato soportado. Este tema explica el enfoque para ajustar el tamaño automáticamente o manualmente usando el enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) de la clase [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Ajustar el tamaño del dibujo CAD**

Aspose.CAD para .NET proporciona la enumeración [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) para ajustar el tamaño del dibujo durante la conversión del formato CAD. Hay dos formas de ajustar el tamaño del dibujo.

1. Ajuste de tamaño automático.
1. Ajustar el tamaño utilizando la enumeración [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) de la clase [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

Para ajustar automáticamente el tamaño, los desarrolladores no necesitan proporcionar las propiedades Width y Height de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). El siguiente fragmento de código proporcionado es un ejemplo de ajuste automático.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

La enumeración [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) proporciona la capacidad de ajustar la escala cuando no se establecen las propiedades Width y Height. El siguiente fragmento de código proporcionado demuestra cómo usar [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
