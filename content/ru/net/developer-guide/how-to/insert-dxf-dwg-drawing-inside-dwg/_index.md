---
title: Вставка чертежа DXF/DWG в DWG
type: docs
weight: 38
url: /ru/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Как вставить чертеж DXF/DWG в DWG**

**Проблема:** Как вставить чертеж DXF/DWG в DWG.

**Советы:** Для этого сначала создайте CadInsertObject с необходимыми значениями, затем получите все блоки в CadBlockDictionary, создайте новый блок CadBlockEntity и добавьте его в CadBlockDictionary, добавьте CadBlockDictionary к BlockEntities чертежа, добавьте CadInsertObject к сущности чертежа для массива, создайте CadBlockTableObject по ссылке, затем добавьте блок к чертежу.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
