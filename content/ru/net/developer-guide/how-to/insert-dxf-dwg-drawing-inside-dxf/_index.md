---
title: Вставка чертежа DXF/DWG в DXF
type: docs
weight: 39
url: /ru/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Как вставить чертеж DXF/DWG в DXF**

**Проблема:** Как вставить чертеж DXF/DWG в DXF.

**Советы:** Для этого сначала необходимо создать объект CadInsertObject с необходимыми значениями, затем получить все блоки в CadBlockDictionary, создать новый блок CadBlockEntity и добавить его в CadBlockDictionary, добавить CadBlockDictionary в BlockEntities чертежа, добавить CadInsertObject в сущности чертежа для массива.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
