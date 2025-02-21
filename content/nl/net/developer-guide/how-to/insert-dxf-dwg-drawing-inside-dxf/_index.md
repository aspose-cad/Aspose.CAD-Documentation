---
title: DXF/DWG-tekening invoegen in DXF
type: docs
weight: 39
url: /nl/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Hoe een DXF/DWG-tekening in DXF in te voegen**

**Probleem:** Hoe een DXF/DWG-tekening in DXF in te voegen.

**Tips:** Om dit te doen, moet je eerst een CadInsertObject aanmaken met de noodzakelijke waarden, vervolgens alle blokken in de CadBlockDictionary ophalen, een nieuwe CadBlockEntity-blok maken en deze toevoegen aan de CadBlockDictionary, de CadBlockDictionary toevoegen aan de BlockEntities van de tekening, een CadInsertObject aan de entiteiten van de tekening toevoegen voor de array.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
