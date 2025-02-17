---
title: DXF/DWG rajz beillesztése DXF-be
type: docs
weight: 39
url: /hu/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Hogyan lehet DXF/DWG rajzot beilleszteni DXF-be**

**Probléma:** Hogyan lehet DXF/DWG rajzot beilleszteni DXF-be.

**Tippek:** Ehhez először létre kell hozni egy CadInsertObject-ot a szükséges értékekkel, majd meg kell szerezni az összes blokkot a CadBlockDictionary-ből, létrehozni egy új CadBlockEntity blokkot és hozzáadni a CadBlockDictionary-hez, hozzáadni a CadBlockDictionary-t a rajz BlockEntities-jéhez, majd hozzáadni egy CadInsertObject-ot a rajz entitásaihoz a tömbhöz.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
