---
title: درج نقشه DXF/DWG درون DXF
type: docs
weight: 39
url: /fa/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **نحوه درج نقشه DXF/DWG درون DXF**

**مسأله:** نحوه درج نقشه DXF/DWG درون DXF.

**نکات:** برای این کار، ابتدا باید یک CadInsertObject با مقادیر لازم ایجاد کنید، سپس تمام بلوک‌ها را در CadBlockDictionary دریافت کنید، یک بلوک CadBlockEntity جدید ایجاد کنید و آن را به CadBlockDictionary اضافه کنید، CadBlockDictionary را به BlockEntities نقشه اضافه کنید، و یک CadInsertObject به موجودیت‌های نقشه برای آرایه اضافه کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
