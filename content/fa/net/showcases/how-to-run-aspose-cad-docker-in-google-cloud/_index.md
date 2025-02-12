---
title: نحوه اجرای تصویر Docker Aspose.CAD در Google Cloud
type: docs
description: "اجرای تصویر Docker Aspose.CAD در Google Cloud."
weight: 75
url: /fa/net/showcases/how-to-run-aspose-cad-docker-image-in-google-cloud
---

## پیش‌نیازها

- Docker باید بر روی سیستم شما نصب شده باشد. برای اطلاعات در مورد نحوه نصب Docker بر روی Windows یا Mac، به لینک‌های بخش "همچنین ببینید" مراجعه کنید.
- Visual Studio 2022.
- Google CLI.
- SDK NET Core 3.1 در این مثال استفاده شده است.
- Postman

## عملکرد Google Cloud Run

Cloud Run یک محیط محاسباتی کاملاً مدیریتی برای استقرار و مقیاس‌گذاری کانتینرهای HTTP بدون سرور است بدون اینکه نگران تأمین ماشین‌ها، پیکربندی خوشه‌ها یا مقیاس‌گذاری خودکار باشید.

- قفل‌گذاری فروشنده وجود ندارد - زیرا Cloud Run از کانتینرهای استاندارد OCI استفاده می‌کند و API استاندارد Knative Serving را پیاده‌سازی می‌کند، می‌توانید به راحتی برنامه‌های خود را به محیط‌های محلی یا هر محیط ابری دیگری منتقل کنید.
- مقیاس‌گذاری خودکار سریع - میکروسرویس‌های مستقر در Cloud Run به‌طور خودکار بر اساس تعداد درخواست‌های ورودی مقیاس می‌گیرند، بدون اینکه شما نیاز به پیکربندی یا مدیریت یک خوشه کامل Kubernetes داشته باشید. Cloud Run به صفر مقیاس می‌گیرد - یعنی در صورت عدم وجود درخواست، هیچ منبعی استفاده نمی‌شود.
- تقسیم ترافیک - Cloud Run به شما اجازه می‌دهد تا ترافیک را بین نسخه‌های متعدد تقسیم کنید، بنابراین می‌توانید استقرارهای تدریجی مانند استقرارهای کانیری یا استقرارهای آبی/سبز انجام دهید.
- دامنه‌های سفارشی - می‌توانید در Cloud Run نگاشتی برای دامنه سفارشی تنظیم کنید و این کار گواهی TLS برای دامنه شما فراهم می‌کند.
- افزونگی خودکار - Cloud Run افزونگی خودکار ارائه می‌دهد بنابراین شما نیازی به نگرانی درباره ایجاد چندین نمونه برای دسترسی بالا ندارید.

Cloud Run و Cloud Functions هر دو خدمات کاملاً مدیریتی هستند که بر روی زیرساخت بدون سرور Google Cloud اجرا می‌شوند، به‌طور خودکار مقیاس می‌گیرند و HTTP requests یا رویدادها را مدیریت می‌کنند. با این حال، تفاوت‌های مهمی دارند:

- Cloud Functions به شما اجازه می‌دهد تا قطعات کد (توابع) نوشته شده به زبان‌های محدود برنامه‌نویسی را مستقر کنید، در حالی که Cloud Run به شما اجازه می‌دهد تصاویر کانتینر را با استفاده از زبان برنامه‌نویسی مورد نظر خود مستقر کنید.
- Cloud Run همچنین از استفاده از هر ابزار یا کتابخانه سیستمی از برنامه شما پشتیبانی می‌کند؛ Cloud Functions به شما اجازه نمی‌دهد از اجرایی‌های سفارشی استفاده کنید.
- Cloud Run مدت زمان تایم‌اوت درخواست طولانی‌تری به مدت حداکثر 60 دقیقه ارائه می‌دهد، در حالی که با Cloud Functions، تایم‌اوت درخواست می‌تواند حداکثر تا 9 دقیقه تنظیم شود.
- Cloud Functions تنها یک درخواست در هر زمان به هر نمونه تابع ارسال می‌کند، در حالی که به طور پیش‌فرض Cloud Run به گونه‌ای پیکربندی شده است که درخواست‌های همزمان متعدد را به هر نمونه کانتینر ارسال کند. این برای بهبود تأخیر و کاهش هزینه‌ها در صورت انتظار حجم بالای درخواست‌ها مفید است.

## ایجاد پروژه Google Cloud Function

{{% alert color="primary" %}} 
اطمینان حاصل کنید که حقوق کافی برای ایجاد تابع Google Cloud Run و تصاویر در مخزن Artifact Registry دارید.
{{% /alert %}}

برای ایجاد برنامه Google Cloud Function، مراحل زیر را دنبال کنید:

