---
title: كيفية تشغيل صورة Aspose.CAD Docker في دالة AWS Lambda
type: docs
description: "تشغيل صورة Aspose.CAD Docker في دالة AWS Lambda."
weight: 74
url: /ar/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## المتطلبات المسبقة
- يجب أن يكون Docker مثبتًا على نظامك. لمزيد من المعلومات حول كيفية تثبيت Docker على Windows أو Mac، راجع الروابط في قسم "راجع أيضًا".
- Visual Studio 2022.
- AWS Toolkit لـ Visual Studio 2022.
- تم استخدام NET 6 SDK في المثال.
- Postman

## دالة AWS Lambda

Lambda هي خدمة حسابية تتيح لك تشغيل الكود دون الحاجة إلى توفير أو إدارة الخوادم. تقوم Lambda بتشغيل الكود الخاص بك على بنية تحتية حسابية عالية التوفر وتؤدي جميع مهام إدارة موارد الحوسبة، بما في ذلك صيانة الخوادم ونظام التشغيل، وتوفير السعة، والتوسع التلقائي، والتسجيل. باستخدام Lambda، يمكنك تشغيل الكود لأي نوع تقريبًا من التطبيقات أو خدمات الخلفية.

## إنشاء دالة AWS Lambda

{{% alert color="primary" %}} 
تأكد من أن لديك حقوق كافية لإنشاء دوال وصور AWS Lambda في سجل حاويات Amazon Elastic.
{{% /alert %}}

لإنشاء برنامج دالة AWS Lambda، اتبع الخطوات أدناه:
1. إنشاء مشروع AWS Lambda.<br>
![إنشاء زر الوظيفة في AWS](/cad/_assets/showcases/aws/create-project.png)<br>
1. اختر .NET 6 (صورة الحاوية) وانقر على زر 'إنهاء'.<br>
![إنشاء زر الدالة الهجينة](/cad/_assets/showcases/aws/create-container.png)<br>
1. افتح AWS Explorer في Visual Studio (عرض-> AWS Explorer).
1. أضف ملف تعريف بيانات الاعتماد AWS في AWS Explorer.<br>
![ملف تعريف بيانات الاعتماد](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. أدخل معرف مفتاح الوصول ومفتاح الوصول السري، يمكنك الحصول على هذه المفاتيح في بيانات الاعتماد الأمنية أو الاتصال بالمسؤول للحصول على ملف csv للتفويض.<br>
![إعدادات ملف تعريف الحساب](/cad/_assets/showcases/aws/account-profile.png)<br>
1. قم بتثبيت أحدث المكتبات من NuGet.<br>
![مدير NuGet](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. مثال على كود لتحويل صورة CAD إلى ملف PDF.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. تعديل DockerFile كما في قسم <a href="#configuring-a-dockerfile">تهيئة ملف Docker</a>.
1. ابدأ Docker Desktop.
1. نشر إلى AWS Lambda.<br>
![نشر AWS lambda](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. تعديل تكوين التحميل.<br>
![تحميل aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. انقر على زر 'تحميل'.<br>
![تحميل aws lambda الأخير](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. انتقل إلى AWS واختر Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. اختر دالتك الجديدة وأنشئ عنوان URL للدالة.<br>
![تهيئة عنوانURL للدالة](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. اختر نوع المصادقة
- AWS_IAM - فقط المستخدمون والأدوار المعتمدون يمكنهم طلب عنوان URL لدالتك.
- NONE - لن تؤدي Lambda مصادقة IAM على الطلبات إلى عنوان URL الخاص بدالتك. سيكون عنوان URL عامًا ما لم تنفذ منطق التفويض الخاص بك في دالتك.

### تهيئة ملف Docker

الخطوة التالية هي تعديل تكوين ملف Docker في المشروع.

1. في ملف Docker، حدد:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

ما سبق هو ملف Docker بسيط، يحتوي على التعليمات التالية:

- صورة SDK المراد استخدامها. هنا هي صورة Net 6. سيقوم Docker بتحميلها عند تشغيل البناء. يتم تحديد إصدار SDK كعلامة.
- بعد ذلك، قد تحتاج إلى تثبيت الخطوط لأن صورة SDK تحتوي على عدد قليل جدًا من الخطوط. كما يمكنك استخدام الخطوط المحلية المنسوخة إلى صورة docker.
- الدليل العامل، الذي يتم تحديده في السطر التالي.
- الأمر لنسخ كل شيء إلى الحاوية، نشر التطبيق، وتحديد نقطة الدخول.

## مثال على التنفيذ

1. إعدادات Postman.<br>
![قائمة نظرة عامة](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. اختر أي ملف DXF أو DWG أو DGN أو DWF أو DWFX أو IFC أو STL أو DWT أو IGES أو PLT أو CF2 أو OBJ أو HPGL أو IGS أو PCL أو FBX أو PDF أو SVG.
1. انقر على زر الإرسال.

{{% alert color="primary" %}} 
إذا كانت الإجابة ناجحة، انقر على حفظ في ملف وستتلقى الملف المحول بتنسيق PDF
{{% /alert %}}

## مزيد من الأمثلة

لمزيد من العينات حول كيفية استخدام Aspose.CAD في Docker، راجع [الأمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## راجع أيضًا.

- [تثبيت AWS Toolkit لـ Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [التبديل إلى حاويات Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) الخيار
- معلومات إضافية حول [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
