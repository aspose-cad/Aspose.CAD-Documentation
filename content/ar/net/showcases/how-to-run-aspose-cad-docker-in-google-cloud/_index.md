---
title: كيفية تشغيل صورة Aspose.CAD Docker في Google Cloud
type: docs
description: "تشغيل صورة Aspose.CAD Docker في Google Cloud."
weight: 75
url: /ar/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## المتطلبات الأساسية

- يجب أن يكون Docker مثبتًا على نظامك. لمعلومات حول كيفية تثبيت Docker على Windows أو Mac، يرجى الرجوع إلى الروابط في قسم "انظر أيضًا".
- Visual Studio 2022.
- Google CLI.
- تم استخدام NET Core 3.1 SDK في المثال.
- Postman

## وظيفة Google Cloud Run

Cloud Run هو بيئة حساب مُدارة بالكامل لنشر وتوسيع الحاويات غير الخادمة (serverless) HTTP دون الحاجة للقلق بشأن تزويد الآلات، أو تكوين الكتل، أو التوسيع التلقائي.

- لا يوجد احتجاز بائع - نظرًا لأن Cloud Run يأخذ حاويات OCI القياسية ويطبق واجهة برمجة التطبيقات Knative Serving القياسية، يمكنك بسهولة نقل تطبيقاتك إلى الموقع أو أي بيئة سحابية أخرى.
- التوسع التلقائي السريع - الخدمات الصغيرة (Microservices) المنشورة في Cloud Run تتوسع تلقائيًا بناءً على عدد الطلبات الواردة، دون الحاجة إلى إعداد أو إدارة كتلة Kubernetes متكاملة. Cloud Run يمكن أن يتوسع إلى الصفر - أي، لا يستخدم أي موارد - إذا لم تكن هناك طلبات.
- تقسيم الحركة - يتيح لك Cloud Run تقسيم الحركة بين إصدارات متعددة، بحيث يمكنك إجراء طرح تدريجي مثل نشر الكاناري أو نشر الأزرق/الأخضر.
- النطاقات المخصصة - يمكنك إعداد تعيين نطاق مخصص في Cloud Run وسوف يوفر شهادة TLS لنطاقك.
- التكرار التلقائي - يقدم Cloud Run تكرارًا تلقائيًا بحيث لا داعي للقلق بشأن إنشاء عدة نسخ لتوفير توافر عالي.

كل من Cloud Run و Cloud Functions هما خدمات مُدارة بالكامل تعمل على البنية التحتية غير الخادمة من Google Cloud، وتقوم بالتوسع تلقائيًا، وتعالج طلبات HTTP أو الأحداث. ومع ذلك، هناك بعض الاختلافات المهمة:

- يسمح لك Cloud Functions بنشر مقاطع من الشيفرة (الدوال) المكتوبة في مجموعة محدودة من لغات البرمجة، بينما يسمح لك Cloud Run بنشر صور الحاوية باستخدام لغة البرمجة التي تختارها.
- يدعم Cloud Run أيضًا استخدام أي أداة أو مكتبة نظام من تطبيقك؛ بينما لا يسمح لك Cloud Functions باستخدام التنفيذيات المخصصة.
- يقدم Cloud Run مدة تجاوز طلب أطول تصل إلى 60 دقيقة، بينما يمكن تعيين تجاوز الطلبات في Cloud Functions إلى 9 دقائق كحد أقصى.
- يرسل Cloud Functions طلبًا واحدًا في كل مرة إلى كل مثيل دالة، بينما يتم تكوين Cloud Run افتراضيًا لإرسال طلبات متعددة متزامنة على كل مثيل من الحاوية. هذا مفيد لتحسين زمن الوصول وتقليل التكاليف إذا كنت تتوقع أحجامًا كبيرة.

## إنشاء مشروع Google Cloud Function

{{% alert color="primary" %}} 
تأكد من حصولك على حقوق كافية لإنشاء وظيفة Google Cloud Run والصور في مستودع Artifact Registry.
{{% /alert %}}

لإنشاء برنامج Google Cloud Function، اتبع الخطوات أدناه:

