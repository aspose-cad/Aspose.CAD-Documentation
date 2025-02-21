---
title: Jak uruchomić obraz Docker Aspose.CAD w funkcji AWS Lambda
type: docs
description: "Uruchom obraz Docker Aspose.CAD w funkcji AWS Lambda."
weight: 74
url: /pl/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Wymagania wstępne
- Docker musi być zainstalowany w twoim systemie. Aby uzyskać informacje na temat instalacji Docker na Windows lub Mac, zapoznaj się z linkami w sekcji "Zobacz także".
- Visual Studio 2022.
- AWS Toolkit for Visual Studio 2022.
- W przykładzie używany jest pakiet .NET 6 SDK.
- Postman

## Funkcja AWS Lambda

Lambda to usługa obliczeniowa, która pozwala uruchamiać kod bez provisionowania lub zarządzania serwerami. Lambda uruchamia Twój kod na infrastrukturze obliczeniowej o wysokiej dostępności i wykonuje wszystkie zadania administracyjne związane z zasobami obliczeniowymi, w tym konserwację serwerów i systemu operacyjnego, provisionowanie pojemności i automatyczne skalowanie oraz rejestrowanie. Dzięki Lambda możesz uruchamiać kod dla prawie każdego rodzaju aplikacji lub usługi zaplecza.

## Tworzenie funkcji AWS Lambda

{{% alert color="primary" %}} 
Upewnij się, że masz wystarczające uprawnienia do tworzenia funkcji Lambda AWS i obrazów w Amazon Elastic Container Registry.
{{% /alert %}}

Aby utworzyć program funkcji AWS Lambda, wykonaj poniższe kroki:
1. Utwórz projekt AWS Lambda.<br>
![Utwórz przycisk funkcji AWS](/_assets/showcases/aws/create-project.png)<br>
1. Wybierz .NET 6 (Obraz kontenera) i kliknij przycisk 'Zakończ'.<br>
![Utwórz przycisk funkcji kontenera](/_assets/showcases/aws/create-container.png)<br>
1. Otwórz AWS Explorer w Visual Studio (Widok->AWS Explorer).
1. Dodaj profil poświadczeń AWS w AWS Explorer.<br>
![Profil poświadczeń](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Wprowadź Access Key ID oraz Secret Access Key, możesz uzyskać te klucze w poświadczeniach zabezpieczeń lub skontaktować się z administratorem i uzyskać plik csv do autoryzacji.<br>
![Ustawienia profilu konta](/_assets/showcases/aws/account-profile.png)<br>
1. Zainstaluj najnowsze biblioteki z NuGet.<br>
![Menadżer NuGet](/_assets/showcases/aws/nuget-manager.png)<br>
1. Przykład kodu do konwersji obrazu CAD do pliku PDF.
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
1. Edytuj DockerFile, jak w sekcji <a href="#configuring-a-dockerfile">Konfigurowanie Dockerfile</a>.
1. Uruchom Docker Desktop.
1. Publikuj do AWS Lambda.<br>
![Publikuj AWS Lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. Edytuj konfigurację przesyłania.<br>
![Przesyłanie AWS Lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Kliknij przycisk 'Prześlij'.<br>
![Ostatnie przesłanie AWS Lambda](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Przejdź do AWS i wybierz Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Wybierz swoją nową funkcję i utwórz URL funkcji.<br>
![Konfiguracja URL funkcji](/_assets/showcases/aws/create-function-url.png)<br>
1. Wybierz typ uwierzytelniania
- AWS_IAM - Tylko uwierzytelnieni użytkownicy i role IAM mogą wysyłać żądania do URL funkcji.
- NONE - Lambda nie będzie przeprowadzać uwierzytelniania IAM dla żądań do URL funkcji. Punkt końcowy URL będzie publiczny, chyba że wdrożysz własną logikę autoryzacyjną w swojej funkcji.

### Konfigurowanie Dockerfile

 Następnym krokiem jest edytowanie i konfigurowanie Dockerfile w projekcie.

1. W Dockerfile określ:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Powyżej znajduje się prosty Dockerfile, który zawiera następujące instrukcje:

- Obraz SDK, który ma być używany. Tutaj jest to obraz Net 6. Docker pobierze go podczas uruchamiania budowy. Wersja SDK jest określona jako etykieta.
- Następnie możesz potrzebować zainstalować czcionki, ponieważ obraz SDK zawiera bardzo mało czcionek. Możesz również użyć lokalnych czcionek skopiowanych do obrazu dockera.
- Katalog roboczy, który jest określony w następnej linii.
- Komenda do skopiowania wszystkiego do kontenera, publikowania aplikacji i określenia punktu wejścia.

## Przykład wykonania

1. Ustawienia Postmana.<br>
![Menu przegląd](/_assets/showcases/aws/postman-settings.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Kliknij przycisk wyślij.

{{% alert color="primary" %}} 
Jeśli odpowiedź jest pozytywna, kliknij Zapisz do pliku, a otrzymasz przekonwertowany plik w formacie PDF
{{% /alert %}}

## Więcej przykładów

Aby uzyskać więcej próbek, jak można użyć Aspose.CAD w Docker, zobacz [przykłady](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Zobacz także.

- [Instalacja AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instalacja Docker Desktop na Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instalacja Docker Desktop na Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, pakiet .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Opcja [Przełącz na kontenery Linuxowe](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Dodatkowe informacje na temat [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
