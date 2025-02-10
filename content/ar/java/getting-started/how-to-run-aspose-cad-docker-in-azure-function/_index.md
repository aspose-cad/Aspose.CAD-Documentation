---
title: كيفية تشغيل صورة Docker الخاصة بـ Aspose.CAD في Azure Function
type: docs
description: "تشغيل صورة Docker الخاصة بـ Aspose.CAD في Azure Function."
weight: 71
url: /ar/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## المتطلبات الأساسية
- يجب أن يكون Docker مثبتًا على نظامك. لمزيد من المعلومات حول كيفية تثبيت Docker على Windows أو Mac، يرجى الرجوع إلى الروابط في قسم "انظر أيضًا".
- IntelliJ IDEA.
- Azure Toolkit لـ IntelliJ.
- Postman.

## Azure Function

في هذا المثال، تقوم بإنشاء دالة تحويل بسيطة تقوم بتحويل ملف CAD وحفظه كصورة. يمكن بعد ذلك بناء التطبيق في Docker وتشغيله في Azure Function.

## إنشاء Azure Function

لإنشاء برنامج Azure Function، اتبع الخطوات أدناه:
1. بمجرد تثبيت Docker، تأكد من أنه يستخدم حاويات Linux (الإعداد الافتراضي). إذا لزم الأمر، اختر خيار التبديل إلى حاويات Linux من قائمة Docker Desktops.
1. أنشئ مشروع Azure Function في IntelliJ IDEA.<br>
![إنشاء مشروع Azure Function](/_assets/create-function-ide-1.png)<br>
![إنشاء مشروع Azure Function - نهائي](/_assets/create-function-ide-2.png)<br>
1. أدوات->Azure->تسجيل الدخول وحدد مصادقة OAuth 2.0.<br>
![تسجيل دخول Azure](/_assets/sign-in-azure.png)<br>
1. تسجيل الدخول عبر المتصفح.
1. اختر اسم الاشتراك.
1. أضف دعم Docker.<br>
![تسجيل دخول Azure](/_assets/add-docker-support.png)<br>
1. قم بتحرير DockerFile كما هو في قسم <a href="#configuring-a-dockerfile">تكوين Dockerfile</a>.
1. أضف كتل للمستودع aspose.cad في pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. عندما تتم إضافة جميع التبعيات المطلوبة، اكتب برنامجًا بسيطًا ينشئ بيضاويًا ويحفظه كصورة:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * تستمع هذه الدالة عند النقطة النهائية "/api/HttpExample". طريقتان لاستدعائها باستخدام أمر "curl" في bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("تم معالجة طلب Java HTTP trigger.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### تكوين Dockerfile

 الخطوة التالية هي إنشاء وتكوين Dockerfile في مجلد المشروع الجذري.

1. في Dockerfile، حدد:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

 تحتوي التعليمات السابقة على Dockerfile بسيط، والذي يحتوي على التعليمات التالية:

- صورة SDK التي سيتم استخدامها. سيقوم Docker بتحميلها عند تشغيل البناء. يتم تحديد إصدار SDK كعلامة.
- الدليل العامل، الذي يتم تحديده في السطر التالي.
- الأمر لنسخ كل شيء إلى الحاوية، ونشر التطبيق، وتحديد نقطة الدخول.

## Docker Hub
1. تسجيل دخول Docker Hub
1. إنشاء مستودع عام

## بناء وتشغيل التطبيق في Docker
 
 الآن يمكن بناء التطبيق وتشغيله في Docker. افتح موجه الأوامر المفضل لديك، وقم بتغيير الدليل إلى المجلد المخصص للتطبيق (المجلد الذي توجد فيه ملف الحل و Dockerfile) واذهب إلى الأمر التالي:


1. أمر بناء Dockerfile في وحدة التحكم
{{< highlight plain >}}
//مثال
docker build -t <اسم المستخدم>/<اسم المستودع> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. في المرة الأولى التي تقوم فيها بتشغيل هذا الأمر، قد يستغرق الأمر وقتًا أطول لأن Docker يحتاج إلى تنزيل الصور الضرورية. بعد اكتمال الأمر السابق، قم بتشغيل الأمر التالي لدفع الصورة إلى Docker Hub.
{{< highlight plain >}}
//مثال
docker push <اسم المستخدم>/<اسم المستودع>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. قم بتشغيل Dockerfile في IDE وبعد دفعه إلى Docker Hub.<br>
![تشغيل Docker في IDE](/_assets/docker-run-in-ide.png)<br>
1. أدخل اسم الصورة، كما هو الحال في مستودع Docker Hub.<br>
![تشغيل Docker في IDE - التالي](/_assets/docker-run-in-ide-1.png)<br>
1. انتظر حتى النهاية.

## Azure

1. تسجيل دخول إلى Azure.
1. اختر خدمات Azure.
1. اختر Function App وأنشئ دالة.<br>
![زر إنشاء دالة Azure](/_assets/create-function-azure.png)<br>
1. قم بتكرار الإعدادات الأساسية كما هو موضح في الصورة أدناه.<br>
![إعدادات إنشاء دالة Azure](/_assets/create-function-settings.png)<br>
1. انقر على 'مراجعة + إنشاء' -> إنشاء.
1. انتظر حتى تكتمل عملية النشر.
1. انقر على زر 'انتقل إلى المورد'.<br>
![زر المورد](/_assets/go-to-resource.png)<br>
1. أوقف وظيفة aspose-cad-docker-example.<br>
![إيقاف الحاوية](/_assets/stop-container.png)<br>
1. انتقل إلى قائمة مركز النشر وقم بإجراء الإعدادات المناسبة.<br>
![مركز النشر](/_assets/deployment-center.png)<br>
1. احفظ الإعدادات
1. انسخ عنوان URL للWebhook من إعدادات مركز النشر.<br>
![عنوان URL للWebhook](/_assets/webhook-url.png)<br>
1. اذهب إلى Docker Hub، واختر المستودع الخاص بك واختر webhooks.
1. ألصق 'عنوان URL للWebhook' من Azure في عنوان URL للWebhook في Docker Hub وحدد الاسم.<br>
![إعدادات Webhook في Docker](/_assets/webhook.png)<br>
1. انقر على زر الإنشاء.
1. عد إلى نظرة عامة على وظيفة Azure وابدأ الحاوية.<br>
![قائمة النظرة العامة](/_assets/overview.png)<br>
{{% alert color="primary" %}} 
قد يستغرق بدء الوظيفة بضع دقائق.
{{% /alert %}}

## مثال على التنفيذ

1. إعدادات Postman.<br>
![إعدادات النظرة العامة](/_assets/postman-settings.png)<br>
1. اختر أي ملف DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. انقر على زر الإرسال.
1. احفظ النتيجة
![احفظ الاستجابة](/_assets/response-postman.png)<br>

{{% alert color="primary" %}} 
إذا كانت الاستجابة ناجحة، انقر على حفظ كملف وستتلقى الملف المحول بصيغة PNG
{{% /alert %}}

## المزيد من الأمثلة

للحصول على مزيد من النماذج حول كيفية استخدام Aspose.CAD في Docker، راجع [الأمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## انظر أيضًا

- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [التبديل إلى حاويات Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
