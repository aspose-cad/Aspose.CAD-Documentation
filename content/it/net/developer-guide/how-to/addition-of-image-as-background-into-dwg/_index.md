---
title: Aggiunta di un'immagine come sfondo in DWG
type: docs
weight: 15
url: /it/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Come aggiungere un'immagine come sfondo in DWG**

**Problema:** Come aggiungere un'immagine come sfondo in DWG.

**Suggerimenti:** Per farlo, crea un oggetto CadRasterImageDef per l'immagine di sfondo, crea un oggetto CadRasterImage per inserire lo sfondo per il disegno, aggiungi un oggetto CadRasterImage agli oggetti del disegno, crea un CadBaseObject e aggiungilo a cadImage.Objects, elabora tutto tramite CadBlockTableObject.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
