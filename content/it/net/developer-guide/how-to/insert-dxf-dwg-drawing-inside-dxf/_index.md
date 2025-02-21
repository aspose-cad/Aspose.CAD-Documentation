---
title: Inserire un disegno DXF/DWG all'interno di DXF
type: docs
weight: 39
url: /it/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Come inserire un disegno DXF/DWG all'interno di DXF**

**Problema:** Come inserire un disegno DXF/DWG all'interno di DXF.

**Suggerimenti:** Per fare ciò, è necessario prima creare un CadInsertObject con i valori necessari, quindi ottenere tutti i blocchi nel CadBlockDictionary, creare un nuovo blocco CadBlockEntity e aggiungerlo al CadBlockDictionary, aggiungere il CadBlockDictionary agli BlockEntities del disegno, aggiungere un CadInsertObject alle entità del disegno per l'array.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
