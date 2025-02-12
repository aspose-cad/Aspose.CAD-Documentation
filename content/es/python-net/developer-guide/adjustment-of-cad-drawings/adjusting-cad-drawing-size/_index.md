---
title: Ajustando el tamaño del dibujo CAD
type: docs
weight: 10
url: /es/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Al utilizar la biblioteca Aspose.CAD para Python, los desarrolladores pueden ajustar el tamaño del dibujo CAD durante la conversión a cualquier formato soportado. Este tema explica el enfoque para ajustar el tamaño automáticamente o manualmente utilizando el enum **UnitType** de la clase **ImageOptions**.

{{% /alert %}}

## **Ajustando el tamaño del dibujo CAD**

Aspose.CAD para Python proporciona la enumeración **UnitType** para ajustar el tamaño del dibujo durante la conversión del formato CAD. Hay dos formas de ajustar el tamaño del dibujo.

1. Ajuste de tamaño automático.
1. Ajustar el tamaño utilizando la enumeración **UnitType** de la clase **ImageOptions**.

Para ajustar automáticamente el tamaño, los desarrolladores no necesitan proporcionar las propiedades de Width y Height de la clase **CadRasterizationOptions**. A continuación se presenta un fragmento de código que es un ejemplo de ajuste automático de tamaño.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

La enumeración **UnitType** brinda la capacidad de ajustar la escala cuando las propiedades de Width y Height no están establecidas. A continuación se presenta un fragmento de código que demuestra cómo utilizar **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
