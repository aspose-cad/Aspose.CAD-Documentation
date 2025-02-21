---
title: Justering av CAD-ritningens storlek
type: docs
weight: 10
url: /sv/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Genom att använda Aspose.CAD för .NET-biblioteket kan utvecklare justera storleken på CAD-ritningen under konverteringen till något stödt format. Detta ämne förklarar metoden för att justera storleken automatiskt eller manuellt med hjälp av [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumen i klassen [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Justering av CAD-ritningens storlek**

Aspose.CAD för .NET tillhandahåller enumerationen [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) för att justera storleken på ritningen under konverteringen av CAD-formatet. Det finns två sätt att justera ritningens storlek.

1. Automatisk storleksjustering.
1. Justera storlek genom att använda enumerationen [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) i klassen [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

För automatisk storleksjustering behöver utvecklare inte ange egenskaperna Bredd och Höjd för klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Nedanstående kodsnutt är ett exempel på automatisk storleksjustering.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Enumerationen [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) ger möjlighet att justera skalningen när egenskaperna Bredd och Höjd inte är inställda. Nedanstående kodsnutt demonstrerar hur man använder [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
