---
title: Hur man kör exemplen
type: docs
weight: 70
url: /sv/net/showcases/how-to-run-the-examples/
---

## **Programvarukrav**

Se till att du uppfyller följande krav innan du laddar ner och kör exemplen.

1. Visual Studio 2010 eller högre
1. NuGet-pakethanterare installerad i Visual Studio. Se till att den senaste versionen av NuGet API är installerad i Visual Studio. För detaljer om hur man installerar NuGet-pakethanteraren, vänligen kolla https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Gå till Verktyg->Alternativ->NuGet-pakethanterare->Paketkällor och se till att alternativet **nuget.org** är markerat
1. Exempelprojektet använder NuGet-funktionen för automatisk paketåterställning, därför bör du ha en aktiv internetanslutning. Om du inte har en aktiv internetanslutning på den maskin där exemplen ska köras, vänligen kolla [Installation](/sv/cad/net/installation/) för att lägga till referens till Aspose.CAD.dll i exempelprojektet.

## **Ladda ner från GitHub**

Alla exempel av Aspose.CAD för .NET finns på [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Du kan antingen klona repositoryn med din favorit GitHub-klient eller ladda ner ZIP-filen från [här](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Extrahera innehållet i ZIP-filen till en valfri mapp på din dator. Alla exempel finns i **Examples**-mappen.
- Det finns en Visual Studio-lösningsfil för C#.
- Projekten är skapade i Visual Studio 2013, men lösningsfilerna är kompatibla med Visual Studio 2010 SP1 och högre.
- Öppna lösningsfilen i Visual Studio och bygg projektet.
- Vid första körningen kommer beroenden automatiskt att laddas ner via NuGet.
- **Data**-mappen i rotmappen av **Examples** innehåller indatafiler som CSharp-exemplen använde. Det är obligatoriskt att du laddar ner **Data**-mappen tillsammans med exempelprojektet.
- Öppna filen RunExamples.cs, alla exempel anropas härifrån.
- Ta bort kommentaren från de exempel du vill köra från projektet.

Tveka inte att kontakta oss via våra forum om du har några problem med att ställa in eller köra exemplen.

## **Bidra**

Om du vill lägga till eller förbättra ett exempel uppmuntrar vi dig att bidra till projektet. Alla exempel och visningsprojekt i detta repository är öppen källkod och kan fritt användas i dina egna applikationer.

För att bidra kan du forka repositoryn, redigera koden och skapa en pull-begäran. Vi kommer att granska ändringarna och inkludera dem i repositoryn om de bedöms vara hjälpsamma.
