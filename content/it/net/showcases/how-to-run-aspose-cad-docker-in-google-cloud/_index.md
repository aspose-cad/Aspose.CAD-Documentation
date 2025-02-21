---
title: Come Eseguire l'immagine Docker di Aspose.CAD in Google Cloud
type: docs
description: "Esegui l'immagine Docker di Aspose.CAD in Google Cloud."
weight: 75
url: /it/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Requisiti

- Docker deve essere installato sul tuo sistema. Per informazioni su come installare Docker su Windows o Mac, fare riferimento ai collegamenti nella sezione “Vedi Anche”.
- Visual Studio 2022.
- Google CLI.
- SDK .NET Core 3.1 è utilizzato nell'esempio.
- Postman

## Funzione Google Cloud Run

Cloud Run è un ambiente di calcolo completamente gestito per il deploy e la scalabilità di contenitori HTTP serverless senza doversi preoccupare della fornitura di macchine, della configurazione di cluster o dell'autoscaling.

- Nessun lock-in del fornitore - Poiché Cloud Run utilizza contenitori OCI standard e implementa l'API standard Knative Serving, puoi facilmente trasferire le tue applicazioni in locale o in qualsiasi altro ambiente cloud. 
- Autoscaling veloce - I microservizi distribuiti in Cloud Run scalano automaticamente in base al numero di richieste in arrivo, senza che tu debba configurare o gestire un intero cluster Kubernetes. Cloud Run scala a zero—cioè, non utilizza risorse—se non ci sono richieste.
- Suddivisione del traffico - Cloud Run ti consente di suddividere il traffico tra più revisioni, quindi puoi eseguire rollout graduali come implementazioni canary o blue/green.
- Domini personalizzati - Puoi configurare il mapping dei domini personalizzati in Cloud Run e verrà fornito un certificato TLS per il tuo dominio. 
- Ridondanza automatica - Cloud Run offre una ridondanza automatica, quindi non devi preoccuparti di creare più istanze per un'alta disponibilità.

Cloud Run e Cloud Functions sono entrambi servizi completamente gestiti che funzionano sull'infrastruttura serverless di Google Cloud, si autoscalano e gestiscono richieste HTTP o eventi. Tuttavia, presentano alcune differenze importanti:

- Cloud Functions consente di distribuire frammenti di codice (funzioni) scritti in un insieme limitato di linguaggi di programmazione, mentre Cloud Run consente di distribuire immagini di contenitori utilizzando il linguaggio di programmazione di tua scelta. 
- Cloud Run supporta anche l'uso di qualsiasi strumento o libreria di sistema dalla tua applicazione; Cloud Functions non ti consente di utilizzare eseguibili personalizzati. 
- Cloud Run offre una durata di timeout delle richieste più lunga, fino a 60 minuti, mentre con Cloud Functions il timeout delle richieste può essere impostato fino a 9 minuti. 
- Cloud Functions invia solo una richiesta alla volta a ciascuna istanza della funzione, mentre per impostazione predefinita Cloud Run è configurato per inviare più richieste simultanee a ciascuna istanza del contenitore. Questo è utile per migliorare la latenza e ridurre i costi se prevedi volumi elevati. 

## Creazione del progetto Google Cloud Function

{{% alert color="primary" %}} 
Assicurati di avere diritti sufficienti per creare la funzione Google Cloud Run e le immagini nel repository Artifact Registry.
{{% /alert %}}

Per creare il programma Google Cloud Function, segui i passaggi riportati di seguito:

