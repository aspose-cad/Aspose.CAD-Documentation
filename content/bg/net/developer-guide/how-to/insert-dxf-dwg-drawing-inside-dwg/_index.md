---
title: Вмъкване на чертеж DXF/DWG в DWG
type: docs
weight: 38
url: /bg/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Как да вмъкнете чертеж DXF/DWG в DWG**

**Проблем:** Как да вмъкнете чертеж DXF/DWG в DWG.

**Съвети:** За да направите това, първо създайте CadInsertObject с необходимите стойности, след това вземете всички блокове в CadBlockDictionary, създайте нов блок CadBlockEntity и го добавете към CadBlockDictionary, добавете CadBlockDictionary към BlockEntities на чертежа, добавете CadInsertObject към съдържанието на чертежа за масива, създайте CadBlockTableObject по референция, след това добавете блок към чертежа.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
