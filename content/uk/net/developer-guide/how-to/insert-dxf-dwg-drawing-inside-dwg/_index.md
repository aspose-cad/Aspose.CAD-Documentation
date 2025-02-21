---
title: Вставка малюнка DXF/DWG всередині DWG
type: docs
weight: 38
url: /uk/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Як вставити малюнок DXF/DWG всередині DWG**

**Проблема:** Як вставити малюнок DXF/DWG всередині DWG.

**Поради:** Щоб це зробити, спочатку створіть CadInsertObject з необхідними значеннями, потім отримайте всі блоки в CadBlockDictionary, створіть новий блок CadBlockEntity і додайте його до CadBlockDictionary, додайте CadBlockDictionary до BlockEntities малюнка, додайте CadInsertObject до сутності малюнка для масиву, створіть CadBlockTableObject за посиланням, потім додайте блок до малюнка.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
