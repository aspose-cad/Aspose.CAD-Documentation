---
title: حساب مساحة ومحيط الدوائر
type: docs
weight: 18
url: /ar/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **كيفية حساب مساحة ومحيط الدوائر**

**المشكلة:** كيفية حساب مساحة ومحيط الدوائر (CADNET-1153).

**نصائح:** للقيام بذلك، احصل على نصف القطر من CadEntityTypeName.CIRCLE من الكيانات واستخدم الصيغة **"2 * Math.PI * radius"**.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
