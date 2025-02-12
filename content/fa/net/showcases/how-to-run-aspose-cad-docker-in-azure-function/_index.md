---
title: چگونه تصویر Docker Aspose.CAD را در Azure Function اجرا کنیم
type: docs
description: "اجرا کردن تصویر Docker Aspose.CAD در Azure Function."
weight: 73
url: /fa/net/showcases/how-to-run-aspose-cad-docker-image-in-azure-function
---

## پیش نیازها
- Docker باید بر روی سیستم شما نصب شده باشد. برای اطلاعات در مورد چگونگی نصب Docker بر روی ویندوز یا مک، به لینک‌های موجود در بخش "همچنین ببینید" مراجعه کنید.
- Visual Studio 2022.
- SDK NET 6 در این مثال استفاده می‌شود.
- Postman

## Azure Function

در این مثال، شما یک تابع تبدیل ساده ایجاد می‌کنید که یک فایل CAD را تبدیل کرده و آن را به عنوان یک تصویر ذخیره می‌کند. سپس می‌توان برنامه را در Docker ساخت و در Azure Function اجرا کرد.

## ایجاد Azure Function

برای ایجاد برنامه Azure Function، مراحل زیر را دنبال کنید:
1. پس از نصب Docker، مطمئن شوید که از Containers لینوکس استفاده می‌کند (به صورت پیش‌فرض). در صورت لزوم، گزینه Switch to Linux containers را از منوی Docker Desktops انتخاب کنید.
1. در Visual Studio، یک Azure Function NET 6 ایجاد کنید.<br>
![گفتگوی پروژه Azure Function NET 6](/fa/_assets/Create-project.png)<br>
1. اطلاعات اضافی.<br>
![گفتگوی پروژه Azure Function NET 6](/fa/_assets/Additional-information.png)<br>
1. آخرین نسخه Aspose.CAD را از NuGet نصب کنید.<br>
![Aspose.CAD در NuGet](/fa/_assets/NuGet.png)<br>
1. از آنجا که برنامه در لینوکس اجرا خواهد شد، ممکن است نیاز به نصب فونت‌های اضافی داشته باشید. می‌توانید ttf-mscorefonts-installer را ترجیح دهید.
1. هنگامی که تمام وابستگی‌های مورد نیاز اضافه شدند، یک برنامه ساده بنویسید که یک بیضی ایجاد کرده و آن را به عنوان تصویر ذخیره کند:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("درخواست تابع HTTP C# پردازش شد.");
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

### پیکربندی Dockerfile

 مرحله بعدی ایجاد و پیکربندی Dockerfile در پوشه اصلی پروژه است.

1. Dockerfile را ایجاد کرده و آن را در کنار فایل راه حل برنامه خود قرار دهید. این نام فایل را بدون پسوند نگه دارید (به صورت پیش‌فرض).
![پوشه ریشه پروژه](/fa/_assets/root-folder.png)<br>
1. در Dockerfile، مشخص کنید:


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

 بالا یک Dockerfile ساده است که شامل دستورات زیر است:

- تصویری که باید استفاده شود. در اینجا تصویر NET 6 است. Docker آن را هنگام اجرای ساخت دانلود می‌کند. نسخه SDK به عنوان یک برچسب مشخص شده است.
- پس از آن، ممکن است نیاز به نصب فونت‌ها داشته باشید زیرا تصویر SDK شامل تعداد بسیار کمی از فونت‌ها است. همچنین می‌توانید از فونت‌های محلی کپی شده به تصویر docker استفاده کنید.
- دایرکتوری کاری که در خط بعدی مشخص شده است.
- دستور برای کپی همه چیز به کانتینر، انتشار برنامه و مشخص کردن نقطه ورودی.

## Docker Hub
1. وارد Docker Hub شوید
1. مخزن عمومی ایجاد کنید

## ساخت و اجرای برنامه در Docker
 
 اکنون می‌توان برنامه را در Docker ساخت و اجرا کرد. ترمینال مورد علاقه خود را باز کرده، دایرکتوری را به پوشه‌ای که برنامه در آن قرار دارد (پوشه‌ای که فایل راه حل و Dockerfile قرار دارد) تغییر دهید و فرمان زیر را اجرا کنید:

{{< highlight plain >}}
//مثال
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
بار اول که این دستور را اجرا می‌کنید، ممکن است طولانی‌تر شود زیرا Docker نیاز به دانلود تصاویر لازم دارد. پس از اتمام دستور قبلی، دستور زیر را برای ارسال تصویر به Docker Hub اجرا کنید:
 
{{< highlight plain >}}
//مثال
docker push <user name>/<repository name>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. وارد Azure شوید.
1. خدمات Azure را انتخاب کنید.
1. اپلیکیشن Function را انتخاب کرده و یک تابع ایجاد کنید.<br>
![دکمه ایجاد تابع Azure](/fa/_assets/create-function.png)<br>
1. تنظیمات پایه را مطابق تصویر زیر تکرار کنید.<br>
![تنظیمات ایجاد تابع Azure](/fa/_assets/create-function-setting.png)<br>
1. روی 'Review + create' کلیک کرده و سپس ایجاد کنید.
1. منتظر بمانید تا استقرار به پایان برسد.
1. روی دکمه 'Go to resource' کلیک کنید.<br>
![دکمه منبع](/fa/_assets/azure/go-to-resource.png)<br>
1. تابع aspose-cad-docker-example را متوقف کنید.<br>
![متوقف کردن کانتینر](/fa/_assets/stop-container.png)<br>
1. به منوی مرکز استقرار بروید و تنظیمات مناسب را انجام دهید.<br>
![مرکز استقرار](/fa/_assets/deployment-center.png)<br>
1. تنظیمات را ذخیره کنید
1. URL Webhook را از تنظیمات مرکز استقرار کپی کنید.<br>
![Webhook url](/fa/_assets/webhook-url.png)<br>
1. به Docker Hub بروید، مخزن خود را انتخاب کنید و وب‌هوک‌ها را انتخاب کنید.
1. 'Webhook url' را از Azure در URL وب‌هوک Docker Hub بچسبانید و نام آن را تنظیم کنید.<br>
![تنظیمات Webhook در Docker](/fa/_assets/webhook.png)<br>
1. روی دکمه ایجاد کلیک کنید.
1. به نمای کلی Azure Function بروید و کانتینر را شروع کنید.<br>
![منوی نمای کلی](/fa/_assets/overview.png)<br>

## مثال اجرای

1. تنظیمات Postman.<br>
![تنظیمات منوی Postman](/fa/_assets/postman-settings.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. روی دکمه ارسال کلیک کنید.

{{% alert color="primary" %}} 
اگر پاسخ موفقیت‌آمیز بود، روی ذخیره به فایل کلیک کنید و فایل تبدیل شده را در فرمت png دریافت خواهید کرد.
{{% /alert %}}

## مثال‌های بیشتر

برای نمونه‌های بیشتر از نحوه استفاده از Aspose.CAD در Docker، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.


## همچنین ببینید

- [نصب Docker Desktop در ویندوز](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop در مک](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- گزینه [تغییر به کانتینرهای لینوکس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- اطلاعات اضافی در مورد [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
