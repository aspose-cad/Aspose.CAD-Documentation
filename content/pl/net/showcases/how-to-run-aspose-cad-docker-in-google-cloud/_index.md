---
title: Jak uruchomić obraz Dockera Aspose.CAD w Google Cloud
type: docs
description: "Uruchom obraz Dockera Aspose.CAD w Google Cloud."
weight: 75
url: /pl/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Wymagania wstępne

- Docker musi być zainstalowany na twoim systemie. Aby uzyskać informacje na temat instalacji Dockera na systemie Windows lub Mac, zapoznaj się z linkami w sekcji „Zobacz także”.
- Visual Studio 2022.
- Google CLI.
- W przykładzie użyto SDK .NET Core 3.1.
- Postman

## Funkcja Google Cloud Run

Cloud Run to w pełni zarządzane środowisko obliczeniowe do wdrażania i skalowania serwerlessowych kontenerów HTTP bez martwienia się o provisionowanie maszyn, konfigurowanie klastrów czy autoskalowanie.

- Brak uzależnienia od dostawcy - Ponieważ Cloud Run wykorzystuje standardowe kontenery OCI i wdraża standardowe API Knative Serving, możesz łatwo przenieść swoje aplikacje do lokalnego środowiska lub innej chmury. 
- Szybkie autoskalowanie - Mikrousługi wdrożone w Cloud Run automatycznie skalują się w zależności od liczby przychodzących żądań, bez konieczności konfigurowania ani zarządzania pełnoprawnym klastrem Kubernetes. Cloud Run skaluję się do zera — to znaczy, że nie wykorzystuje żadnych zasobów — jeśli nie ma żądań.
- Rozdzielanie ruchu - Cloud Run umożliwia rozdzielanie ruchu pomiędzy wieloma wersjami, co pozwala na stopniowe wdrożenia, takie jak wdrożenia kanarka czy blue/green.
- Niestandardowe domeny - Możesz skonfigurować mapowanie niestandardowej domeny w Cloud Run, a on przydzieli certyfikat TLS dla tej domeny. 
- Automatyczna redundancja - Cloud Run oferuje automatyczną redundancję, więc nie musisz się martwić o tworzenie wielu instancji w celu zapewnienia wysokiej dostępności.

Cloud Run i Cloud Functions to w pełni zarządzane usługi, które działają na serwerlessowej infrastrukturze Google Cloud, automatycznie skalują się i obsługują żądania HTTP lub zdarzenia. Mają jednak kilka ważnych różnic:

- Cloud Functions pozwala na wdrażanie fragmentów kodu (funkcji) napisanych w ograniczonej liczbie języków programowania, podczas gdy Cloud Run pozwala na wdrażanie obrazów kontenerów przy użyciu języka programowania według wyboru. 
- Cloud Run obsługuje również użycie dowolnego narzędzia lub biblioteki systemowej z twojej aplikacji; Cloud Functions nie pozwala na używanie niestandardowych wykonywalnych. 
- Cloud Run oferuje dłuższy czas oczekiwania na żądania, wynoszący do 60 minut, podczas gdy w Cloud Functions maksymalny czas oczekiwania na żądanie można ustawić na maksymalnie 9 minut. 
- Cloud Functions przesyła tylko jedno żądanie na raz do każdej instancji funkcji, podczas gdy domyślnie Cloud Run jest skonfigurowany do wysyłania wielu równoczesnych żądań do każdej instancji kontenera. Pomaga to poprawić opóźnienia i zmniejszyć koszty w przypadku dużego obciążenia. 

## Tworzenie projektu funkcji Google Cloud

{{% alert color="primary" %}} 
Upewnij się, że masz wystarczające uprawnienia do tworzenia funkcji Google Cloud Run oraz obrazów w repozytorium Artifact Registry.
{{% /alert %}}

Aby utworzyć program funkcji Google Cloud, wykonaj poniższe kroki:

