---
title: صادرات فونت‌های SHX
type: docs
weight: 40
url: /fa/java/developer-guide/export-shx-fonts/
---

## **صادرات فونت‌های SHX برای نقشه‌های DXF/DWG**

برخی از نقشه‌ها ممکن است شامل فونت‌ها در فرمت خاص SHX باشند که نمادهای فونت را به شکل اشکال ذخیره می‌کند.
این فرمت نیاز به یک رویه بارگذاری اضافی برای هر فونتی که در نقشه استفاده می‌شود دارد.
Apose.CAD می‌تواند نقشه‌ها را با متنی که به صورت SHX نوشته شده است صادر کند و گزینه‌های مختلفی برای انجام این کار دارد.
ساده‌ترین راه برای انجام این کار فقط استفاده از [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 
خصوصیت شیء [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) است.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

هر فونت SHX با صفحه کد مربوط به خود همراه است. این ارتباطات شناخته شده و به‌طور جزئی در Aspose.CAD برای فونت‌های SHX شناخته شده گنجانده شده است.
در صورت استفاده از یک فونت SHX سفارشی، می‌توان از خصوصیت **setShxCodePages** استفاده کرد و مسیر فایل SHX و صفحه کد مربوطه را تنظیم کرد.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
