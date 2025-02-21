---
title: Licensiering
type: docs
weight: 50
url: /sv/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Du kan ladda ner en utvärderingsversion av **Aspose.CAD** för Java från [dess nedladdningssida](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Utvärderingsversionen ger absolut samma funktioner som den licensierade versionen av produkten. Dessutom blir utvärderingsversionen helt enkelt licensierad när du köper en licens och lägger till ett par rader kod för att tillämpa licensen.

När du är nöjd med din utvärdering av **Aspose.CAD** kan du [köpa en licens](https://purchase.aspose.com/buy) på Aspose-webbplatsen. Gör dig familjär med de olika prenumerationstyper som erbjuds. Om du har några frågor, tveka inte att kontakta Aspose försäljningsteam.

Varje Aspose-licens omfattar en ettårig prenumeration för fria uppgraderingar till alla nya versioner eller korrigeringar som kommer ut under denna tid. Teknisk support är gratis och oändlig och erbjuds både till licensierade och utvärderingsanvändare.

{{% /alert %}}

Om du vill testa **Aspose.CAD** utan begränsningar i utvärderingsversionen, begär en 30-dagars tillfällig licens. Vänligen hänvisa till [Hur man får en tillfällig licens?](https://purchase.aspose.com/temporary-license) för mer information.

## **Ställa in en licens**

Licensen är en ren text XML-fil som innehåller detaljer som produktnamn, antal utvecklare den är licensierad till, prenumerationens utgångsdatum och så vidare. Filen är digitalt signerad, så gör inte några ändringar i filen; även en oavsiktlig tillägg av ett extra radbrytning i filen kommer att ogiltigförklara den.

Du behöver ställa in en licens innan du utför några operationer med AutoCAD-filer. Du måste endast ställa in en licens en gång per applikation eller process.

Licensen kan laddas från en ström eller fil i följande platser:

1. Explicit sökväg.
1. Mappen som innehåller Aspose.CAD.jar.

Använd metoden License.setLicense() för att licensiera komponenten. Ofta är det enklaste sättet att ställa in en licens att lägga licensfilen i samma mapp som Aspose.CAD.jar och spécifiera bara filnamnet utan sökväg som visas i följande exempel:

### **Exempel 1**

I detta exempel kommer **Aspose.CAD** att försöka hitta licensfilen i mappen som innehåller dina applikations-JARs.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Exempel 2**

Initierar en licens från en ström.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Verifiera licensen**

Det är möjligt att verifiera om licensen har ställts in korrekt eller inte. Klassen License har fältet isLicensed som returnerar true om licensen har ställts in korrekt.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Licensen är inställd!");

}

{{< /highlight >}}
