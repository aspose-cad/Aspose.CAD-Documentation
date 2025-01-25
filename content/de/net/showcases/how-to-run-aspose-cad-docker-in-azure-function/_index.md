---
title: So führen Sie das Aspose.CAD-Docker-Image in Azure Functions aus
type: docs
description: "Führen Sie das Aspose.CAD-Docker-Image in Azure Function aus."
weight: 73
url: /de/net/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Voraussetzungen
- Docker muss auf Ihrem System installiert sein. Informationen zur Installation von Docker auf Windows oder Mac finden Sie in den Links im Abschnitt "Siehe auch".
- Visual Studio 2022.
- NET 6 SDK wird im Beispiel verwendet.
- Postman

## Azure-Funktion

In diesem Beispiel erstellen Sie eine einfache konvertierende Funktion, die eine CAD-Datei konvertiert und als Bild speichert. Die Anwendung kann dann in Docker gebaut und in Azure Functions ausgeführt werden.

## Erstellen der Azure-Funktion

Um das Azure-Funktionsprogramm zu erstellen, folgen Sie den folgenden Schritten:
1. Stellen Sie sicher, dass Docker installiert ist und Linux-Container (Standard) verwendet werden. Wenn nötig, wählen Sie die Option "Zu Linux-Containern wechseln" im Menü Docker Desktop.
1. Erstellen Sie in Visual Studio eine NET 6 Azure-Funktion.<br>
![Dialog für ein NET 6 Azure-Funktionsprojekt](Create-project.png)<br>
1. Zusätzliche Informationen.<br>
![Dialog für ein NET 6 Azure-Funktionsprojekt](Additional-information.png)<br>
1. Installieren Sie die neueste Aspose.CAD-Version von NuGet.<br>
![Aspose.CAD auf NuGet](NuGet.png)<br>
1. Da die Anwendung auf Linux ausgeführt wird, müssen Sie möglicherweise zusätzliche Schriftarten installieren. Sie könnten den ttf-mscorefonts-installer bevorzugen.
1. Wenn alle erforderlichen Abhängigkeiten hinzugefügt wurden, schreiben Sie ein einfaches Programm, das eine Ellipse erstellt und als Bild speichert:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP-Triggerfunktion verarbeitet eine Anfrage.");
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

### Konfigurieren eines Dockerfiles

 Der nächste Schritt ist, das Dockerfile im Stammverzeichnis des Projekts zu erstellen und zu konfigurieren.

1. Erstellen Sie das Dockerfile und platzieren Sie es neben der Lösungsdatei Ihrer Anwendung. Behalten Sie diesen Dateinamen ohne Erweiterung (Standard).
![Stammprojektordner](root-folder.png)<br>
1. Geben Sie im Dockerfile Folgendes an:


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

 Das obige ist ein einfaches Dockerfile, das die folgenden Anweisungen enthält:

- Das zu verwendende SDK-Image. Hier ist es das Net 6-Image. Docker wird es herunterladen, wenn der Build ausgeführt wird. Die Version des SDK wird als Tag angegeben.
- Danach müssen Sie möglicherweise Schriftarten installieren, da das SDK-Image nur sehr wenige Schriftarten enthält. Sie können auch lokale Schriftarten verwenden, die in das Docker-Image kopiert wurden.
- Das Arbeitsverzeichnis, das in der nächsten Zeile angegeben wird.
- Der Befehl zum Kopieren aller Dateien in den Container, die Anwendung zu veröffentlichen und den Einstiegspunkt anzugeben.

## Docker Hub
1. Anmelden bei Docker Hub
1. Öffentliches Repository erstellen

## Erstellen und Ausführen der Anwendung in Docker

 Jetzt kann die Anwendung in Docker erstellt und ausgeführt werden. Öffnen Sie Ihre bevorzugte Eingabeaufforderung, wechseln Sie in das Verzeichnis des Ordners mit der Anwendung (Ordner, in dem die Lösungsdatei und das Dockerfile platziert sind) und führen Sie den folgenden Befehl aus:

{{< highlight plain >}}
//Beispiel
docker build -t <benutzername>/<repositoryname> .

docker build -t benutzer/asposefunction .
{{< /highlight >}}
 
Beim ersten Ausführen dieses Befehls kann es länger dauern, da Docker die erforderlichen Images herunterladen muss. Nachdem der vorherige Befehl abgeschlossen ist, führen Sie den folgenden Befehl aus, um das Image in den Docker Hub zu pushen:
 
{{< highlight plain >}}
//Beispiel
docker push <benutzername>/<repositoryname>:tagname

docker push benutzer/asposefunction:latest
{{< /highlight >}}

## Azure

1. Anmelden bei Azure.
1. Wählen Sie Azure-Dienste aus.
1. Wählen Sie App Function aus und erstellen Sie eine Funktion.<br>
![Azure-Funktionstasten](create-function.png)<br>
1. Wiederholen Sie die Grundeinstellungen wie im Bild unten.<br>
![Einstellungen zur Erstellung einer Azure-Funktion](create-function-setting.png)<br>
1. Klicken Sie auf 'Überprüfen + erstellen' -> Erstellen.
1. Warten Sie, bis die Bereitstellung abgeschlossen ist.
1. Klicken Sie auf die Schaltfläche 'Gehe zu Ressource'.<br>
![Ressourcenschaltfläche](go-to-resource.png)<br>
1. Stoppen Sie die Funktion aspose-cad-docker-example.<br>
![Container stoppen](stop-container.png)<br>
1. Gehen Sie zum Menü Bereitstellungscenter und treffen Sie die entsprechenden Einstellungen.<br>
![Bereitstellungszentrum](deployment-center.png)<br>
1. Einstellungen speichern
1. Kopieren Sie die Webhook-URL aus den Einstellungen des Bereitstellungscenters.<br>
![Webhook-URL](webhook-url.png)<br>
1. Gehen Sie zu Docker Hub, wählen Sie Ihr Repository aus und wählen Sie Webhooks.
1. Fügen Sie die 'Webhook-URL' von Azure in die Webhook-URL von Docker Hub ein und geben Sie den Namen an.<br>
![Webhook-Einstellungen in Docker](webhook.png)<br>
1. Klicken Sie auf die Schaltfläche Erstellen.
1. Kehren Sie zur Übersicht der Azure-Funktion zurück und starten Sie den Container.<br>
![Übersichtsmenü](overview.png)<br>

## Ausführungsbeispiel

1. Postman-Einstellungen.<br>
![Übersichtsmenü](postman-settings.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei.
1. Klicken Sie auf die Schaltfläche Senden.

{{% alert color="primary" %}} 
Wenn die Antwort erfolgreich ist, klicken Sie auf "In Datei speichern" und Sie erhalten die konvertierte Datei im PNG-Format
{{% /alert %}}

## Weitere Beispiele

Für weitere Beispiele, wie Sie Aspose.CAD in Docker verwenden können, siehe die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Siehe auch

- [Installieren von Docker Desktop unter Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installieren von Docker Desktop auf Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Zu Linux-Containern wechseln](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) Option
- Zusätzliche Informationen zum [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
