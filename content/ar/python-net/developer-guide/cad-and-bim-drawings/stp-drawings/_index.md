---
title: رسومات STP
type: docs
weight: 160
url: /ar/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **تصدير تنسيق STP إلى PDF**

تسمح Aspose.CAD لـ Python للمطورين بتصدير ملف [STP](https://docs.fileformat.com/3d/stp/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [STP](https://docs.fileformat.com/3d/stp/) إلى [PDF](https://docs.fileformat.com/pdf/) على النحو التالي:

1. تحميل ملف رسم [STP](https://docs.fileformat.com/3d/stp/) باستخدام الطريقة **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وتعيين الخصائص **page_height** و **page_width**.
1. إنشاء كائن من فئة **PdfOptions** وتعيين خاصية **vector_rasterization_options**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## مثال على الكود

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
