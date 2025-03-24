---
title: Come Eseguire Aspose.CAD in Docker
type: docs
description: "Esegui Aspose.CAD in un contenitore Docker per Linux, Windows Server e qualsiasi OS."
weight: 71
url: /it/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Prerequisiti
- Docker deve essere installato sul tuo sistema. Per informazioni su come installare Docker su Windows o Mac, fare riferimento ai collegamenti nella sezione "Vedi Anche".
- Visual Studio 2022.
- NET 6 SDK è utilizzato nell'esempio.

## Applicazione Hello World

In questo esempio, crei una semplice applicazione console Hello World che disegna un'ellisse e la salva come immagine. L'applicazione può quindi essere compilata ed eseguita in Docker.

## Creazione dell'Applicazione Console

Per creare il programma Hello World, segui i passaggi qui sotto:
1. Una volta installato Docker, assicurati che utilizzi i contenitori Linux (predefinito). Se necessario, seleziona l'opzione Passa a contenitori Linux dal menu di Docker Desktop.
1. In Visual Studio, crea un'applicazione console NET 6.<br>
![Un dialogo del progetto dell'applicazione console NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. Installa l'ultima versione di Aspose.CAD da NuGet.<br>
![Aspose.CAD su NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. Poiché l'applicazione verrà eseguita su Linux, potrebbe essere necessario installare font aggiuntivi. Potresti preferire ttf-mscorefonts-installer.
1. Quando tutte le dipendenze richieste sono state aggiunte, scrivi un semplice programma che crea un'ellisse e la salva come immagine:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Nota che la cartella "TestOut" è specificata come cartella di output per il salvataggio dei documenti generati. Quando esegui l'applicazione in Docker, una cartella sulla macchina host verrà montata a questa cartella nel contenitore. Questo ti permetterà di visualizzare facilmente l'output generato da Aspose.CAD nel contenitore Docker.

### Configurazione di un Dockerfile

Il passo successivo è creare e configurare il Dockerfile.

1. Crea il Dockerfile e posizionalo accanto al file di soluzione della tua applicazione. Mantieni questo nome di file senza estensione (il predefinito).
1. Nel Dockerfile, specifica:


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
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

Quello sopra è un Dockerfile semplice, che contiene le seguenti istruzioni:

- L'immagine SDK da utilizzare. Qui è l'immagine Net 6. Docker la scaricherà quando verrà eseguita la build. La versione dell'SDK è specificata come tag.
- Dopo, potrebbe essere necessario installare i font perché l'immagine SDK contiene pochissimi font. Inoltre, puoi utilizzare font locali copiati nell'immagine docker.
- La directory di lavoro, che è specificata nella riga successiva.
- Il comando per copiare tutto nel contenitore, pubblicare l'applicazione e specificare il punto di ingresso.

## Compilazione ed Esecuzione dell'Applicazione in Docker

Ora l'applicazione può essere compilata ed eseguita in Docker. Apri il tuo prompt dei comandi preferito, cambia la directory nella cartella con l'applicazione (cartella in cui si trova il file di soluzione e il Dockerfile) ed esegui il seguente comando:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

La prima volta che questo comando viene eseguito, potrebbe richiedere più tempo, poiché Docker deve scaricare le immagini necessarie. Una volta completato il comando precedente, esegui il seguente comando:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Fai attenzione all'argomento di mount, perché, come accennato in precedenza, una cartella sulla macchina host è montata nella cartella del contenitore, per vedere facilmente i risultati dell'esecuzione dell'applicazione. I percorsi in Linux sono case sensitive.
{{% /alert %}}

## Ulteriori Esempi

Per ulteriori esempi su come puoi utilizzare Aspose.CAD in Docker, vedere gli [esempi](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Vedi Anche

- [Installa Docker Desktop su Windows](https://docs.docker.com/docker-for-windows/install/)
- [Installa Docker Desktop su Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Opzione [Passa a contenitori Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Informazioni aggiuntive su [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
