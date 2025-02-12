---
title: چگونه در توابع AWS Lambda تصویر Docker Aspose.CAD را اجرا کنیم
type: docs
description: "اجرای تصویر Docker Aspose.CAD در توابع AWS Lambda."
weight: 74
url: /fa/net/showcases/how-to-run-aspose-cad-docker-image-in-aws-lambda-function
---

## پیش نیازها
- Docker باید بر روی سیستم شما نصب شده باشد. برای اطلاعات در مورد نحوه نصب Docker در ویندوز یا مک، به لینک‌های بخش "به همچنین ببینید" مراجعه کنید.
- Visual Studio 2022.
- AWS Toolkit برای Visual Studio 2022.
- NET 6 SDK در این مثال استفاده می‌شود.
- Postman

## تابع AWS Lambda

Lambda یک سرویس محاسباتی است که به شما اجازه می‌دهد بدون تأمین یا مدیریت سرورها، کد اجرا کنید. Lambda کد شما را بر روی یک زیرساخت محاسباتی با دسترسی بالا اجرا کرده و تمام مدیریت منابع محاسباتی، از جمله نگهداری سرور و سیستم عامل، تأمین ظرفیت و مقیاس‌گذاری خودکار و ثبت رویدادها را انجام می‌دهد. با Lambda، می‌توانید کد را برای تقریباً هر نوع برنامه یا سرویس پشتیبانی اجرا کنید.

## ایجاد تابع AWS Lambda

{{% alert color="primary" %}} 
اطمینان حاصل کنید که حقوق کافی برای ایجاد توابع و تصاویر AWS Lambda در Amazon Elastic Container Registry دارید.
{{% /alert %}}

برای ایجاد برنامه تابع AWS Lambda، مراحل زیر را دنبال کنید:
1. پروژه AWS Lambda را ایجاد کنید.<br>
![دکمه ایجاد تابع AWS](/_assets/create-project.png)<br>
1. .NET 6 (Container Image) را انتخاب کرده و روی دکمه 'پایان' کلیک کنید.<br>
![دکمه ایجاد تابع کانتینر](/_assets/create-container.png)<br>
1. AWS Explorer را در Visual Studio باز کنید (View->AWS Explorer).
1. پروفایل اعتبارنامه AWS را در AWS Explorer اضافه کنید.<br>
![پروفایل اعتبارنامه](/_assets/add-aws-credentials-profile.png)<br>
1. Access Key ID و Secret Access Key را وارد کنید، می‌توانید این کلیدها را در اعتبارنامه امنیتی پیدا کنید یا با مدیر تماس بگیرید و یک فایل csv برای مجوز دریافت کنید.<br>
![تنظیمات پروفایل حساب](/_assets/account-profile.png)<br>
1. آخرین کتابخانه‌ها را از NuGet نصب کنید.<br>
![مدیریت NuGet](/_assets/nuget-manager.png)<br>
1. مثال کد برای تبدیل تصویر cad به فایل pdf.
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
1. فایل Docker را مانند بخش <a href="#configuring-a-dockerfile">پیکربندی Dockerfile</a> ویرایش کنید.
1. Docker Desktop را راه‌اندازی کنید.
1. به AWS Lambda منتشر کنید.<br>
![انتشار AWS Lambda](/_assets/publish-aws.png)<br>
1. پیکربندی بارگذاری را ویرایش کنید.<br>
![بارگذاری AWS Lambda](/_assets/upload-aws-lambda.png)<br>
1. روی دکمه 'بارگذاری' کلیک کنید.<br>
![بارگذاری آخرین AWS Lambda](/_assets/upload-aws-lambda-finish.png)<br>
1. به AWS بروید و Lambda را انتخاب کنید.<br>
![AWS Lambda](/_assets/select-aws-lambda.png)<br>
1. تابع جدید خود را انتخاب کرده و URL تابع را ایجاد کنید.<br>
![ایجاد URL تابع](/_assets/create-function-url.png)<br>
1. نوع احراز هویت را انتخاب کنید
- AWS_IAM - تنها کاربران و نقش‌های معتبر IAM می‌توانند درخواست‌هایی به URL تابع شما ارسال کنند.
- NONE - Lambda احراز هویت IAM را برای درخواست‌های URL تابع شما انجام نخواهد داد. نقطه پایانی URL عمومی خواهد بود، مگر اینکه منطق مجوز خود را در تابع خود پیاده‌سازی کنید.

### پیکربندی Dockerfile

 مرحله بعدی ویرایش پیکربندی Dockerfile در پروژه است.

1. در Dockerfile، مشخص کنید:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 مورد بالا یک Dockerfile ساده است که شامل دستورات زیر می‌باشد:

- تصویر SDK که باید استفاده شود. در اینجا تصویر Net 6 است. Docker آن را هنگام اجرا کردن ساخت دانلود خواهد کرد. نسخه SDK به عنوان یک برچسب مشخص شده است.
- پس از آن، شما ممکن است نیاز به نصب فونت‌ها داشته باشید زیرا تصویر SDK دارای فونت بسیار کمی است. همچنین، می‌توانید از فونت‌های محلی کپی شده به تصویر Docker استفاده کنید.
- دایرکتوری کار، که در خط بعدی مشخص شده است.
- دستور برای کپی کردن همه چیز به کانتینر، نشر برنامه و مشخص کردن نقطه ورود.

## مثال اجرای

1. تنظیمات Postman.<br>
![منوی Overview](/_assets/postman-settings.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. روی دکمه ارسال کلیک کنید.

{{% alert color="primary" %}} 
اگر پاسخ موفقیت‌آمیز بود، روی "ذخیره به فایل" کلیک کنید و شما فایل تبدیل شده را در فرمت pdf دریافت خواهید کرد.
{{% /alert %}}

## مثال‌های بیشتر

برای نمونه‌های بیشتر از نحوه استفاده از Aspose.CAD در Docker، به [نمونه‌ها](https://github.com/aspose-cad/Aspose.CAD-Documentation) مراجعه کنید.

## به همچنین ببینید.

- [نصب AWS Toolkit برای Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [نصب Docker Desktop در ویندوز](https://docs.docker.com/docker-for-windows/install/)
- [نصب Docker Desktop در مک](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- گزینه [تغییر به کانتینرهای لینوکس](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 
- اطلاعات اضافی در مورد [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
