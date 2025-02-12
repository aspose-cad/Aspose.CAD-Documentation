---
title: چگونه تصویر Docker Aspose.CAD را در Azure Function اجرا کنیم
type: docs
description: "اجرای تصویر Docker Aspose.CAD در Azure Function."
weight: 71
url: /fa/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## پیش‌نیازها
- Docker باید بر روی سیستم شما نصب شده باشد. برای اطلاعات در مورد چگونگی نصب Docker بر روی ویندوز یا مک، به لینک‌های بخش "همچنین ببینید" مراجعه کنید.
- IntelliJ IDEA.
- Azure Toolkit برای IntelliJ.
- Postman.

## Azure Function

در این مثال، شما یک تابع ساده تبدیل ایجاد می‌کنید که یک فایل CAD را تبدیل کرده و آن را به عنوان یک تصویر ذخیره می‌کند. سپس می‌توان برنامه را در Docker ساخت و در Azure Function اجرا کرد.

## ایجاد Azure Function

برای ایجاد برنامه Azure Function، مراحل زیر را دنبال کنید:
1. پس از نصب Docker، اطمینان حاصل کنید که از کانتینرهای لینوکسی استفاده می‌کند (به طور پیش‌فرض). در صورت لزوم، گزینه Switch to Linux containers را از منوی Docker Desktop انتخاب کنید.
1. پروژه Azure Function را در IntelliJ IDEA ایجاد کنید.<br>
![Create azure function project](/fa/_assets/create-function-ide-1.png)<br>
![Create azure function project-final](/fa/_assets/create-function-ide-2.png)<br>
1. Tools->Azure->Sing In و انتخاب احراز هویت OAuth 2.0.<br>
![Azure sign In](/fa/_assets/sign-in-azure.png)<br>
1. در مرورگر ثبت‌نام کنید.
1. نام اشتراک را انتخاب کنید.
1. پشتیبانی Docker را اضافه کنید.<br>
![Azure sign In](/fa/_assets/add-docker-support.png)<br>
1. DockerFile را طبق بخش <a href="#configuring-a-dockerfile">پیکربندی Dockerfile</a> ویرایش کنید.
1. بلوک‌هایی برای مخزن aspose.cad در pom.xml اضافه کنید.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>API جاوا Aspose</name>
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

1. وقتی تمام وابستگی‌های مورد نیاز اضافه شد، یک برنامه ساده بنویسید که یک بیضی ایجاد کرده و آن را به عنوان تصویر ذخیره کند:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * این تابع در endpoint "/api/HttpExample" گوش می‌دهد. دو راه برای فراخوانی آن وجود دارد با استفاده از دستور "curl" در bash:
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
        context.getLogger().info("Java HTTP trigger processed a request.");

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

### پیکربندی Dockerfile

 مرحله بعدی ایجاد و پیکربندی Dockerfile در پوشه اصلی پروژه است.

1. در Dockerfile، مشخص کنید:
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

 بالای این یک Dockerfile ساده است که شامل دستورالعمل‌های زیر می‌باشد:

- تصویر SDK که باید استفاده شود. Docker آن را هنگام اجرای ساخت دانلود می‌کند. نسخه SDK به عنوان تگ مشخص شده است.
- دایرکتوری کاری که در خط بعد مشخص شده است.
- دستور برای کپی همه چیز به کانتینر، انتشار برنامه و مشخص کردن نقطه ورودی.

## Docker Hub
1. وارد Docker Hub شوید
1. مخزن عمومی ایجاد کنید

## ساخت و اجرای برنامه در Docker
 
 حالا برنامه می‌تواند در Docker ساخته و اجرا شود. ترمینال مورد علاقه خود را باز کنید، دایرکتوری را به پوشه‌ای که برنامه قرار دارد (پوشه‌ای که فایل راه‌حل و Dockerfile قرار دارد) تغییر دهید و دستور زیر را اجرا کنید:


1. فرمان ساخت Dockerfile در کنسول
{{< highlight plain >}}
//مثال
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. دفعه اول که این دستور را اجرا می‌کنید ممکن است زمان بیشتری ببرد زیرا Docker باید تصاویر لازم را دانلود کند. پس از اتمام دستور قبلی، دستور زیر را برای ارسال تصویر به Docker Hub اجرا کنید.
{{< highlight plain >}}
//مثال
docker push <user name>/<repository name>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Dockerfile را در IDE اجرا کرده و پس از آن به Docker Hub ارسال کنید.<br>
![Run docker in ide](/fa/_assets/docker-run-in-ide.png)<br>
1. نام تصویر را وارد کنید، مانند نام موجود در مخزن Docker Hub.<br>
![Run docker in ide-next](/fa/_assets/docker-run-in-ide-1.png)<br>
1. منتظر اتمام کار باشید.

## Azure

1. وارد Azure شوید.
1. خدمات Azure را انتخاب کنید.
1. برنامه عملکرد را انتخاب کرده و یک تابع ایجاد کنید.<br>
![Azure create function button](/fa/_assets/create-function-azure.png)<br>
1. تنظیمات اولیه را مانند تصویر زیر تکرار کنید.<br>
![Azure create function settings](/fa/_assets/create-function-settings.png)<br>
1. روی 'بررسی + ایجاد' -> ایجاد کلیک کنید.
1. منتظر اتمام استقرار باشید.
1. روی دکمه 'به منبع بروید' کلیک کنید.<br>
![Resource button](/fa/_assets/go-to-resource.png)<br>
1. عملکرد aspose-cad-docker-example را متوقف کنید.<br>
![Stop conteiner](/fa/_assets/stop-container.png)<br>
1. به منوی مرکز استقرار بروید و تنظیمات مناسب را انجام دهید.<br>
![Deployment center](/fa/_assets/deployment-center.png)<br>
1. تنظیمات را ذخیره کنید.
1. URL Webhook را از تنظیمات مرکز استقرار کپی کنید.<br>
![Webhook url](/fa/_assets/webhook-url.png)<br>
1. به Docker Hub بروید، مخزن خود را انتخاب کرده و وب‌هوک‌ها را انتخاب کنید.
1. 'Webhook url' را از Azure در URL webhook Docker Hub قرار دهید و نام را تنظیم کنید.<br>
![Webhook settings in docker](/fa/_assets/webhook.png)<br>
1. روی دکمه ایجاد کلیک کنید.
1. به نمای کلی عملکرد Azure برگردید و کانتینر را شروع کنید.<br>
![Overview menu](/fa/_assets/overview.png)<br>
{{% alert color="primary" %}} 
ممکن است برای شروع تابع چند دقیقه طول بکشد.
{{% /alert %}}

## مثال اجرای

1. تنظیمات Postman.<br>
![Overview menu](/fa/_assets/postman-settings.png)<br>
1. یک فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. روی دکمه ارسال کلیک کنید.
1. نتیجه را ذخیره کنید
![Save responce](/fa/_assets/response-postman.png)<br>

{{% alert color="primary" %}} 
اگر پاسخ موفقیت آمیز بود، روی ذخیره به فایل کلیک کنید و فایل تبدیل شده به فرمت png را دریافت خواهید کرد.
{{% /alert %}}

## نمونه‌های بیشتر

برای نمونه‌های بیشتر از اینکه چگونه می‌توانید از Aspose.CAD در Docker استفاده کنید، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.


## همچنین ببینید

- [نصب Docker Desktop در ویندوز](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop بر روی مک](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [انتقال به کانتینرهای لینوکسی](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
