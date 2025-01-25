---
title: So führen Sie das Aspose.CAD Docker-Image in Google Cloud aus
type: docs
description: "Führen Sie das Aspose.CAD Docker-Image in Google Cloud aus."
weight: 75
url: /de/net/how-to-run-aspose-cad-docker-image-in-google-cloud
---

## Voraussetzungen

- Docker muss auf Ihrem System installiert sein. Informationen zur Installation von Docker unter Windows oder Mac finden Sie in den Links im Abschnitt „Siehe auch“.
- Visual Studio 2022.
- Google CLI.
- NET Core 3.1 SDK wird im Beispiel verwendet.
- Postman

## Google Cloud Run Funktion

Cloud Run ist eine vollständig verwaltete Compute-Umgebung zum Bereitstellen und Skalieren serverloser HTTP-Container, ohne sich um die Bereitstellung von Maschinen, die Konfiguration von Clustern oder das automatische Skalieren kümmern zu müssen.

- Kein Anbieter-Lock-in - Da Cloud Run standardisierte OCI-Container verwendet und die Standard-Knative Serving API implementiert, können Sie Ihre Anwendungen problemlos in lokale oder andere Cloud-Umgebungen portieren.
- Schnelles automatisches Skalieren - Mikrodienste, die in Cloud Run bereitgestellt werden, skalieren automatisch basierend auf der Anzahl der eingehenden Anfragen, ohne dass Sie einen vollwertigen Kubernetes-Cluster konfigurieren oder verwalten müssen. Cloud Run skaliert auf null, das heißt, es werden keine Ressourcen verwendet, wenn es keine Anfragen gibt.
- Verkehr aufteilen - Cloud Run ermöglicht es Ihnen, den Verkehr zwischen mehreren Revisionen aufzuteilen, sodass Sie schrittweise Rollouts wie Canary-Bereitstellungen oder Blue/Green-Bereitstellungen durchführen können.
- Benutzerdefinierte Domains - Sie können in Cloud Run eine benutzerdefinierte Domain-Zuordnung einrichten, und es wird ein TLS-Zertifikat für Ihre Domain bereitgestellt.
- Automatische Redundanz - Cloud Run bietet automatische Redundanz, sodass Sie sich keine Sorgen machen müssen, mehrere Instanzen für hohe Verfügbarkeit zu erstellen.

Cloud Run und Cloud Functions sind beide vollständig verwaltete Dienste, die auf der serverlosen Infrastruktur von Google Cloud ausgeführt werden, automatisch skalieren und HTTP-Anfragen oder Ereignisse verarbeiten. Sie haben jedoch einige wichtige Unterschiede:

- Cloud Functions ermöglicht es Ihnen, Code-Snippets (Funktionen) in einer begrenzten Anzahl von Programmiersprachen bereitzustellen, während Cloud Run es Ihnen ermöglicht, Container-Images mit der Programmiersprache Ihrer Wahl bereitzustellen.
- Cloud Run unterstützt auch die Verwendung von beliebigen Tools oder Systembibliotheken aus Ihrer Anwendung; Cloud Functions erlaubt es nicht, benutzerdefinierte ausführbare Dateien zu verwenden.
- Cloud Run bietet eine längere Zeitüberschreitung für Anfragen von bis zu 60 Minuten, während bei Cloud Functions die Zeitüberschreitung für Anfragen auf maximal 9 Minuten eingestellt werden kann.
- Cloud Functions sendet nur eine Anfrage gleichzeitig an jede Funktionsinstanz, während Cloud Run standardmäßig so konfiguriert ist, dass mehrere gleichzeitige Anfragen an jede Containerinstanz gesendet werden. Dies ist hilfreich, um die Latenz zu verbessern und Kosten zu reduzieren, wenn Sie mit hohen Volumina rechnen.

## Erstellen des Google Cloud Function-Projekts

{{% alert color="primary" %}} 
Stellen Sie sicher, dass Sie über ausreichende Rechte verfügen, um Google Cloud Run-Funktionen und -Images im Artifact Registry-Repository zu erstellen.
{{% /alert %}}

Um das Google Cloud Function-Programm zu erstellen, befolgen Sie die folgenden Schritte:

