---
title: Come eseguire l'immagine Docker di Aspose.CAD in Azure Function
type: docs
description: "Esegui l'immagine Docker di Aspose.CAD in Azure Function."
weight: 71
url: /it/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Requisiti
- Docker deve essere installato sul tuo sistema. Per informazioni su come installare Docker su Windows o Mac, consulta i collegamenti nella sezione "Vedi anche".
- IntelliJ IDEA.
- Azure Toolkit per IntelliJ.
- Postman.

## Azure Function

In questo esempio, crei una semplice funzione di conversione che converte un file CAD e lo salva come immagine. L'applicazione può quindi essere costruita in Docker ed eseguita in Azure Function.

## Creazione della Azure Function

Per creare il programma Azure Function, segui i passaggi di seguito:
1. Una volta installato Docker, assicurati che utilizzi contenitori Linux (predefinito). Se necessario, seleziona l'opzione Passa a contenitori Linux dal menu di Docker Desktops.
1. Crea un progetto Azure Function in IntelliJ IDEA.<br>
![Crea progetto Azure Function](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Crea progetto Azure Function - finale](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Strumenti -> Azure -> Accedi e seleziona l'autenticazione OAuth 2.0.<br>
![Accesso ad Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Accedi nel browser.
1. Seleziona il nome dell'abbonamento.
1. Aggiungi supporto Docker.<br>
![Accesso ad Azure](/_assets/java/java-azure/add-docker-support.png)<br>
1. Modifica il DockerFile come nella sezione <a href="#configuring-a-dockerfile">Configurare un Dockerfile</a>.
1. Aggiungi blocchi per il repository aspose.cad in pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. Quando tutte le dipendenze necessarie sono aggiunte, scrivi un semplice programma che crea un'ellisse e la salva come immagine:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Questa funzione ascolta all'endpoint "/api/HttpExample". Due modi per attivarla utilizzando il comando "curl" in bash:
     * 1. curl -d "Corpo HTTP" {il tuo host}/api/HttpExample
     * 2. curl "{il tuo host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Il trigger HTTP Java ha elaborato una richiesta.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### Configurazione di un Dockerfile

 Il passo successivo è creare e configurare il Dockerfile nella cartella principale del progetto.

1. Nel Dockerfile, specifica:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

 Il sopra è un semplice Dockerfile, che contiene le seguenti istruzioni:

- L'immagine SDK da utilizzare. Docker la scaricherà quando il build viene eseguito. La versione dell'SDK è specificata come tag.
- La cartella di lavoro, che è specificata nella riga successiva.
- Il comando per copiare tutto nel container, pubblicare l'applicazione e specificare il punto di ingresso.

## Docker Hub
1. Accedi a Docker Hub
1. Crea un repository pubblico

## Costruzione e esecuzione dell'applicazione in Docker
 
 Ora l'applicazione può essere costruita ed eseguita in Docker. Apri il tuo prompt dei comandi preferito, cambia la directory nella cartella con l'applicazione (cartella in cui si trova il file di soluzione e il Dockerfile) e esegui il seguente comando:


1. Costruisci il comando dockerfile nella console
{{< highlight plain >}}
//esempio
docker build -t <nome utente>/<nome repository> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. La prima volta che esegui questo comando, potrebbe richiedere più tempo perché Docker deve scaricare le immagini necessarie. Dopo che il comando precedente è stato completato, esegui il seguente comando per inviare l'immagine a Docker Hub.
{{< highlight plain >}}
//esempio
docker push <nome utente>/<nome repository>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Esegui il Dockerfile in IDE e dopo invia a Docker Hub.<br>
![Esegui docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Inserisci il nome dell'immagine, come nel repository di Docker Hub.<br>
![Esegui docker in ide - successivo](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Attendi la fine.

## Azure

1. Accedi ad Azure.
1. Scegli i servizi Azure.
1. Scegli Function App e crea una funzione.<br>
![Pulsante crea funzione Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Ripeti le impostazioni di base come nell'immagine seguente.<br>
![Impostazioni crea funzione Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Clicca su 'Rivedi + crea' -> Crea.
1. Attendi il completamento del deployment.
1. Clicca sul pulsante 'Vai alla risorsa'.<br>
![Pulsante risorsa](/_assets/java/java-azure/go-to-resource.png)<br>
1. Ferma la funzione aspose-cad-docker-example.<br>
![Ferma contenitore](/_assets/java/java-azure/stop-container.png)<br>
1. Vai al menu centro di distribuzione e fai le impostazioni appropriate.<br>
![Centro di distribuzione](/_assets/java/java-azure/deployment-center.png)<br>
1. Salva le impostazioni
1. Copia l'URL del webhook dalle impostazioni del centro di distribuzione.<br>
![URL del webhook](/_assets/java/java-azure/webhook-url.png)<br>
1. Vai a Docker Hub, seleziona il tuo repository e seleziona webhooks.
1. Incolla l'URL del 'Webhook' da Azure nell'URL del webhook di Docker Hub e imposta il nome.<br>
![Impostazioni del webhook in docker](/_assets/java/java-azure/webhook.png)<br>
1. Clicca sul pulsante Crea.
1. Torna alla panoramica della funzione Azure e avvia il contenitore.<br>
![Menu panoramica](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Potrebbe richiedere alcuni minuti per avviare la funzione.
{{% /alert %}}

## Esempio di esecuzione

1. Impostazioni di Postman.<br>
![Menu panoramica](/_assets/java/java-azure/postman-settings.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, file SVG.
1. Clicca sul pulsante invia.
1. Salva il risultato
![Salva risposta](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Se la risposta è positiva, clicca su Salva su file e riceverai il file convertito in formato PNG.
{{% /alert %}}

## Altri esempi

Per ulteriori campioni su come puoi utilizzare Aspose.CAD in Docker, consulta gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Vedi anche

- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opzione
