---
title: Hoe de Aspose.CAD Docker-afbeelding in Google Cloud uit te voeren
type: docs
description: "Voer de Aspose.CAD Docker-afbeelding uit in Google Cloud."
weight: 75
url: /nl/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Vereisten

- Docker moet op uw systeem zijn geïnstalleerd. Voor informatie over hoe u Docker op Windows of Mac installeert, verwijst u naar de links in de sectie "Zie ook".
- Visual Studio 2022.
- Google CLI.
- .NET Core 3.1 SDK wordt in het voorbeeld gebruikt.
- Postman

## Google Cloud Run Functie

Cloud Run is een volledig beheerde computeraanpassing voor het implementeren en schalen van serverloze HTTP-containers zonder zich zorgen te maken over het provisioneren van machines, het configureren van clusters of autoscaling.

- Geen vendor lock-in - Omdat Cloud Run standaard OCI-containers gebruikt en de standaard Knative Serving API implementeert, kunt u uw toepassingen eenvoudig overzetten naar on-premises of andere cloudomgevingen.
- Snelle autoscaling - Microservices die in Cloud Run zijn geïmplementeerd, schalen automatisch op basis van het aantal binnenkomende verzoeken, zonder dat u een volledig Kubernetes-cluster hoeft te configureren of te beheren. Cloud Run schaalt naar nul - dat wil zeggen, gebruikt geen middelen - als er geen verzoeken zijn.
- Verkeer splitsen - Cloud Run stelt u in staat om verkeer tussen meerdere versies te splitsen, zodat u geleidelijke uitrolmogelijkheden kunt uitvoeren, zoals canary-implementaties of blue/green-implementaties.
- Aangepaste domeinen - U kunt aangepaste domeinmapping instellen in Cloud Run en het zal een TLS-certificaat voor uw domein provisioneren.
- Automatische redundantie - Cloud Run biedt automatische redundantie, zodat u zich geen zorgen hoeft te maken over het creëren van meerdere instanties voor hoge beschikbaarheid.

Cloud Run en Cloud Functions zijn beide volledig beheerde services die draaien op de serverless infrastructuur van Google Cloud, autoschalen en HTTP-verzoeken of evenementen verwerken. Ze hebben echter enkele belangrijke verschillen:

- Cloud Functions laat u snippet van code (functies) implementeren die zijn geschreven in een beperkt aantal programmeertalen, terwijl Cloud Run u toestaat om containerafbeeldingen te implementeren met de programmeertaal van uw keuze.
- Cloud Run ondersteunt ook het gebruik van elk hulpmiddel of systeembibliotheek uit uw toepassing; Cloud Functions laat u geen aangepaste uitvoerbare bestanden gebruiken.
- Cloud Run biedt een langere time-outduur van verzoeken van maximaal 60 minuten, terwijl bij Cloud Functions de time-out voor verzoeken tot 9 minuten kan worden ingesteld.
- Cloud Functions stuurt slechts één verzoek tegelijk naar elke functie-instantie, terwijl Cloud Run standaard is geconfigureerd om meerdere gelijktijdige verzoeken naar elke containerinstantie te verzenden. Dit is nuttig om de latentie te verbeteren en kosten te verlagen als u grote volumes verwacht.

## Het Google Cloud Function-project maken

{{% alert color="primary" %}} 
Zorg ervoor dat u voldoende rechten hebt om een Google Cloud Run-functie en afbeeldingen in het Artifact Registry-repository te maken.
{{% /alert %}}

Volg de onderstaande stappen om het Google Cloud Function-programma te maken:

