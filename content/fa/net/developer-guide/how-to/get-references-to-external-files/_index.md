---
title: دریافت مراجع به فایل های خارجی
type: docs
weight: 36
url: /fa/net/how-to/get-references-to-external-files/
---

## **چگونه به مراجع فایل های خارجی دسترسی پیدا کنیم**

**مسئله:** چگونه به مراجع فایل های خارجی دسترسی پیدا کنیم (CADNET-110).

**نکات:** برای دریافت مراجع به فایل های خارجی برای نقشه ها در بلاک موجودیت، یک فیلد XRef PathName برای تصاویر پیکسلی وجود دارد. CadRasterImage Def برای زیرلایه خارجی استفاده می شود و CadDgnUnderlay و فیلد UnderlayPath آن به کار می رود.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
