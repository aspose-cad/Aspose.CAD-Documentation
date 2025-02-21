---
title: Meterad licensiering
type: docs
weight: 60
url: /sv/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD gör det möjligt för utvecklare att använda en metered-nyckel. Det är en ny licensieringsmekanism. Den nya licensieringsmekanismen kommer att användas tillsammans med den befintliga licensieringsmetoden. De kunder som vill debiteras baserat på användningen av API-funktionerna kan använda den metered licensieringen. För mer information, vänligen se avsnittet [Metered Licensing FAQ](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Meterad licensiering**
Här är de enkla stegen för att använda Metered-klassen.

1. Skapa en instans av Metered-klassen.
1. Passera offentliga och privata nycklar till SetMeteredKey-metoden.
1. Gör bearbetning (utför uppgift).
1. Anropa metoden GetConsumptionQuantity i Metered-klassen.
1. Den kommer att returnera mängden/antalet av API-begärningar som du har förbrukat hittills.

Följande är exempel på kod som visar hur man ställer in metered offentlig och privat nyckel.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
