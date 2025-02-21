---
title: Justering av CAD-ritningens storlek
type: docs
weight: 10
url: /sv/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Genom att använda Aspose.CAD-biblioteket för Python kan utvecklare justera storleken på CAD-ritningen under konverteringen till något stödt format. Det här ämnet förklarar tillvägagångssättet för att justera storleken automatiskt eller manuellt med hjälp av **UnitType**-enumen från **ImageOptions**-klassen.

{{% /alert %}}

## **Justering av CAD-ritningens storlek**

Aspose.CAD för Python tillhandahåller **UnitType**-enumin för att justera storleken på ritningen under konverteringen av CAD-formatet. Det finns två sätt att justera storleken på ritningen.

1. Automatisk storleksjustering.
1. Justera storleken genom att använda **UnitType**-enumen från **ImageOptions**-klassen.

För automatisk justering av storlek behöver utvecklarna inte ange Width och Height-egenskaperna för **CadRasterizationOptions**-klassen. Nedan måttade kodsnutten är ett exempel på automatisk storleksjustering.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType**-enumin ger möjlighet att justera skalan när Width och Height-egenskaperna inte är inställda. Nedan måttade kodsnutten visar hur man använder **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
