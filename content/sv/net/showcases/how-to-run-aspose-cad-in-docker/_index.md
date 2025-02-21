---
title: Hur man kör Aspose.CAD i Docker
type: docs
description: "Kör Aspose.CAD i en Docker-container för Linux, Windows Server och alla operativsystem."
weight: 71
url: /sv/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Förutsättningar
- Docker måste vara installerat på ditt system. För information om hur du installerar Docker på Windows eller Mac, hänvisa till länkarna i avsnittet "Se Även".
- Visual Studio 2022.
- NET 6 SDK används i exemplet.

## Hello World-applikation

I det här exemplet skapar du en enkel Hello World-konsolapplikation som ritar en ellips och sparar den som en bild. Applikationen kan sedan byggas och köras i Docker.

## Skapa konsolapplikationen

För att skapa Hello World-programmet, följ stegen nedan:
1. När Docker är installerat, se till att det använder Linux-containrar (standard). Om det behövs, välj alternativet Väx till Linux-containrar från Docker Desktop-menyn.
1. I Visual Studio, skapa en NET 6 konsolapplikation.<br>
![Ett NET 6 konsolapplikationsprojekt-dialog](/_assets/showcases/docker/1.png)<br>
1. Installera den senaste versionen av Aspose.CAD från NuGet.<br>
![Aspose.CAD på NuGet](/_assets/showcases/docker/2.png)<br>
1. Eftersom applikationen kommer att köras på Linux kan det behövas installera ytterligare typsnitt. Du kan behöva ttf-mscorefonts-installer.
1. När alla nödvändiga beroenden har lagts till, skriv ett enkelt program som skapar en ellips och sparar den som en bild:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Observera att mappen “TestOut” anges som en utmatningsmapp för att spara utmatningsdokument. När applikationen körs i Docker kommer en mapp på värdmaskinen att monteras till denna mapp i containern. Detta gör att du enkelt kan se den utdata som genereras av Aspose.CAD i Docker-containern.

### Konfigurera en Dockerfile

 Nästa steg är att skapa och konfigurera Dockerfilen.

1. Skapa Dockerfilen och placera den bredvid lösningsfilen för din applikation. Håll detta filnamn utan tillägg (standard).
1. I Dockerfilen, specificera:

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
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

 Ovanstående är en enkel Dockerfile som innehåller följande instruktioner:

- SDK-bilden som ska användas. Här är det Net 6-bilden. Docker kommer att ladda ner den när byggningen körs. Versionen av SDK anges som en tagg.
- Därefter kan det behövas installeras typsnitt eftersom SDK-bilden innehåller väldigt få typsnitt. Dessutom kan du använda lokala typsnitt kopierade till Docker-bild.
- Arbetskatalogen, som specificeras i nästa rad.
- Kommandot för att kopiera allt till containern, publicera applikationen och specificera startpunkten.


## Bygga och köra applikationen i Docker
 
 Nu kan applikationen byggas och köras i Docker. Öppna din favoritkommandotolk, ändra katalog till mappen med applikationen (mappen där lösningsfilen och Dockerfilen är placerade) och kör följande kommando:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 Första gången detta kommando körs kan det ta längre tid, eftersom Docker behöver ladda ner de nödvändiga bilderna. När det föregående kommandot har slutförts, kör följande kommando:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Observera monteringsargumentet, eftersom, som nämnts tidigare, en mapp på värdmaskinen monteras i containerns mapp för att enkelt se resultaten av applikationens körning. Sökvägar i Linux är skiftlägeskänsliga.
{{% /alert %}}

## Fler exempel

För fler exempel på hur du kan använda Aspose.CAD i Docker, se [exempel](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Se Även

- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Väx till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
- Ytterligare information om [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
