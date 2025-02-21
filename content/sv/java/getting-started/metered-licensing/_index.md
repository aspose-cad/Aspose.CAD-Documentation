---
title: Mätlicensiering
type: docs
weight: 60
url: /sv/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD gör det möjligt för utvecklare att använda en mätlicensnyckel. Det är en ny licensieringsmetod. Den nya licensieringsmetoden kommer att användas tillsammans med den befintliga licensieringsmetoden. De kunder som vill faktureras baserat på användningen av API-funktioner kan använda mätlicensiering. För mer detaljer, vänligen hänvisa till avsnittet [Mätlicensiering FAQ](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Mätlicensiering**
Här är de enkla stegen för att använda Metered-klassen.

1. Skapa en instans av Metered-klassen.
1. Passera offentliga och privata nycklar till setMeteredKey-metoden.
1. Gör bearbetning (utför uppgift).
1. Anropa metoden getConsumptionQuantity av Metered-klassen.
1. Den kommer att returnera mängden/antalet API-förfrågningar som du har använt hittills.

Följande är exempel på kod som demonstrerar hur man ställer in mätlicensens offentliga och privata nyckel:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
