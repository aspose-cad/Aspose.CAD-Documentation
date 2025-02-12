---
title: پشتیبانی از فایل های CTB
type: docs
weight: 40
url: /fa/java/support-ctb/
---

## **پشتیبانی از فایل های CTB**

گاهی اوقات رنگ، ضخامت خطوط و برخی گزینه های دیگر برای رسم ها ممکن است نه تنها از خود رسم ها بلکه همچنین از استایل های چاپ در فایل های CTB مجزا استفاده شوند. 
ساده ترین راه برای استفاده از این اطلاعات، قرار دادن فایل های CTB مربوطه در کنار فایل با رسم در فرمت DWG/DXF است و اطلاعات آنها به طور خودکار در حین صدور اعمال خواهد شد.

همچنین ممکن است تمام فایل های CTB به صورت Stream بارگذاری شوند با استفاده از 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) خاصیت 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) شیء.

در اینجا یک مثال از چگونگی انجام این کار آورده شده است:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
