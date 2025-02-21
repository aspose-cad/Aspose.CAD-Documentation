---
title: Infoga DXF/DWG-teckning i DXF
type: docs
weight: 39
url: /sv/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Hur man infogar DXF/DWG-teckning i DXF**

**Problem:** Hur man infogar DXF/DWG-teckning i DXF.

**Tips:** För att göra detta måste du först skapa ett CadInsertObject med de nödvändiga värdena, sedan hämta alla block i CadBlockDictionary, skapa ett nytt CadBlockEntity-block och lägga till det i CadBlockDictionary, lägga till CadBlockDictionary till BlockEntities i ritningen, lägga till ett CadInsertObject till entiteterna i ritningen för arrayen.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
