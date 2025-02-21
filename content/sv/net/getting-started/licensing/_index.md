---
title: Licensiering
type: docs
weight: 50
url: /sv/net/getting-started/licensing/
---

{{% alert color="primary" %}}

När du är nöjd med din utvärdering av Aspose.CAD för .NET, köp en licens på Aspose-webbplatsen: [Inköpsportal](https://purchase.aspose.com/buy). Gör dig bekant med de olika licenstyperna som finns tillgängliga. Om du har några frågor, [kontakta Aspose försäljningsteam](https://about.aspose.com/contact) så hjälper de gärna dig.

Varje Aspose-licens ger en ettårig prenumeration för gratis uppgraderingar till alla nya versioner eller fixar som släpps under denna tid. Vi tillhandahåller gratis och obegränsad teknisk support till både licensierade och utvärderingsanvändare.

Licensen är en vanlig text-XML-fil som innehåller detaljer som produktnamn, antal licensierade utvecklare, prenumerationens utgångsdatum och så vidare. Filen är digitalt signerad, så ändra inte filen: att även lägga till en extra radbrytning i filen gör den ogiltig.

{{% /alert %}}

## **När man ska tillämpa en licens**

Följ dessa enkla regler:

- Licensen behöver endast sättas en gång per applikationsdomän.
- Du behöver ställa in licensen innan du använder några andra Aspose.CAD-klasser.
- Att anropa SetLicense flera gånger är inte skadligt, men slösar processorstid.
- Om du utvecklar en Windows Forms- eller konsolapplikation, anropa SetLicense i startkoden, innan du använder Aspose.CAD-klasser.
- När du utvecklar en ASP.NET-applikation, anropa SetLicense från Global.asax.cs (Global.asax.vb) filen, i den skyddade metoden Application_Start. Den anropas en gång när applikationen startar.
- Anropa inte SetLicense från Page_Load-metoderna eftersom det innebär att licensen laddas varje gång en webbsida laddas.
- Om du utvecklar ett klassbibliotek, anropar du SetLicense från en statisk konstruktor av klassen som använder Aspose.CAD. Den statiska konstruktören körs innan en instans av din klass skapas, vilket säkerställer att Aspose.CAD-licensen är korrekt inställd.

## **Tillämpa licens med fil eller strömobjekt**

Använd **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** metoden för att licensiera komponenten. Det enklaste sättet att ställa in en licens är att lägga licensfilen i samma mapp som Aspose.CAD.dll och ange filnamnet, utan sökväg, som visas nedan.

### **Ladda en licens från fil**

Detta kodexempel initialiserar en licens som är lagrad i en fil eller i en inbäddad resurs.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Ladda en licens från ett strömobjekt**

Detta kodexempel initialiserar licensen från ström.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
