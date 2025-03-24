---
title: Как запустить образ Aspose.CAD Docker в Google Cloud
type: docs
description: "Запустите образ Aspose.CAD Docker в Google Cloud."
weight: 75
url: /ru/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Предварительные условия

- Docker должен быть установлен на вашей системе. Для получения информации о том, как установить Docker на Windows или Mac, обратитесь к ссылкам в разделе "Смотрите также".
- Visual Studio 2022.
- Google CLI.
- В примере используется SDK .NET Core 3.1.
- Postman

## Функция Google Cloud Run

Cloud Run - это полностью управляемая вычислительная среда для развертывания и масштабирования серверных HTTP-контейнеров без необходимости беспокоиться о предоставлении машин, настройке кластеров или автоматическом масштабировании.

- Нет принудительной привязки к поставщику - Поскольку Cloud Run использует стандартные контейнеры OCI и реализует стандартный API Knative Serving, вы можете легко перенести свои приложения на локальные серверы или любую другую облачную среду.
- Быстрое автоматическое масштабирование - Микросервисы, развернутые в Cloud Run, автоматически масштабируются в зависимости от количества входящих запросов, без необходимости настраивать или управлять полноценным кластером Kubernetes. Cloud Run масштабируется до нуля — то есть не использует ресурсы — если нет запросов.
- Разделение трафика - Cloud Run позволяет вам разделять трафик между несколькими версиями, так что вы можете выполнять поэтапные развертывания, такие как канарейкинг или синий/зеленый развертывание.
- Пользовательские домены - Вы можете настроить сопоставление пользовательского домена в Cloud Run и он предоставит сертификат TLS для вашего домена.
- Автоматическая избыточность - Cloud Run предлагает автоматическую избыточность, поэтому вам не нужно беспокоиться о создании множества экземпляров для высокой доступности.

Cloud Run и Cloud Functions - это полностью управляемые сервисы, которые работают на серверной инфраструктуре Google Cloud, автоматически масштабируются и обрабатывают HTTP-запросы или события. Тем не менее, у них есть несколько важных различий:

- Cloud Functions позволяет вам развертывать фрагменты кода (функции), написанные на ограниченном наборе языков программирования, в то время как Cloud Run позволяет вам развертывать контейнерные образы, используя любой язык программирования на ваш выбор.
- Cloud Run также поддерживает использование любых инструментов или системных библиотек из вашего приложения; Cloud Functions не позволяет использовать пользовательские исполняемые файлы.
- Cloud Run предлагает более длительный тайм-аут запросов до 60 минут, в то время как в Cloud Functions тайм-аут запросов можно установить максимум до 9 минут.
- Cloud Functions отправляет только один запрос одновременно в каждый экземпляр функции, тогда как по умолчанию Cloud Run сконфигурирован для отправки нескольких параллельных запросов на каждый экземпляр контейнера. Это полезно для улучшения задержки и снижения затрат, если вы ожидаете большие объемы.

## Создание проекта Google Cloud Function

{{% alert color="primary" %}} 
Убедитесь, что у вас достаточно прав для создания функции Google Cloud Run и образов в репозитории Artifact Registry.
{{% /alert %}}

Чтобы создать программу Google Cloud Function, выполните следующие шаги:

1. Установите .NET Core SDK 3.1.
1. Установите пакет шаблонов:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Затем создайте каталог для вашего проекта и используйте dotnet new для создания новой HTTP-функции:
{{< highlight plain >}}
mkdir AsposeFunctions //создать папку
cd AsposeFunctions //перейти в папку AsposeFunctions
dotnet new gcf-http //создание проекта Google Cloud Function с http триггером
{{< /highlight >}}
{{% alert color="primary" %}} 
Это создает AsposeFunctions.csproj и Function.cs в текущем каталоге. Откройте Function.cs, чтобы просмотреть код и при необходимости предоставить пользовательское сообщение.
{{% /alert %}}
1. Пример кода для файла csproj (AsposeFunctions.csproj).
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
1. Пример кода для преобразования изображения cad в файл png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Логика вашей функции здесь.
        /// </summary>
        /// <param name="context">HTTP контекст, содержащий запрос и ответ.</param>
        /// <returns>Задача, представляющая асинхронную операцию.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //формат файла
                var file = context.Request.Body; //двоичные данные
                
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
1. Постройте вашу функцию локально следующим образом:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Как только сервер запустится, перейдите по адресу http://localhost:8080, чтобы вызвать функцию. Нажмите Ctrl-C в консоли, чтобы остановить сервер.

## Развертывание образа docker в Google Cloud

1. Войдите в Google Cloud.
1. Создайте проект, если его еще нет.
1. Перейдите в 'Artifact Registry' и создайте репозиторий.<br>
![Создать репозиторий артефактов](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Выберите новый репозиторий в Artifact Registry.
![Выбрать репозиторий артефактов](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Нажмите 'ИНСТРУКЦИИ ПО НАСТРОЙКЕ' и скопируйте команду 'Настроить Docker'.<br>
![ИНСТРУКЦИИ ПО НАСТРОЙКЕ](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Добавьте запись credHelper Docker в файл конфигурации Docker или создайте файл, если он не существует.
{{< highlight plain >}}
//пример
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Создайте Dockerfile в корневом каталоге проекта и отредактируйте DockerFile, как в разделе <a href="#configuring-a-dockerfile">Настройка Dockerfile</a>.
1. Запустите Docker Desktop.
1. Постройте образ docker с путем к облачному репозиторию.
{{< highlight plain >}}
//пример
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Отправьте изображение в Google Cloud Artifact Registry
{{< highlight plain >}}
//пример
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Создание службы Google Cloud Run 

1. Перейдите на Cloud Run.
1. Создайте службу Cloud Run.<br>
![Создать службу Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. В поле URL контейнера выберите контейнер из 'АРТЕФАКТНЫЙ РЕГИСТР'.<br>
![URL контейнера](/cad/_assets/showcases/google/container-url.png)<br>
1. Проверьте другие настройки, как ниже.<br>
![Настройки службы](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Дождитесь завершения развертывания.
1. URL службы, чтобы работать с приложением преобразования.<br>
![URL службы](/cad/_assets/showcases/google/url-service.png)<br>

### Настройка Dockerfile

Следующий шаг - отредактировать Dockerfile в проекте.

1. В Dockerfile укажите:

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

Выше приведен простой Dockerfile, который содержит следующие инструкции:

- Используемый образ SDK. Здесь это образ .NET Core 3.1. Docker загрузит его, когда будет запущена сборка. Версия SDK указана как тег.
- Затем вам может потребоваться установить шрифты, поскольку образ SDK содержит очень мало шрифтов. Также вы можете использовать локальные шрифты, скопированные в образ Docker.
- Рабочий каталог, указанный в следующей строке.
- Команда для копирования всего в контейнер, публикации приложения и указания точки входа.

## Пример выполнения

1. Настройки Postman.<br>
![Меню обзора](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Нажмите кнопку отправки.

{{% alert color="primary" %}} 
Если ответ успешный, нажмите Сохранить в файл, и вы получите преобразованный файл в формате png
{{% /alert %}}

## Еще примеры

Для получения дополнительных примеров того, как вы можете использовать Aspose.CAD в Docker, смотрите [примеры](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Смотрите также

- [Установите Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установите Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Переключение на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Дополнительная информация о [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
