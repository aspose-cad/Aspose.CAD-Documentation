---
title: افزودن موجودیت‌های جدید TEXT/MTEXT به راست موجودیت‌های موجود
type: docs
weight: 17
url: /fa/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **چگونه موجودیت‌های جدید TEXT/MTEXT را به راست موجودیت‌های موجود اضافه کنیم**

**مسئله:** چگونه موجودیت‌های جدید TEXT/MTEXT را به راست موجودیت‌های موجود اضافه کنیم (CADNET-8172).

**نکات:** برای انجام این کار، یک شیء CadBaseEntity ایجاد کنید، یک CadMText یا CadText با متن ایجاد کنید، در شیء جدید به فیلد SoftOwner مقدار cadImage.Layouts["Model"].BlockTableRecordHandle از نقشه‌کش را اضافه کنید و آن را به بلاک cadImage.BlockEntities[" *MODEL_SPACE"] اضافه کنید و شیء جدید را به موجودیت‌های نقشه‌کش اضافه کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
