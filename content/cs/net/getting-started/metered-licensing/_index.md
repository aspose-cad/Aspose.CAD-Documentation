---
title: Metered Licensing
type: docs
weight: 60
url: /cs/net/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD umožňuje vývojářům používat metrický klíč. Jedná se o nový mechanismus licencování. Nový mechanismus licencování bude použit společně s existující metodou licencování. Ti zákazníci, kteří chtějí být fakturováni na základě využití funkcí API, mohou používat metrické licencování. Pro více podrobností se obraťte na část [Často kladené otázky o metrickém licencování](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Metrické licencování**
Zde jsou jednoduché kroky k použití třídy Metered.

1. Vytvořte instanci třídy Metered.
1. Předejte veřejný a privátní klíč metodě SetMeteredKey.
1. Provádějte zpracování (provádějte úlohu).
1. Zavolejte metodu GetConsumptionQuantity třídy Metered.
1. Vrátí množství požadavků API, které jste dosud spotřebovali.

Následuje ukázkový kód, který ukazuje, jak nastavit metrický veřejný a privátní klíč.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
