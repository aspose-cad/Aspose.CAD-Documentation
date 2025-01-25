---
title: DXF/DWG-Zeichnung in DWG einfügen
type: docs
weight: 38
url: /de/net/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Wie man eine DXF/DWG-Zeichnung in eine DWG einfügt**

**Problem:** Wie man eine DXF/DWG-Zeichnung in eine DWG einfügt.

**Tipps:** Um dies zu tun, erstellen Sie zuerst ein CadInsertObject mit den erforderlichen Werten, dann rufen Sie alle Blöcke in einem CadBlockDictionary ab, erstellen Sie einen neuen CadBlockEntity-Block und fügen Sie ihn dem CadBlockDictionary hinzu, fügen Sie ein CadBlockDictionary zu den BlockEntities der Zeichnung hinzu, fügen Sie ein CadInsertObject zur Zeichnungseinheit für das Array hinzu, erstellen Sie ein CadBlockTableObject durch Referenz und fügen Sie dann einen Block zur Zeichnung hinzu.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
