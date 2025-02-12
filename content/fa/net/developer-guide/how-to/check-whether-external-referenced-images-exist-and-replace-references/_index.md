---
title: بررسی اینکه آیا تصاویر مرجع خارجی وجود دارند و جایگزینی مراجع
type: docs
weight: 22
url: /fa/net/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **چگونه هایپرلینک‌ها را روی اشیاء ویرایش کنیم**

**مسئله:** چگونه بررسی کنیم که آیا تصاویر مرجع خارجی وجود دارند و مراجع را جایگزین کنیم (CADNET-8088).

**نکات:** برای انجام این کار، یک موجودیت از نوع CadObjectTypeName.IMAGEDEF را از موجودیت‌های ترسیمی بگیرید و از CadRasterImageDef برای بررسی استفاده کنید.

**نمونه:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
