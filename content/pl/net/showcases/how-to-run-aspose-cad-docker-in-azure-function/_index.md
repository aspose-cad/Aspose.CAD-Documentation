---
title: Jak uruchomić obraz Docker Aspose.CAD w funkcji Azure
type: docs
description: "Uruchom obraz Docker Aspose.CAD w funkcji Azure."
weight: 73
url: /pl/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Wymagania wstępne
- Docker musi być zainstalowany na twoim systemie. Aby uzyskać informacje na temat instalacji Dockera na Windows lub Mac, zapoznaj się z linkami w sekcji „Zobacz także”.
- Visual Studio 2022.
- W przykładzie używany jest SDK .NET 6.
- Postman

## Funkcja Azure

W tym przykładzie tworzysz prostą funkcję konwersji, która konwertuje plik CAD i zapisuje go jako obraz. Aplikację można zbudować w Dockerze i uruchomić w funkcji Azure.

## Tworzenie funkcji Azure

Aby utworzyć program funkcji Azure, wykonaj poniższe kroki:
1. Po zainstalowaniu Dockera upewnij się, że używa kontenerów Linux (domyślnie). W razie potrzeby wybierz opcję Przełącz na kontenery Linux z menu Dockera Desktop.
1. W Visual Studio utwórz funkcję Azure dla .NET 6.<br>
![Dialog projektu funkcji Azure dla .NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Dodatkowe informacje.<br>
![Dialog projektu funkcji Azure dla .NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Zainstaluj najnowszą wersję Aspose.CAD z NuGet.<br>
![Aspose.CAD na NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Ponieważ aplikacja będzie uruchamiana na Linuxie, może być konieczne zainstalowanie dodatkowych czcionek. Możesz preferować ttf-mscorefonts-installer.
1. Po dodaniu wszystkich wymaganych zależności napisz prosty program, który tworzy elipsę i zapisuje ją jako obraz:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Funkcja wyzwalania HTTP w C# przetworzyła żądanie.");
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

### Konfigurowanie pliku Dockerfile

Kolejnym krokiem jest utworzenie i skonfigurowanie pliku Dockerfile w głównym folderze projektu.

1. Utwórz plik Dockerfile i umieść go obok pliku rozwiązań swojej aplikacji. Zachowaj tę nazwę pliku bez rozszerzenia (domyślnie).
![Główny folder projektu](/cad/_assets/showcases/azure/root-folder.png)<br>
1. W pliku Dockerfile, określ:


{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll
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

Powyższy plik Dockerfile jest prosty i zawiera następujące instrukcje:

- Używany obraz SDK. Tutaj jest to obraz .NET 6. Docker pobierze go podczas uruchamiania budowy. Wersja SDK jest określona jako tag.
- Następnie może być konieczne zainstalowanie czcionek, ponieważ obraz SDK zawiera bardzo mało czcionek. Możesz także użyć lokalnych czcionek skopiowanych do obrazu dockera.
- Katalog roboczy, który jest określony w następnej linii.
- Komenda do skopiowania wszystkiego do kontenera, opublikowania aplikacji i określenia punktu wejścia.

## Docker Hub
1. Zaloguj się na Docker Hub
1. Utwórz publiczne repozytorium

## Budowanie i uruchamianie aplikacji w Docker

Teraz aplikację można zbudować i uruchomić w Dockerze. Otwórz ulubiony wiersz poleceń, przejdź do folderu z aplikacją (folder, w którym znajduje się plik rozwiązań i plik Dockerfile) i uruchom następujące polecenie:

{{< highlight plain >}}
//przykład
docker build -t <nazwa użytkownika>/<nazwa repozytorium> .

docker build -t użytkownik/asposefunction .
{{< /highlight >}}

Pierwszy raz, gdy uruchomisz to polecenie, może zająć więcej czasu, ponieważ Docker musi pobrać niezbędne obrazy. Po zakończeniu poprzedniego polecenia uruchom następujące polecenie, aby przesłać obraz do docker hub:

{{< highlight plain >}}
//przykład
docker push <nazwa użytkownika>/<nazwa repozytorium>:tagname

docker push użytkownik/asposefunction:latest
{{< /highlight >}}

## Azure

1. Zaloguj się do Azure.
1. Wybierz usługi Azure.
1. Wybierz aplikację funkcji i utwórz funkcję.<br>
![Przycisk utwórz funkcję Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Powtórz podstawowe ustawienia jak na obrazku poniżej.<br>
![Ustawienia utworzenia funkcji Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Kliknij 'Przejrzyj + utwórz' -> Utwórz.
1. Poczekaj na zakończenie wdrażania.
1. Kliknij przycisk 'Przejdź do zasobu'.<br>
![Przycisk zasobu](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Zatrzymaj funkcję aspose-cad-docker-example.<br>
![Zatrzymaj kontener](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Przejdź do menu centrum wdrażania i wprowadź odpowiednie ustawienia.<br>
![Centrum wdrażania](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Zapisz ustawienia
1. Skopiuj adres URL webhooka z ustawień centrum wdrażania.<br>
![Adres URL webhooka](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Przejdź do Docker Hub, wybierz swoje repozytorium i wybierz webhooks.
1. Wklej 'Adres URL webhooka' z Azure do adresu URL webhooka Docker Hub i ustaw nazwę.<br>
![Ustawienia webhooka w dockerze](/cad/_assets/showcases/azure/webhook.png)<br>
1. Kliknij przycisk utwórz.
1. Wróć do przeglądu funkcji Azure i uruchom kontener.<br>
![Menu przeglądu](/cad/_assets/showcases/azure/overview.png)<br>

## Przykład wykonania

1. Ustawienia Postmana.<br>
![Menu przeglądu](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Kliknij przycisk wyślij.

{{% alert color="primary" %}} 
Jeśli odpowiedź jest pomyślna, kliknij Zapisz do pliku, a otrzymasz przekonwertowany plik w formacie png
{{% /alert %}}

## Więcej przykładów

Aby uzyskać więcej próbek pokazujących, jak można używać Aspose.CAD w Dockerze, zobacz [przykłady](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zobacz także

- [Zainstaluj Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Zainstaluj Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Przełącz na kontenery Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opcja
- Dodatkowe informacje na temat [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
