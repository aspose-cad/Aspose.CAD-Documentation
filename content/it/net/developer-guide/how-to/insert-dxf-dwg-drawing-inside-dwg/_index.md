---
title: Inserire un disegno DXF/DWG all'interno di DWG
type: docs
weight: 38
url: /it/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Come inserire un disegno DXF/DWG all'interno di DWG**

**Problema:** Come inserire un disegno DXF/DWG all'interno di DWG.

**Suggerimenti:** Per farlo, crea prima un CadInsertObject con i valori necessari, poi ottieni tutti i blocchi in un CadBlockDictionary, crea un nuovo blocco CadBlockEntity e aggiungilo al CadBlockDictionary, aggiungi un CadBlockDictionary alle BlockEntities del disegno, aggiungi un CadInsertObject all'entità di disegno per l'array, crea un CadBlockTableObject per riferimento, quindi aggiungi un blocco al disegno.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
