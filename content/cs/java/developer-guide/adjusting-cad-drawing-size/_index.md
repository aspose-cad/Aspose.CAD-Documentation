---
title: Upravení velikosti CAD kresby
type: docs
weight: 10
url: /cs/upraveni-velikosti-cad-kresby/
---

{{% alert color="primary" %}}

Pomocí Aspose.CAD pro Java mohou vývojáři upravovat velikost kresby během konverze formátu CAD. Téma vysvětluje přístup k automatickému nastavení nebo úpravě velikosti pomocí enumerace [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) třídy [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Upravení velikosti CAD kresby**

Aspose.CAD pro Java poskytuje enumeraci [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) pro úpravu velikosti kresby během konverze formátu CAD. Existují dva způsoby úpravy velikosti kresby.

1. Automatické nastavení velikosti
1. Úprava velikosti pomocí enumerace [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) třídy [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Pro automatické nastavení velikosti nemusí vývojáři poskytovat vlastnosti Šířka a Výška třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Níže uvedený kód ukázky je příkladem automatického nastavení velikosti.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Enumerace [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) umožňuje úpravu měřítka, když nejsou nastaveny vlastnosti Šířka a Výška. Níže uvedený kód ukazuje, jak použít enumeraci [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
