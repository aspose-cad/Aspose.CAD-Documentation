---
title: إنشاء مستطيل كخطوط متعددة وملؤه بالخطوط المتقاطعة
type: docs
weight: 24
url: /ar/net/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **كيفية إنشاء مستطيل كخطوط متعددة وملؤه بالخطوط المتقاطعة**

**المشكلة:** كيفية إنشاء مستطيل كخطوط متعددة وملؤه بالخطوط المتقاطعة (CADNET-1351).

**نصائح:** للقيام بذلك، أنشئ CadLwPolyline وأضف إحداثيات النقاط إليه، استخدم CadHatch للعمل مع اللون واستخدم CadEdgeBoundaryPath للاتصال، استخدم CadHatch للعمل مع الزوايا وCadHatchPatternData للنمط.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
