---
title: Hoe Aspose.CAD in Docker te draaien
type: docs
description: "Draai Aspose.CAD in een Docker-container voor Linux, Windows Server en elk besturingssysteem."
weight: 71
url: /nl/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Vereisten
- Docker moet op uw systeem zijn geïnstalleerd. Raadpleeg de links in de sectie "Zie Ook" voor informatie over hoe u Docker op Windows of Mac kunt installeren.
- Visual Studio 2022.
- NET 6 SDK wordt in het voorbeeld gebruikt.

## Hello World-toepassing

In dit voorbeeld maakt u een eenvoudige Hello World-consoletoepassing die een ellipse tekent en deze opslaat als een afbeelding. De toepassing kan vervolgens worden gebouwd en uitgevoerd in Docker.

## De Console-toepassing maken

Volg de onderstaande stappen om het Hello World-programma te maken:
1. Zodra Docker is geïnstalleerd, zorg ervoor dat het Linux-containers gebruikt (standaard). Selecteer zo nodig de optie 'Overschakelen naar Linux-containers' in het menu van Docker Desktops.
1. Maak in Visual Studio een NET 6-consoletoepassing.<br>
![Een NET 6-consoletoepassing projectdialoog](/cad/_assets/showcases/docker/1.png)<br>
1. Installeer de nieuwste versie van Aspose.CAD van NuGet.<br>
![Aspose.CAD op NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. Aangezien de toepassing op Linux zal worden uitgevoerd, moet u mogelijk extra lettertypen installeren. U kunt ttf-mscorefonts-installer overwegen.
1. Wanneer alle vereiste afhankelijkheden zijn toegevoegd, schrijft u een eenvoudig programma dat een ellipse maakt en deze opslaat als een afbeelding:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Let op dat de map "TestOut" is opgegeven als de uitvoermap voor het opslaan van uitvoerdocumenten. Wanneer de toepassing in Docker wordt uitgevoerd, wordt een map op de host machine aan deze map in de container gekoppeld. Dit stelt u in staat om de output die door Aspose.CAD in de Docker-container is gegenereerd gemakkelijk te bekijken.

### Een Dockerfile configureren

De volgende stap is het maken en configureren van de Dockerfile.

1. Maak de Dockerfile en plaats deze naast het oplossingbestand van uw toepassing. Houd deze bestandsnaam zonder extensie (de standaard).
1. Geef in de Dockerfile het volgende op:


{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

Bovenstaande is een eenvoudige Dockerfile, die de volgende instructies bevat:

- De SDK-afbeelding die moet worden gebruikt. Hier is het de Net 6-afbeelding. Docker zal deze downloaden wanneer de build wordt uitgevoerd. De versie van de SDK wordt opgegeven als een tag.
- Daarna moet u mogelijk lettertypen installeren omdat de SDK-afbeelding zeer weinig lettertypen bevat. U kunt ook lokale lettertypen gebruiken die naar de docker-afbeelding zijn gekopieerd.
- De werkmap, die in de volgende regel is opgegeven.
- Het commando om alles naar de container te kopiëren, de toepassing te publiceren, en het startpunt op te geven.


## De toepassing bouwen en uitvoeren in Docker
 
Nu kan de toepassing worden gebouwd en uitgevoerd in Docker. Open uw favoriete opdrachtprompt, verander directory naar de map met de toepassing (de map waar het oplossingbestand en de Dockerfile zijn geplaatst) en voer de volgende opdracht uit:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

De eerste keer dat deze opdracht wordt uitgevoerd, kan het langer duren, aangezien Docker de vereiste afbeeldingen moet downloaden. Zodra de vorige opdracht is voltooid, voert u de volgende opdracht uit:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Let op de mount-argument, omdat, zoals eerder vermeld, een map op de host machine in de map van de container wordt gemonteerd, zodat de resultaten van de uitvoering van de toepassing gemakkelijk kunnen worden bekeken. Paden in Linux zijn hoofdlettergevoelig.
{{% /alert %}}

## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zie Ook

- [Docker Desktop op Windows installeren](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop op Mac installeren](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Overschakelen naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
- Aanvullende informatie over [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
