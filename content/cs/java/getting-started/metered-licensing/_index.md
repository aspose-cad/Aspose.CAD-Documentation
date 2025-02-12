---
title: Metered Licensing
type: docs
weight: 60
url: /cs/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD umožňuje vývojářům používat ohodnocený klíč. Jedná se o nový mechanismus licencování. Nový mechanismus licencování bude použit vedle existující metody licencování. Zákazníci, kteří chtějí být účtováni na základě využití funkcí API, mohou použít ohodnocené licencování. Pro více informací se podívejte na sekci [Často kladené dotazy ohledně ohodnoceného licencování](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Ohodnocené licencování**
Zde jsou jednoduché kroky k použití třídy Metered.

1. Vytvořte instanci třídy Metered.
1. Předejte veřejný a privátní klíč metodě setMeteredKey.
1. Provádějte zpracování (vykonávat úlohu).
1. Zavolejte metodu getConsumptionQuantity třídy Metered.
1. Vrátí množství požadavků API, které jste doposud spotřebovali.

Následuje ukázkový kód, který ukazuje, jak nastavit ohodnocený veřejný a privátní klíč:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
