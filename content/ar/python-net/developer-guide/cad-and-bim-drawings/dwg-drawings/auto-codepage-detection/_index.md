---
title: الكشف التلقائي عن ترميز الصفحات
type: docs
weight: 10
url: /ar/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **الكشف التلقائي عن ترميز الصفحات**

يدعم Aspose.CAD الكشف التلقائي عن ترميز الصفحات لملفات [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/). إذا كنت لا ترغب في استخدام هذه الميزة، يمكنك تجاوز ذلك عن طريق تعيين الخصائص التالية من فئة **LoadOptions**.

- **specified_encoding**: يحدد الترميز المستخدم لقراءة بيانات النص من تنسيقات DXF وDWG غير Unicode. يتم اكتشافه تلقائيًا بشكل افتراضي.
- **specified_mif_encoding**: يحدد الترميز المستخدم لقراءة الرموز المشفرة بتنسيق MIF من ترميزات CJK (تنسيق M+nXXXX). يتم اكتشافه تلقائيًا بشكل افتراضي.
- **recover_malformed_cif_mif**: يعرف ما إذا كان سيتم فك تشفير شخصيات CIF (U+XXXX) وMIF المشفرة إذا لم يكن لها تنسيق AutoCAD مناسب (تسبق AutoCAD هذه الرموز بشرطة مائلة). بشكل افتراضي، يتم فك تشفيرها.

## عينة كود

تظهر عينة الكود أدناه كيفية تجاوز الكشف التلقائي عن ترميز الصفحات في Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
