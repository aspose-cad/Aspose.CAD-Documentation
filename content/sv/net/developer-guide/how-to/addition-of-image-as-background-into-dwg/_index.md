---
title: Tillägg av bild som bakgrund i DWG
type: docs
weight: 15
url: /sv/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Hur man lägger till en bild som bakgrund i DWG**

**Problem:** Hur man lägger till en bild som bakgrund i DWG.

**Tips:** För att göra detta, skapa ett CadRasterImageDef-objekt för bakgrundsbilden, skapa ett CadRasterImage-objekt för att sätta in bakgrunden för ritningen, lägg till ett CadRasterImage-objekt i ritningens objekt, skapa ett CadBaseObject CadBaseObject och lägg till det i cadImage.Objects, bearbeta allt via CadBlockTableObject.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
