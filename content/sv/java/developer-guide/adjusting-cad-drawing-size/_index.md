---
title: Justering av CAD-ritningsstorlek
type: docs
weight: 10
url: /sv/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Genom att använda Aspose.CAD för Java kan utvecklare justera storleken på ritningen under konverteringen av CAD-formatet. Detta ämne förklarar tillvägagångssättet för automatisk justering eller justering av storleken med hjälp av [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum av klassen [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Justering av CAD-ritningsstorlek**

Aspose.CAD för Java tillhandahåller enumerationen [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) för att justera storleken på ritningen under konverteringen av CAD-formatet. Det finns två sätt att justera ritningsstorleken.

1. Automatisk justering av storlek
1. Justera storlek med hjälp av enumerationen [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) av klassen [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

För automatisk justering av storleken behöver utvecklare inte ange egenskaperna Bredd och Höjd för klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Nedan är ett exempel på automatisk storleksjustering.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Enumerationen [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) ger möjlighet att justera skalning när egenskaperna Bredd och Höjd inte är inställda. Nedan är ett kodexempel som demonstrerar hur man använder [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
