---
title: خروجی فونت های SHX
type: docs
weight: 40
url: /fa/net/export-shx-fonts/
---

## **خروجی فونت های SHX برای رسم های DXF/DWG**

برخی از رسم ها ممکن است فونت هایی در فرمت خاص SHX داشته باشند که نمادهای فونت را به شکل اشکال ذخیره می کند. این فرمت نیاز به بارگذاری اضافی برای هر فونت استفاده شده در نقاشی دارد. Apose.CAD می تواند نقاشی هایی را با متنی که در SHX نوشته شده صادر کند و گزینه های مختلفی برای انجام این کار دارد. ساده ترین راه برای انجام این کار، استفاده از 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) ویژگی 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) شی است.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxFonts.cs">}}


با استفاده از مثال زیر، می توان از تنظیم مسیرهای متعدد فونت های SHX جلوگیری کرد:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxFonts با پوشه.cs">}}
	
هر فونت SHX با کد صفحه مناسب مرتبط است. این ارتباطات شناخته شده و بخشی از آن در Aspose.CAD برای فونت های شناخته شده SHX تعبیه شده است.
در صورت استفاده از فونت SHX سفارشی، می توان از ویژگی ShxCodePages استفاده کرد و مسیر فایل SHX و کد صفحه مربوطه را تنظیم کرد. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxCodePages.cs">}}
