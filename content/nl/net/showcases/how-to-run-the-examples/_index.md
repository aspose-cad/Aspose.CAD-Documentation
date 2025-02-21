---
title: Hoe de Voorbeelden te Runnen
type: docs
weight: 70
url: /nl/net/showcases/how-to-run-the-examples/
---

## **Softwarevereisten**

Zorg ervoor dat je aan de volgende vereisten voldoet voordat je de voorbeelden downloadt en uitvoert.

1. Visual Studio 2010 of hoger
1. NuGet Package Manager geïnstalleerd in Visual Studio. Zorg ervoor dat de nieuwste versie van de NuGet API in Visual Studio is geïnstalleerd. Voor details over hoe je de NuGet package manager moet installeren, raadpleeg https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Ga naar Tools->Options->NuGet Package Manager->Package Sources en zorg ervoor dat de optie **nuget.org** is aangevinkt
1. Het voorbeeldproject maakt gebruik van de NuGet Automatic Package Restore functie, dus je moet een actieve internetverbinding hebben. Als je geen actieve internetverbinding hebt op de machine waar de voorbeelden moeten worden uitgevoerd, controleer dan [Installatie](/nl/cad/net/installation/) om een referentie naar Aspose.CAD.dll in het voorbeeldproject toe te voegen.

## **Downloaden van GitHub**

Alle voorbeelden van Aspose.CAD voor .NET zijn gehost op [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Je kunt de repository ofwel klonen met je favoriete GitHub-client of het ZIP-bestand downloaden van [hier](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Extraheer de inhoud van het ZIP-bestand naar een map op je computer. Alle voorbeelden bevinden zich in de **Voorbeelden**-map.
- Er is een Visual Studio-oplossingsbestand voor C#.
- De projecten zijn gemaakt in Visual Studio 2013, maar de oplossingsbestanden zijn compatibel met Visual Studio 2010 SP1 en hoger.
- Open het oplossingsbestand in Visual Studio en bouw het project.
- Bij de eerste uitvoering worden de afhankelijkheden automatisch gedownload via NuGet.
- De **Data**-map in de hoofdmap van **Voorbeelden** bevat invoerbestanden die door de CSharp-voorbeelden worden gebruikt. Het is verplicht dat je de **Data**-map samen met het voorbeeldenproject downloadt.
- Open het RunExamples.cs-bestand, alle voorbeelden worden hier vanuit aangeroepen.
- Verwijder de opmerkingen van de voorbeelden die je wilt uitvoeren vanuit het project.

Voel je vrij om contact met ons op te nemen via onze Forums als je problemen hebt met het instellen of uitvoeren van de voorbeelden.

## **Bijdragen**

Als je een voorbeeld wilt toevoegen of verbeteren, moedigen we je aan om bij te dragen aan het project. Alle voorbeelden en showcase-projecten in deze repository zijn open source en kunnen vrij worden gebruikt in je eigen toepassingen.

Om bij te dragen, kun je de repository fork'en, de broncode bewerken en een pull request indienen. We zullen de wijzigingen beoordelen en het opnemen in de repository als we het nuttig vinden.
