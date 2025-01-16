---
title: رسومات FBX
type: docs
weight: 110
url: /ar/python-net/fbx-drawings/
---

## **تصدير تنسيق FBX إلى PDF**

يتيح Aspose.CAD لـ Python للمطورين تصدير ملف [FBX](https://docs.fileformat.com/3d/fbx/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). يعمل نهج تحويل [FBX](https://docs.fileformat.com/3d/fbx/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف رسومات [FBX](https://docs.fileformat.com/3d/fbx/) باستخدام طريقة المصنع **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وتعيين خصائص **PageHeight** و **PageWidth**.
1. إنشاء كائن من فئة **PdfOptions** وتعيين خاصية **vector_rasterization_options**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## كود العينة

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
