---
title: Hoe de Aspose.CAD Docker-image uit te voeren in Azure Function
type: docs
description: "Voer de Aspose.CAD Docker-image uit in Azure Function."
weight: 73
url: /nl/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Vereisten
- Docker moet op uw systeem zijn geïnstalleerd. Voor informatie over het installeren van Docker op Windows of Mac, verwijst u naar de links in de sectie "Zie ook".
- Visual Studio 2022.
- NET 6 SDK wordt gebruikt in het voorbeeld.
- Postman

## Azure Function

In dit voorbeeld maakt u een eenvoudige conversiefunctie die een CAD-bestand omzet en opslaat als een afbeelding. De applicatie kan vervolgens in Docker worden gebouwd en uitgevoerd in Azure Function.

## De Azure Function maken

Om het Azure Function-programma te maken, volgt u de onderstaande stappen:
1. Zodra Docker is geïnstalleerd, moet u ervoor zorgen dat het Linux-containers gebruikt (standaard). Indien nodig, selecteer de optie 'Schakel over naar Linux-containers' in het menu van Docker Desktop.
1. Maak in Visual Studio een NET 6 Azure Function.<br>
![Een NET 6 Azure Function-projectdialoog](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Aanvullende informatie.<br>
![Een NET 6 Azure Function-projectdialoog](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Installeer de nieuwste versie van Aspose.CAD van NuGet.<br>
![Aspose.CAD op NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Aangezien de applicatie op Linux wordt uitgevoerd, moet u mogelijk extra lettertypen installeren. U kunt de ttf-mscorefonts-installer gebruiken.
1. Wanneer alle vereiste afhankelijkheden zijn toegevoegd, schrijft u een eenvoudig programma dat een ellips maakt en deze opslaat als een afbeelding:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP-triggerfunctie heeft een verzoek verwerkt.");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### Een Dockerfile configureren

De volgende stap is om de Dockerfile in de rootprojectmap te maken en te configureren.

1. Maak de Dockerfile en plaats deze naast het oplossingbestand van uw applicatie. Houd deze bestandsnaam zonder extensie (de standaard).
![Root projectmap](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Specificeer in de Dockerfile:

{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

Bovenstaande is een eenvoudige Dockerfile, die de volgende instructies bevat:

- De SDK-image die moet worden gebruikt. Hier is het de Net 6-image. Docker zal deze downloaden wanneer de build wordt uitgevoerd. De versie van de SDK wordt gespecificeerd als een tag.
- Daarna moet u mogelijk lettertypen installeren omdat de SDK-image zeer weinig lettertypen bevat. U kunt ook lokale lettertypen gebruiken die naar de docker-image zijn gekopieerd.
- De werkdirectory, die in de volgende regel wordt gespecificeerd.
- De opdracht om alles naar de container te kopiëren, de applicatie te publiceren en het toegangspunt op te geven.

## Docker Hub
1. Log in op Docker Hub
1. Maak een publieke repository

## De applicatie bouwen en uitvoeren in Docker

Nu kan de applicatie in Docker worden gebouwd en uitgevoerd. Open uw favoriete opdrachtprompt, wijzig de map naar de map met de applicatie (de map waar het oplossingbestand en de Dockerfile zijn geplaatst) en voer de volgende opdracht uit:

{{< highlight plain >}}
//voorbeeld
docker build -t <gebruikersnaam>/<repository-naam> .

docker build -t user/asposefunction .
{{< /highlight >}}

De eerste keer dat u deze opdracht uitvoert, kan het langer duren omdat Docker de nodige images moet downloaden. Nadat de vorige opdracht is voltooid, voert u de volgende opdracht uit om de image naar Docker Hub te duwen:

{{< highlight plain >}}
//voorbeeld
docker push <gebruikersnaam>/<repository-naam>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Log in op Azure.
1. Kies Azure-services.
1. Kies Function App en maak een functie.<br>
![Azure maak functieknop](/cad/_assets/showcases/azure/create-function.png)<br>
1. Herhaal de basisinstellingen zoals in de afbeelding hieronder.<br>
![Azure maak functie-instellingen](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Klik op 'Review + create' -> Maak.
1. Wacht tot de implementatie is voltooid.
1. Klik op de knop 'Ga naar resource'.<br>
![Resource-knop](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Stop de aspose-cad-docker-example-functie.<br>
![Stop container](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Ga naar het menu implementatiecentrum en maak de juiste instellingen.<br>
![Implementatiecentrum](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Sla instellingen op
1. Kopieer de Webhook-URL vanuit de instellingen van het implementatiecentrum.<br>
![Webhook-url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Ga naar Docker Hub, selecteer uw repository en selecteer webhooks.
1. Plak de 'Webhook-url' van Azure in de Docker Hub-webhook-URL en stel de naam in.<br>
![Webhook-instellingen in Docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Klik op de knop Aanmaken.
1. Ga terug naar het overzicht van de azure-functie en start de container.<br>
![Overzicht menu](/cad/_assets/showcases/azure/overview.png)<br>

## Voorbeeld van uitvoering

1. Postman-instellingen.<br>
![Overzicht menu](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Selecteer elk DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Klik op de verzendknop.

{{% alert color="primary" %}} 
Als het antwoord succesvol is, klik dan op Opslaan naar bestand en u ontvangt het geconverteerde bestand in png-indeling
{{% /alert %}}

## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zie ook

- [Installeer Docker Desktop op Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installeer Docker Desktop op Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Schakel over naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
- Aanvullende informatie over [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
