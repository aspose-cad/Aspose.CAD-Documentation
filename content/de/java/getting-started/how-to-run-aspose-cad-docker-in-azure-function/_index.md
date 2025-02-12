---
title: So führen Sie das Aspose.CAD Docker-Image in Azure Function aus
type: docs
description: "Führen Sie das Aspose.CAD Docker-Image in Azure Function aus."
weight: 71
url: /de/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Voraussetzungen
- Docker muss auf Ihrem System installiert sein. Informationen zur Installation von Docker unter Windows oder Mac finden Sie in den Links im Abschnitt „Siehe auch“.
- IntelliJ IDEA.
- Azure Toolkit für IntelliJ.
- Postman.

## Azure Function

In diesem Beispiel erstellen Sie eine einfache Konvertierungsfunktion, die eine CAD-Datei konvertiert und als Bild speichert. Die Anwendung kann dann in Docker erstellt und in Azure Function ausgeführt werden.

## Erstellen der Azure Function

Um das Azure Function-Programm zu erstellen, befolgen Sie die folgenden Schritte:
1. Stellen Sie sicher, dass Docker auf Linux-Containern (Standard) verwendet wird, nachdem es installiert wurde. Wählen sie gegebenenfalls im Dropdown-Menü von Docker Desktop die Option „Zu Linux-Containern wechseln“.
1. Erstellen Sie ein Azure Function-Projekt in IntelliJ IDEA.<br>
![Azure-Funktionsprojekt erstellen](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Azure-Funktionsprojekt erstellen-endgültig](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Anmelden und „OAuth 2.0“-Authentifizierung auswählen.<br>
![Azure-Anmeldung](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Im Browser anmelden.
1. Abonnementnamen auswählen.
1. Docker-Unterstützung hinzufügen.<br>
![Azure-Anmeldung](/_assets/java/java-azure/add-docker-support.png)<br>
1. Bearbeiten Sie die DockerFile wie im Abschnitt <a href="#konfigurieren-einer-dockerfile">Konfigurieren einer Dockerfile</a>.
1. Blöcke für das Repository aspose.cad in die pom.xml hinzufügen.
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

1. Nachdem alle erforderlichen Abhängigkeiten hinzugefügt wurden, schreiben Sie ein einfaches Programm, das ein Ellipse erstellt und als Bild speichert:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Diese Funktion lauscht am Endpunkt "/api/HttpExample". Zwei Möglichkeiten, sie mit dem „curl“-Befehl in der Bash aufzurufen:
     * 1. curl -d "HTTP-Body" {Ihr Host}/api/HttpExample
     * 2. curl "{Ihr Host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java-HTTP-Trigger hat eine Anforderung verarbeitet.");

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

### Konfigurieren einer Dockerfile

Der nächste Schritt besteht darin, die Dockerfile im Stammprojektordner zu erstellen und zu konfigurieren.

1. Geben Sie in der Dockerfile Folgendes an:
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

Das oben stehende ist eine einfache Dockerfile, die die folgenden Anweisungen enthält:

- Das SDK-Image, das verwendet werden soll. Docker wird es herunterladen, wenn der Build ausgeführt wird. Die Version des SDK wird als Tag angegeben.
- Das Arbeitsverzeichnis wird in der nächsten Zeile angegeben.
- Der Befehl zum Kopieren von allem in den Container, zum Veröffentlichen der Anwendung und zum Festlegen des Einstiegspunkts.

## Docker Hub
1. Bei Docker Hub anmelden
1. Öffentliches Repository erstellen

## Anwendung in Docker erstellen und ausführen
 
Die Anwendung kann nun in Docker erstellt und ausgeführt werden. Öffnen Sie Ihre bevorzugte Eingabeaufforderung, wechseln Sie zum Verzeichnis mit der Anwendung (Ordner, in dem die Lösungsdatei und die Dockerfile platziert sind) und führen Sie folgenden Befehl aus:


1. Dockerfile-Befehl im Konsolenfenster erstellen
{{< highlight plain >}}
//Beispiel
docker build -t <Benutzername>/<Repositoriesname> .

docker build -t benutzer/asposefunction .
{{< /highlight >}}
 
1. Beim ersten Ausführen dieses Befehls kann es länger dauern, da Docker die erforderlichen Images herunterladen muss. Nach Abschluss des vorherigen Befehls führen Sie den folgenden Befehl aus, um das Image auf Docker Hub hochzuladen.
{{< highlight plain >}}
//Beispiel
docker push <Benutzername>/<Repositoriesname>:Tagname

docker push benutzer/aspose-cad-java:latest
{{< /highlight >}}

1. Dockerfile in IDE ausführen und anschließend in Docker Hub hochladen.<br>
![Docker in IDE ausführen](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Geben Sie den Namen des Bildes ein, wie im Docker-Hub-Repository.<br>
![Docker in IDE ausführen-nächster Schritt](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Warten Sie auf Beendigung.

## Azure

1. Bei Azure anmelden.
1. Azure-Dienste auswählen.
1. Funktion-App auswählen und eine Funktion erstellen.<br>
![Azure-Schaltfläche „Funktion erstellen“](/_assets/java/java-azure/create-function-azure.png)<br>
1. Wiederholen Sie die grundlegenden Einstellungen, wie im folgenden Bild.<br>
![Azure-Funktionseinstellungen erstellen](/_assets/java/java-azure/create-function-settings.png)<br>
1. Auf „Überprüfen + Erstellen“ klicken -> Erstellen.
1. Auf Abschluss des Bereitstellungsvorgangs warten.
1. Auf die Schaltfläche „Zur Ressource gehen“ klicken.<br>
![Ressourcen-Schaltfläche](/_assets/java/java-azure/go-to-resource.png)<br>
1. Stoppen Sie die Funktion aspose-cad-docker-example.<br>
![Container anhalten](/_assets/java/java-azure/stop-container.png)<br>
1. Gehen Sie zum Menü „Bereitstellungszentrum“ und nehmen Sie die entsprechenden Einstellungen vor.<br>
![Bereitstellungszentrum](/_assets/java/java-azure/deployment-center.png)<br>
1. Einstellungen speichern.
1. Webhook-URL aus den Einstellungen des Bereitstellungszentrums kopieren.<br>
![Webhook-URL](/_assets/java/java-azure/webhook-url.png)<br>
1. Gehen Sie zu Docker Hub, wählen Sie Ihr Repository aus und wählen Sie Webhooks aus.
1. Fügen Sie die „Webhook-URL“ von Azure in die „Docker Hub“-Webhook-URL ein und legen Sie den Namen fest.<br>
![Webhook-Einstellungen in Docker](/_assets/java/java-azure/webhook.png)<br>
1. Klicken Sie auf „Erstellen“.
1. Zurück zur Übersicht der Azure-Funktion und Container starten.<br>
![Menü Übersicht](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Es kann einige Minuten dauern, bis die Funktion gestartet ist.
{{% /alert %}}

## Ausführungsbeispiel

1. Postman-Einstellungen.<br>
![Menü Übersicht](/_assets/java/java-azure/postman-settings.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
1. Klicken Sie auf die Schaltfläche „Senden“.
1. Ergebnis speichern
![Antwort speichern](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Wenn die Antwort erfolgreich ist, klicken Sie auf „Als Datei speichern“, und Sie erhalten die konvertierte Datei im PNG-Format.
{{% /alert %}}

## Weitere Beispiele

Für weitere Beispiele zur Verwendung von Aspose.CAD in Docker sehen Sie die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Siehe auch

- [Docker Desktop auf Windows installieren](https://docs.docker.com/docker-for-windows/install/)
- [Docker Desktop auf Mac installieren](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Option „Zu Linux-Containern“ (https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
