---
title: پشتیبانی از فایل‌های CTB
type: docs
weight: 40
url: /fa/net/developer-guide/support-ctb/
---

## **پشتیبانی از فایل‌های CTB**

گاهی اوقات رنگ، ضخامت خطوط و برخی دیگر از گزینه‌ها برای نقشه‌ها ممکن است نه تنها از خود نقشه‌ها بلکه همچنین از سبک‌های چاپ در فایل‌های CTB جداگانه استفاده شوند.
ساده‌ترین راه برای استفاده از این اطلاعات، قرار دادن فایل‌های CTB مربوطه در کنار فایل نقشه در فرمت DWG/DXF است و اطلاعات آن‌ها به طور 
خودکار در حین صادرات اعمال می‌شود.

همچنین می‌توان همه فایل‌های CTB را به صورت جریان بارگذاری کرد 
با استفاده از 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) ویژگی 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) آبجکت.

در اینجا یک مثال از چگونگی انجام این کار آورده شده است:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
