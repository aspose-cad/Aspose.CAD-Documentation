---
title: Licentieverlening
type: docs
weight: 50
url: /nl/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Zodra je tevreden bent met je evaluatie van Aspose.CAD voor .NET, koop je een licentie op de Aspose-website: [Aankoopportaal](https://purchase.aspose.com/buy). Maak jezelf vertrouwd met de verschillende beschikbare licentietypes. Als je vragen hebt, [neem contact op met het Aspose-verkoopteam](https://about.aspose.com/contact) en zij helpen je graag.

Elke Aspose-licentie bevat een abonnement van één jaar voor gratis upgrades naar nieuwe versies of fixes die tijdens deze periode uitkomen. We bieden gratis en onbeperkte technische ondersteuning aan zowel gelicentieerde als evaluatiegebruikers.

De licentie is een platte tekst XML-bestand dat details bevat zoals de productnaam, het aantal gelicentieerde ontwikkelaars, de vervaldatum van het abonnement, enzovoort. Het bestand is digitaal ondertekend, dus wijzig het bestand niet: zelfs het toevoegen van een extra regel in het bestand maakt het ongeldig.

{{% /alert %}}

## **Wanneer een Licentie Toepassen**

Volg deze eenvoudige regels:

- De licentie hoeft maar één keer per applicatiedomein ingesteld te worden.
- Je moet de licentie instellen voordat je andere Aspose.CAD-klassen gebruikt.
- Meerdere keren SetLicense aanroepen is niet schadelijk, maar verspilt verwerkings tijd.
- Als je een Windows Forms- of consoletoepassing ontwikkelt, roep je SetLicense aan in de opstartcode, voordat je Aspose.CAD-klassen gebruikt.
- Bij het ontwikkelen van een ASP.NET-toepassing, roep je SetLicense aan vanuit het Global.asax.cs (Global.asax.vb) bestand, in de Application_Start beschermde methode. Het wordt één keer aangeroepen wanneer de toepassing start.
- Roep SetLicense niet aan vanuit de Page_Load-methoden, aangezien dit betekent dat de licentie elke keer wordt geladen wanneer een webpagina wordt geladen.
- Als je een klasbibliotheek ontwikkelt, roep je SetLicense aan vanuit een statische constructor van de klasse die Aspose.CAD gebruikt. De statische constructor wordt uitgevoerd voordat een instantie van je klasse wordt gemaakt, zodat de Aspose.CAD-licentie correct is ingesteld.

## **Licentie Toepassen met Bestands- of Stream-object**

Gebruik de **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** methode om de component van licentie te voorzien. De eenvoudigste manier om een licentie in te stellen, is door het licentiebestand in dezelfde map te plaatsen als de Aspose.CAD.dll en de bestandsnaam op te geven, zonder pad, zoals hieronder weergegeven.

### **Een Licentie Laden vanuit een Bestand**

Deze codefragment initialiseert een licentie die is opgeslagen in een bestand of in een ingebedde bron.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Een Licentie Laden vanuit een Stream-object**

Deze codefragment initialiseert de licentie vanuit de stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
