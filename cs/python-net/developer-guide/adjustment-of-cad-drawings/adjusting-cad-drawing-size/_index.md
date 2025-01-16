---
title: Upravení velikosti CAD výkresu
type: docs
weight: 10
url: /cs/python-net/upraveni-velikosti-cad-vykresu/
---

{{% alert color="primary" %}}

Pomocí knihovny Aspose.CAD pro Python mohou vývojáři upravit velikost CAD výkresu během konverze do libovolného podporovaného formátu. Téma tohoto textu vysvětluje přístup k automatické nebo ruční úpravě velikosti pomocí výčtu **UnitType** třídy **ImageOptions**.

{{% /alert %}}

## **Upravení velikosti CAD výkresu**

Aspose.CAD pro Python poskytuje výčet **UnitType** pro úpravu velikosti výkresu během konverze formátu CAD. Existují dvě způsoby, jak upravit velikost výkresu.

1. Automatické upravení velikosti.
1. Upravení velikosti pomocí výčtu **UnitType** třídy **ImageOptions**

Pro automatické upravení velikosti vývojáři nemusejí poskytovat vlastnosti Width a Height třídy **CadRasterizationOptions**. Níže uvedený kód ukázky je příklad automatického změření.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Výčet **UnitType** poskytuje schopnost upravit měřítko, když vlastnosti Width a Height nejsou nastaveny. Níže uvedený kód ukázky demonstruje, jak použít **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