1. Installa SDK .NET Core 3.1.
1. Installa il pacchetto template:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Successivamente, crea una directory per il tuo progetto e usa dotnet new per creare una nuova funzione HTTP:
{{< highlight plain >}}
mkdir AsposeFunctions //crea cartella
cd AsposeFunctions //vai alla cartella AsposeFunctions
dotnet new gcf-http //crea progetto Google Cloud Function con trigger http
{{< /highlight >}}
{{% alert color="primary" %}} 
Questo crea AsposeFunctions.csproj e Function.cs nella directory corrente. Apri Function.cs per rivedere il codice e fornire un messaggio personalizzato se lo desideri.
{{% /alert %}}
1. Esempio di codice per il file csproj (AsposeFunctions.csproj).
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
1. Esempio di codice per convertire un'immagine CAD in un file png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// La logica per la tua funzione va qui.
        /// </summary>
        /// <param name="context">Il contesto HTTP, contenente la richiesta e la risposta.</param>
        /// <returns>Un'attività che rappresenta l'operazione asincrona.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //file da modulo
                var file = context.Request.Body; //dati binari
                
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
1. Compila la tua funzione localmente come segue:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Una volta che il server è in esecuzione, vai su http://localhost:8080 per attivare la funzione. Premi Ctrl-C nella console per fermare il server.

## Distribuzione dell'immagine docker su Google Cloud

1. Accedi a Google Cloud.
1. Crea un progetto se non esiste.
1. Vai a 'Artifact Registry' e crea un repository.<br>
![Crea Repository Artifact](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Seleziona il nuovo repository in Artifact Registry.
![Seleziona repository artifact](/_assets/showcases/google/select-artifact.png)<br>
1. Fai clic su 'ISTRUZIONI DI CONFIGURAZIONE' e copia il comando 'Configura Docker'.<br>
![ISTRUZIONI DI CONFIGURAZIONE](/_assets/showcases/google/setup-instruction.png)<br>
1. Aggiungi un'entrata credHelper Docker al file di configurazione di Docker, o crea il file se non esiste.
{{< highlight plain >}}
//esempio
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Crea un Dockerfile nella directory principale del progetto ed edita il DockerFile come nella sezione <a href="#configuring-a-dockerfile">Configurazione di un Dockerfile</a>.
1. Avvia Docker Desktop.
1. Compila l'immagine docker con il percorso del repository cloud.
{{< highlight plain >}}
//esempio
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Pubblica l'immagine su Google Cloud Artifact Registry
{{< highlight plain >}}
//esempio
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Crea servizio Google Cloud Run 

1. Vai a Cloud Run.
1. Crea servizio Cloud Run.<br>
![Crea servizio Cloud Run](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Nel campo URL immagine contenitore, seleziona il contenitore da 'ARTIFACT REGISTRY'.<br>
![URL immagine contenitore](/_assets/showcases/google/container-url.png)<br>
1. Controlla le altre impostazioni come di seguito.<br>
![Impostazioni servizio](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Attendi che la distribuzione termini.
1. URL del servizio per lavorare con l'applicazione di conversione.<br>
![Url servizio](/_assets/showcases/google/url-service.png)<br>

### Configurazione di un Dockerfile

Il passaggio successivo è modificare la configurazione del Dockerfile nel progetto.

1. Nel Dockerfile, specifica:

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

Il sopra è un semplice Dockerfile, che contiene le seguenti istruzioni:

- L'immagine SDK da utilizzare. Qui è l'immagine Net Core 3.1. Docker la scaricherà quando verrà eseguita la build. La versione dell'SDK è specificata come un tag.
- Dopo, potrebbe essere necessario installare i font perché l'immagine SDK contiene pochissimi font. Inoltre, puoi utilizzare font locali copiati nell'immagine docker.
- La directory di lavoro, che è specificata nella riga successiva.
- Il comando per copiare tutto nel contenitore, pubblicare l'applicazione e specificare il punto di ingresso.

## Esempio di esecuzione

1. Impostazioni di Postman.<br>
![Menu panoramica](/_assets/showcases/google/postman-settings.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Fare clic sul pulsante invia.

{{% alert color="primary" %}} 
Se la risposta è positiva, fai clic su Salva su file e riceverai il file convertito in formato png
{{% /alert %}}

## Altri Esempi

Per ulteriori esempi su come puoi utilizzare Aspose.CAD in Docker, consulta gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Vedi Anche.

- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opzione
- Ulteriori informazioni su [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
