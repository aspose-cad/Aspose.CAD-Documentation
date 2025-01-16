---
title: كشف تلقائي لصفحة الترميز
type: docs
weight: 10
url: /ar/java/auto-codepage-detection/
---

## **كشف تلقائي لصفحة الترميز**

تدعم Aspose.CAD الكشف التلقائي لصفحة الترميز لملفات [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/). إذا كنت لا ترغب في استخدام هذه الميزة، يمكنك تجاوز ذلك عن طريق ضبط الخصائص التالية من فئة [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): يحدد الترميز المستخدم لقراءة بيانات النص من تنسيقات DXF و DWG غير Unicode. يتم اكتشافه تلقائيًا بشكل افتراضي.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): يحدد الترميز المستخدم لقراءة الرموز المشفرة MIF لبرامج الترميز CJK (تنسيق M+nXXXX). يتم اكتشافه تلقائيًا بشكل افتراضي.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): يحدد ما إذا كان سيتم فك تشفير أحرف CIF (U+XXXX) وأحرف MIF المشفرة إذا لم يكن لها تنسيق AutoCAD الصحيح (تسبق AutoCAD هذه الرموز بعلامة مائلة للخلف). بشكل افتراضي، يتم فك تشفيرها.

## مثال على الكود

تظهر عينة الكود أدناه كيفية تجاوز الكشف التلقائي لصفحة الترميز في Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
