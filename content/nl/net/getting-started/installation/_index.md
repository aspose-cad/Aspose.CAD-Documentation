---
title: Installatie
type: docs
weight: 30
url: /nl/net/getting-started/installation/
---

## **Aspose.CAD voor .NET installeren via NuGet**

NuGet is de gemakkelijkste manier om Aspose API's voor .NET te downloaden en te installeren. Open Microsoft Visual Studio en de NuGet-pakketbeheerder. Zoek naar "aspose" om de gewenste Aspose API te vinden. Klik op "Installeren", de geselecteerde API wordt gedownload en in uw project opgenomen.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Aspose.CAD vanuit een .NET-project opnemen**

Volg deze stappen (ervan uitgaande dat u Microsoft Visual Studio gebruikt):

1. In **Oplossingsverkenner** , vouw de projectknoop uit waaraan u een referentie wilt toevoegen.
1. Klik met de rechtermuisknop op de **Referenties**-knoop voor het project en selecteer **Verwijzing toevoegen** in het snelmenu.
1. Zoek in het dialoogvenster **Verwijzing toevoegen** naar de locatie van het DLL-bestand.
1. Selecteer het *Aspose.CAD* DLL-bestand en klik op de knop **OK**.
1. De *Aspose.CAD* referentie verschijnt onder de **Referenties**-knoop van uw project.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Aspose.CAD installeren of bijwerken met de Package Manager Console**

U kunt de onderstaande stappen volgen om de [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) te refereren via de Package Manager Console:

1. Open uw oplossing/project in Visual Studio.
1. Selecteer Hulpmiddelen -> Bibliotheekpakketbeheer -> Package Manager Console in het menu om de Package Manager Console te openen.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Typ het commando “**Install-Package Aspose.CAD**” en druk op enter om de nieuwste volledige release in uw applicatie te installeren. U kunt ook de suffix "**-prerelease**" aan het commando toevoegen om op te geven dat de nieuwste release inclusief hotfixes ook moet worden geïnstalleerd.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

U zult zien dat de tip "Aspose.CAD aan het downloaden..." onderaan links in het venster verschijnt, wat aangeeft dat de download bezig is.

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

Wanneer de download is voltooid, ziet u de volgende bevestigingsberichten. Als u niet bekend bent met de [Aspose EULA](https://about.aspose.com/legal/eula) dan is het een goed idee om de licentie te lezen die in de URL is vermeld.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

U zou nu moeten zien dat Aspose.CAD met succes aan uw applicatie is toegevoegd en opgenomen.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

In de Package Manager Console kunt u ook het commando “**Update-Package Aspose.CAD**” gebruiken en op enter drukken om te controleren op eventuele updates voor het Aspose.CAD-pakket en deze te installeren indien aanwezig. U kunt ook de "-prerelease" suffix toevoegen om de nieuwste release bij te werken.

## **Overwegingen bij het draaien op een gedeelde serveromgeving**

Alle Aspose .NET-componenten worden aanbevolen om met een Full Trust-permissieset te draaien. Dit is omdat Aspose .NET-componenten soms toegang moeten hebben tot registerinstellingen en bestanden die zich op andere plaatsen dan de virtuele map bevinden, bijvoorbeeld voor het lezen van lettertypen, enz. Bovendien zijn Aspose.NET-componenten gebaseerd op kern .NET-systeemklassen, waarvan sommige ook Full Trust-permissies vereisen om in sommige gevallen te draaien.

Internet Service Providers die meerdere toepassingen van verschillende bedrijven hosten, handhaven meestal het Medium Trust-beveiligingsniveau. In het geval van .NET 2.0 kan een dergelijk beveiligingsniveau de volgende beperkingen opleggen die de mogelijkheid van Aspose.CAD om goed te functioneren kunnen beïnvloeden.

- **RegistryPermission** is niet beschikbaar. Dit betekent dat u geen toegang hebt tot het register, wat nodig is om geïnstalleerde lettertypen te enumereren bij het weergeven van documenten.
- **FileIOPermission** is beperkt. Dit betekent dat u alleen toegang heeft tot bestanden in de hiërarchie van de virtuele map van uw applicatie. Dit betekent mogelijk dat lettertypen niet kunnen worden gelezen tijdens export.

Om deze hierboven gespecificeerde redenen wordt aanbevolen dat Aspose.CAD wordt uitgevoerd met Full Trust-permissies. U zult merken dat sommige functies van de bibliotheek kunnen werken bij het uitvoeren van verschillende taken in Medium trust, terwijl sommige dat niet zullen doen (bijvoorbeeld rendering), wat kan komen door oproepen naar GDI+ voor beeldverwerking.

## **Systeemvereisten**

### **Besturingssystemen**

Aspose.CAD voor .NET ondersteunt elk 32-bits of 64-bits besturingssysteem waarop het .NET- of Mono-framework is geïnstalleerd, inclusief, maar niet beperkt tot:

- Microsoft Windows-bureaublad (XP, Vista, 7, 8, 10) en serverbesturingssystemen (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS en anderen)
- Mac OS X

### **Frameworks**

Aspose.CAD voor .NET ondersteunt:

- .NET Framework-versies van 2.0 tot 4.5, inclusief Client Profile-versies
- .NET Core
- Mono 2.6.7 of later

### **Ontwikkelomgevingen**

U kunt Aspose.CAD voor .NET gebruiken om applicaties te ontwikkelen in elke ontwikkelomgeving die gericht is op het .NET-platform, maar de volgende omgevingen worden expliciet ondersteund:

- Microsoft Visual Studio 2010 of hoger
- MonoDevelop 2.4 en later
