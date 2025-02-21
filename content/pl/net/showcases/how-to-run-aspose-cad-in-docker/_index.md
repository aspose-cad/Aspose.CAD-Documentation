---
title: Jak uruchomić Aspose.CAD w Dockerze
type: docs
description: "Uruchom Aspose.CAD w kontenerze Docker na systemach Linux, Windows Server i innych systemach operacyjnych."
weight: 71
url: /pl/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Wymagania wstępne
- Docker musi być zainstalowany na twoim systemie. Aby uzyskać informacje na temat instalacji Dockera na Windows lub Mac, zapoznaj się z linkami w sekcji "Zobacz także".
- Visual Studio 2022.
- W przykładzie użyto .NET 6 SDK.

## Aplikacja Hello World

W tym przykładzie utworzysz prostą aplikację konsolową Hello World, która rysuje elipsę i zapisuje ją jako obraz. Aplikację można zbudować i uruchomić w Dockerze.

## Tworzenie aplikacji konsolowej

Aby utworzyć program Hello World, wykonaj poniższe kroki:
1. Po zainstalowaniu Dockera upewnij się, że używa kontenerów Linux (domyślnie). W razie potrzeby wybierz opcję Przełącz na kontenery Linux z menu Docker Desktops.
1. W Visual Studio utwórz aplikację konsolową .NET 6.<br>
![Okno dialogowe projektu aplikacji konsolowej .NET 6](/_assets/showcases/docker/1.png)<br>
1. Zainstaluj najnowszą wersję Aspose.CAD z NuGet.<br>
![Aspose.CAD na NuGet](/_assets/showcases/docker/2.png)<br>
1. Ponieważ aplikacja będzie uruchamiana na systemie Linux, może być konieczne zainstalowanie dodatkowych czcionek. Możesz zainstalować ttf-mscorefonts-installer.
1. Po dodaniu wszystkich wymaganych zależności napisz prosty program, który tworzy elipsę i zapisuje ją jako obraz:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Zauważ, że folder “TestOut” jest określony jako folder wyjściowy do zapisywania dokumentów wyjściowych. Podczas uruchamiania aplikacji w Dockerze, folder na hoście zostanie podmontowany do tego folderu w kontenerze. Umożliwi to łatwe przeglądanie wyjścia generowanego przez Aspose.CAD w kontenerze Docker.

### Konfigurowanie Dockerfile

 Następnym krokiem jest utworzenie i skonfigurowanie Dockerfile.

1. Utwórz Dockerfile i umieść go obok pliku rozwiązania twojej aplikacji. Zachowaj tę nazwę pliku bez rozszerzenia (domyślnie).
1. W Dockerfile określ:

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

 Powyższy kod to prosty Dockerfile, który zawiera następujące instrukcje:

- Obraz SDK, który ma być użyty. Tutaj jest to obraz .NET 6. Docker pobierze go podczas uruchamiania budowy. Wersja SDK jest określona jako tag.
- Następnie może być konieczne zainstalowanie czcionek, ponieważ obraz SDK zawiera bardzo mało czcionek. Możesz również użyć lokalnych czcionek skopiowanych do obrazu dockerowego.
- Katalog roboczy, który jest określony w następnej linii.
- Komenda do skopiowania wszystkiego do kontenera, publikacji aplikacji i określenia punktu wejścia.

## Budowanie i uruchamianie aplikacji w Dockerze
 
 Teraz aplikacja może być zbudowana i uruchomiona w Dockerze. Otwórz preferowany wiersz poleceń, zmień katalog na folder z aplikacją (folder, w którym znajdują się plik rozwiązania i Dockerfile) i uruchom następującą komendę:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 Przy pierwszym uruchomieniu tej komendy może to potrwać dłużej, ponieważ Docker musi pobrać wymagane obrazy. Gdy poprzednia komenda zostanie zakończona, uruchom następującą komendę:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Zwróć uwagę na argument montowania, ponieważ, jak już wspomniano, folder na hoście jest podmontowany do folderu kontenera, aby łatwo zobaczyć wyniki wykonania aplikacji. Ścieżki w systemie Linux są wrażliwe na wielkość liter.
{{% /alert %}}

## Więcej przykładów

Aby zobaczyć więcej przykładów użycia Aspose.CAD w Dockerze, zapoznaj się z [przykładami](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zobacz także

- [Instalacja Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalacja Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Przełącz na kontenery Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opcja
- Dodatkowe informacje o [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
