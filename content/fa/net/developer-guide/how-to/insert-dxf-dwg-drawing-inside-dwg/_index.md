---
title: درج نقاشی DXF/DWG در داخل DWG
type: docs
weight: 38
url: /fa/net/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **چگونه نقاشی DXF/DWG را در داخل DWG درج کنیم**

**مسئله:** چگونه نقاشی DXF/DWG را در داخل DWG درج کنیم.

**نکات:** برای این کار، ابتدا یک CadInsertObject با مقادیر مورد نیاز ایجاد کنید، سپس تمام بلوک‌ها را در یک CadBlockDictionary بگیرید، یک بلوک CadBlockEntity جدید ایجاد کرده و آن را به CadBlockDictionary اضافه کنید، یک CadBlockDictionary به BlockEntities نقاشی اضافه کنید، یک CadInsertObject به موجودیت نقاشی برای آرایه اضافه کنید، یک CadBlockTableObject با ارجاع ایجاد کنید، سپس یک بلوک به نقاشی اضافه کنید.

**نمونه:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
