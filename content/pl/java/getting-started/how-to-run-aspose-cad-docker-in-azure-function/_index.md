---
title: Jak uruchomić obraz Docker Aspose.CAD w Azure Function
type: docs
description: "Uruchom obraz Docker Aspose.CAD w Azure Function."
weight: 71
url: /pl/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Wymagania wstępne
- Docker musi być zainstalowany na twoim systemie. Aby uzyskać informacje, jak zainstalować Docker na Windows lub Mac, odwołaj się do linków w sekcji „Zobacz także”.
- IntelliJ IDEA.
- Azure Toolkit dla IntelliJ.
- Postman.

## Azure Function

W tym przykładzie tworzysz prostą funkcję konwersji, która konwertuje plik CAD i zapisuje go jako obraz. Następnie aplikację można zbudować w Dockerze i uruchomić w Azure Function.

## Tworzenie funkcji Azure

Aby utworzyć program funkcji Azure, wykonaj poniższe kroki:
1. Po zainstalowaniu Dockera upewnij się, że używa kontenerów Linux (domyślnie). W razie potrzeby wybierz opcję Przełącz do kontenerów Linux z menu Docker Desktop.
1. Utwórz projekt funkcji Azure w IntelliJ IDEA.<br>
![Utwórz projekt funkcji Azure](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![Utwórz projekt końcowy funkcji Azure](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Narzędzia->Azure->Zaloguj się i wybierz uwierzytelnianie OAuth 2.0.<br>
![Zaloguj się do Azure](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. Zaloguj się w przeglądarce.
1. Wybierz nazwę subskrypcji.
1. Dodaj wsparcie dla Dockera.<br>
![Zaloguj się do Azure](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. Edytuj plik DockerFile jak w sekcji <a href="#configuring-a-dockerfile">Konfiguracja Dockerfile</a>.
1. Dodaj bloki dla repozytorium aspose.cad w pom.xml.
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

1. Gdy wszystkie wymagane zależności są dodane, napisz prosty program, który tworzy elipsę i zapisuje ją jako obraz:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Ta funkcja nasłuchuje na punkcie końcowym "/api/HttpExample". Dwa sposoby na jej wywołanie za pomocą polecenia "curl" w bash:
     * 1. curl -d "HTTP Body" {twój host}/api/HttpExample
     * 2. curl "{twój host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger przetworzył żądanie.");

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

### Konfiguracja Dockerfile

 Następnym krokiem jest utworzenie i skonfigurowanie Dockerfile w katalogu głównym projektu.

1. W Dockerfile określ:
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

 Powyższy kod to prosty Dockerfile, który zawiera następujące instrukcje:

- Obraz SDK, który ma być używany. Docker pobierze go, gdy zostanie uruchomiona budowa. Wersja SDK jest określona jako tag.
- Katalog roboczy, który jest określony w następnej linii.
- Polecenie do skopiowania wszystkiego do kontenera, opublikowania aplikacji i określenia punktu wejścia.

## Docker Hub
1. Zaloguj się do Docker Hub
1. Utwórz publiczne repozytorium

## Budowanie i uruchamianie aplikacji w Dockerze
 
 Teraz aplikację można zbudować i uruchomić w Dockerze. Otwórz ulubiony terminal, zmień katalog na folder z aplikacją (folder, w którym znajduje się plik rozwiązania i Dockerfile) i uruchom poniższe polecenie:


1. Buduj polecenie dockerfile w konsoli
{{< highlight plain >}}
//przykład
docker build -t <nazwa użytkownika>/<nazwa repozytorium> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Przy pierwszym uruchomieniu tego polecenia może to potrwać dłużej, ponieważ Docker musi pobrać niezbędne obrazy. Po zakończeniu poprzedniego polecenia uruchom następujące polecenie, aby przesłać obraz do docker hub.
{{< highlight plain >}}
//przykład
docker push <nazwa użytkownika>/<nazwa repozytorium>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Uruchom dockerfile w IDE, a następnie przesyłaj do docker hub.<br>
![Uruchom docker w ide](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Wprowadź nazwę obrazu, jak w repozytorium Docker Hub.<br>
![Uruchom docker w ide-następnie](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Czekaj na zakończenie.

## Azure

1. Zaloguj się do Azure.
1. Wybierz usługi Azure.
1. Wybierz aplikację funkcji i utwórz funkcję.<br>
![Przycisk utworzenia funkcji Azure](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. Powtórz podstawowe ustawienia, jak na obrazku poniżej.<br>
![Ustawienia funkcji Azure](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. Kliknij 'Przejrzyj + utwórz' -> Utwórz.
1. Poczekaj na zakończenie wdrażania.
1. Kliknij przycisk 'Przejdź do zasobu'.<br>
![Przycisk zasobu](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. Zatrzymaj funkcję aspose-cad-docker-example.<br>
![Zatrzymaj kontener](/cad/_assets/java/java-azure/stop-container.png)<br>
1. Przejdź do menu centrum wdrożeń i wprowadź odpowiednie ustawienia.<br>
![Centrum wdrożeń](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. Zapisz ustawienia
1. Skopiuj URL webhooka z ustawień centrum wdrożenia.<br>
![URL webhooka](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. Przejdź do Docker Hub, wybierz swoje repozytorium i wybierz webhooki.
1. Wklej 'URL webhooka' z Azure do URL webhooka Docker Hub i ustaw nazwę.<br>
![Ustawienia webhooka w docker](/cad/_assets/java/java-azure/webhook.png)<br>
1. Kliknij przycisk stwórz.
1. Wraca do przeglądu funkcji azure i uruchom kontener.<br>
![Menu przeglądu](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Może to potrwać kilka minut, zanim funkcja się uruchomi.
{{% /alert %}}

## Przykład wykonania

1. Ustawienia Postmana.<br>
![Menu przeglądu](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, plik SVG.
1. Kliknij przycisk wyślij.
1. Zapisz wynik
![Zapisz odpowiedź](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Jeśli odpowiedź jest pomyślna, kliknij Zapisz do pliku, a otrzymasz przekonwertowany plik w formacie png
{{% /alert %}}

## Więcej przykładów

Aby uzyskać więcej przykładów, jak można używać Aspose.CAD w Dockerze, zobacz [przykłady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zobacz także

- [Zainstaluj Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Zainstaluj Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Przełącz do kontenerów Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opcja
