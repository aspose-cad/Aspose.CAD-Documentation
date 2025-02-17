---
title: Kép hozzáadása háttérként a DWG-hez
type: docs
weight: 15
url: /hu/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Hogyan adhatunk hozzá egy képet háttérként a DWG-hez**

**Probléma:** Hogyan adhatunk hozzá egy képet háttérként a DWG-hez.

**Tippek:** Ehhez hozzon létre egy CadRasterImageDef objektumot a háttérképhez, hozzon létre egy CadRasterImage objektumot a háttér beillesztésére a rajzhoz, adjon hozzá egy CadRasterImage objektumot a rajz objektumaihoz, hozzon létre egy CadBaseObject CadBaseObject-ot és adja hozzá a cadImage.Objects-hoz, és mindent dolgozzon fel a CadBlockTableObject-en keresztül.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
