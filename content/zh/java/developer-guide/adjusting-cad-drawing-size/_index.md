---
title: 调整 CAD 图纸大小
type: docs
weight: 10
url: /zh/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

使用 Aspose.CAD for Java，开发人员可以在转换 CAD 格式时调整图纸的大小。本主题解释了使用 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 枚举的自动调整或手动调整大小的方法，属于 [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) 类。

{{% /alert %}}

## **调整 CAD 图纸大小**

Aspose.CAD for Java 提供 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 枚举以在转换 CAD 格式时调整图纸的大小。有两种方法可以调整图纸大小。

1. 自动调整大小
2. 使用 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 枚举调整大小，属于 [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) 类

对于自动调整大小，开发人员不需要提供 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 类的宽度和高度属性。下面提供的代码片段是自动调整大小的示例。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 枚举提供了在未设置宽度和高度属性时调整缩放的能力。下面提供的代码片段演示了如何使用 [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
