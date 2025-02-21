---
title: Leggere, aggiornare e scrivere file DWG
type: docs
weight: 11
url: /it/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Come leggere, aggiornare e scrivere un file DWG**

**Problema:** Come leggere, aggiornare e scrivere un file DWG.

**Suggerimenti:** Per fare questo, puoi ottenere il file utilizzando il metodo load, ottenere le entità necessarie e apportare modifiche, come cambiare i punti di inizio e di fine o lo spessore delle linee.

**Nota:** Questo frammento di codice mostra un esempio di lettura di un file dwg, cambiando gli oggetti: le posizioni delle linee, dei cerchi, dei valori di testo (puoi aggiungere modifiche ad altri oggetti e ai loro valori per cui è supportata la lettura/scrittura) e poi salvando in un nuovo file. Quindi puoi aprire un nuovo file in AutoCAD e vedere oggetti con valori modificati.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
