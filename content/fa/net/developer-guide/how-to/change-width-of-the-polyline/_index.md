---
title: تغییر عرض خط پلی‌لاین 
type: docs
weight: 20
url: /fa/net/how-to/change-width-of-the-polyline/
---

## **چگونه عرض خط پلی‌لاین را تغییر دهیم**

**مسئله:** چگونه عرض خط پلی‌لاین را تغییر دهیم (CADNET-459-460).

**نکات:** برای تغییر عرض در CadBaseEntity (اگر نوع CadEntityTypeName.LWPOLYLINE باشد) از (entity as CadLwPolyline).ConstantWidth = 2 یا برای موجودی‌های معمولی LineWeight استفاده کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
