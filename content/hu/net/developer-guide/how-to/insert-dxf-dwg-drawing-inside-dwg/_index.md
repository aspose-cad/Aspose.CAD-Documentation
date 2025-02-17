---
title: DXF/DWG rajz beillesztése DWG-be
type: docs
weight: 38
url: /hu/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Hogyan illesszünk be DXF/DWG rajzot DWG-be**

**Probléma:** Hogyan illesszünk be DXF/DWG rajzot DWG-be.

**Tippek:** Ehhez először hozz létre egy CadInsertObject-ot a szükséges értékekkel, majd szerezd meg az összes blokkot egy CadBlockDictionary-ból, hozz létre egy új CadBlockEntity blokkot, és add hozzá a CadBlockDictionary-hoz, adj hozzá egy CadBlockDictionary-t a rajz BlockEntities-hez, adj hozzá egy CadInsertObject-ot a rajzelemhez a tömbhöz, hozz létre egy CadBlockTableObject-ot referencia alapján, majd adj hozzá egy blokkot a rajzhoz.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
