---
title: Як запустити Docker-образ Aspose.CAD у Google Cloud
type: docs
description: "Запустіть Docker-образ Aspose.CAD у Google Cloud."
weight: 75
url: /uk/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Попередні вимоги

- Docker повинен бути встановлений на вашій системі. Для інформації про те, як встановити Docker на Windows або Mac, зверніться до посилань у розділі "Дивіться також".
- Visual Studio 2022.
- Google CLI.
- У прикладі використовується .NET Core 3.1 SDK.
- Postman

## Функція Google Cloud Run

Cloud Run — це повністю кероване обчислювальне середовище для розгортання та масштабування безсерверних HTTP-контейнерів без необхідності турбуватися про постачання машин, налаштування кластерів або автоматичне масштабування.

- Немає прив’язки до постачальника - оскільки Cloud Run використовує стандартні OCI-контейнери та реалізує стандартний API Knative Serving, ви можете легко перенести свої додатки на локальні сервери або будь-яке інше хмарне середовище.
- Швидке автоматичне масштабування - мікросервіси, розгорнуті в Cloud Run, автоматично масштабуються залежно від кількості вхідних запитів, без потреби в налаштуванні або управлінні повноцінним кластером Kubernetes. Cloud Run масштабується до нуля — тобто не використовує ресурси — якщо немає запитів.
- Розподіл трафіку - Cloud Run дозволяє розподілити трафік між кількома версіями, тому ви можете виконати поетапне розгортання, таке як канаркове або синє/зелене розгортання.
- Настроювані домени - ви можете налаштувати відображення власного домену в Cloud Run, і він створить сертифікат TLS для вашого домену.
- Автоматична відмовостійкість - Cloud Run пропонує автоматичну відмовостійкість, тому вам не потрібно турбуватися про створення кількох примірників для високої доступності.

Cloud Run і Cloud Functions — це обидва повністю керовані сервіси, які працюють на безсерверній інфраструктурі Google Cloud, автоматично масштабуються та обробляють HTTP-запити або події. Однак у них є деякі суттєві відмінності:

- Cloud Functions дозволяє вам розгортати фрагменти коду (функції), написані на обмеженій кількості мов програмування, тоді як Cloud Run дозволяє вам розгортати образи контейнерів, використовуючи обрану вами мову програмування.
- Cloud Run також підтримує використання будь-якого інструменту або системної бібліотеки з вашого додатка; Cloud Functions не дозволяє використовувати власні виконувані файли.
- Cloud Run пропонує більший час очікування запитів до 60 хвилин, тоді як для Cloud Functions тайм-аут запитів можна встановити на максимум 9 хвилин.
- Cloud Functions надсилає лише один запит одночасно до кожного примірника функції, тоді як за замовчуванням Cloud Run налаштовано на надсилання кількох паралельних запитів на кожен примірник контейнера. Це корисно для покращення затримки та зниження витрат, якщо ви очікуєте великі обсяги.

## Створення проекту Google Cloud Function

{{% alert color="primary" %}} 
Переконайтеся, що у вас є достатні права для створення функції Google Cloud Run та образів у сховищі Artifact Registry.
{{% /alert %}}

Щоб створити програму Google Cloud Function, виконайте такі кроки:

