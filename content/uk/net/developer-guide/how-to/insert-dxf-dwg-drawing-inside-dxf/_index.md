---
title: Вставити креслення DXF/DWG всередину DXF
type: docs
weight: 39
url: /uk/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Як вставити креслення DXF/DWG всередину DXF**

**Проблема:** Як вставити креслення DXF/DWG всередину DXF.

**Поради:** Для цього спочатку потрібно створити об'єкт CadInsertObject з необхідними значеннями, потім отримати всі блочки з CadBlockDictionary, створити новий блок CadBlockEntity та додати його до CadBlockDictionary, додати CadBlockDictionary до BlockEntities креслення, додати CadInsertObject до об'єктів креслення для масиву.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
