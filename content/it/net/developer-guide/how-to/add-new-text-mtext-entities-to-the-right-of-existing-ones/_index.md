---
title: Aggiungere nuove entità TEXT/MTEXT a destra di quelle esistenti
type: docs
weight: 17
url: /it/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Come aggiungere nuove entità TEXT/MTEXT a destra di quelle esistenti**

**Problema:** Come aggiungere nuove entità TEXT/MTEXT a destra di quelle esistenti (CADNET-8172).

**Suggerimenti:** Per fare ciò, creare un oggetto CadBaseEntity, creare un CadMText o CadText con testo, nel nuovo oggetto nel campo SoftOwner aggiungere cadImage.Layouts["Model"].BlockTableRecordHandle dal disegno e aggiungerlo al blocco cadImage.BlockEntities[" *MODEL_SPACE"] e aggiungere il nuovo oggetto agli entità di disegno.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
