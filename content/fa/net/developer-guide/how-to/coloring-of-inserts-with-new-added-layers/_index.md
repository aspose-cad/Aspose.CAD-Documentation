---
title: رنگ‌آمیزی ورودی‌ها با لایه‌های جدید اضافه شده
type: docs
weight: 23
url: /fa/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **چگونه ورودی‌ها را با لایه‌های جدید اضافه شده رنگ‌آمیزی کنیم (CADNET-1146)**

**مسئله:** چگونه ورودی‌ها را با لایه‌های جدید اضافه شده رنگ‌آمیزی کنیم (CADNET-1146).

**نکات:** برای این کار، از کلاس CadLayerTable برای ایجاد یک لایه استفاده کنید تا بتوانید یک لایه جدید به طراحی اضافه کنید، همچنین می‌توانید از CadLayersList برای اضافه کردن چندین لایه استفاده کنید.

**مثال:**

{{% alert color="primary" %}}

فایل اولیه شامل ۵ ورودی با نام‌های "1"، "2"، "3"، "4" و "5" است و همه آن‌ها در لایه پیش‌فرض ۰ قرار دارند.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
