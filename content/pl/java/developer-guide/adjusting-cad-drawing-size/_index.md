---
title: Dostosowywanie rozmiaru rysunku CAD
type: docs
weight: 10
url: /pl/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Korzystając z Aspose.CAD dla Java, programiści mogą dostosować rozmiar rysunku podczas konwersji formatu CAD. Ten temat wyjaśnia podejście do automatycznego dostosowywania lub dostosowywania rozmiaru przy użyciu wyliczenia [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) z klasy [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Dostosowywanie rozmiaru rysunku CAD**

Aspose.CAD dla Java udostępnia wyliczenie [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType), aby dostosować rozmiar rysunku podczas konwersji formatu CAD. Istnieją dwa sposoby dostosowania rozmiaru rysunku.

1. Automatyczne dostosowanie rozmiaru
1. Dostosowanie rozmiaru za pomocą wyliczenia [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) z klasy [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

W przypadku automatycznego dostosowania rozmiaru programiści nie muszą podawać właściwości Width i Height klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Poniższy zrzut kodu jest przykładem automatycznego dostosowywania rozmiaru.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Wyliczenie [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) umożliwia dostosowanie skalowania, gdy właściwości Width i Height nie są ustawione. Poniższy zrzut kodu demonstruje, jak używać [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
