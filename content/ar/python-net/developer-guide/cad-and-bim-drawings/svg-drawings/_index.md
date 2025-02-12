---
title: رسومات SVG
type: docs
weight: 170
url: /ar/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **تصدير تنسيق SVG إلى PDF**

تسمح Aspose.CAD لمطوري Python بتصدير ملف [SVG](https://docs.fileformat.com/page-description-language/svg/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [SVG](https://docs.fileformat.com/page-description-language/svg/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسم SVG باستخدام طريقة المصنع **Image.load**.
1. أنشئ كائن من فئة **CadRasterizationOptions** وقم بتعيين خصائص **page_height** و **page_width**.
1. أنشئ كائن من فئة **PdfOptions** وقم بتعيين خاصية **VectorRasterizationOptions**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

## عينة الكود

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
