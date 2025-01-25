---
title: Zeichnung nach unten verschieben, um Titel hinzuzufügen
type: docs
weight: 40
url: /de/net/how-to/move-drawing-down-to-add-title/
---

## **Wie man die Zeichnung nach unten verschiebt, um einen Titel hinzuzufügen**

**Problem:** Wie man die Zeichnung nach unten verschiebt, um einen Titel hinzuzufügen (CADNET-980).

**Tipps:** Um dies zu tun, erstellen Sie ein CadText-Objekt mit Parametern, fügen Sie diesen Block zur Zeichnung hinzu, aktualisieren Sie dann die Zeichnung mit den neuen Abmessungen mit UpdateSize, fügen Sie eine Polylinie hinzu, die einen Rahmen um die Zeichnung bildet, fügen Sie die Polylinie zu BlockEntities["*Model_Space"] hinzu und aktualisieren Sie erneut mit UpdateSize.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
