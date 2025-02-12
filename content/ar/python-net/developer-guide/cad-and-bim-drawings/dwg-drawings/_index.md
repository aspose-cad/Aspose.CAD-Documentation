---
title: رسومات DWG
type: docs
weight: 70
url: /ar/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **تصدير رسومات DWG إلى PDF**

يمكن لـ Aspose.CAD لواجهة برمجة التطبيقات بايثون تحميل رسومات AutoCAD بتنسيق [DWG](https://docs.fileformat.com/cad/dwg/) وتحويلها إلى [PDF](https://docs.fileformat.com/pdf/). يوضح هذا الموضوع استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق PDF من خلال خطوات بسيطة كما هو موضح أدناه.

{{% alert color="primary" %}}

تدعم واجهة البرمجة النصية ما يلي من إصدارات AutoCAD DWG:

- إصدار 16.0 من DWG 2004 الإصدار 18
- إصدار 16.1 من DWG 2005
- إصدار 18.0 من DWG 2010
- إصدار 19.0 من DWG 2013

{{% /alert %}}

### **تنسيق ملف DWG**

ملف [DWG](https://docs.fileformat.com/cad/dwg/) هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات تعريفية. توفر بيانات الصورة المتجهة تعليمات لتطبيق CAD حول كيفية عرض DWG؛ قد تحتوي البيانات التعريفية على مجموعة متنوعة من المعلومات حول الملف بما في ذلك البيانات المحددة عند الموقع وأيضًا بيانات العميل. يمكن العثور على المواصفات المفتوحة لتنسيق ملف DWG [في هذه PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **تحويل ملفات DWG إلى PDF**

الخطوات البسيطة التالية مطلوبة لتحويل [DWG](https://docs.fileformat.com/cad/dwg/) إلى [PDF](https://docs.fileformat.com/pdf/).

1. تحميل ملف DWG في مثيل من **Image**.
1. إنشاء كائن من فئة **CadRasterizationOptions** وتعيين خصائص **page_height** و **page_width**.
1. إنشاء كائن من فئة **PdfOptions** وتعيين خاصية **VectorRasterizationOptions**.
1. استدعاء **Image.save** مع تمرير كائن من **PdfOptions** كمعامل ثانٍ.

عينة الكود أدناه توضح كيفية تصدير رسومات DWG إلى PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **الكائنات الأولية المدعومة في AutoCAD**

تدعم الكائنات الأولية التالية في AutoCAD.

- نص
- نص متعدد الخطوط
- تعريف المرفقات
- الخصائص
- قوس
- بيضاوي
- حشيش
- قائد
- نقطة
- رأس 2D
- رأس 3D
- خط متعدد 2D
- خط متعدد LWPOLYLINE
- شعاع
- دائرة
- بعد البعد
- بعد خطي
- بعد محاذي
- بعد زاوية 3 نقاط
- بعد زاوية 2 خط
- بعد نصف القطر
- بعد القطر
- شكل
- صلب
- مقطع
- خط متعدد
- خط
- خط ممتد
- نمط
- نمط البعد
- نوع الخط
- نمط خط متعدد
- طبقة
- منطقة عرض
- تخطيط

## **تصدير تخطيط DWG محدد إلى PDF**

تعمل هذه الطريقة كما يلي:

1. تحميل ملف DWG باستخدام الطريقة المصنع **Aspose.CAD.Image.load**.
1. إنشاء مثيل من فئة **CadRasterizationOptions** وتعيين ارتفاع الصفحة الناتج وعرضها.
1. تعيين خاصية **Layouts** لكائن **CadRasterizationOptions**.
1. إنشاء مثيل من فئة **PdfOptions** وتعيين خاصيتها **VectorRasterizationOptions**.
1. تصدير الصورة إلى PDF باستخدام الطريقة **Image.save()**.

عينة الكود أدناه توضح كيفية تحويل تخطيط معين من DWG إلى PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **تصدير DWG إلى PDF/A و PDF/E**

تعمل هذه الطريقة كما يلي:

1. تحميل ملف DWG باستخدام الطريقة المصنع **Image.load**.
1. إنشاء مثيل من فئة **CadRasterizationOptions**.
1. إنشاء مثيل من فئة **PdfOptions** وتعيين خاصيتها **VectorRasterizationOptions**.
1. تعيين خاصية امتثال PDF وحفظها.
1. تصدير الصورة إلى PDF باستخدام الطريقة **Image.save()**.

عينة الكود أدناه توضح كيفية تحويل ملف DWG إلى PDF/A و PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **تحويل رسومات DWG إلى DXF**

تقدم Aspose.CAD ميزة تحميل ملف DWG في AutoCAD وتصديره إلى تنسيق DXF. تعمل طريقة تحويل DWG إلى DXF كما يلي:

1. تحميل ملف رسومات DWG باستخدام الطريقة المصنع **Image.load**.
1. تصدير رسمة DWG إلى DXF باستخدام الطريقة **Image.save()**.

عينة الكود أدناه توضح كيفية تحويل ملف DWG إلى تنسيق DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **تحويل رسومات DWG إلى SVG**

يمكن لـ Aspose.CAD لواجهة برمجة التطبيقات بايثون تحميل رسومات AutoCAD بتنسيق DWG، وتحويلها إلى SVG. يوضح هذا الموضوع استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق SVG من خلال خطوات بسيطة كما هو موضح أدناه.

1. تحميل ملف DWG في مثيل من **Image**.
1. إنشاء كائن من فئة **SvgOptions** وتعيين الخصائص المطلوبة.
1. تصدير رسم DWG إلى SVG باستخدام الطريقة **Image.save()**.

عينة الكود أدناه توضح كيفية تحويل ملف DWG إلى تنسيق SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
