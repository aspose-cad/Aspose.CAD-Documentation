---
title: افزودن تصویر به عنوان پس‌زمینه در DWG
type: docs
weight: 15
url: /fa/net/how-to/addition-of-image-as-background-into-dwg/
---

## **چگونه یک تصویر به عنوان پس‌زمینه در DWG اضافه کنیم**

**مسئله:** چگونه یک تصویر به عنوان پس‌زمینه در DWG اضافه کنیم.

**نکات:** برای این کار، یک شیء CadRasterImageDef برای تصویر پس‌زمینه ایجاد کنید، یک شیء CadRasterImage برای قرار دادن پس‌زمینه برای نقشه‌کشی ایجاد کنید، یک شیء CadRasterImage را به اشیاء نقشه‌کشی اضافه کنید، یک شیء CadBaseObject ایجاد کنید و آن را به cadImage.Objects اضافه کنید، و همه چیز را از طریق CadBlockTableObject پردازش کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
