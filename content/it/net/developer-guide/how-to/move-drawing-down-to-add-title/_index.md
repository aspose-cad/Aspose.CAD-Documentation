---
title: Spostare il disegno in basso per aggiungere il titolo
type: docs
weight: 40
url: /it/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Come spostare il disegno in basso per aggiungere il titolo**

**Problema:** Come spostare il disegno in basso per aggiungere il titolo (CADNET-980).

**Suggerimenti:** Per fare questo, crea un oggetto CadText con i parametri, aggiungi questo blocco al disegno, poi aggiorna il disegno con le nuove dimensioni usando UpdateSize, aggiungi una polilinea che sia una cornice attorno al disegno, aggiungi la polilinea a BlockEntities["*Model_Space"] e aggiorna di nuovo con UpdateSize.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
