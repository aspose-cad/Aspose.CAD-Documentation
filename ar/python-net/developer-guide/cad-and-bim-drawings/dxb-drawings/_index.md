---
title: رسومات DXB
type: docs
weight: 90
url: /ar/python-net/dxb-drawings/
---

## **تصدير تنسيق DXB إلى PDF**

تتيح Aspose.CAD لـ Python للمطورين تصدير ملف DXB إلى [PDF](https://docs.fileformat.com/pdf/) . تعمل طريقة تحويل DXB إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسم DXB باستخدام طريقة المصنع **Image.load**.
1. أنشئ كائنًا من فئة **CadRasterizationOptions** وقم بتعيين خصائص **page_height** و **page_width**.
1. أنشئ كائنًا من فئة **PdfOptions** وقم بتعيين خاصية **vector_rasterization_options**.
1. قم باستدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## عينة من الكود

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
