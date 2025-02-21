---
title: Как запустить образ Aspose.CAD Docker в Azure Function
type: docs
description: "Запустите образ Aspose.CAD Docker в Azure Function."
weight: 73
url: /ru/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Предварительные требования
- Docker должен быть установлен на вашей системе. Для получения информации о том, как установить Docker на Windows или Mac, обратитесь к ссылкам в разделе "Смотрите также".
- Visual Studio 2022.
- NET 6 SDK используется в примере.
- Postman

## Azure Function

В этом примере вы создаете простую функцию преобразования, которая конвертирует файл CAD и сохраняет его как изображение. Приложение затем может быть собрано в Docker и запущено в Azure Function.

## Создание Azure Function

Чтобы создать программу Azure Function, выполните следующие шаги:
1. После установки Docker убедитесь, что он использует контейнеры Linux (по умолчанию). Если необходимо, выберите опцию Переключиться на контейнеры Linux в меню Docker Desktops.
1. В Visual Studio создайте Azure Function для .NET 6.<br>
![Диалог проекта Azure Function для .NET 6](/_assets/showcases/azure/Create-project.png)<br>
1. Дополнительная информация.<br>
![Диалог проекта Azure Function для .NET 6](/_assets/showcases/azure/Additional-information.png)<br>
1. Установите последнюю версию Aspose.CAD из NuGet.<br>
![Aspose.CAD на NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. Поскольку приложение будет запущено на Linux, возможно, вам потребуется установить дополнительные шрифты. Вы можете предпочесть ttf-mscorefonts-installer.
1. Когда все необходимые зависимости добавлены, напишите простую программу, которая создает эллипс и сохраняет его как изображение:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");
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

### Конфигурация Dockerfile

Следующий шаг - создать и настроить Dockerfile в корневой папке проекта.

1. Создайте Dockerfile и поместите его рядом с файлом решения вашего приложения. Сохраните это имя файла без расширения (по умолчанию).
![Корневая папка проекта](/_assets/showcases/azure/root-folder.png)<br>
1. В Dockerfile укажите:

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

Выше представлен простой Dockerfile, который содержит следующие инструкции:

- Образ SDK, который будет использоваться. Здесь используется образ Net 6. Docker загрузит его, когда будет запущена сборка. Версия SDK указывается как тег.
- Далее, вам может понадобиться установить шрифты, потому что образ SDK содержит очень мало шрифтов. Также вы можете использовать локальные шрифты, скопированные в образ docker.
- Рабочий каталог, который указывается в следующей строке.
- Команда для копирования всего в контейнер, публикации приложения и указания точки входа.

## Docker Hub
1. Войдите в Docker Hub
1. Создайте публичный репозиторий

## Сборка и запуск приложения в Docker

Теперь приложение можно собрать и запустить в Docker. Откройте свой любимый командный интерпретатор, перейдите в папку с приложением (папка, где находятся файл решения и Dockerfile) и выполните следующую команду:

{{< highlight plain >}}
//пример
docker build -t <имя пользователя>/<имя репозитория> .

docker build -t user/asposefunction .
{{< /highlight >}}

В первый раз, когда вы запускаете эту команду, это может занять больше времени, поскольку Docker должен загрузить необходимые образы. После завершения предыдущей команды выполните следующую команду, чтобы загрузить образ в Docker Hub:

{{< highlight plain >}}
//пример
docker push <имя пользователя>/<имя репозитория>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Войдите в Azure.
1. Выберите услуги Azure.
1. Выберите Function App и создайте функцию.<br>
![Кнопка создания функции Azure](/_assets/showcases/azure/create-function.png)<br>
1. Повторите основные настройки, как на изображении ниже.<br>
![Настройки создания функции Azure](/_assets/showcases/azure/create-function-setting.png)<br>
1. Нажмите 'Просмотреть + создать' -> Создать.
1. Дождитесь завершения развертывания.
1. Нажмите кнопку 'Перейти к ресурсу'.<br>
![Кнопка ресурса](/_assets/showcases/azure/go-to-resource.png)<br>
1. Остановите функцию aspose-cad-docker-example.<br>
![Остановка контейнера](/_assets/showcases/azure/stop-container.png)<br>
1. Перейдите в меню центра развертывания и сделайте соответствующие настройки.<br>
![Центр развертывания](/_assets/showcases/azure/deployment-center.png)<br>
1. Сохраните настройки
1. Скопируйте URL-адрес вебхука из настроек центра развертывания.<br>
![URL вебхука](/_assets/showcases/azure/webhook-url.png)<br>
1. Перейдите в Docker Hub, выберите свой репозиторий и выберите вебхуки.
1. Вставьте 'URL вебхука' из Azure в URL вебхука Docker Hub и задайте имя.<br>
![Настройки вебхука в docker](/_assets/showcases/azure/webhook.png)<br>
1. Нажмите кнопку создания.
1. Вернитесь к обзору функции Azure и запустите контейнер.<br>
![Меню обзора](/_assets/showcases/azure/overview.png)<br>

## Пример выполнения

1. Настройки Postman.<br>
![Настройки Postman](/_assets/showcases/azure/postman-settings.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Нажмите кнопку отправки.

{{% alert color="primary" %}} 
Если ответ успешный, нажмите «Сохранить в файл», и вы получите преобразованный файл в формате png
{{% /alert %}}

## Дополнительные примеры

Для получения дополнительных примеров того, как вы можете использовать Aspose.CAD в Docker, смотрите [примеры](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Смотрите также

- [Установка Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установка Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Опция [Переключиться на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Дополнительная информация о [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
