---
title: رسومات DWF
type: docs
weight: 50
url: /ar/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **تصدير رسومات DWF إلى PDF**

توفر Aspose.CAD ميزة تحميل كائنات رسم AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) وعرضها كرسمة كاملة في صيغة [PDF](https://docs.fileformat.com/pdf/). يعمل نهج تحويل [DWF](https://docs.fileformat.com/cad/dwf/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وضبط خصائص **page_height** و **page_width**.
1. إنشاء كائن من فئة **PdfOptions** وضبط خاصية **vector_rasterization_options**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

### عينة من الكود

توضح عينة الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **تصدير رسومات DWF إلى BMP**

توفر Aspose.CAD ميزة تحميل كائنات رسم AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) وعرضها كرسمة كاملة في صيغة [BMP](https://docs.fileformat.com/image/bmp/). يعمل نهج تحويل [DWF](https://docs.fileformat.com/cad/dwf/) إلى [BMP](https://docs.fileformat.com/image/bmp/) كما يلي:

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع **Image.load**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وضبط خصائص **page_height** و **page_width**.
1. إنشاء كائن من فئة **BmpOptions** وضبط خاصية **vector_rasterization_options**.
1. استدعاء **Image.save** مع تمرير كائن من **BmpOptions** كمعامل ثانٍ.

### عينة من الكود

توضح عينة الكود أدناه كيفية تحويل ملف [DWF](https://docs.fileformat.com/cad/dwf/) إلى [BMP](https://docs.fileformat.com/image/bmp/) باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