1. تثبيت .NET Core SDK 3.1.
1. تثبيت حزمة القوالب:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. بعد ذلك، قم بإنشاء دليل لمشروعك، واستخدم dotnet new لإنشاء دالة HTTP جديدة:
{{< highlight plain >}}
mkdir AsposeFunctions //إنشاء مجلد
cd AsposeFunctions //الذهاب إلى مجلد AsposeFunctions
dotnet new gcf-http //إنشاء مشروع Google Cloud Function مع مشغل http
{{< /highlight >}}
{{% alert color="primary" %}} 
هذا يقوم بإنشاء AsposeFunctions.csproj و Function.cs في الدليل الحالي. افتح Function.cs لمراجعة الشيفرة، وقدم رسالة مخصصة إذا رغبت في ذلك.
{{% /alert %}}
1. مثال على الشيفرة لملف csproj (AsposeFunctions.csproj).
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
1. مثال على الشيفرة لتحويل صورة cad إلى ملف png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// المنطق لدالتك هنا.
        /// </summary>
        /// <param name="context">سياق HTTP، يحتوي على الطلب والاستجابة.</param>
        /// <returns>مهمة تمثل العملية غير المتزامنة.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //ملف النموذج
                var file = context.Request.Body; //بيانات ثنائية
                
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
1. قم بإنشاء دالتك محليًا كالتالي:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. بمجرد تشغيل الخادم، انتقل إلى http://localhost:8080 لاستدعاء الدالة. اضغط Ctrl-C في وحدة التحكم لإيقاف الخادم.

## نشر صورة Docker إلى Google Cloud

1. تسجيل الدخول إلى Google Cloud.
1. إنشاء مشروع إذا لم يكن موجودًا.
1. الذهاب إلى "Artifact Registry" وإنشاء مستودع.<br>
![إنشاء مستودع Artifact](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. حدد مستودع جديد في Artifact Registry.
![حدد مستودع artifact](/cad/_assets/showcases/google/select-artifact.png)<br>
1. اضغط على 'SETUP INSTRUCTION' ونسخ الأمر 'Configure Docker'.<br>
![SETUP INSTRUCTION](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. أضف إدخال credHelper لـ Docker إلى ملف إعدادات Docker، أو أنشئ الملف إذا لم يكن موجودًا.
{{< highlight plain >}}
//مثال
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. أنشئ Dockerfile في الدليل الجذري للمشروع وقم بتحرير DockerFile كما في قسم <a href="#configuring-a-dockerfile">تكوين Dockerfile</a>.
1. ابدأ Docker Desktop.
1. قم ببناء صورة Docker مع مسار المستودع السحابي.
{{< highlight plain >}}
//مثال
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. ادفع الصورة إلى Google Cloud Artifact Registry
{{< highlight plain >}}
//مثال
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## إنشاء خدمة Google Cloud Run 

1. انتقل إلى Cloud Run.
1. إنشاء خدمة Cloud Run.<br>
![إنشاء خدمة Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. في حقل عنوان URL لصورة الحاوية، حدد الحاوية من 'ARTIFACT REGISTRY'.<br>
![عنوان URL لصورة الحاوية](/cad/_assets/showcases/google/container-url.png)<br>
1. تحقق من الإعدادات الأخرى كما هو موضح أدناه.<br>
![إعدادات الخدمة](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. انتظر حتى تنتهي عملية النشر.
1. عنوان URL للخدمة للعمل مع تطبيق التحويل.<br>
![عنوان الخدمة](/cad/_assets/showcases/google/url-service.png)<br>

### تكوين Dockerfile

 الخطوة التالية هي تحرير تكوين Dockerfile في المشروع.

1. في Dockerfile، حدد:

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

 ما سبق هو Dockerfile بسيط، يحتوي على التعليمات التالية:

- صورة SDK المراد استخدامها. هنا هي صورة Net Core 3.1. سوف يقوم Docker بتنزيلها عندما يتم تشغيل البناء. تم تحديد إصدار SDK كعلامة.
- بعد ذلك، قد تحتاج إلى تثبيت الخطوط لأن صورة SDK تحتوي على عدد قليل جدًا من الخطوط. أيضًا، يمكنك استخدام الخطوط المحلية المنسوخة إلى صورة Docker.
- دليل العمل، والذي يتم تحديده في السطر التالي.
- الأمر لنسخ كل شيء إلى الحاوية، نشر التطبيق، وتحديد نقطة الدخول.

## مثال على التنفيذ

1. إعدادات Postman.<br>
![قائمة نظرة عامة](/cad/_assets/showcases/google/postman-settings.png)<br>
1. اختر أي ملف DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. اضغط على زر الإرسال.

{{% alert color="primary" %}} 
إذا كانت الاستجابة ناجحة، انقر على "حفظ إلى ملف" وستتلقى الملف المحول بصيغة PNG.
{{% /alert %}}

## المزيد من الأمثلة

لمزيد من العينات حول كيفية استخدام Aspose.CAD في Docker، راجع [أمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## انظر أيضًا.

- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [التحويل إلى حاويات Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) الخيار
- معلومات إضافية حول [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)