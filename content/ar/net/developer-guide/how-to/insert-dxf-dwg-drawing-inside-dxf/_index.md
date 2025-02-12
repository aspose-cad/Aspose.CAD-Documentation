---
title: إدراج رسم DXF/DWG داخل DXF
type: docs
weight: 39
url: /ar/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **كيفية إدراج رسم DXF/DWG داخل DXF**

**المشكلة:** كيفية إدراج رسم DXF/DWG داخل DXF.

**نصائح:** للقيام بذلك، يجب عليك أولاً إنشاء CadInsertObject بالقيم اللازمة، ثم الحصول على جميع الكتل في CadBlockDictionary، إنشاء كتلة جديدة CadBlockEntity وإضافتها إلى CadBlockDictionary، إضافة CadBlockDictionary إلى BlockEntities للرسم، إضافة CadInsertObject إلى الكيانات للرسم للمصفوفة.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
