---
title: Вмъкване на чертеж DXF/DWG вътре в DXF
type: docs
weight: 39
url: /bg/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Как да вмъкнете чертеж DXF/DWG вътре в DXF**

**Проблем:** Как да вмъкнете чертеж DXF/DWG вътре в DXF.

**Съвети:** За да направите това, трябва първо да създадете CadInsertObject с необходимите стойности, след това да вземете всички блокове в CadBlockDictionary, да създадете нов блок CadBlockEntity и да го добавите към CadBlockDictionary, да добавите CadBlockDictionary към BlockEntities на чертежа, да добавите CadInsertObject към същностите на чертежа за масив.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
