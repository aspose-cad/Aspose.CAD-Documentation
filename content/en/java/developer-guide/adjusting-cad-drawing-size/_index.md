---
title: Adjusting CAD Drawing Size
type: docs
weight: 10
url: /java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Using Aspose.CAD for Java, developers can adjust the size of drawing during the conversion of the CAD format. This topic explains the approach to auto-adjusts or adjusts the size using the [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum of the [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) class.

{{% /alert %}}

## **Adjusting CAD drawing size**

Aspose.CAD for Java provides the [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration to adjust the size of the drawing during the conversion of the CAD format. There are two ways to adjust the drawing size.

1. Automatic adjust size
1. Adjust size by using the [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration of the [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) class

For automatic adjusting the size, developers do not need to provide the Width and Height properties of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class. Below provided code snippet is an example of automatic sizing.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration gives the ability to adjust scaling when Width and Height properties are not set. Below provided code snippet demonstrate how to use [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
