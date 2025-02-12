---
title: كيفية تشغيل Aspose.CAD في Docker
type: docs
description: "تشغيل Aspose.CAD في حاوية Docker لنظام Linux و Windows Server وأي نظام تشغيل آخر."
weight: 71
url: /ar/net/showcases/how-to-run-aspose-cad-in-docker/
---

## المتطلبات الأساسية
- يجب تثبيت Docker على نظامك. لمزيد من المعلومات حول كيفية تثبيت Docker على Windows أو Mac، راجع الروابط في قسم "انظر أيضًا".
- Visual Studio 2022.
- يتم استخدام NET 6 SDK في المثال.

## تطبيق مرحبا بالعالم

في هذا المثال، ستقوم بإنشاء تطبيق وحدة تحكم بسيط لمرحبا بالعالم يقوم برسم دائرة وحفظها كصورة. يمكن بعد ذلك بناء التطبيق وتشغيله في Docker.

## إنشاء تطبيق وحدة التحكم

لإنشاء برنامج مرحبا بالعالم، اتبع الخطوات أدناه:
1. بمجرد تثبيت Docker، تأكد من أنه يستخدم حاويات لينكس (الافتراضي). إذا لزم الأمر، اختر الخيار "التبديل إلى حاويات لينكس" من قائمة Docker Desktops.
1. في Visual Studio، أنشئ تطبيق وحدة تحكم NET 6.<br>
![مربع حوار مشروع تطبيق وحدة تحكم NET 6](/_assets/showcases/docker/1.png)<br>
1. قم بتثبيت أحدث إصدار من Aspose.CAD من NuGet.<br>
![Aspose.CAD على NuGet](/_assets/showcases/docker/2.png)<br>
1. نظرًا لأن التطبيق سيتم تشغيله على Linux، قد تحتاج إلى تثبيت خطوط إضافية. يمكنك تفضيل ttf-mscorefonts-installer.
1. عند إضافة جميع التبعيات المطلوبة، اكتب برنامجًا بسيطًا يقوم بإنشاء دائرة وحفظها كصورة:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

لاحظ أن مجلد "TestOut" محدد كمجلد إخراج لحفظ الوثائق الناتجة. عند تشغيل التطبيق في Docker، سيتم تركيب مجلد على الجهاز المضيف إلى هذا المجلد في الحاوية. سيتيح لك ذلك عرض الإخراج الناتج عن Aspose.CAD في حاوية Docker بسهولة.

### تكوين Dockerfile

 الخطوة التالية هي إنشاء وتكوين Dockerfile.

1. قم بإنشاء Dockerfile وضعه بجوار ملف الحل الخاص بتطبيقك. احتفظ بهذا الاسم بدون امتداد (افتراضي).
1. في Dockerfile، حدد:


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

 أعلاه هو Dockerfile بسيط، يحتوي على التعليمات التالية:

- صورة SDK التي سيتم استخدامها. هنا هي صورة Net 6. ستقوم Docker بتنزيلها عند تشغيل البناء. يتم تحديد إصدار SDK كعلامة.
- بعد ذلك، قد تحتاج إلى تثبيت الخطوط لأن صورة SDK تحتوي على عدد قليل جدًا من الخطوط. أيضًا، يمكنك استخدام الخطوط المحلية المنسوخة إلى صورة docker.
- الدليل العامل، الذي يتم تحديده في السطر التالي.
- الأمر لنقل كل شيء إلى الحاوية، نشر التطبيق وتحديد نقطة الدخول.

## بناء وتشغيل التطبيق في Docker

 الآن يمكن بناء التطبيق وتشغيله في Docker. افتح موجه الأوامر المفضل لديك، قم بتغيير الدليل إلى المجلد الذي يحتوي على التطبيق (المجلد الذي تم وضع ملف الحل و Dockerfile فيه) وقم بتشغيل الأمر التالي:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

 في المرة الأولى التي يتم فيها تنفيذ هذا الأمر، قد يستغرق الأمر وقتًا أطول، حيث يحتاج Docker إلى تنزيل الصور المطلوبة. بمجرد الانتهاء من الأمر السابق، قم بتشغيل الأمر التالي:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile من Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
يرجى الانتباه إلى وسيط التركيب، لأنه، كما ذُكر سابقًا، تم تركيب مجلد على الجهاز المضيف في مجلد الحاوية، لرؤية نتائج تنفيذ التطبيق بسهولة. المسارات في Linux حساسة لحالة الأحرف.
{{% /alert %}}

## المزيد من الأمثلة

لمزيد من العينات عن كيفية استخدام Aspose.CAD في Docker، راجع [أمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## انظر أيضًا

- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [التبديل إلى حاويات لينكس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) الخيار
- معلومات إضافية عن [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
