---
title: Ajuste del tamaño del dibujo CAD
type: docs
weight: 10
url: /es/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Usando Aspose.CAD para Java, los desarrolladores pueden ajustar el tamaño del dibujo durante la conversión del formato CAD. Este tema explica el enfoque para ajustar automáticamente o ajustar el tamaño utilizando el [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum de la clase [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Ajuste del tamaño del dibujo CAD**

Aspose.CAD para Java proporciona la enumeración [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) para ajustar el tamaño del dibujo durante la conversión del formato CAD. Hay dos maneras de ajustar el tamaño del dibujo.

1. Ajuste automático del tamaño
1. Ajuste del tamaño utilizando la enumeración [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) de la clase [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Para ajustar automáticamente el tamaño, los desarrolladores no necesitan proporcionar las propiedades Width y Height de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). El siguiente fragmento de código proporcionado es un ejemplo de ajuste automático del tamaño.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

La enumeración [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) proporciona la capacidad para ajustar la escala cuando las propiedades Width y Height no están establecidas. El siguiente fragmento de código proporcionado demuestra cómo usar [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
