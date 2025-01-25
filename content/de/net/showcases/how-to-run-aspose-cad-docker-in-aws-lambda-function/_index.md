---
title: So führen Sie das Aspose.CAD Docker-Image in AWS Lambda-Funktionen aus
type: docs
description: "Führen Sie das Aspose.CAD Docker-Image in AWS Lambda-Funktionen aus."
weight: 74
url: /de/net/how-to-run-aspose-cad-docker-image-in-aws-lambda-function
---

## Voraussetzungen
- Docker muss auf Ihrem System installiert sein. Informationen zur Installation von Docker unter Windows oder Mac finden Sie in den Links im Abschnitt „Siehe auch“.
- Visual Studio 2022.
- AWS-Toolkit für Visual Studio 2022.
- .NET 6 SDK wird im Beispiel verwendet.
- Postman

## AWS Lambda-Funktion

Lambda ist ein Rechenservice, der es Ihnen ermöglicht, Code auszuführen, ohne Server bereitzustellen oder zu verwalten. Lambda führt Ihren Code auf einer hochverfügbaren Compute-Infrastruktur aus und übernimmt die gesamte Verwaltung der Compute-Ressourcen, einschließlich Server- und Betriebssystemwartung, Kapazitätsbereitstellung und automatische Skalierung sowie Protokollierung. Mit Lambda können Sie Code für nahezu jede Art von Anwendung oder Backend-Service ausführen.

## Erstellen der AWS Lambda-Funktion

{{% alert color="primary" %}} 
Stellen Sie sicher, dass Sie über ausreichende Berechtigungen zum Erstellen von AWS Lambda-Funktionen und -Images im Amazon Elastic Container Registry verfügen.
{{% /alert %}}

Um das AWS Lambda-Funktionsprogramm zu erstellen, befolgen Sie die folgenden Schritte:
1. Erstellen Sie ein AWS Lambda-Projekt.<br>
![AWS-Funktion erstellen](create-project.png)<br>
1. Wählen Sie .NET 6 (Container-Image) aus und klicken Sie auf die Schaltfläche 'Fertigstellen'.<br>
![Container-Funktion erstellen](create-container.png)<br>
1. Öffnen Sie AWS Explorer in Visual Studio (Ansicht->AWS Explorer).
1. Fügen Sie ein AWS-Credentials-Profil im AWS Explorer hinzu.<br>
![Anmeldeprofil](add-aws-credentials-profile.png)<br>
1. Geben Sie die Access Key ID und den Secret Access Key ein. Diese Schlüssel können Sie in den Sicherheitsanmeldeinformationen erhalten oder den Administrator kontaktieren, um eine CSV-Datei zur Autorisierung zu erhalten.<br>
![Kontoprofileinstellungen](account-profile.png)<br>
1. Installieren Sie die neuesten Bibliotheken von NuGet.<br>
![NuGet-Manager](nuget-manager.png)<br>
1. Beispielcode zum Konvertieren von CAD-Bildern in PDF-Dateien.
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
1. Bearbeiten Sie die Dockerfile wie im Abschnitt <a href="#configuring-a-dockerfile">Konfigurieren einer Dockerfile</a>.
1. Starten Sie Docker Desktop.
1. Veröffentlichen Sie die AWS Lambda.<br>
![AWS Lambda veröffentlichen](publish-aws.png)<br>
1. Bearbeiten Sie die Upload-Konfiguration.<br>
![Upload AWS Lambda](upload-aws-lambda.png)<br>
1. Klicken Sie auf die Schaltfläche 'Hochladen'.<br>
![Upload AWS Lambda abschließen](upload-aws-lambda-finish.png)<br>
1. Gehen Sie zu AWS und wählen Sie Lambda aus.<br>
![AWS Lambda](select-aws-lambda.png)<br>
1. Wählen Sie Ihre neue Funktion aus und erstellen Sie eine URL-Funktion.<br>
![Konfiguration URL-Funktion](create-function-url.png)<br>
1. Wählen Sie den Authentifizierungstyp aus
- AWS_IAM - Nur authentifizierte IAM-Benutzer und -Rollen können Anfragen an Ihre Funktions-URL stellen.
- NONE - Lambda führt keine IAM-Authentifizierung für Anfragen an die Funktion-URL durch. Der URL-Endpunkt wird öffentlich, es sei denn, Sie implementieren Ihre eigene Autorisierungslogik in Ihrer Funktion.

### Konfigurieren einer Dockerfile

Der nächste Schritt besteht darin, die Dockerfile im Projekt zu konfigurieren.

1. Geben Sie in der Dockerfile Folgendes an:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

Das obige ist eine einfache Dockerfile, die die folgenden Anweisungen enthält:

- Das SDK-Image, das verwendet werden soll. Hier handelt es sich um das .NET 6-Image. Docker lädt es herunter, wenn der Build ausgeführt wird. Die Version des SDK wird als Tag angegeben.
- Danach müssen Sie möglicherweise Schriftarten installieren, da das SDK-Image sehr wenige Schriftarten enthält. Außerdem können Sie lokale Schriftarten verwenden, die in das Docker-Image kopiert wurden.
- Das Arbeitsverzeichnis, das in der nächsten Zeile angegeben ist.
- Der Befehl, um alles in den Container zu kopieren, die Anwendung zu veröffentlichen und den Einstiegspunkt anzugeben.

## Ausführungsbeispiel

1. Postman-Einstellungen.<br>
![Kursübersicht](postman-settings.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF- oder SVG-Datei aus.
1. Klicken Sie auf die Schaltfläche Senden.

{{% alert color="primary" %}} 
Wenn die Antwort erfolgreich ist, klicken Sie auf „In Datei speichern“ und Sie erhalten die konvertierte Datei im PDF-Format.
{{% /alert %}}

## Weitere Beispiele

Für weitere Beispiele, wie Sie Aspose.CAD in Docker verwenden können, siehe die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Siehe auch.

- [Installieren Sie das AWS Toolkit für Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Installieren Sie Docker Desktop unter Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installieren Sie Docker Desktop auf Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Wechseln zu Linux-Containern](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) Option
- Zusätzliche Informationen zum [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
