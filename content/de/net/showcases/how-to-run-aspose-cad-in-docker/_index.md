---
title: So führen Sie Aspose.CAD in Docker aus
type: docs
description: "Führen Sie Aspose.CAD in einem Docker-Container für Linux, Windows Server und jedes Betriebssystem aus."
weight: 71
url: /de/net/showcases/how-to-run-aspose-cad-in-docker
---

## Voraussetzungen
- Docker muss auf Ihrem System installiert sein. Informationen zur Installation von Docker unter Windows oder Mac finden Sie in den Links im Abschnitt „Siehe auch“.
- Visual Studio 2022.
- Das .NET 6 SDK wird im Beispiel verwendet.

## Hello World Anwendung

In diesem Beispiel erstellen Sie eine einfache Hello World Konsolenanwendung, die eine Ellipse zeichnet und sie als Bild speichert. Die Anwendung kann dann in Docker erstellt und ausgeführt werden.

## Erstellen der Konsolenanwendung

Um das Hello World-Programm zu erstellen, folgen Sie den untenstehenden Schritten:
1. Sobald Docker installiert ist, stellen Sie sicher, dass es Linux-Container verwendet (Standard). Wählen Sie gegebenenfalls die Option „Zu Linux-Containern wechseln“ aus dem Menü von Docker Desktop aus.
1. Erstellen Sie in Visual Studio eine .NET 6 Konsolenanwendung.<br>
![Ein NET 6 Konsolenanwendungsprojekt-Dialog](1.png)<br>
1. Installieren Sie die neueste Version von Aspose.CAD von NuGet.<br>
![Aspose.CAD auf NuGet](2.png)<br>
1. Da die Anwendung unter Linux ausgeführt wird, müssen möglicherweise zusätzliche Schriftarten installiert werden. Sie können ttf-mscorefonts-installer bevorzugen.
1. Sobald alle erforderlichen Abhängigkeiten hinzugefügt sind, schreiben Sie ein einfaches Programm, das eine Ellipse erstellt und sie als Bild speichert:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Beachten Sie, dass der Ordner „TestOut“ als Ausgabeordner für das Speichern von Ausgabedokumenten angegeben ist. Wenn Sie die Anwendung in Docker ausführen, wird ein Ordner auf dem Hostrechner in diesen Ordner im Container gemountet. Dadurch können Sie die von Aspose.CAD im Docker-Container generierte Ausgabe problemlos anzeigen.

### Konfigurieren einer Dockerfile

Der nächste Schritt besteht darin, die Dockerfile zu erstellen und zu konfigurieren.

1. Erstellen Sie die Dockerfile und platzieren Sie sie neben der Lösungsdatei Ihrer Anwendung. Behalten Sie diesen Dateinamen ohne Erweiterung (Standard).
1. Geben Sie in der Dockerfile Folgendes an:


{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

Oben ist eine einfache Dockerfile, die die folgenden Anweisungen enthält:

- Das SDK-Bild, das verwendet werden soll. Hier ist es das .NET 6-Bild. Docker wird es herunterladen, wenn der Build ausgeführt wird. Die Version des SDK wird als Tag angegeben.
- Danach müssen möglicherweise Schriftarten installiert werden, da das SDK-Bild nur sehr wenige Schriftarten enthält. Darüber hinaus können Sie lokale Schriftarten verwenden, die in das Docker-Image kopiert wurden.
- Das Arbeitsverzeichnis, das in der nächsten Zeile angegeben wird.
- Der Befehl, um alles in den Container zu kopieren, die Anwendung zu veröffentlichen und den Einstiegspunkt anzugeben.

## Erstellen und Ausführen der Anwendung in Docker
 
Jetzt kann die Anwendung in Docker erstellt und ausgeführt werden. Öffnen Sie Ihre bevorzugte Eingabeaufforderung, wechseln Sie in das Verzeichnis mit der Anwendung (den Ordner, in dem sich die Lösungsdatei und die Dockerfile befinden) und führen Sie den folgenden Befehl aus:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Beim ersten Ausführen dieses Befehls kann es länger dauern, da Docker die erforderlichen Bilder herunterladen muss. Sobald der vorherige Befehl abgeschlossen ist, führen Sie den folgenden Befehl aus:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Achten Sie auf das Mount-Argument, denn wie bereits erwähnt, wird ein Ordner auf dem Host-Rechner in den Ordner des Containers gemountet, um die Ergebnisse der Ausführung der Anwendung leicht sehen zu können. Pfade in Linux sind fallempfindlich.
{{% /alert %}}

## Weitere Beispiele

Für weitere Beispiele, wie Sie Aspose.CAD in Docker verwenden können, siehe die [Beispiele](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Siehe auch

- [Installieren Sie Docker Desktop unter Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installieren Sie Docker Desktop auf Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Wechseln zu Linux-Containern](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) Option
- Zusätzliche Informationen zum [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
