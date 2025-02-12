---
title: Metered Licensing
type: docs
weight: 40
url: /cs/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD umožňuje vývojářům používat metrický klíč. Jedná se o nový licenční mechanismus. Nový licenční mechanismus se bude používat spolu s existující metodou licencování. Zákazníci, kteří chtějí být účtováni na základě využití funkcí API, mohou použít metrické licencování. Pro více informací se podívejte do sekce [Často kladené dotazy o metrickém licencování](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Metrické licencování**
Zde jsou jednoduché kroky k použití třídy Metered.

1. Vytvořte instanci třídy Metered.
1. Předejte veřejné a privátní klíče metodě SetMeteredKey.
1. Provádějte zpracování (vykonávejte úlohy).
1. Zavolejte metodu GetConsumptionQuantity třídy Metered.
1. Tato metoda vrátí množství/počet požadavků API, které jste zatím spotřebovali.

Následující ukázka kódu ukazuje, jak nastavit veřejný a privátní metrický klíč.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
