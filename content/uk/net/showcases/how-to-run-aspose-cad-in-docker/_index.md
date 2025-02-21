---
title: Як запустити Aspose.CAD у Docker
type: docs
description: "Запустіть Aspose.CAD у контейнері Docker для Linux, Windows Server та будь-якої ОС."
weight: 71
url: /uk/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Попередні вимоги
- Docker повинен бути встановлений на вашій системі. Для отримання інформації про те, як встановити Docker на Windows або Mac, зверніться до посилань у розділі "Дивіться також".
- Visual Studio 2022.
- У прикладі використовується .NET 6 SDK.

## Додаток Hello World

У цьому прикладі ви створюєте простий консольний додаток Hello World, який малює еліпс і зберігає його як зображення. Додаток потім можна зібрати та запустити в Docker.

## Створення консольного додатка

Щоб створити програму Hello World, виконайте наступні кроки:
1. Після встановлення Docker переконайтеся, що він використовує контейнери Linux (за замовчуванням). Якщо необхідно, виберіть опцію Переключити на контейнери Linux у меню Docker Desktop.
1. У Visual Studio створіть консольний додаток .NET 6.<br>
![Діалог проекту консольного застосунку .NET 6](/_assets/showcases/docker/1.png)<br>
1. Встановіть останню версію Aspose.CAD з NuGet.<br>
![Aspose.CAD на NuGet](/_assets/showcases/docker/2.png)<br>
1. Оскільки додаток буде запущено на Linux, можливо, вам буде потрібно встановити додаткові шрифти. Ви можете віддати перевагу ttf-mscorefonts-installer.
1. Коли всі необхідні залежності додані, напишіть просту програму, яка створює еліпс і зберігає його як зображення:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Зверніть увагу, що папка “TestOut” вказується як папка для збереження вихідних документів. Під час виконання програми в Docker папка на хост-машині буде змонтована до цієї папки у контейнері. Це дозволить вам легко переглядати вихідні дані, згенеровані Aspose.CAD у контейнері Docker.

### Налаштування Dockerfile

Наступний крок — створити та налаштувати Dockerfile.

1. Створіть Dockerfile і розмістіть його поряд з файлом рішення вашого додатку. Залиште це ім'я файлу без розширення (за замовчуванням).
1. У Dockerfile вкажіть:

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

Наведеного вище — це простий Dockerfile, який містить наступні команди:

- Зображення SDK, яке буде використовуватися. Тут це зображення Net 6. Docker завантажить його під час виконання зборки. Версія SDK вказується як тег.
- Після цього може знадобитися встановити шрифти, оскільки зображення SDK містить дуже мало шрифтів. Також ви можете використовувати локальні шрифти, скопійовані в образ Docker.
- Робочий каталог, який вказується в наступному рядку.
- Команда для копіювання всього в контейнер, публікації програми та визначення точки входу.

## Збірка та запуск програми в Docker

Тепер програму можна зібрати та запустити в Docker. Відкрийте улюблений командний рядок, змініть каталог на папку з додатком (папка, де знаходиться файл рішення та Dockerfile) і виконайте наступну команду:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Перший раз, коли ця команда виконується, це може зайняти більше часу, оскільки Docker повинен завантажити необхідні зображення. Коли попередня команда завершиться, виконайте наступну команду:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Зверніть увагу на аргумент монтування, оскільки, як було згадано раніше, папка на хост-машині змонтована до папки контейнера, щоб легко бачити результати виконання програми. Шляхи в Linux чутливі до регістру.
{{% /alert %}}

## Більше прикладів

Для отримання додаткових прикладів того, як можна використовувати Aspose.CAD у Docker, дивіться [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Дивіться також

- [Встановіть Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановіть Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Переключитися на контейнери Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опція
- Додаткова інформація про [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
