---
title: Hinzufügen eines Bildes als Hintergrund in DWG
type: docs
weight: 15
url: /de/net/how-to/addition-of-image-as-background-into-dwg/
---

## **Wie man ein Bild als Hintergrund in DWG hinzufügt**

**Problem:** Wie man ein Bild als Hintergrund in DWG hinzufügt.

**Tipps:** Um dies zu tun, erstellen Sie ein CadRasterImageDef-Objekt für das Hintergrundbild, erstellen Sie ein CadRasterImage-Objekt, um den Hintergrund für die Zeichnung einzufügen, fügen Sie ein CadRasterImage-Objekt zu den Zeichnungsobjekten hinzu, erstellen Sie ein CadBaseObject und fügen Sie es zu cadImage.Objects hinzu, verarbeiten Sie alles über CadBlockTableObject.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
