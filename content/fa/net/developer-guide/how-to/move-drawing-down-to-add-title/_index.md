---
title: حرکت دادن ترسیم به پایین برای اضافه کردن عنوان
type: docs
weight: 40
url: /fa/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **چگونه ترسیم را به پایین حرکت دهیم تا عنوان اضافه کنیم**

**مسئله:** چگونه ترسیم را به پایین حرکت دهیم تا عنوان اضافه کنیم (CADNET-980).

**نکات:** برای انجام این کار، یک شیء CadText با پارامترها ایجاد کنید، سپس این بلوک را به ترسیم اضافه کنید، سپس ترسیم را با ابعاد جدید با استفاده از UpdateSize به‌روزرسانی کنید، یک پلی‌لاین که قاب اطراف ترسیم است اضافه کنید، پلی‌لاین را به BlockEntities["*Model_Space"] اضافه کنید و دوباره با UpdateSize به‌روزرسانی کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
