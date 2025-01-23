---
title: رسومات COLLADA
type: docs
weight: 20
url: /ar/python-net/collada-drawings/
---

## **تصدير تنسيق COLLADA إلى PDF**

تتيح Aspose.CAD لـ Python للمطورين تصدير ملف [COLLADA](https://docs.fileformat.com/3d/dae/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [COLLADA](https://docs.fileformat.com/3d/dae/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف رسم [COLLADA](https://docs.fileformat.com/3d/dae/) باستخدام طريقة المصنع **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وتعيين خاصيتي **page_height** و **page_width**.
1. إنشاء كائن من فئة **PdfOptions** وتعيين خاصية **vector_rasterization_options**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## كود العينة

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
