---
title: Hoe de Aspose.CAD Docker afbeelding uit te voeren in Azure Function
type: docs
description: "Voer de Aspose.CAD Docker afbeelding uit in Azure Function."
weight: 71
url: /nl/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Vereisten
- Docker moet op uw systeem zijn geïnstalleerd. Voor informatie over hoe u Docker op Windows of Mac installeert, verwijst u naar de links in de sectie "Zie ook".
- IntelliJ IDEA.
- Azure Toolkit voor IntelliJ.
- Postman.

## Azure Function

In dit voorbeeld maakt u een eenvoudige conversiefunctie die een CAD-bestand converteert en opslaat als een afbeelding. De applicatie kan dan worden gebouwd in Docker en uitgevoerd in Azure Function.

## De Azure Function maken

Om het Azure Function-programma te maken, volgt u de onderstaande stappen:
1. Zodra Docker is geïnstalleerd, zorgt u ervoor dat het Linux-containers gebruikt (standaard). Indien nodig selecteert u de optie Overschakelen naar Linux-containers in het menu van Docker Desktops.
1. Maak een Azure Function-project in IntelliJ IDEA.<br>
![Create azure function project](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Aanmelden en selecteer OAuth 2.0-authenticatie.<br>
![Azure sign In](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Log in in uw browser.
1. Selecteer de abonnementsnaam.
1. Voeg Docker-ondersteuning toe.<br>
![Azure sign In](/_assets/java/java-azure/add-docker-support.png)<br>
1. Bewerk het Dockerfile zoals in de sectie <a href="#configuring-a-dockerfile">Een Dockerfile configureren</a>.
1. Voeg blokken toe voor de repository aspose.cad in pom.xml.
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

1. Wanneer alle vereiste afhankelijkheden zijn toegevoegd, schrijft u een eenvoudig programma dat een ellips maakt en opslaat als een afbeelding:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Deze functie luistert op het eindpunt "/api/HttpExample". Twee manieren om het aan te roepen met de "curl"-opdracht in bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP-trigger heeft een verzoek verwerkt.");

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

### Een Dockerfile configureren

De volgende stap is om de Dockerfile in de hoofdprojectmap te maken en te configureren.

1. Specificeer in de Dockerfile:
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

Het bovenstaande is een eenvoudige Dockerfile, die de volgende instructies bevat:

- De SDK-afbeelding die moet worden gebruikt. Docker downloadt deze wanneer de build wordt uitgevoerd. De versie van de SDK wordt als tag opgegeven.
- De werkdirectory, die in de volgende regel wordt gespecificeerd.
- De opdracht om alles naar de container te kopiëren, de applicatie te publiceren en het entry point op te geven.

## Docker Hub
1. Meld u aan bij Docker Hub
1. Maak een openbare repository

## De applicatie bouwen en uitvoeren in Docker

Nu kan de applicatie worden gebouwd en uitgevoerd in Docker. Open uw favoriete opdrachtprompt, wijzig de directory naar de map met de applicatie (map waarin het oplossingbestand en de Dockerfile zijn geplaatst) en voer de volgende opdracht uit:


1. Dockerfile-bouwopdracht in de console
{{< highlight plain >}}
//voorbeeld
docker build -t <gebruikersnaam>/<repository-naam> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. De eerste keer dat u deze opdracht uitvoert, kan het langer duren omdat Docker de benodigde afbeeldingen moet downloaden. Nadat de vorige opdracht is voltooid, voert u de volgende opdracht uit om de afbeelding naar Docker Hub te duwen.
{{< highlight plain >}}
//voorbeeld
docker push <gebruikersnaam>/<repository-naam>:tagnaam

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Voer het Dockerfile uit in de IDE en push daarna naar Docker Hub.<br>
![Run docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Voer de naam van de afbeelding in, zoals in de Docker Hub-repository.<br>
![Run docker in ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Wacht tot deze is afgelopen.

## Azure

1. Meld u aan bij Azure.
1. Kies Azure-services.
1. Kies Function App en maak een functie.<br>
![Azure create function button](/_assets/java/java-azure/create-function-azure.png)<br>
1. Herhaal de basisinstellingen zoals in de afbeelding hieronder.<br>
![Azure create function settings](/_assets/java/java-azure/create-function-settings.png)<br>
1. Klik op 'Beoordelen + maken' -> Maken.
1. Wacht tot de implementatie is voltooid.
1. Klik op de knop 'Ga naar resource'.<br>
![Resource button](/_assets/java/java-azure/go-to-resource.png)<br>
1. Stop de aspose-cad-docker-example-functie.<br>
![Stop conteiner](/_assets/java/java-azure/stop-container.png)<br>
1. Ga naar het menu implementatiecentrum en maak de juiste instellingen.<br>
![Deployment center](/_assets/java/java-azure/deployment-center.png)<br>
1. Sla de instellingen op
1. Kopieer de Webhook-URL van de instellingen van het implementatiecentrum.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Ga naar Docker Hub, selecteer uw repository en selecteer webhooks.
1. Plak de 'Webhook-URL' van Azure in de Docker Hub-webhook-URL en stel de naam in.<br>
![Webhook settings in docker](/_assets/java/java-azure/webhook.png)<br>
1. Klik op de knop 'Maken'.
1. Ga terug naar het overzicht van de Azure-functie en start de container.<br>
![Overview menu](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Het kan enkele minuten duren voordat de functie is gestart.
{{% /alert %}}

## Voorbeeld van uitvoering

1. Postman-instellingen.<br>
![Overview menu](/_assets/java/java-azure/postman-settings.png)<br>
1. Selecteer een DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Klik op de verzendknop.
1. Sla resultaat op
![Save responce](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Als de respons succesvol is, klik dan op Opslaan als bestand en u ontvangt het geconverteerde bestand in png-indeling
{{% /alert %}}

## Meer Voorbeelden

Voor meer voorbeelden van hoe u Aspose.CAD in Docker kunt gebruiken, zie de [voorbeelden](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zie Ook

- [Installeer Docker Desktop op Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installeer Docker Desktop op Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Overschakelen naar Linux-containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) optie
