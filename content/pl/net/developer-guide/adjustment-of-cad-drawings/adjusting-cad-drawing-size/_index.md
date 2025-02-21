---
title: Dostosowywanie rozmiaru rysunku CAD
type: docs
weight: 10
url: /pl/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Korzystając z biblioteki Aspose.CAD dla .NET, deweloperzy mogą dostosować rozmiar rysunku CAD podczas konwersji do dowolnego obsługiwanego formatu. Ten temat wyjaśnia podejście do automatycznego lub ręcznego dostosowywania rozmiaru za pomocą wyliczenia [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) z klasy [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Dostosowywanie rozmiaru rysunku CAD**

Aspose.CAD dla .NET zapewnia wyliczenie [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) do dostosowywania rozmiaru rysunku podczas konwersji formatu CAD. Istnieją dwa sposoby dostosowywania rozmiaru rysunku.

1. Automatyczne dostosowanie rozmiaru.
1. Dostosowanie rozmiaru przy użyciu wyliczenia [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) z klasy [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Aby automatycznie dostosować rozmiar, deweloperzy nie muszą podawać właściwości Width i Height klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Poniżej przedstawiono przykład automatycznego dostosowywania rozmiaru.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Wyliczenie [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) daje możliwość dostosowania skalowania, gdy właściwości Width i Height nie są ustawione. Poniżej przedstawiono przykład, jak używać [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
