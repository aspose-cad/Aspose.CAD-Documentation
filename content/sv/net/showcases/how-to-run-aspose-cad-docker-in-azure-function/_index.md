---
title: Hur man kör Aspose.CAD Docker-bild i Azure Function
type: docs
description: "Kör Aspose.CAD Docker-bild i Azure Function."
weight: 73
url: /sv/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Förutsättningar
- Docker måste vara installerat på ditt system. För information om hur man installerar Docker på Windows eller Mac, se länkarna i avsnittet "Se Även".
- Visual Studio 2022.
- NET 6 SDK används i exemplet.
- Postman

## Azure Function

I detta exempel skapar du en enkel konverteringsfunktion som konverterar en CAD-fil och sparar den som en bild. Applikationen kan sedan byggas i Docker och köras i Azure Function.

## Skapa Azure Function

För att skapa Azure Function-programmet, följ stegen nedan:
1. När Docker är installerat, se till att det använder Linux-containrar (standard). Om nödvändigt, välj alternativet Väx till Linux-containrar i Docker Desktops meny.
1. I Visual Studio, skapa en NET 6 Azure Function.<br>
![Ett NET 6 Azure Functionprojekt-dialog](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Ytterligare information.<br>
![Ett NET 6 Azure Functionprojekt-dialog](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Installera den senaste Aspose.CAD-versionen från NuGet.<br>
![Aspose.CAD på NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Eftersom applikationen kommer att köras på Linux, kan det behövas installera ytterligare typsnitt. Du kan föredra ttf-mscorefonts-installer.
1. När alla nödvändiga beroenden har lagts till, skriv ett enkelt program som skapar en ellipse och sparar den som en bild:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP-triggerfunktion har behandlat en begäran.");
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

### Konfigurera en Dockerfile

 Nästa steg är att skapa och konfigurera Dockerfile i den överordnade projektmappen.

1. Skapa Dockerfile och placera den bredvid lösningsfilen för din applikation. Håll detta filnamn utan tillägg (standard).
![Rotprojektmapp](/cad/_assets/showcases/azure/root-folder.png)<br>
1. I Dockerfile, specificera:

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

 Ovanstående är en enkel Dockerfile som innehåller följande instruktioner:

- SDK-bilden som ska användas. Här är det NET 6-bilden. Docker kommer att ladda ner den när byggningen körs. Versionen av SDK anges som en tagg.
- Efteråt, kan det vara nödvändigt att installera typsnitt eftersom SDK-bilden innehåller mycket få typsnitt. Du kan också använda lokala typsnitt kopierade till dockerbilden.
- Den arbetskatalog som anges på nästa rad.
- Kommandot för att kopiera allt till containern, publicera applikationen och specificera ingångspunkten.

## Docker Hub
1. Logga in på Docker Hub
1. Skapa ett offentligt repo

## Bygga och köra applikationen i Docker
 
 Nu kan applikationen byggas och köras i Docker. Öppna din favoritskalkylator, ändra katalog till mappen med applikationen (mappen där lösningsfilen och Dockerfile är placerade) och kör följande kommando:

{{< highlight plain >}}
//exempel
docker build -t <användarnamn>/<repo namn> .

docker build -t användare/asposefunction .
{{< /highlight >}}
 
Vid första körning av detta kommando kan det ta längre tid eftersom Docker behöver ladda ner de nödvändiga bilderna. När den föregående kommandon har slutförts, kör följande kommando för att trycka bilden till docker hub:
 
{{< highlight plain >}}
//exempel
docker push <användarnamn>/<repo namn>:tagname

docker push användare/asposefunction:senaste
{{< /highlight >}}

## Azure

1. Logga in på Azure.
1. Välj Azure-tjänster.
1. Välj Function App och skapa en funktion.<br>
![Azure skapa funktionsknapp](/cad/_assets/showcases/azure/create-function.png)<br>
1. Upprepa de grundläggande inställningarna som på bilden nedan.<br>
![Azure skapa funktionsinställningar](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Klicka på 'Granska + skapa' -> Skapa.
1. Vänta tills distributionen är klar.
1. Klicka på "Gå till resurs"-knappen.<br>
![Resursknapp](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Stoppa aspose-cad-docker-example-funktionen.<br>
![Stoppa containern](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Gå till deploymentscenter-menyn och gör lämpliga inställningar.<br>
![Distribution centrum](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Spara inställningar
1. Kopiera Webhook-URL från inställningarna för distributionscentret.<br>
![Webhook-url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Gå till Docker Hub, välj ditt repo och välj webhooks.
1. Klistra in 'Webhook-url' från Azure i Docker Hub-webhook-url och ställ in namnet.<br>
![Webhook-inställningar i Docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Klicka på skapa-knappen.
1. Återgå till översikten av Azure-funktionen och starta containern.<br>
![Översiktsmeny](/cad/_assets/showcases/azure/overview.png)<br>

## Exempel på körning

1. Postman-inställningar.<br>
![Översiktsmeny](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Klicka på send-knappen.

{{% alert color="primary" %}} 
Om svaret är framgångsrikt, klicka på Spara till fil så får du den konverterade filen i png-format
{{% /alert %}}

## Fler exempel

För fler exempel på hur du kan använda Aspose.CAD i Docker, se [exemplen](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Se även

- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Väx till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
- Ytterligare information om [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
