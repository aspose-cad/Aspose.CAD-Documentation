---
title: Come Eseguire l'immagine Docker di Aspose.CAD in Azure Function
type: docs
description: "Esegui l'immagine Docker di Aspose.CAD in Azure Function."
weight: 73
url: /it/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Requisiti
- Docker deve essere installato sul tuo sistema. Per informazioni su come installare Docker su Windows o Mac, fai riferimento ai link nella sezione “Vedi anche”.
- Visual Studio 2022.
- NET 6 SDK è utilizzato nell'esempio.
- Postman

## Azure Function

In questo esempio, crei una semplice funzione di conversione che converte un file CAD e lo salva come immagine. L'applicazione può quindi essere costruita in Docker e eseguita in Azure Function.

## Creazione della Azure Function

Per creare il programma Azure Function, segui i passaggi qui sotto:
1. Una volta installato Docker, assicurati che utilizzi i contenitori Linux (default). Se necessario, seleziona l'opzione Passa a contenitori Linux dal menu di Docker Desktop.
1. In Visual Studio, crea una Azure Function NET 6.<br>
![Dialogo del progetto Azure Function NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Informazioni aggiuntive.<br>
![Dialogo del progetto Azure Function NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Installa l'ultima versione di Aspose.CAD da NuGet.<br>
![Aspose.CAD su NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Poiché l'applicazione verrà eseguita su Linux, potrebbe essere necessario installare caratteri aggiuntivi. Puoi preferire ttf-mscorefonts-installer.
1. Quando tutte le dipendenze richieste sono state aggiunte, scrivi un semplice programma che crea un'ellisse e la salva come immagine:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("La funzione di trigger HTTP C# ha elaborato una richiesta.");
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

### Configurazione di un Dockerfile

Il passo successivo è creare e configurare il Dockerfile nella cartella principale del progetto.

1. Crea il Dockerfile e posizionalo accanto al file di soluzione della tua applicazione. Mantieni questo nome di file senza estensione (il default).
![Cartella principale del progetto](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Nel Dockerfile, specifica:


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

Quello sopra è un semplice Dockerfile, che contiene le seguenti istruzioni:

- L'immagine SDK da utilizzare. Qui è l'immagine Net 6. Docker la scaricherà quando verrà eseguita la build. La versione dell'SDK è specificata come tag.
- Dopo, potrebbe essere necessario installare i caratteri perché l'immagine SDK contiene pochissimi caratteri. Inoltre, puoi utilizzare caratteri locali copiati nell'immagine Docker.
- La directory di lavoro, che è specificata nella riga successiva.
- Il comando per copiare tutto nel contenitore, pubblicare l'applicazione e specificare il punto di ingresso.

## Docker Hub
1. Accedi a Docker Hub
1. Crea un repository pubblico

## Costruzione ed Esecuzione dell'Applicazione in Docker
 
Ora l'applicazione può essere costruita ed eseguita in Docker. Apri il tuo prompt dei comandi preferito, cambia directory nella cartella con l'applicazione (la cartella dove si trova il file di soluzione e il Dockerfile) e esegui il seguente comando:

{{< highlight plain >}}
//esempio
docker build -t <nome utente>/<nome repository> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
La prima volta che esegui questo comando, potrebbe richiedere più tempo poiché Docker deve scaricare le immagini necessarie. Dopo che il comando precedente è stato completato, esegui il seguente comando per inviare l'immagine su Docker Hub:
 
{{< highlight plain >}}
//esempio
docker push <nome utente>/<nome repository>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Accedi ad Azure.
1. Scegli i servizi Azure.
1. Scegli Function App e crea una funzione.<br>
![Pulsante di creazione funzione Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Ripeti le impostazioni di base come nell'immagine qui sotto.<br>
![Impostazioni di creazione funzione Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Fai clic su 'Rivedi + crea' -> Crea.
1. Attendi il completamento del deployment.
1. Fai clic sul pulsante 'Vai alla risorsa'.<br>
![Pulsante risorsa](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Ferma la funzione aspose-cad-docker-example.<br>
![Ferma contenitore](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Vai al menu del centro di distribuzione e fai le impostazioni appropriate.<br>
![Centro di distribuzione](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Salva le impostazioni
1. Copia l'URL del Webhook dalle impostazioni del centro di distribuzione.<br>
![URL del webhook](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Vai su Docker Hub, seleziona il tuo repository e seleziona webhooks.
1. Incolla l'URL del 'Webhook' da Azure nell'URL del webhook di Docker Hub e imposta il nome.<br>
![Impostazioni webhook in docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Fai clic sul pulsante di creazione.
1. Torna alla panoramica della funzione azure e avvia il contenitore.<br>
![Menu panoramica](/cad/_assets/showcases/azure/overview.png)<br>

## Esempio di Esecuzione

1. Impostazioni di Postman.<br>
![Menu panoramica](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Fai clic sul pulsante invia.

{{% alert color="primary" %}} 
Se la risposta è positiva, fai clic su Salva su file e riceverai il file convertito in formato png
{{% /alert %}}

## Altri Esempi

Per ulteriori esempi su come puoi utilizzare Aspose.CAD in Docker, vedi gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Vedi Anche

- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opzione
- Informazioni aggiuntive su [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
