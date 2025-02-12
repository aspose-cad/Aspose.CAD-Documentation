---
title: نقل نقطة أصل الفتحة أقرب إلى حدود الفتحة لتحسين الأداء
type: docs
weight: 41
url: /ar/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **كيفية نقل نقطة أصل الفتحة أقرب إلى حدود الفتحة لتحسين الأداء**

**المشكلة:** كيفية نقل نقطة أصل الفتحة أقرب إلى حدود الفتحة لتحسين الأداء (CADNET-1340).

**نصائح:** للقيام بذلك، احصل على كائنات CadHatch من الرسم، قم بتعيين النقاط المطلوبة باستخدام Point2D، حساب المسافة وفي CadHatchPatternData قم بتعيين LineBasePoint لـ X و Y.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
