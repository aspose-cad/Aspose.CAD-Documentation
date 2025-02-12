---
title: Как да стартирате образа Aspose.CAD Docker в Azure Function
type: docs
description: "Стартирайте образа Aspose.CAD Docker в Azure Function."
weight: 73
url: /bg/net/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Изисквания
- Docker трябва да бъде инсталиран на вашата система. За информация как да инсталирате Docker на Windows или Mac, вижте връзките в секцията "Виж също".
- Visual Studio 2022.
- Използва се .NET 6 SDK в примера.
- Postman.

## Azure Function

В този пример ще създадете проста конверсионна функция, която конвертира CAD файл и го запазва като изображение. Приложението след това може да бъде построено в Docker и стартирано в Azure Function.

## Създаване на Azure Function

За да създадете програмата Azure Function, следвайте стъпките по-долу:
1. След инсталиране на Docker, уверете се, че използва Linux контейнерите (по подразбиране). При необходимост изберете опцията Превключване към Linux контейнери от менюто на Docker Desktops.
1. В Visual Studio, създайте .NET 6 Azure Function.<br>
![Диалогов прозорец за проект на .NET 6 Azure Function](/_assets/Create-project.png)<br>
1. Допълнителна информация.<br>
![Диалогов прозорец за проект на .NET 6 Azure Function](/_assets/Additional-information.png)<br>
1. Инсталирайте последната версия на Aspose.CAD от NuGet.<br>
![Aspose.CAD на NuGet](/_assets/NuGet.png)<br>
1. Тъй като приложението ще бъде стартирано на Linux, може да се наложи да инсталирате допълнителни шрифтове. Можете да предпочетете ttf-mscorefonts-installer.
1. Когато всички изисквани зависимости са добавени, напишете проста програма, която създава елипса и я запазва като изображение:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger функция обработи искане.");
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

### Конфигуриране на Dockerfile

 Следващата стъпка е да създадете и конфигурирате Dockerfile в основната папка на проекта.

1. Създайте Dockerfile и го поставете до файла с решението на вашето приложение. Запазете това име на файла без разширение (по подразбиране).
![Основна папка на проекта](/_assets/root-folder.png)<br>
1. В Dockerfile, задайте:

{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
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

 По-горе е прост Dockerfile, който съдържа следните инструкции:

- Образа на SDK, който да се използва. Тук е образа на .NET 6. Docker ще го изтегли, когато се стартира изграждането. Версията на SDK е зададена като етикет.
- След това, може да се наложи да инсталирате шрифтове, тъй като образа на SDK съдържа много ограничени шрифтове. Също така, можете да използвате локални шрифтове, копирани в образа на docker.
- Работната директория, която е посочена в следващия ред.
- Командата за копиране на всичко в контейнера, публикуване на приложението и посочване на входната точка.

## Docker Hub
1. Влезте в Docker Hub.
1. Създайте публичен репозитори.

## Изграждане и стартиране на приложението в Docker

 Сега приложението може да бъде построено и стартирано в Docker. Отворете предпочитания от вас команден ред, променете директорията на папката с приложението (папката, в която се намира файла с решението и Dockerfile) и изпълнете следната команда:

{{< highlight plain >}}
//пример
docker build -t <потребителско име>/<име на репозитории> .

docker build -t user/asposefunction .
{{< /highlight >}}

Първият път, когато изпълните тази команда, може да отнеме повече време, тъй като Docker трябва да изтегли необходимите образи. След като предишната команда завърши, изпълнете следната команда, за да качите изображението в docker hub:

{{< highlight plain >}}
//пример
docker push <потребителско име>/<име на репозитории>:тегло

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Влезте в Azure.
1. Изберете Azure услуги.
1. Изберете Function App и създайте функция.<br>
![Бутон за създаване на функция в Azure](/_assets/create-function.png)<br>
1. Повторете основните настройки, както е показано на изображението по-долу.<br>
![Настройки на функция в Azure](/_assets/create-function-setting.png)<br>
1. Щракнете 'Преглед + създаване' -> Създаване.
1. Изчакайте завършването на разполагането.
1. Щракнете върху бутона 'Отидете на ресурса'.<br>
![Бутон за ресурс](/_assets/azure/go-to-resource.png)<br>
1. Спиране на функцията aspose-cad-docker-example.<br>
![Спиране на контейнер](/_assets/stop-container.png)<br>
1. Отидете в менюто на центъра за разполагане и направете съответните настройки.<br>
![Център за разполагане](/_assets/deployment-center.png)<br>
1. Запазете настройките.
1. Копирайте URL адреса на уебхук от настройки на центъра за разполагане.<br>
![URL адрес на уебхук](/_assets/webhook-url.png)<br>
1. Отидете в Docker Hub, изберете репозитория си и изберете уеб хукове.
1. Поставете 'URL адреса на уебхук' от Azure в URL адреса на уебхук на Docker Hub и задайте името.<br>
![Настройки на уебхук в docker](/_assets/webhook.png)<br>
1. Щракнете върху бутона за създаване.
1. Върнете се на прегледа на Azure функцията и стартирайте контейнера.<br>
![Меню за преглед](/_assets/overview.png)<br>

## Пример за изпълнение

1. Настройки на Postman.<br>
![Меню за преглед](/_assets/postman-settings.png)<br>
1. Изберете произволен DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Щракнете бутона за изпращане.

{{% alert color="primary" %}} 
Ако отговорът е успешен, щракнете Запази в файл и ще получите конвертирания файл в png формат.
{{% /alert %}}

## Повече примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примерите](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Вижте също

- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Превключете към Linux контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Допълнителна информация за [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