1. نصب SDK NET Core 3.1.
1. نصب بسته الگو:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. سپس، یک دایرکتوری برای پروژه خود ایجاد کرده و از dotnet new برای ایجاد یک تابع HTTP جدید استفاده کنید:
{{< highlight plain >}}
mkdir AsposeFunctions //ایجاد پوشه
cd AsposeFunctions //رفتن به پوشه AsposeFunctions
dotnet new gcf-http //ایجاد پروژه Google Cloud Function با تریگر HTTP
{{< /highlight >}}
{{% alert color="primary" %}} 
این کار AsposeFunctions.csproj و Function.cs را در دایرکتوری فعلی ایجاد می‌کند. Function.cs را باز کنید تا کد را مرور کنید و در صورت تمایل یک پیام سفارشی ارائه دهید.
{{% /alert %}}
1. مثال کد برای فایل csproj (AsposeFunctions.csproj).
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
1. مثال کد برای تبدیل تصویر cad به فایل png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// منطق تابع شما در اینجا قرار دارد.
        /// </summary>
        /// <param name="context">زمینه HTTP، شامل درخواست و پاسخ.</param>
        /// <returns>یک کار که نمایانگر عملیات غیرهمزمان است.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //فایل فرم
                var file = context.Request.Body; //داده باینری
                
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
1. تابع خود را به صورت محلی با روند زیر بسازید:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. زمانی که سرور در حال اجرا است، به http://localhost:8080 بروید تا تابع را فعال کنید. در صورت متوقف کردن سرور، Ctrl-C را در کنسول فشار دهید.

## استقرار تصویر docker به Google Cloud

1. به Google Cloud وارد شوید.
1. اگر پروژه‌ای وجود ندارد، آن را ایجاد کنید.
1. به 'Artifact Registry' بروید و یک مخزن بسازید.<br>
![Create Artifact Repository](/fa/_assets/create-artifact-repository.png)<br>
1. مخزن جدید را در Artifact Registry انتخاب کنید.
![Select artifact repository](/fa/_assets/select-artifact.png)<br>
1. روی 'SETUP INSTRUCTION' کلیک کنید و دستور 'Configure Docker' را کپی کنید.<br>
![SETUP INSTRUCTION](/fa/_assets/setup-instruction.png)<br>
1. یک ورودی credHelper Docker به فایل پیکربندی Docker اضافه کنید، یا اگر وجود ندارد، آن را ایجاد کنید.
{{< highlight plain >}}
//مثال
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. یک Dockerfile در دایرکتوری ریشه پروژه ایجاد کنید و DockerFile را همان‌طور که در بخش <a href="#configuring-a-dockerfile">پیکربندی Dockerfile</a> نشان داده شده ویرایش کنید.
1. Docker Desktop را شروع کنید.
1. تصویر docker را با مسیر مخزن ابری بسازید.
{{< highlight plain >}}
//مثال
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. تصویر را به Google Cloud Artifact Registry فشار دهید.
{{< highlight plain >}}
//مثال
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## ایجاد سرویس Google Gloud Run 

1. به Cloud Run بروید.
1. سرویس Cloud Run را ایجاد کنید.<br>
![Create Cloud Run service](/fa/_assets/create-cloud-run-service.png)<br>
1. در فیلد URL تصویر کانتینر، کانتینر را از 'ARTIFACT REGISTRY' انتخاب کنید.<br>
![Container Image URL](/fa/_assets/container-url.png)<br>
1. سایر تنظیمات را همان‌طور که در زیر نشان داده شده بررسی کنید.<br>
![Settings service](/fa/_assets/cloud-run-service-settings.png)<br>
1. برای اتمام استقرار صبر کنید.
1. URL سرویس برای کار با برنامه تبدیل.<br>
![Url service](/fa/_assets/url-service.png)<br>

### پیکربندی Dockerfile

 مرحله بعدی ویرایش Dockerfile در پروژه است.

1. در Dockerfile، مشخص کنید:

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

 متن بالا یک Dockerfile ساده است که دارای دستورالعمل‌های زیر است:

- تصویری که باید استفاده شود. اینجا تصویر Net Core 3.1 است. Docker زمانی که ساخت اجرا می‌شود، آن را دانلود می‌کند. نسخه SDK به عنوان برچسب مشخص شده است.
- بعد از آن، ممکن است نیاز به نصب نویسه‌ها داشته باشید زیرا تصویر SDK شامل نویسه‌های بسیار کمی است. همچنین می‌توانید نویسه‌های محلی را که به تصویر Docker کپی شده‌اند، استفاده کنید.
- دایرکتوری کاری که در خط بعدی مشخص شده است.
- دستوری برای کپی همه چیز به کانتینر، انتشار برنامه و مشخص کردن نقطه ورودی.

## مثال اجرایی

1. تنظیمات Postman.<br>
![Overview menu](/fa/_assets/postman-settings.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. روی دکمه ارسال کلیک کنید.

{{% alert color="primary" %}} 
اگر پاسخ موفقیت‌آمیز بود، روی ذخیره به فایل کلیک کنید و شما فایل تبدیل‌شده در فرمت png را دریافت خواهید کرد.
{{% /alert %}}

## مثال‌های بیشتر

برای نمونه‌های بیشتر از نحوه استفاده از Aspose.CAD در Docker، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.

## همچنین ببینید.

- [نصب Docker Desktop بر روی Windows](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop بر روی Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، SDK NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [انتقال به کانتینرهای لینوکس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) گزینه
- اطلاعات اضافی در مورد [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
