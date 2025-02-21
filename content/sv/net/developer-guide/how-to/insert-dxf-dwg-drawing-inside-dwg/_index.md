---
title: Infoga DXF/DWG-ritning i DWG
type: docs
weight: 38
url: /sv/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Hur man infogar DXF/DWG-ritning i DWG**

**Problem:** Hur man infogar DXF/DWG-ritning i DWG.

**Tips:** För att göra detta, skapa först ett CadInsertObject med de nödvändiga värdena, hämta sedan alla block i en CadBlockDictionary, skapa en ny CadBlockEntity-block och lägg till den i CadBlockDictionary, lägg till en CadBlockDictionary till BlockEntities i ritningen, lägg till ett CadInsertObject till ritningsentiteten för arrayen, skapa ett CadBlockTableObject genom referens, lägg sedan till ett block i ritningen.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
