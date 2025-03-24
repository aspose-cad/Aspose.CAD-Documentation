---
title: چگونه Aspose.CAD را در Docker اجرا کنیم
type: docs
description: "اجرای Aspose.CAD در یک کانتینر Docker برای لینوکس، ویندوز سرور و هر سیستم عاملی."
weight: 71
url: /fa/net/showcases/how-to-run-aspose-cad-in-docker/
---

## پیش‌نیازها
- Docker باید بر روی سیستم شما نصب شده باشد. برای اطلاعات در مورد نحوه نصب Docker در ویندوز یا مک، به لینک‌های موجود در بخش «همچنین ببینید» مراجعه کنید.
- Visual Studio 2022.
- NET 6 SDK در این مثال استفاده شده است.

## برنامه Hello World

در این مثال، شما یک برنامه ساده Hello World کنسولی ایجاد می‌کنید که یک بیضی را ترسیم کرده و آن را به عنوان یک تصویر ذخیره می‌کند. سپس این برنامه می‌تواند در Docker ساخته و اجرا شود.

## ایجاد برنامه کنسولی

برای ایجاد برنامه Hello World، مراحل زیر را دنبال کنید:
1. پس از نصب Docker، مطمئن شوید که از کانتینرهای لینوکس استفاده می‌کند (پیش‌فرض). در صورت لزوم، گزینه Switch to Linux containers را از منوی Docker Desktop انتخاب کنید.
1. در Visual Studio، یک برنامه کنسولی NET 6 ایجاد کنید.<br>
![گفتگوی پروژه برنامه کنسولی NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. آخرین نسخه Aspose.CAD را از NuGet نصب کنید.<br>
![Aspose.CAD در NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. از آن‌جا که برنامه در لینوکس اجرا خواهد شد، ممکن است نیاز به نصب فونت‌های اضافی داشته باشید. شما می‌توانید ttf-mscorefonts-installer را ترجیح دهید.
1. هنگامی که تمام وابستگی‌های مورد نیاز اضافه شد، یک برنامه ساده بنویسید که یک بیضی ایجاد کرده و آن را به عنوان یک تصویر ذخیره کند:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

به یاد داشته باشید که پوشه «TestOut» به عنوان پوشه خروجی برای ذخیره اسناد خروجی تعیین شده است. هنگام اجرای برنامه در Docker، یک پوشه در ماشین میزبان به این پوشه در کانتینر متصل خواهد شد. این کار به شما این امکان را می‌دهد که به راحتی خروجی تولید شده توسط Aspose.CAD در کانتینر Docker را مشاهده کنید.

### پیکربندی Dockerfile

 مرحله بعدی ایجاد و پیکربندی Dockerfile است.

1. Dockerfile را ایجاد کرده و آن را در کنار فایل راه حل برنامه خود قرار دهید. این نام فایل را بدون پسوند (پیش‌فرض) نگه دارید.
1. در Dockerfile، مشخص کنید:

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

 در بالا یک Dockerfile ساده وجود دارد که شامل دستورالعمل‌های زیر است:

- تصویری که باید استفاده شود. در اینجا تصویر Net 6 است. Docker هنگام اجرای ساخت، آن را دانلود می‌کند. نسخه SDK به عنوان یک برچسب مشخص شده است.
- بعد، ممکن است نیاز به نصب فونت‌ها داشته باشید زیرا تصویر SDK شامل فونت‌های بسیار کمی است. همچنین، می‌توانید از فونت‌های محلی کپی شده به تصویر Docker استفاده کنید.
- دایرکتوری کار، که در خط بعدی مشخص شده است.
- دستوری برای کپی همه چیز به کانتینر، انتشار برنامه و مشخص کردن نقطه ورودی.


## ساخت و اجرای برنامه در Docker
 
 حالا برنامه می‌تواند در Docker ساخته و اجرا شود. ترمینال مورد علاقه خود را باز کنید، دایرکتوری را به پوشه‌ای که برنامه در آن قرار دارد (پوشه‌ای که فایل راه حل و Dockerfile در آن قرار دارد) تغییر دهید و دستور زیر را اجرا کنید:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 اولین بار که این دستور اجرا می‌شود ممکن است زمان بیشتری ببرد، زیرا Docker نیاز به دانلود تصاویر مورد نیاز دارد. هنگامی که دستور قبلی به پایان رسید، دستور زیر را اجرا کنید:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
به آرگومان mount توجه کنید، زیرا همانطور که قبلاً ذکر شد، یک پوشه در ماشین میزبان به پوشه کانتینر متصل می‌شود تا به راحتی نتایج اجرای برنامه را ببینید. مسیرها در لینوکس به حروف بزرگ و کوچک حساس هستند.
{{% /alert %}}

## مثال‌های بیشتر

برای نمونه‌های بیشتر از اینکه چگونه می‌توانید از Aspose.CAD در Docker استفاده کنید، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.


## همچنین ببینید

- [نصب Docker Desktop در ویندوز](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop در مک](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [تغییر به کانتینرهای لینوکس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) گزینه
- اطلاعات اضافی در مورد [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
