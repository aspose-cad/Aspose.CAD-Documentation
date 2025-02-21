---
title: Hur man kör Aspose.CAD Docker-bild i Azure Function
type: docs
description: "Kör Aspose.CAD Docker-bild i Azure Function."
weight: 71
url: /sv/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Förutsättningar
- Docker måste vara installerad på ditt system. För information om hur man installerar Docker på Windows eller Mac, se länkarna i avsnittet "Se Även".
- IntelliJ IDEA.
- Azure Toolkit för IntelliJ.
- Postman.

## Azure Function

I det här exemplet skapar du en enkel konverteringsfunktion som konverterar en CAD-fil och sparar den som en bild. Applikationen kan sedan byggas i Docker och köras i Azure Function.

## Skapa Azure Function

För att skapa Azure Function-programmet, följ stegen nedan:
1. När Docker är installerat, se till att det använder Linux-containrar (standard). Om nödvändigt, välj alternativet Väx till Linux-containrar i Docker Desktops meny.
1. Skapa Azure Function-projekt i IntelliJ IDEA.<br>
![Skapa azure function-projekt](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Skapa azure function-projekt-slutgiltigt](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Verktyg->Azure->Logga in och välj OAuth 2.0-autentisering.<br>
![Azure inloggning](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Logga in i webbläsaren.
1. Välj abonnemangsnamn.
1. Lägg till docker-stöd.<br>
![Lägg till docker-stöd](/_assets/java/java-azure/add-docker-support.png)<br>
1. Redigera DockerFile enligt avsnittet <a href="#configuring-a-dockerfile">Konfigurera en Dockerfile</a>.
1. Lägg till block för repository aspose.cad i pom.xml.
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

1. När alla nödvändiga beroenden har lagts till, skriv ett enkelt program som skapar en ellips och sparar den som en bild:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Denna funktion lyssnar på slutpunkten "/api/HttpExample". Två sätt att anropa den med hjälp av "curl"-kommandot i bash:
     * 1. curl -d "HTTP-kropp" {ditt värdnamn}/api/HttpExample
     * 2. curl "{ditt värdnamn}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP-trigger behandlade en begäran.");

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

### Konfigurera en Dockerfile

Det nästa steget är att skapa och konfigurera Dockerfile i rotprojektmappen.

1. I Dockerfile, specificera:
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

Den ovanstående är en enkel Dockerfile, som innehåller följande instruktioner:

- SDK-bilden som ska användas. Docker kommer att ladda ner den när byggprocessen körs. Versionen av SDK specificeras som en tagg.
- Arbetskatalogen, som specificeras i nästa rad.
- Kommandot att kopiera allt till containern, publicera applikationen och specificera ingångspunkten.

## Docker Hub
1. Logga in på Docker Hub
1. Skapa en offentlig repository

## Bygga och köra applikationen i Docker

Nu kan applikationen byggas och köras i Docker. Öppna ditt favoritkommandofönster, ändra katalog till mappen med applikationen (mappen där lösningsfilen och Dockerfile ligger) och kör följande kommando:

1. Bygg dockerfile-kommandot i konsolen
{{< highlight plain >}}
//exempel
docker build -t <användarnamn>/<repositoriesnamn> .

docker build -t user/asposefunction .
{{< /highlight >}}

1. Första gången du kör det här kommandot kan det ta längre tid eftersom Docker behöver ladda ner de nödvändiga bilderna. När det föregående kommandot är klart, kör följande kommando för att trycka på bilden till docker hub.
{{< highlight plain >}}
//exempel
docker push <användarnamn>/<repositoriesnamn>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Kör dockerfile i IDE och efter tryck till docker hub.<br>
![Kör docker i ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Ange namnet på bilden, som i Docker Hub-repo.<br>
![Kör docker i ide-nästa](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Vänta tills det är klart.

## Azure

1. Logga in på Azure.
1. Välj Azure-tjänster.
1. Välj Function App och skapa en funktion.<br>
![Skapa funktion knapp i Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Upprepa de grundläggande inställningarna som i bilden nedan.<br>
![Skapa funktionsinställningar i Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Klicka på 'Granska + skapa' -> Skapa.
1. Vänta på att distributionen ska slutföras.
1. Klicka på 'Gå till resurs' knappen.<br>
![Resurs knapp](/_assets/java/java-azure/go-to-resource.png)<br>
1. Stoppa aspose-cad-docker-example-funktionen.<br>
![Stoppa container](/_assets/java/java-azure/stop-container.png)<br>
1. Gå till distributionscentralen och gör lämpliga inställningar.<br>
![Distributionscentral](/_assets/java/java-azure/deployment-center.png)<br>
1. Spara inställningar
1. Kopiera Webhook-URL:en från inställningarna i distributionscentralen.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Gå till Docker Hub, välj ditt repository och välj webhooks.
1. Klistra in 'Webhook-url' från Azure i Docker Hub-webhook-url och ange namnet.<br>
![Webhook-inställningar i docker](/_assets/java/java-azure/webhook.png)<br>
1. Klicka på knappen skapa.
1. Återgå till översikten över Azure-funktionen och starta containern.<br>
![Översikt meny](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Det kan ta några minuter för funktionen att starta.
{{% /alert %}}

## Exempel på körning

1. Inställningar i Postman.<br>
![Översikt meny](/_assets/java/java-azure/postman-settings.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Klicka på skicka-knappen.
1. Spara resultatet
![Spara svar](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Om svaret är framgångsrikt, klicka på Spara till fil så får du den konverterade filen i png-format.
{{% /alert %}}

## Fler exempel

För fler exempel på hur du kan använda Aspose.CAD i Docker, se [exemplen](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Se Även

- [Installera Docker Desktop på Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installera Docker Desktop på Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Väx till Linux-containrar](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) alternativ
