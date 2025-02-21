---
title: Dostosowywanie rozmiaru rysunku CAD
type: docs
weight: 10
url: /pl/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Korzystając z biblioteki Aspose.CAD dla Pythona, deweloperzy mogą dostosować rozmiar rysunku CAD podczas konwersji do dowolnego obsługiwanego formatu. Temat ten wyjaśnia podejście do automatycznego lub ręcznego dostosowywania rozmiaru za pomocą wyliczenia **UnitType** klasy **ImageOptions**.

{{% /alert %}}

## **Dostosowywanie rozmiaru rysunku CAD**

Aspose.CAD dla Pythona udostępnia wyliczenie **UnitType** do dostosowywania rozmiaru rysunku podczas konwersji formatu CAD. Istnieją dwie metody dostosowywania rozmiaru rysunku.

1. Automatyczne dostosowywanie rozmiaru.
1. Dostosowanie rozmiaru za pomocą wyliczenia **UnitType** klasy **ImageOptions**.

Aby automatycznie dostosować rozmiar, deweloperzy nie muszą podawać właściwości Width i Height klasy **CadRasterizationOptions**. Poniżej podany fragment kodu jest przykładem automatycznego dostosowywania rozmiaru.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Wyliczenie **UnitType** daje możliwość dostosowania skalowania, gdy właściwości Width i Height nie są ustawione. Poniżej podany fragment kodu demonstruje, jak używać **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
