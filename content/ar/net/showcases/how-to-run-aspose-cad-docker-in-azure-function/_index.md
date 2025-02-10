---
title: كيفية تشغيل صورة Aspose.CAD Docker في وظيفة Azure
type: docs
description: "تشغيل صورة Aspose.CAD Docker في وظيفة Azure."
weight: 73
url: /ar/net/how-to-run-aspose-cad-docker-image-in-azure-function
---

## المتطلبات الأساسية
- يجب تثبيت Docker على نظامك. لمزيد من المعلومات حول كيفية تثبيت Docker على Windows أو Mac، راجع الروابط في قسم "رؤية أخرى".
- Visual Studio 2022.
- يتم استخدام NET 6 SDK في هذا المثال.
- Postman

## وظيفة Azure

في هذا المثال، ستقوم بإنشاء وظيفة تحويل بسيطة تقوم بتحويل ملف CAD وتخزينه كصورة. يمكن بعد ذلك إنشاء التطبيق في Docker وتشغيله في وظيفة Azure.

## إنشاء وظيفة Azure

لإنشاء برنامج وظيفة Azure، اتبع الخطوات أدناه:
1. بعد تثبيت Docker، تأكد من استخدامه للحاويات الخاصة بنظام Linux (الإعداد الافتراضي). إذا لزم الأمر، اختر خيار التبديل إلى حاويات Linux من قائمة سطح مكتب Docker.
1. في Visual Studio، أنشئ وظيفة Azure NET 6.<br>
![نافذة مشروع وظيفة Azure NET 6](/_assets/Create-project.png)<br>
1. معلومات إضافية.<br>
![نافذة مشروع وظيفة Azure NET 6](/_assets/Additional-information.png)<br>
1. قم بتثبيت أحدث إصدار من Aspose.CAD من NuGet.<br>
![Aspose.CAD على NuGet](/_assets/NuGet.png)<br>
1. نظرًا لأن التطبيق سيعمل على Linux، قد تحتاج إلى تثبيت خطوط إضافية. يمكنك تفضيل ttf-mscorefonts-installer.
1. عندما تتم إضافة جميع التبعيات المطلوبة، اكتب برنامجًا بسيطًا ينشئ بيضاويًا ويخزنه كصورة:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("تم معالجة طلب وظيفة HTTP C#.");
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

### تكوين ملف Dockerfile

 الخطوة التالية هي إنشاء وتكوين ملف Dockerfile في مجلد المشروع الجذر.

1. أنشئ ملف Dockerfile وضعه بجوار ملف الحل الخاص بتطبيقك. احتفظ بهذا الاسم بدون الامتداد (الإعداد الافتراضي).
![مجلد المشروع الجذر](/_assets/root-folder.png)<br>
1. في ملف Dockerfile، حدد:


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

 يحتوي المثال أعلاه على ملف Dockerfile بسيط، يتضمن التعليمات التالية:

- صورة SDK التي سيتم استخدامها. هنا هي صورة Net 6. سيتم تنزيل Docker عند تشغيل البناء. يتم تحديد إصدار SDK كعلامة.
- بعد ذلك، قد تحتاج إلى تثبيت الخطوط لأن صورة SDK تحتوي على عدد قليل جدًا من الخطوط. أيضًا، يمكنك استخدام الخطوط المحلية المنسوخة إلى صورة docker.
- دليل العمل، الذي يتم تحديده في السطر التالي.
- الأمر لنسخ كل شيء إلى الحاوية، ونشر التطبيق، وتحديد نقطة الدخول.

## Docker Hub
1. تسجيل الدخول إلى Docker Hub
1. إنشاء مستودع عام

## بناء وتشغيل التطبيق في Docker
 
 الآن يمكن بناء التطبيق وتشغيله في Docker. افتح موجه الأوامر المفضل لديك، غير الدليل إلى المجلد الذي يحتوي على التطبيق (المجلد الذي يوجد فيه ملف الحل وملف Dockerfile) وانفذ الأمر التالي:

{{< highlight plain >}}
//مثال
docker build -t <اسم المستخدم>/<اسم المستودع> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
في المرة الأولى التي تقوم فيها بتشغيل هذا الأمر، قد يستغرق الأمر وقتًا أطول لأن Docker يحتاج لتنزيل الصور الضرورية. بعد اكتمال الأمر السابق، قم بتشغيل الأمر التالي لدفع الصورة إلى Docker Hub:
 
{{< highlight plain >}}
//مثال
docker push <اسم المستخدم>/<اسم المستودع>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. تسجيل الدخول إلى Azure.
1. اختر خدمات Azure.
1. اختر وظيفة التطبيق وقم بإنشاء وظيفة.<br>
![زر إنشاء وظيفة Azure](/_assets/create-function.png)<br>
1. كرر الإعدادات الأساسية كما في الصورة أدناه.<br>
![إعدادات إنشاء وظيفة Azure](/_assets/create-function-setting.png)<br>
1. انقر على "مراجعة + إنشاء" -> إنشاء.
1. انتظر حتى تكتمل عملية النشر.
1. انقر على زر "انتقل إلى المورد".<br>
![زر المورد](/_assets/go-to-resource.png)<br>
1. أوقف وظيفة asp-cad-docker-example.<br>
![أوقف الحاوية](/_assets/stop-container.png)<br>
1. انتقل إلى قائمة مركز النشر واضبط الإعدادات المناسبة.<br>
![مركز النشر](/_assets/deployment-center.png)<br>
1. احفظ الإعدادات
1. انسخ عنوان URL للويب هوك من إعدادات مركز النشر.<br>
![عنوان URL للويب هوك](/_assets/webhook-url.png)<br>
1. انتقل إلى Docker Hub، اختر مستودعك واختر الويب هوكس.
1. قم بلصق "عنوان URL للويب هوك" من Azure في عنوان URL للويب هوك في Docker Hub وحدد الاسم.<br>
![إعدادات الويب هوك في Docker](/_assets/webhook.png)<br>
1. انقر على زر الإنشاء.
1. عد إلى نظرة عامة على وظيفة Azure وابدأ الحاوية.<br>
![قائمة نظرة عامة](/_assets/overview.png)<br>

## مثال على التنفيذ

1. إعدادات Postman.<br>
![قائمة نظرة عامة](/_assets/postman-settings.png)<br>
1. اختر أي ملف DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. انقر على زر الإرسال.

{{% alert color="primary" %}} 
إذا كانت الإجابة ناجحة، انقر على "حفظ إلى ملف" وستتلقى الملف المحول بتنسيق png
{{% /alert %}}

## المزيد من الأمثلة

للمزيد من العينات حول كيفية استخدام Aspose.CAD في Docker، راجع [الأمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## رؤية أخرى

- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [التبديل إلى حاويات Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) الخيار
- معلومات إضافية حول [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
