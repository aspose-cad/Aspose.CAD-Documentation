---
title: Meterad licensiering
type: docs
weight: 40
url: /sv/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD tillåter utvecklare att använda en mätfördelad nyckel. Det är en ny licensieringsmekanism. Den nya licensieringsmekanismen kommer att användas tillsammans med befintlig licensieringsmetod. De kunder som vill bli debiterade baserat på användningen av API-funktioner kan använda den mätfördelade licensieringen. För mer information, vänligen se [Frågor och svar om Meterad licensiering](https://purchase.aspose.com/faqs/licensing/metered) avsnitt.

{{% /alert %}} 
## **Meterad licensiering**
Här är de enkla stegen för att använda Metered-klassen.

1. Skapa en instans av Metered-klassen.
1. Skicka offentliga och privata nycklar till SetMeteredKey-metoden.
1. Gör bearbetning (utför uppgift).
1. Anropa metoden GetConsumptionQuantity i Metered-klassen.
1. Den kommer att returnera mängden/antalet API-förfrågningar som du har använt hittills.

Följande är exempel på kod som demonstrerar hur man ställer in den mätfördelade offentliga och privata nyckeln.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
