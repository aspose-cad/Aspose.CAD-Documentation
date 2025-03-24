---
title: Hur man kör Aspose.CAD Docker-bild i Google Cloud
type: docs
description: "Kör Aspose.CAD Docker-bild i Google Cloud."
weight: 75
url: /sv/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Förutsättningar

- Docker måste vara installerat på ditt system. För information om hur du installerar Docker på Windows eller Mac, se länkarna i avsnittet "Se även".
- Visual Studio 2022.
- Google CLI.
- NET Core 3.1 SDK används i exemplet.
- Postman

## Google Cloud Run-funktion

Cloud Run är en helt hanterad beräkningsmiljö för att distribuera och skala serverlösa HTTP-containrar utan att behöva oroa sig för att provisionera maskiner, konfigurera kluster eller autoskalning.

- Ingen leverantörslåsning - Eftersom Cloud Run tar standard OCI-containrar och implementerar standard Knative Serving API kan du enkelt flytta dina applikationer till lokala installationer eller någon annan molnmiljö. 
- Snabb autoskalning - Mikrotjänster som distribueras i Cloud Run skalar automatiskt baserat på antal inkommande förfrågningar, utan att du behöver konfigurera eller hantera ett fullfjädrat Kubernetes-kluster. Cloud Run skalar ner till noll— det vill säga använder inga resurser—om det inte finns några förfrågningar.
- Dela trafik - Cloud Run gör det möjligt för dig att dela trafik mellan flera revisioner, så att du kan utföra gradvisa utrullningar som kanarietjänster eller blå/gröna utrullningar.
- Anpassade domäner - Du kan ställa in anpassad domänmappning i Cloud Run och det kommer att provisionera ett TLS-certifikat för din domän. 
- Automatisk redundans - Cloud Run erbjuder automatisk redundans så att du inte behöver oroa dig för att skapa flera instanser för hög tillgänglighet.

Cloud Run och Cloud Functions är båda helt hanterade tjänster som körs på Google Clouds serverlösa infrastruktur, autoskalas och hanterar HTTP-förfrågningar eller händelser. De har dock några viktiga skillnader:

- Cloud Functions låter dig distribuera snippets av kod (funktioner) skrivna i en begränsad uppsättning programmeringsspråk, medan Cloud Run låter dig distribuera containerbilder med det programmeringsspråk du väljer. 
- Cloud Run stöder också användning av vilket verktyg eller systembibliotek som helst från din applikation; Cloud Functions låter dig inte använda anpassade körbara filer. 
- Cloud Run erbjuder en längre timeout för förfrågningar på upp till 60 minuter, medan timeouten för förfrågningar med Cloud Functions kan sättas så högt som 9 minuter. 
- Cloud Functions skickar endast en förfrågan i taget till varje funktionsinstans, medan Cloud Run som standard är konfigurerat för att skicka flera samtidiga förfrågningar på varje containerinstans. Detta är användbart för att förbättra latens och minska kostnader om du förväntar dig stora volymer. 

## Skapa Google Cloud Function-projekt

{{% alert color="primary" %}} 
Se till att du har tillräckliga rättigheter för att skapa Google Cloud Run-funktioner och bilder i Artifact Registry-repot.
{{% /alert %}}

För att skapa Google Cloud Function-programmet, följ stegen nedan:

1. Installera .NET Core SDK 3.1.
1. Installera mallpaketet:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Skapa en mapp för ditt projekt och använd dotnet new för att skapa en ny HTTP-funktion:
{{< highlight plain >}}
mkdir AsposeFunctions //skapa en mapp
cd AsposeFunctions //gå till mappen AsposeFunctions
dotnet new gcf-http //skapa Google Cloud Function-projekt med http-trigger
{{< /highlight >}}
{{% alert color="primary" %}} 
Detta skapar AsposeFunctions.csproj och Function.cs i den aktuella mappen. Öppna Function.cs för att granska koden och ge ett anpassat meddelande om du vill.
{{% /alert %}}
1. Kodexempel för csproj-fil (AsposeFunctions.csproj).
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. Kodexempel för att konvertera cad-bild till png-fil (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logiken för din funktion går här.
        /// </summary>
        /// <param name="context">HTTP-kontakten, som innehåller förfrågan och svaret.</param>
        /// <returns>En uppgift som representerar den asynkrona operationen.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //formulärfil
                var file = context.Request.Body; //binär data
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. Bygg din funktion lokalt enligt följande:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. När servern körs, bläddra till http://localhost:8080 för att anropa funktionen. Tryck Ctrl-C i konsolen för att stoppa servern.

## Distribuera docker-bild till Google Cloud

1. Logga in på Google Cloud.
1. Skapa ett projekt om det inte redan finns.
1. Gå till 'Artifact Registry' och skapa ett repository.<br>
![Skapa Artifact Repository](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Välj nytt repository i Artifact Registry.
![Välj artefaktrepository](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Klicka på 'INSTALLATIONSANVISNINGAR' och kopiera kommandot 'Konfigurera Docker'.<br>
![INSTALLATIONSANVISNINGAR](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Lägg till en Docker credHelper-post i Docks konfigurationsfil, eller skapa filen om den inte finns.
{{< highlight plain >}}
//exempel
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Skapa en Dockerfile i projektets rotverzeichnis och redigera DockerFil som i <a href="#configuring-a-dockerfile">Konfigurera en Dockerfile</a> avsnittet.
1. Starta Docker Desktop.
1. Bygg docker-bild med molnrepository-vägen.
{{< highlight plain >}}
//exempel
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Tryck upp bilden till Google Cloud Artifact Registry
{{< highlight plain >}}
//exempel
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Skapa Google Cloud Run-tjänst 

1. Gå till Cloud Run.
1. Skapa Cloud Run-tjänst.<br>
![Skapa Cloud Run-tjänst](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. I fältet Container Image URL, välj containern från 'ARTIFAKTREPOSITORY'.<br>
![Containern bild URL](/cad/_assets/showcases/google/container-url.png)<br>
1. Kontrollera andra inställningar enligt nedan.<br>
![Inställningar för tjänst](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Vänta på att distributionen ska slutföras.
1. Tjänstens URL för att arbeta med konverteringsapplikationen.<br>
![Url tjänst](/cad/_assets/showcases/google/url-service.png)<br>

### Konfigurera en Dockerfile

Nästa steg är att redigera konfigurationsfilen i projektet.

1. I Dockerfile, specificera:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

Ovanstående är en enkel Dockerfile, som innehåller följande instruktioner:

- SDK-bilden som ska användas. Här är det Net Core 3.1-bilden. Docker kommer att ladda ner den när bygget körs. Versionen av SDK specificeras som en tagg.
- Efter det kan du behöva installera typsnitt eftersom SDK-bilden innehåller mycket få typsnitt. Du kan också använda lokala typsnitt som kopieras till dockerbilden.
- Arbetskatalogen som specificeras i nästa rad.
- Kommandot för att kopiera allt till containern, publicera applikationen och specificera ingångspunkten.

## Exempel på körning

1. Postman-inställningar.<br>
![Översiktsmeny](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Välj vilken DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil som helst.
1. Klicka på knappen skicka.

{{% alert color="primary" %}} 
Om svaret är framgångsrikt, klicka på Spara till fil och du kommer att få den konverterade filen i png-format
{{% /alert %}}

## Fler exempel

För fler exempel på hur du kan använda Aspose.CAD i Docker, se [exemplen](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Se även.

- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Byt till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
- Ytterligare information om [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
