---
title: DXF/DWG-tekening invoegen in DWG
type: docs
weight: 38
url: /nl/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Hoe een DXF/DWG-tekening in DWG in te voegen**

**Probleem:** Hoe een DXF/DWG-tekening in DWG in te voegen.

**Tips:** Om dit te doen, maak eerst een CadInsertObject met de vereiste waarden, haal dan alle blokken op in een CadBlockDictionary, maak een nieuwe CadBlockEntity-blok aan en voeg deze toe aan de CadBlockDictionary, voeg een CadBlockDictionary toe aan de BlockEntities van de tekening, voeg een CadInsertObject toe aan de tekeningentiteit voor de array, maak een CadBlockTableObject per referentie, en voeg dan een blok toe aan de tekening.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