1. Installeer .NET Core SDK 3.1.
1. Installeer het sjabloonpakket:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Maak vervolgens een directory voor uw project en gebruik dotnet new om een nieuwe HTTP-functie te maken:
{{< highlight plain >}}
mkdir AsposeFunctions //maak map
cd AsposeFunctions //ga naar map AsposeFunctions
dotnet new gcf-http //maak Google Cloud Function-project met http-trigger
{{< /highlight >}}
{{% alert color="primary" %}} 
Dit creëert AsposeFunctions.csproj en Function.cs in de huidige directory. Open Function.cs om de code te bekijken en geef een aangepaste boodschap op als u dat wilt.
{{% /alert %}}
1. Codevoorbeeld voor csproj-bestand (AsposeFunctions.csproj).
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
1. Codevoorbeeld voor het converteren van CAD-afbeeldingen naar png-bestand (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// De logica voor uw functie gaat hier.
        /// </summary>
        /// <param name="context">De HTTP-context, met het verzoek en de respons.</param>
        /// <returns>Een taak die de asynchrone bewerking vertegenwoordigt.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //form bestand
                var file = context.Request.Body; //binaire gegevens
                
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
1. Bouw uw functie lokaal als volgt:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Zodra de server draait, gaat u naar http://localhost:8080 om de functie aan te roepen. Druk op Ctrl-C in de console om de server te stoppen.

## Docker-afbeelding naar Google Cloud implementeren

1. Log in op Google Cloud.
1. Maak een project als het nog niet bestaat.
1. Ga naar 'Artifact Registry' en maak een repository.<br>
![Creëer Artifact Repository](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Selecteer de nieuwe repository in Artifact Registry.
![Selecteer artifact-repository](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Klik op 'SETUP INSTRUCTIE' en kopieer het commando 'Configure Docker'.<br>
![SETUP INSTRUCTIE](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Voeg een Docker credHelper-item toe aan het configuratiebestand van Docker, of maak het bestand aan als het nog niet bestaat.
{{< highlight plain >}}
//voorbeeld
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Maak een Dockerfile in de hoofdmap van het project en bewerk de DockerFile zoals in de <a href="#configuring-a-dockerfile">sectie Configureren van een Dockerfile</a>.
1. Start Docker Desktop.
1. Bouw de Docker-afbeelding met het cloudrepositorypad.
{{< highlight plain >}}
//voorbeeld
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Duw de afbeelding naar Google Cloud Artifact Registry
{{< highlight plain >}}
//voorbeeld
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Maak Google Cloud Run-service aan 

1. Ga naar Cloud Run.
1. Maak Cloud Run-service aan.<br>
![Creëer Cloud Run-service](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Selecteer in het veld Container Image URL de container van 'ARTIFACT REGISTRY'.<br>
![Containerafbeelding URL](/cad/_assets/showcases/google/container-url.png)<br>
1. Controleer andere instellingen zoals hieronder.<br>
![Instellingen service](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Wacht tot de implementatie is voltooid.
1. Service-URL om met de conversietoepassing te werken.<br>
![Url service](/cad/_assets/showcases/google/url-service.png)<br>

### Een Dockerfile configureren

De volgende stap is om de Dockerfile in het project te configureren.

1. Specificeer in de Dockerfile:

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

Bovenstaande is een eenvoudige Dockerfile, die de volgende instructies bevat:

- De SDK-afbeelding die moet worden gebruikt. Hier is het de Net Core 3.1-afbeelding. Docker zal het downloaden wanneer de build wordt uitgevoerd. De versie van de SDK wordt als een tag opgegeven.
- Vervolgens moet u mogelijk lettertypen installeren, omdat de SDK-afbeelding heel weinig lettertypen bevat. U kunt ook lokale lettertypen gebruiken die naar de Docker-afbeelding zijn gekopieerd.
- De werkdirectory, die in de volgende regel wordt opgegeven.
- Het commando om alles naar de container te kopiëren, de toepassing te publiceren en het startpunt op te geven.

## Voorbeeld van uitvoering

1. Postman-instellingen.<br>
![Overzicht menu](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Selecteer een DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-bestand.
1. Klik op de verzendknop.

{{% alert color="primary" %}} 
Als het antwoord succesvol is, klik dan op Opslaan als bestand en u ontvangt het geconverteerde bestand in png-formaat.
{{% /alert %}}

## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zie ook.

- [Installeer Docker Desktop op Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installeer Docker Desktop op Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Overschakelen naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
- Extra informatie over [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
