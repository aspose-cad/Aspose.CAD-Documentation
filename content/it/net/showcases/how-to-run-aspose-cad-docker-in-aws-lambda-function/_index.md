---
title: Come eseguire l'immagine Dockers di Aspose.CAD in una funzione AWS Lambda
type: docs
description: "Esegui l'immagine Docker di Aspose.CAD in una funzione AWS Lambda."
weight: 74
url: /it/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Requisiti
- Docker deve essere installato sul tuo sistema. Per informazioni su come installare Docker su Windows o Mac, fare riferimento ai collegamenti della sezione "Vedi anche".
- Visual Studio 2022.
- AWS Toolkit per Visual Studio 2022.
- Il SDK .NET 6 è utilizzato nell'esempio.
- Postman

## Funzione AWS Lambda

Lambda è un servizio di calcolo che consente di eseguire codice senza provisioning o gestione dei server. Lambda esegue il tuo codice su un'infrastruttura di calcolo ad alta disponibilità e svolge tutta l'amministrazione delle risorse di calcolo, inclusa la manutenzione del server e del sistema operativo, il provisioning della capacità e il ridimensionamento automatico, e la registrazione. Con Lambda, puoi eseguire codice per praticamente qualsiasi tipo di applicazione o servizio backend.

## Creazione della Funzione AWS Lambda

{{% alert color="primary" %}} 
Assicurati di avere diritti sufficienti per creare funzioni e immagini AWS Lambda nel Amazon Elastic Container Registry.
{{% /alert %}}

Per creare il programma della Funzione AWS Lambda, segui i passaggi qui sotto:
1. Crea un progetto AWS Lambda.<br>
![Crea pulsante funzione AWS](/cad/_assets/showcases/aws/create-project.png)<br>
1. Seleziona .NET 6 (Immagine del contenitore) e fai clic sul pulsante 'Fine'.<br>
![Crea pulsante funzione contenitore](/cad/_assets/showcases/aws/create-container.png)<br>
1. Apri AWS Explorer in Visual Studio (Visualizza->AWS Explorer).
1. Aggiungi il profilo delle credenziali AWS in AWS Explorer.<br>
![Profilo credenziali](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Inserisci l'ID chiave di accesso e la chiave di accesso segreta, puoi ottenere queste chiavi nelle credenziali di sicurezza oppure contatta l'amministratore e ottieni un file csv per l'autenticazione.<br>
![Impostazioni profilo account](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Installa le ultime librerie da NuGet.<br>
![Gestore NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Esempio di codice per convertire l'immagine CAD in un file PDF.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. Modifica il DockerFile come nella sezione <a href="#configuring-a-dockerfile">Configurazione di un Dockerfile</a>.
1. Avvia Docker Desktop.
1. Pubblica su AWS Lambda.<br>
![Pubblica AWS lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Modifica la configurazione di caricamento.<br>
![Carica aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Fai clic sul pulsante 'Carica'.<br>
![Carica aws lambda ultimo](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Vai su AWS e seleziona Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Seleziona la tua nuova funzione e crea l'url della funzione.<br>
![Configurazione url funzione](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Seleziona il tipo di autenticazione
- AWS_IAM - Solo gli utenti e i ruoli IAM autenticati possono inviare richieste all'URL della tua funzione.
- NONE - Lambda non eseguirà l'autenticazione IAM sulle richieste all'URL della tua funzione. L'endpoint URL sarà pubblico a meno che tu non implementi la tua logica di autorizzazione nella tua funzione.

### Configurazione di un Dockerfile

 Il passaggio successivo è modificare e configurare il Dockerfile nel progetto.

1. Nel Dockerfile, specifica:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Quello sopra è un semplice Dockerfile, che contiene le seguenti istruzioni:

- L'immagine SDK da utilizzare. Qui si tratta dell'immagine Net 6. Docker la scaricherà quando viene eseguita la build. La versione del SDK è specificata come tag.
- Inoltre, potrebbe essere necessario installare i font perché l'immagine SDK contiene pochissimi font. Inoltre, puoi utilizzare font locali copiati nell'immagine docker.
- La cartella di lavoro, che è specificata nella riga successiva.
- Il comando per copiare tutto nel contenitore, pubblicare l'applicazione e specificare il punto di entrata.

## Esempio di esecuzione

1. Impostazioni di Postman.<br>
![Menu panoramica](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Fai clic sul pulsante invia.

{{% alert color="primary" %}} 
Se la risposta è positiva, fai clic su Salva su file e riceverai il file convertito in formato pdf
{{% /alert %}}

## Ulteriori esempi

Per ulteriori esempi su come puoi utilizzare Aspose.CAD in Docker, vedere gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Vedi anche.

- [Installa AWS Toolkit per Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opzione
- Ulteriori informazioni su [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
