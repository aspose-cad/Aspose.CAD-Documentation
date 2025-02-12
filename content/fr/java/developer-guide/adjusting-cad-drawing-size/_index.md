---
title: Ajuster la taille du dessin CAD
type: docs
weight: 10
url: /fr/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

En utilisant Aspose.CAD pour Java, les développeurs peuvent ajuster la taille du dessin lors de la conversion du format CAD. Ce sujet explique l'approche pour ajuster automatiquement ou ajuster la taille en utilisant l'énumération [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) de la classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Ajuster la taille du dessin CAD**

Aspose.CAD pour Java fournit l'énumération [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) pour ajuster la taille du dessin lors de la conversion du format CAD. Il existe deux manières d'ajuster la taille du dessin.

1. Ajuster la taille automatiquement
1. Ajuster la taille en utilisant l'énumération [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) de la classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Pour ajuster la taille automatiquement, les développeurs n'ont pas besoin de fournir les propriétés Width et Height de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Le code ci-dessous fournit un exemple de dimensionnement automatique.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

L'énumération [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) permet d'ajuster l'échelle lorsque les propriétés Width et Height ne sont pas définies. Le code ci-dessous fournit un exemple de comment utiliser [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