1. Installieren Sie das .NET Core SDK 3.1.
1. Installieren Sie das Vorlagenpaket:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Erstellen Sie als Nächstes ein Verzeichnis für Ihr Projekt und verwenden Sie dotnet new, um eine neue HTTP-Funktion zu erstellen:
{{< highlight plain >}}
mkdir AsposeFunctions //Ordner erstellen
cd AsposeFunctions //Zum Ordner AsposeFunctions wechseln
dotnet new gcf-http //Google Cloud Function-Projekt mit HTTP-Trigger erstellen
{{< /highlight >}}
{{% alert color="primary" %}} 
Dies erstellt AsposeFunctions.csproj und Function.cs im aktuellen Verzeichnis. Öffnen Sie Function.cs, um den Code zu überprüfen, und geben Sie eine benutzerdefinierte Nachricht ein, wenn Sie möchten.
{{% /alert %}}
1. Codebeispiel für die csproj-Datei (AsposeFunctions.csproj).
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
1. Codebeispiel für die Konvertierung von CAD-Bildern in PNG-Dateien (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logik für Ihre Funktion befindet sich hier.
        /// </summary>
        /// <param name="context">Der HTTP-Kontext, der die Anfrage und die Antwort enthält.</param>
        /// <returns>Eine Aufgabe, die die asynchrone Operation darstellt.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //Formular-Datei
                var file = context.Request.Body; //binäre Daten
                
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
1. Bauen Sie Ihre Funktion lokal wie folgt:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Sobald der Server läuft, rufen Sie http://localhost:8080 auf, um die Funktion aufzurufen. Drücken Sie Strg-C in der Konsole, um den Server zu stoppen.

## Docker-Image in Google Cloud bereitstellen

1. Melden Sie sich bei Google Cloud an.
1. Erstellen Sie ein Projekt, falls es nicht existiert.
1. Gehen Sie zu 'Artifact Registry' und erstellen Sie ein Repository.<br>
![Artifact-Repository erstellen](create-artifact-repository.png)<br>
1. Wählen Sie das neue Repository im Artifact Registry aus.
![Artifact-Repository auswählen](select-artifact.png)<br>
1. Klicken Sie auf 'EINRICHTUNGSANWEISUNG' und kopieren Sie den Befehl 'Docker konfigurieren'.<br>
![EINRICHTUNGSANWEISUNG](setup-instruction.png)<br>
1. Fügen Sie einen Docker-Credential-Helfer-Eintrag zur Konfigurationsdatei von Docker hinzu oder erstellen Sie die Datei, falls sie nicht vorhanden ist.
{{< highlight plain >}}
//Beispiel
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Erstellen Sie eine Dockerfile im Stammverzeichnis des Projekts und bearbeiten Sie die Dockerfile wie im Abschnitt <a href="#configuring-a-dockerfile">Konfiguration einer Dockerfile</a>.
1. Starten Sie Docker Desktop.
1. Erstellen Sie das Docker-Image mit dem Pfad zum Cloud-Repository.
{{< highlight plain >}}
//Beispiel
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Pushen Sie das Image in das Google Cloud Artifact Registry
{{< highlight plain >}}
//Beispiel
docker push {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Cloud Run-Dienst erstellen 

1. Gehen Sie zu Cloud Run.
1. Erstellen Sie den Cloud Run-Dienst.<br>
![Cloud Run-Dienst erstellen](create-cloud-run-service.png)<br>
1. Wählen Sie im Feld Container-Image-URL das Container-Image aus 'ARTIFACT REGISTRY'.<br>
![Container-Image-URL](container-url.png)<br>
1. Überprüfen Sie andere Einstellungen wie unten.<br>
![Einstellungen für den Dienst](cloud-run-service-settings.png)<br>
1. Warten Sie, bis die Bereitstellung abgeschlossen ist.
1. Dienst-URL zur Verwendung mit der Konvertierungsanwendung.<br>
![URL-Dienst](url-service.png)<br>

### Konfiguration einer Dockerfile

Der nächste Schritt besteht darin, die Dockerfile im Projekt zu konfigurieren.

1. Geben Sie in der Dockerfile an:

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

Das obige ist eine einfache Dockerfile, die die folgenden Anweisungen enthält:

- Das verwendete SDK-Image. Hier ist es das Net Core 3.1-Image. Docker wird es herunterladen, wenn der Build ausgeführt wird. Die Version des SDK wird als Tag angegeben.
- Danach müssen Sie möglicherweise Schriftarten installieren, da das SDK-Image nur sehr wenige Schriftarten enthält. Sie können auch lokale Schriftarten verwenden, die in das Docker-Image kopiert werden.
- Das Arbeitsverzeichnis, das in der nächsten Zeile angegeben wird.
- Der Befehl, um alles in den Container zu kopieren, die Anwendung zu veröffentlichen und den Einstiegspunkt anzugeben.

## Ausführungsbeispiel

1. Postman-Einstellungen.<br>
![Übersichtsmenü](postman-settings.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
1. Klicken Sie auf die Schaltfläche "Senden".

{{% alert color="primary" %}} 
Wenn die Antwort erfolgreich ist, klicken Sie auf "In Datei speichern" und Sie erhalten die konvertierte Datei im PNG-Format.
{{% /alert %}}

## Weitere Beispiele

Für weitere Beispiele, wie Sie Aspose.CAD in Docker verwenden können, siehe die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Siehe auch.

- [Installieren Sie Docker Desktop unter Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installieren Sie Docker Desktop auf Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Wechseln zu Linux-Containern](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) Option
- Zusätzliche Informationen zum [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)