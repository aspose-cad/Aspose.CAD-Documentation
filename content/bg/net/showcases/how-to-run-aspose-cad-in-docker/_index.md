---
title: Как да стартирате Aspose.CAD в Docker
type: docs
description: "Стартирайте Aspose.CAD в контейнер Docker за Linux, Windows Server и всяка операционна система."
weight: 71
url: /bg/net/how-to-run-aspose-cad-in-docker
---

## Предварителни изисквания
- Docker трябва да бъде инсталиран на вашата система. За информация как да инсталирате Docker на Windows или Mac, се запознайте с линковете в секцията "Вижте също".
- Visual Studio 2022.
- NET 6 SDK се използва в примера.

## Hello World Приложение

В този пример създавате просто Hello World конзолно приложение, което рисува елипса и я запазва като изображение. Приложението след това може да бъде компилирано и стартирано в Docker.

## Създаване на Конзолно Приложение

За да създадете програмата Hello World, следвайте стъпките по-долу:
1. След като Docker е инсталиран, уверете се, че използва Linux контейнери (по подразбиране). При необходимост изберете опцията "Смяна на Linux контейнери" от менюто на Docker Desktop.
1. В Visual Studio, създайте NET 6 конзолно приложение.<br>
![Диалогов прозорец на проект за NET 6 конзолно приложение](/_assets/1.png)<br>
1. Инсталирайте най-новата версия на Aspose.CAD от NuGet.<br>
![Aspose.CAD в NuGet](/_assets/2.png)<br>
1. Тъй като приложението ще се стартира под Linux, може да се наложи да инсталирате допълнителни шрифтове. Можете да предпочетете ttf-mscorefonts-installer.
1. Когато всички необходими зависимости са добавени, напишете проста програма, която създава елипса и я запазва като изображение:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Обърнете внимание, че папката “TestOut” е зададена като папка за изход за запазване на изходни документи. Когато стартирате приложението в Docker, папка на хост машината ще бъде свързана с тази папка в контейнера. Това ще ви позволи лесно да видите изхода, генериран от Aspose.CAD в контейнера Docker.

### Конфигуриране на Dockerfile

Следващата стъпка е да създадете и конфигурирате Dockerfile.

1. Създайте Dockerfile и го поставете до файла на решението на вашето приложение. Запазете това име на файл без разширение (по подразбиране).
1. В Dockerfile, задайте:

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

Горноизложеното е прост Dockerfile, който съдържа следните инструкции:

- Изображението на SDK, което да се използва. Тук е изображението на Net 6. Docker ще го изтегли, когато бъде стартиран билдът. Версията на SDK е зададена като таг.
- След това, може да се наложи да инсталирате шрифтове, тъй като изображението на SDK съдържа много малко шрифтове. Също така можете да използвате локални шрифтове, копирани в docker изображението.
- Работното директория, която е зададена в следващия ред.
- Командата за копиране на всичко в контейнера, публикуване на приложението и задаване на входната точка.

## Компилиране и Стартиране на Приложението в Docker

Сега приложението може да бъде компилирано и стартирано в Docker. Отворете любимия си команден ред, сменете директорията на папката с приложението (папката, където се намира файлът на решението и Dockerfile) и изпълнете следната команда:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

При първото изпълнение на тази команда може да отнеме по-дълго време, тъй като Docker трябва да изтегли необходимите изображения. След като предишната команда завърши, стартирайте следната команда:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Обърнете внимание на аргумента за свързване, тъй като, както споменахме по-рано, папка на хост машината е свързана с папката на контейнера, за да можете лесно да виждате резултатите от изпълнението на приложението. Пътищата в Linux са чувствителни към регистъра.
{{% /alert %}}

## Повече Примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примерите](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Вижте Също

- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Смяна на Linux контейнери](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) опция
- Допълнителна информация за [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
