---
title: Как да стартирате Docker образ на Aspose.CAD в Google Cloud
type: docs
description: "Стартирайте Docker образ на Aspose.CAD в Google Cloud."
weight: 75
url: /bg/net/how-to-run-aspose-cad-docker-image-in-google-cloud
---

## Изисквания

- Docker трябва да бъде инсталиран на вашата система. За информация как да инсталирате Docker на Windows или Mac, вижте линковете в раздела „Вижте също“.
- Visual Studio 2022.
- Google CLI.
- NET Core 3.1 SDK се използва в примера.
- Postman

## Функция на Google Cloud Run

Cloud Run е напълно управлявана среда за изчисление за внедряване и скалиране на безсървърни HTTP контейнери, без да се безпокоите за осигуряване на машини, конфигуриране на клъстери или автоматично мащабиране.

- Без заключване от доставчика - Поскольку Cloud Run приема стандартни OCI контейнери и внедрява стандартния API на Knative Serving, можете лесно да прехвърлите вашите приложения на локални машини или в която и да е друга облачна среда.
- Бързо автоматично мащабиране - Микросервизите, внедрени в Cloud Run, се мащабират автоматично на базата на броя на входящите заявки, без да е необходимо да конфигурирате или управлявате пълен клъстер на Kubernetes. Cloud Run мащабира до нула - тоест, не използва ресурси - ако няма заявки.
- Разделяне на трафика - Cloud Run ви позволява да разделяте трафика между няколко ревизии, така че да можете да извършвате постепенни разгръщания, като например canary deployments или blue/green deployments.
- Персонализирани домейни - Можете да настроите персонализирано съвпадение на домейни в Cloud Run и то ще осигури TLS сертификат за вашия домейн.
- Автоматична резервиране - Cloud Run предлага автоматично резервиране, така че да не се налага да се притеснявате за създаване на множество инстанции за висока наличност.

Cloud Run и Cloud Functions са напълно управлявани услуги, които работят на безсървърната инфраструктура на Google Cloud, автоматично мащабират и обработват HTTP заявки или събития. Все пак, те имат някои важни разлики:

- Cloud Functions позволява да внедрите фрагменти от код (функции), написани на ограничен набор от програмни езици, докато Cloud Run позволява да внедрите образи на контейнери, използвайки избрания от вас програмния език.
- Cloud Run също така поддържа използването на всякакви инструменти или системни библиотеки от вашето приложение; Cloud Functions не ви позволява да използвате персонализирани изпълними файлове.
- Cloud Run предлага по-дълъг период на таймаут за заявки от до 60 минути, докато при Cloud Functions таймаутите за заявки могат да бъдат настроени до максимум 9 минути.
- Cloud Functions изпраща само една заявка в даден момент до всяка инстанция на функцията, докато по подразбиране Cloud Run е конфигуриран да изпраща множество паралелни заявки на всяка инстанция на контейнера. Това е полезно за подобряване на латентността и намаляване на разходите, ако очаквате голямо количество заявки.

## Създаване на проекта за Google Cloud Function

{{% alert color="primary" %}} 
Уверете се, че имате достатъчно права за създаване на функция за Google Cloud Run и образи в репозиторито на Artifact Registry.
{{% /alert %}}

За да създадете програмата за Google Cloud Function, следвайте стъпките по-долу:

