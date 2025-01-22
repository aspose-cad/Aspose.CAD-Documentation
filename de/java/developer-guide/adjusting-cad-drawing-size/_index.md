---
title: Anpassen der Größe einer CAD-Zeichnung
type: docs
weight: 10
url: /de/java/anpassen-der-cad-zeichnungsgröße/
---

{{% alert color="primary" %}}

Mit Aspose.CAD für Java können Entwickler die Größe einer Zeichnung während der Konvertierung des CAD-Formats anpassen. Dieses Thema erläutert den Ansatz zum automatischen Anpassen oder Anpassen der Größe mithilfe des [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)-Enums der Klasse [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Anpassen der Größe einer CAD-Zeichnung**

Aspose.CAD für Java bietet die [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)-Enumeration, um die Größe der Zeichnung während der Konvertierung des CAD-Formats anzupassen. Es gibt zwei Möglichkeiten, die Größe der Zeichnung anzupassen.

1. Automatische Größenanpassung
1. Größe anpassen, indem das [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)-Enum der Klasse [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) verwendet wird

Für die automatische Anpassung der Größe müssen Entwickler die Eigenschaften Width und Height der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nicht angeben. Der untenstehende Code-Schnipsel ist ein Beispiel für automatische Größenanpassung.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Das [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)-Enum bietet die Möglichkeit, die Skalierung anzupassen, wenn die Eigenschaften Width und Height nicht festgelegt sind. Der untenstehende Code-Schnipsel zeigt, wie man [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) verwendet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
