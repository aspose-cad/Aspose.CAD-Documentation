---
title: Rajz lemozgatása a cím hozzáadásához
type: docs
weight: 40
url: /hu/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Hogyan mozgassuk le a rajzot a cím hozzáadásához**

**Probléma:** Hogyan mozgassuk le a rajzot a cím hozzáadásához (CADNET-980).

**Tippek:** Ehhez hozzon létre egy CadText objektumot paraméterekkel, adja hozzá ezt a blokkot a rajzhoz, majd frissítse a rajzot az új méretekkel az UpdateSize segítségével, adjon hozzá egy poligonvonalat, amely a rajz körüli keret, adja hozzá a poligonvonalat a BlockEntities["*Model_Space"]-hez, és frissítse újra az UpdateSize segítségével.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