1. Инсталирайте .NET Core SDK 3.1.
1. Инсталирайте пакета с шаблони:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. След това създайте директория за вашия проект и използвайте dotnet new, за да създадете нова HTTP функция:
{{< highlight plain >}}
mkdir AsposeFunctions //създайте папка
cd AsposeFunctions //влезте в папката AsposeFunctions
dotnet new gcf-http //създайте проект за Google Cloud Function с http триггер
{{< /highlight >}}
{{% alert color="primary" %}} 
Това създава AsposeFunctions.csproj и Function.cs в текущата директория. Отворете Function.cs, за да прегледате кода, и предоставете персонализирано съобщение, ако желаете.
{{% /alert %}}
1. Примерен код за csproj файл (AsposeFunctions.csproj).
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
1. Примерен код за конвертиране на CAD изображение в PNG файл (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Логика за вашата функция отива тук.
        /// </summary>
        /// <param name="context">HTTP контекстът, съдържащ заявката и отговора.</param>
        /// <returns>Задача, представляваща асинхронната операция.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //формулярен файл
                var file = context.Request.Body; //двуични данни
                
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
1. Сглобете функцията локално, както следва:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. След като сървърът стартира, отидете на http://localhost:8080, за да извикате функцията. Натиснете Ctrl-C в конзолата, за да спрете сървъра.

## Разгръщане на docker образ в Google Cloud

1. Влезте в Google Cloud.
1. Създайте проект, ако не съществува.
1. Отидете на 'Artifact Registry' и създайте репозиторио.<br>
![Създаване на Artifact Repository](/_assets/create-artifact-repository.png)<br>
1. Изберете новото репозиторио в Artifact Registry.
![Изберете репозиторио за артефакти](/_assets/select-artifact.png)<br>
1. Кликнете върху 'SETUP INSTRUCTION' и копирайте командата 'Конфигуриране на Docker'.<br>
![SETUP INSTRUCTION](/_assets/setup-instruction.png)<br>
1. Добавете вход за Docker credHelper в конфигурационния файл на Docker или създайте файла, ако не съществува.
{{< highlight plain >}}
//пример
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Създайте Dockerfile в основната директория на проекта и редактирайте DockerFile, както в секцията <a href="#configuring-a-dockerfile">Конфигуриране на Dockerfile</a>.
1. Стартирайте Docker Desktop.
1. Сглобете docker образ с пътя към облачното репозиторио.
{{< highlight plain >}}
//пример
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Изпратете образа в Google Cloud Artifact Registry
{{< highlight plain >}}
//пример
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Създаване на услуга Google Cloud Run

1. Отидете в Cloud Run.
1. Създайте услуга Cloud Run.<br>
![Създаване на услуга Cloud Run](/_assets/create-cloud-run-service.png)<br>
1. В полето URL на образа на контейнера изберете контейнера от 'ARTIFACT REGISTRY'.<br>
![URL на образа на контейнера](/_assets/container-url.png)<br>
1. Проверете другите настройки, както е показано по-долу.<br>
![Настройки на услугата](/_assets/cloud-run-service-settings.png)<br>
1. Изчакайте завършването на внедряването.
1. URL на услугата за работа с приложението за конверсия.<br>
![URL на услугата](/_assets/url-service.png)<br>

### Конфигуриране на Dockerfile

Следващата стъпка е да редактирате конфигурирането на Dockerfile в проекта.

1. В Dockerfile задайте:

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

Горният Dockerfile е прост, който съдържа следните инструкции:

- Изображението на SDK, което ще се използва. Тук е изображението на .NET Core 3.1. Docker ще го изтегли, когато стартира сглобяването. Версията на SDK е посочена като етикет.
- След това, вероятно ще трябва да инсталирате шрифтове, тъй като изображението на SDK съдържа много малко шрифтове. Също така можете да използвате локални шрифтове, копирани в изображението на Docker.
- Работната директория, която е посочена в следващия ред.
- Командата за копиране на всичко в контейнера, публикуване на приложението и посочване на входната точка.

## Пример за изпълнение

1. Настройки на Postman.<br>
![Обзорно меню](/_assets/postman-settings.png)<br>
1. Изберете произволен файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Натиснете бутона за изпращане.

{{% alert color="primary" %}} 
Ако отговорът е успешен, кликнете върху Запази в файл и ще получите конвертирания файл в PNG формат
{{% /alert %}}

## Повече примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примерите](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Вижте също.

- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Преминаване към Linux контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Допълнителна информация за [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)