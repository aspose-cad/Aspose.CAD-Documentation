---
title: Callback errors during export and load
type: docs
weight: 40
url: /fa/net/developer-guide/callback-errors-during-export-and-loading/
---

## **بررسی خطاهای callback در طول صادرات و بارگذاری**

ممکن است در طول صادرات یا بارگذاری نقشه‌کش با خطاهایی مربوط به ساختار فایل مواجه شویم 
(به عنوان مثال، بخش‌هایی در فایل اکنون ضروری هستند ولی قبلاً نبوده‌اند). 
برخی از این خطاها بحرانی هستند و در این موارد استثنا رخ می‌دهد، اما ما همچنین می‌توانیم برخی از آن‌ها را به طور داخلی نادیده گرفته و با استفاده از پیام‌های callback در مورد آن اطلاع‌رسانی کنیم.
به هر حال، همه این پیام‌ها نیاز به توجه دارند زیرا ممکن است توضیح دهند که به عنوان مثال، نهادهای مفقود شده در نتایج صادرات یا اثرات دیگر وجود دارند.

### **خطاها در طول صادرات**

یک فیلد RenderResult در [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/)،
وجود دارد که شامل IsRenderComplete است تا ببیند آیا در طول صادرات خطاهایی وجود داشته و اطلاعاتی در مورد آن‌ها چاپ کند:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **خطاها در طول بارگذاری**

برخی مشکلات با نقشه‌کش‌ها ممکن است قبل از شروع فرآیند صادرات مشاهده شوند. 
خاصیت [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) در
 شیء [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) برای ذخیره پیام‌ها درباره آن‌ها استفاده می‌شود.
خاصیت [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) برای تصمیم‌گیری درباره این که آیا 
لازم است در مورد خطاهای بارگذاری استثنا صادر شود یا خیر، مفید است. 

در اینجا یک مثال از استفاده از خاصیت Errors آورده شده است:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
