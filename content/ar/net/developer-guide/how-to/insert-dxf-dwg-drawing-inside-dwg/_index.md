---
title: إدراج رسم DXF/DWG داخل DWG
type: docs
weight: 38
url: /ar/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **كيفية إدراج رسم DXF/DWG داخل DWG**

**المشكلة:** كيفية إدراج رسم DXF/DWG داخل DWG.

**نصيحة:** للقيام بذلك، قم أولاً بإنشاء CadInsertObject بالقيم المطلوبة، ثم احصل على جميع الكتل في CadBlockDictionary، أنشئ كتلة جديدة CadBlockEntity وأضفها إلى CadBlockDictionary، أضف CadBlockDictionary إلى BlockEntities للرسم، أضف CadInsertObject إلى كيان الرسم للمصفوفة، أنشئ CadBlockTableObject عن طريق المرجع، ثم أضف كتلة إلى الرسم.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