1. Встановіть .NET Core SDK 3.1.
1. Встановіть пакет шаблону:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Далі створіть каталог для свого проекту та використовуйте dotnet new для створення нової HTTP-функції:
{{< highlight plain >}}
mkdir AsposeFunctions //створіть папку
cd AsposeFunctions //перейдіть до папки AsposeFunctions
dotnet new gcf-http //створіть проект Google Cloud Function з http-тригером
{{< /highlight >}}
{{% alert color="primary" %}} 
Це створює AsposeFunctions.csproj та Function.cs у поточному каталозі. Відкрийте Function.cs, щоб переглянути код, і надайте власне повідомлення, якщо хочете.
{{% /alert %}}
1. Приклад коду для файлу csproj (AsposeFunctions.csproj).
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
1. Приклад коду для перетворення CAD-образу на файл PNG (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Логіка для вашої функції йде сюди.
        /// </summary>
        /// <param name="context">HTTP-контекст, що містить запит і відповідь.</param>
        /// <returns>Завдання, що представляє асинхронну операцію.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //файл форми
                var file = context.Request.Body; //бінарні дані
                
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
1. Запустіть вашу функцію локально наступним чином:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Після того, як сервер запуститься, перейдіть за адресою http://localhost:8080, щоб викликати функцію. Натисніть Ctrl-C у консолі, щоб зупинити сервер.

## Розгортання образу Docker у Google Cloud

1. Увійдіть до Google Cloud.
1. Створіть проект, якщо його не існує.
1. Перейдіть до 'Artifact Registry' та створіть репозиторій.<br>
![Створіть сховище артефактів](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Виберіть новий репозиторій у Artifact Registry.
![Виберіть репозиторій артефактів](/cad/_assets/showcases/google/select-artifact.png)<br>
1. Натисніть 'ІНСТРУКЦІЇ З НАЛАШТУВАННЯ' та скопіюйте команду 'Налаштувати Docker'.<br>
![ІНСТРУКЦІЇ З НАЛАШТУВАННЯ](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Додайте запис Docker credHelper до файлу конфігурації Docker або створіть файл, якщо він не існує.
{{< highlight plain >}}
//приклад
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Створіть файл Dockerfile у кореневому каталозі проекту та відредагуйте DockerFile, як у <a href="#configuring-a-dockerfile">Розділі налаштування Dockerfile</a>.
1. Запустіть Docker Desktop.
1. Побудуйте образ Docker з шляхом до хмарного репозиторію.
{{< highlight plain >}}
//приклад
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Завантажте образ до Google Cloud Artifact Registry
{{< highlight plain >}}
//приклад
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Створення сервісу Google Cloud Run 

1. Перейдіть до Cloud Run.
1. Створіть сервіс Cloud Run.<br>
![Створіть сервіс Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. У полі URL контейнера виберіть контейнер із 'ARTIFACT REGISTRY'.<br>
![URL контейнера](/cad/_assets/showcases/google/container-url.png)<br>
1. Перевірте інші налаштування, як наведено нижче.<br>
![Налаштування сервісу](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Зачекайте, поки завершиться розгортання.
1. URL сервісу для роботи з програмою конвертації.<br>
![URL сервісу](/cad/_assets/showcases/google/url-service.png)<br>

### Налаштування Dockerfile

Наступним кроком буде редагування конфігурації Dockerfile у проекті.

1. В Dockerfile вкажіть:

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

Наведеними вище простий Dockerfile, який містить наступні інструкції:

- Зображення SDK, що використовуватиметься. Тут це зображення Net Core 3.1. Docker завантажить його під час виконання збірки. Версія SDK вказується як тег.
- Далі, вам може знадобитися встановити шрифти, оскільки зображення SDK містить дуже мало шрифтів. Крім того, ви можете використовувати локальні шрифти, скопійовані в образ Docker.
- Робочий каталог, який вказується в наступному рядку.
- Команда, яка копіює все в контейнер, публікує додаток і вказує точку входу.

## Приклад виконання

1. Налаштування Postman.<br>
![Меню огляду](/cad/_assets/showcases/google/postman-settings.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Натисніть кнопку надсилання.

{{% alert color="primary" %}} 
Якщо відповідь успішна, натисніть "Зберегти у файл", і ви отримаєте перетворений файл у форматі PNG
{{% /alert %}}

## Більше прикладів

Для отримання додаткових прикладів того, як ви можете використовувати Aspose.CAD у Docker, див. [приклади](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Дивіться також.

- [Встановіть Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Встановіть Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Перемикання на контейнери Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) варіант
- Додаткова інформація про [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
