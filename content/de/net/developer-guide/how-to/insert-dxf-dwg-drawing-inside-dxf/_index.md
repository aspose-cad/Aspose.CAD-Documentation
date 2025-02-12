---
title: DXF/DWG-Zeichnung in DXF einfügen
type: docs
weight: 39
url: /de/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Wie man eine DXF/DWG-Zeichnung in DXF einfügt**

**Problem:** Wie man eine DXF/DWG-Zeichnung in DXF einfügt.

**Tipps:** Dazu müssen Sie zunächst ein CadInsertObject mit den erforderlichen Werten erstellen, dann alle Blöcke im CadBlockDictionary abrufen, einen neuen CadBlockEntity-Block erstellen und ihn zum CadBlockDictionary hinzufügen, das CadBlockDictionary zu den BlockEntities der Zeichnung hinzufügen und ein CadInsertObject zu den Entitäten der Zeichnung für das Array hinzufügen.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