1. Zainstaluj SDK .NET Core 3.1.
1. Zainstaluj pakiet szablonów:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Następnie utwórz katalog dla swojego projektu i użyj polecenia dotnet new do utworzenia nowej funkcji HTTP:
{{< highlight plain >}}
mkdir AsposeFunctions //utwórz folder
cd AsposeFunctions //przejdź do folderu AsposeFunctions
dotnet new gcf-http //utwórz projekt funkcji Google Cloud z wyzwalaczem http
{{< /highlight >}}
{{% alert color="primary" %}} 
To tworzy pliki AsposeFunctions.csproj i Function.cs w bieżącym katalogu. Otwórz Function.cs, aby zapoznać się z kodem, i podaj niestandardową wiadomość, jeśli chcesz.
{{% /alert %}}
1. Przykład kodu dla pliku csproj (AsposeFunctions.csproj).
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
1. Przykład kodu dla konwersji obrazu CAD do pliku PNG (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logika funkcji znajduje się tutaj.
        /// </summary>
        /// <param name="context">Kontext HTTP, zawierający żądanie i odpowiedź.</param>
        /// <returns>Zadanie reprezentujące operację asynchroniczną.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //plik formularza
                var file = context.Request.Body; //dane binarne
                
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
1. Zbuduj swoją funkcję lokalnie w następujący sposób:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Gdy serwer będzie działał, przejdź do http://localhost:8080, aby wywołać funkcję. Naciśnij Ctrl-C w konsoli, aby zatrzymać serwer.

## Wdrażanie obrazu dockera do Google Cloud

1. Zaloguj się do Google Cloud.
1. Utwórz projekt, jeśli jeszcze nie istnieje.
1. Przejdź do 'Artifact Registry' i utwórz repozytorium.<br>
![Utwórz repozytorium artifact](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Wybierz nowe repozytorium w Artifact Registry.
![Wybierz repozytorium artifact](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Kliknij 'INSTRUKCJE DOTYCZĄCE KONFIGURACJI' i skopiuj polecenie 'Skonfiguruj Docker'.<br>
![INSTRUKCJE DOTYCZĄCE KONFIGURACJI](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Dodaj wpis credHelper Dockera do pliku konfiguracyjnego Dockera lub utwórz plik, jeśli nie istnieje.
{{< highlight plain >}}
//przykład
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Utwórz plik Dockerfile w głównym katalogu projektu i edytuj DockerFile jak w sekcji <a href="#configuring-a-dockerfile">Konfigurowanie pliku Dockerfile</a>.
1. Uruchom Docker Desktop.
1. Zbuduj obraz dockera ze ścieżką do repozytorium w chmurze.
{{< highlight plain >}}
//przykład
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Wypchnij obraz do Google Cloud Artifact Registry
{{< highlight plain >}}
//przykład
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Utwórz usługę Google Cloud Run 

1. Przejdź do Cloud Run.
1. Utwórz usługę Cloud Run.<br>
![Utwórz usługę Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. W polu URL obrazu kontenera wybierz kontener z 'REPOZYTORIUM ARTIFAKTÓW'.<br>
![URL obrazu kontenera](/cad/_assets/showcases/google/container-url.png)<br>
1. Sprawdź inne ustawienia jak poniżej.<br>
![Ustawienia usługi](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Poczekaj na zakończenie wdrożenia.
1. URL usługi do współpracy z aplikacją konwersji.<br>
![URL usługi](/cad/_assets/showcases/google/url-service.png)<br>

### Konfigurowanie pliku Dockerfile

 Następny krok to edytowanie pliku Dockerfile w projekcie.

1. W pliku Dockerfile określ:

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

 Powyższy plik Dockerfile jest prostym plikiem, który zawiera następujące instrukcje:

- Obraz SDK, który ma być użyty. Tutaj jest to obraz Net Core 3.1. Docker pobierze go, gdy zostanie uruchomiona kompilacja. Wersja SDK jest określona jako tag.
- Następnie możesz potrzebować zainstalować czcionki, ponieważ obraz SDK zawiera bardzo mało czcionek. Możesz również użyć lokalnych czcionek kopiowanych do obrazu dockera.
- Katalog roboczy, który jest określony w następnej linii.
- Polecenie kopiowania wszystkiego do kontenera, opublikowania aplikacji i określenia punktu wejścia.

## Przykład wykonania

1. Ustawienia Postmana.<br>
![Menu przeglądu](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Kliknij przycisk wyślij.

{{% alert color="primary" %}} 
Jeśli odpowiedź jest sukcesem, kliknij Zapisz do pliku, a otrzymasz przekonwertowany plik w formacie PNG.
{{% /alert %}}

## Więcej przykładów

Aby zobaczyć więcej próbek dotyczących użycia Aspose.CAD w Dockerze, zobacz [przykłady](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Zobacz także.

- [Zainstaluj Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Zainstaluj Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Przełącz na kontenery Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opcja
- Dodatkowe informacje na temat [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
