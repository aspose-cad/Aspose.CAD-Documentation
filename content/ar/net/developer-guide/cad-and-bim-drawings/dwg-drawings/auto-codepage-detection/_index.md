---
title: الكشف التلقائي لصفحات الرموز
type: docs
weight: 10
url: /ar/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **الكشف التلقائي لصفحات الرموز**

يدعم Aspose.CAD الكشف التلقائي عن صفحات الرموز لملفات [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/). إذا كنت لا ترغب في استخدام هذه الميزة، يمكنك تجاوز ذلك عن طريق ضبط الخصائص التالية من فئة [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): يحدد التشفير المستخدم لقراءة بيانات النص من تنسيقات DXF و DWG غير Unicode. يتم اكتشافه تلقائيًا بشكل افتراضي.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): يحدد التشفير المستخدم لقراءة رموز MIF المشفرة لتشفيرات CJK (تنسيق M+nXXXX). يتم اكتشافه تلقائيًا بشكل افتراضي.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): يحدد ما إذا كانت الشخصيات المشفرة CIF (U+XXXX) و MIF ستتم فك شفرتهما إذا لم تكن لها تنسيق AutoCAD الصحيح (يسبق AutoCAD هذه الرموز بفضل عكسي). يتم فك تشفيرها بشكل افتراضي.

## كود العينة

تظهر عينة الكود أدناه كيفية تجاوز الكشف التلقائي عن صفحات الرموز في Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
