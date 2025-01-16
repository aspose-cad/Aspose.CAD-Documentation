---
title: رسومات DRC
type: docs
weight: 40
url: /ar/python-net/drc-drawings/
---

## **تصدير تنسيق DRC إلى PDF**

يتيح Aspose.CAD لـ Python للمطورين تصدير ملف [DRC](https://docs.fileformat.com/3d/drc/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/).  تعمل طريقة تحويل  [DRC](https://docs.fileformat.com/3d/drc/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف رسم DRC باستخدام طريقة مصنع **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وتعيين خصائص **page_height** و **page_width**.
1. إنشاء كائن من فئة **PdfOptions** وتعيين خاصية **VectorRasterizationOptions**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## عينة من الكود


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
