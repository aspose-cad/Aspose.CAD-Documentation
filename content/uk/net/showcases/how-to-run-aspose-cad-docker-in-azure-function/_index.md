---
title: Як запустити Docker-образ Aspose.CAD в Azure Function
type: docs
description: "Запустити Docker-образ Aspose.CAD в Azure Function."
weight: 73
url: /uk/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Передумови
- Docker має бути встановлений на вашій системі. Для отримання інформації про те, як встановити Docker на Windows або Mac, перегляньте посилання в розділі "Дивіться також".
- Visual Studio 2022.
- Використовується NET 6 SDK у прикладі.
- Postman

## Azure Function

У цьому прикладі ви створюєте просту функцію конвертації, яка конвертує CAD-файл і зберігає його як зображення. Додаток можна скласти в Docker та запустити в Azure Function.

## Створення Azure Function

Щоб створити програму Azure Function, виконайте наведені нижче кроки:
1. Після встановлення Docker переконайтеся, що він використовує Linux-контейнери (за замовчуванням). Якщо необхідно, виберіть опцію "Переключитися на Linux-контейнери" в меню Docker Desktop.
1. У Visual Studio створіть Azure Function на NET 6.<br>
![Діалогове вікно проекту Azure Function NET 6](/_assets/showcases/azure/Create-project.png)<br>
1. Додаткова інформація.<br>
![Діалогове вікно проекту Azure Function NET 6](/_assets/showcases/azure/Additional-information.png)<br>
1. Встановіть останню версію Aspose.CAD з NuGet.<br>
![Aspose.CAD на NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. Оскільки додаток буде запущено на Linux, можливо, вам буде потрібно встановити додаткові шрифти. Ви можете віддати перевагу ttf-mscorefonts-installer.
1. Коли всі потрібні залежності додані, напишіть просту програму, яка створить еліпс і збереже його як зображення:<br>

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

### Налаштування Dockerfile

Наступним кроком є створення та налаштування Dockerfile в кореневій папці проекту.

1. Створіть Dockerfile і помістіть його поруч з файлом рішення вашого додатка. Залиште цю назву файлу без розширення (за замовчуванням).
![Коренева папка проекту](/_assets/showcases/azure/root-folder.png)<br>
1. У Dockerfile вкажіть:

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

Вищезазначений Dockerfile простий і містить такі інструкції:

- Образ SDK, який буде використаний. Тут це образ Net 6. Docker завантажить його, коли буде запущено складання. Версія SDK вказується як тег.
- Далі, можливо, вам потрібно буде встановити шрифти, оскільки образ SDK містить дуже мало шрифтів. Також ви можете використовувати локальні шрифти, скопійовані в образ Docker.
- Робочий каталог, який вказується в наступному рядку.
- Команда для копіювання всього в контейнер, публікації програми та вказівки точки входу.

## Docker Hub
1. Увійдіть у Docker Hub
1. Створіть публічний репозиторій

## Збірка та запуск додатка в Docker
 
 Тепер додаток можна зібрати та запустити в Docker. Відкрийте свій улюблений командний рядок, змініть директорію на папку з додатком (папка, в якій розміщено файл рішення та Dockerfile), і виконайте команду:

{{< highlight plain >}}
//приклад
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
Перший раз, коли ви запустите цю команду, це може зайняти більше часу, оскільки Docker потрібно завантажити потрібні образи. Після того, як попередня команда завершиться, виконайте наступну команду, щоб відправити образ у docker hub:
 
{{< highlight plain >}}
//приклад
docker push <user name>/<repository name>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Увійдіть в Azure.
1. Виберіть служби Azure.
1. Виберіть Function App і створіть функцію.<br>
![Кнопка створення функції в Azure](/_assets/showcases/azure/create-function.png)<br>
1. Повторіть основні налаштування, як на зображенні нижче.<br>
![Налаштування створення функції в Azure](/_assets/showcases/azure/create-function-setting.png)<br>
1. Натисніть 'Переглянути + створити' -> Створити.
1. Дочекайтеся завершення розгортання.
1. Натисніть кнопку 'Перейти до ресурсу'.<br>
![Кнопка ресурсу](/_assets/showcases/azure/go-to-resource.png)<br>
1. Зупиніть функцію aspose-cad-docker-example.<br>
![Зупинити контейнер](/_assets/showcases/azure/stop-container.png)<br>
1. Перейдіть до меню центру розгортання та внесіть відповідні налаштування.<br>
![Центр розгортання](/_assets/showcases/azure/deployment-center.png)<br>
1. Збережіть налаштування.
1. Скопіюйте URL-адресу Webhook із налаштувань центру розгортання.<br>
![URL-адреса Webhook](/_assets/showcases/azure/webhook-url.png)<br>
1. Перейдіть до Docker Hub, виберіть свій репозиторій і виберіть вебхуки.
1. Вставте 'URL-адресу Webhook' з Azure в URL-адресу вебхука Docker Hub і встановіть ім'я.<br>
![Налаштування Webhook у Docker](/_assets/showcases/azure/webhook.png)<br>
1. Натисніть кнопку створення.
1. Поверніться до загального огляду Azure Function і запустіть контейнер.<br>
![Меню огляду](/_assets/showcases/azure/overview.png)<br>

## Приклад виконання

1. Налаштування Postman.<br>
![Меню огляду](/_assets/showcases/azure/postman-settings.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Натисніть кнопку відправити.

{{% alert color="primary" %}} 
Якщо відповідь успішна, натисніть Зберегти у файл, і ви отримаєте конвертований файл у форматі png.
{{% /alert %}}

## Більше прикладів

Для більшої кількості зразків того, як ви можете використовувати Aspose.CAD у Docker, дивіться [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Дивіться також

- [Встановлення Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановлення Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Перейти на Linux-контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опція
- Додаткова інформація про [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
