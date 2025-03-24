---
title: Как запустить Aspose.CAD в Docker
type: docs
description: "Запустите Aspose.CAD в контейнере Docker для Linux, Windows Server и любой другой ОС."
weight: 71
url: /ru/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Предварительные требования
- Docker должен быть установлен на вашей системе. Для получения информации о том, как установить Docker на Windows или Mac, смотрите ссылки в разделе "См. также".
- Visual Studio 2022.
- В примере используется .NET 6 SDK.

## Приложение Hello World

В этом примере вы создаете простое консольное приложение Hello World, которое рисует эллипс и сохраняет его как изображение. Приложение затем можно собрать и запустить в Docker.

## Создание консольного приложения

Чтобы создать программу Hello World, выполните следующие шаги:
1. После установки Docker убедитесь, что он использует контейнеры Linux (по умолчанию). При необходимости выберите опцию Переключиться на контейнеры Linux в меню Docker Desktop.
1. В Visual Studio создайте консольное приложение .NET 6.<br>
![Диалоговое окно проекта консольного приложения .NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. Установите последнюю версию Aspose.CAD из NuGet.<br>
![Aspose.CAD на NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. Поскольку приложение будет запущено на Linux, может потребоваться установить дополнительные шрифты. Вы можете предпочесть ttf-mscorefonts-installer.
1. Когда все необходимые зависимости добавлены, напишите простую программу, которая создает эллипс и сохраняет его как изображение:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Обратите внимание, что папка “TestOut” указана в качестве выходной папки для сохранения выходных документов. При запуске приложения в Docker папка на основном компьютере будет смонтирована в эту папку в контейнере. Это позволит вам легко просматривать вывод, сгенерированный Aspose.CAD в контейнере Docker.

### Настройка Dockerfile

Следующий шаг — создать и настроить Dockerfile.

1. Создайте Dockerfile и поместите его рядом с файлом решения вашего приложения. Сохраните это имя файла без расширения (по умолчанию).
1. В Dockerfile укажите:

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

Выше представлена простой Dockerfile, который содержит следующие инструкции:

- Изображение SDK, которое будет использоваться. Здесь это изображение .NET 6. Docker загрузит его при выполнении сборки. Версия SDK указана в качестве тега.
- После этого вам может понадобиться установить шрифты, так как изображение SDK содержит очень мало шрифтов. Также вы можете использовать локальные шрифты, скопированные в изображение Docker.
- Рабочий каталог, который указан в следующей строке.
- Команда для копирования всего в контейнер, публикации приложения и указания точки входа.

## Сборка и запуск приложения в Docker

Теперь приложение можно собрать и запустить в Docker. Откройте предпочитаемую командную строку, перейдите в каталог с приложением (каталог, где располагаются файл решения и Dockerfile), и выполните следующую команду:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

При выполнении этой команды в первый раз она может занять больше времени, так как Docker должен загрузить необходимые образы. После завершения предыдущей команды выполните следующую команду:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Обратите внимание на аргумент монтирования, поскольку, как упоминалось ранее, папка на основном компьютере монтируется в папку контейнера, чтобы легко увидеть результаты выполнения приложения. Пути в Linux чувствительны к регистру.
{{% /alert %}}

## Дополнительные примеры

Для получения дополнительных примеров того, как вы можете использовать Aspose.CAD в Docker, смотрите [примеры](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## См. также

- [Установить Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установить Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Переключиться на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Дополнительная информация о [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
