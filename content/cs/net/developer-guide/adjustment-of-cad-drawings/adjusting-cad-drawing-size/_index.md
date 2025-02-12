---
title: Upravování velikosti výkresu CAD
type: docs
weight: 10
url: /cs/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Pomocí knihovny Aspose.CAD pro .NET mohou vývojáři upravit velikost výkresu CAD během konverze do jakéhokoli podporovaného formátu. Téma vysvětluje přístup k automatické nebo ruční úpravě velikosti pomocí enumerace [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) třídy [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Upravování velikosti výkresu CAD**

Aspose.CAD pro .NET poskytuje enumeraci [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) k úpravě velikosti výkresu během konverze formátu CAD. Existují dvě způsoby, jak upravit velikost výkresu.

1. Automatické přizpůsobení velikosti.
1. Úprava velikosti pomocí enumerace [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) třídy [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

Pro automatické přizpůsobení velikosti vývojáři nemusí uvést vlastnosti Width a Height třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Níže je uveden kód příkladu automatického nastavení velikosti.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Enumerace [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) umožňuje úpravu měřítka, když nejsou nastaveny vlastnosti Width a Height. Následující kódový výňatek ukazuje, jak použít [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
