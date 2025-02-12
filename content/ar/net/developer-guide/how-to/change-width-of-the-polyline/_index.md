---
title: تغيير عرض الخط المتعدد
type: docs
weight: 20
url: /ar/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **كيفية تغيير عرض الخط المتعدد**

**المشكلة:** كيفية تغيير عرض الخط المتعدد (CADNET-459-460).

**نصائح:** لتغيير العرض في CadBaseEntity (إذا كان النوع CadEntityTypeName.LWPOLYLINE) استخدم (entity as CadLwPolyline).ConstantWidth = 2 أو للكيانات العادية LineWeight.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
