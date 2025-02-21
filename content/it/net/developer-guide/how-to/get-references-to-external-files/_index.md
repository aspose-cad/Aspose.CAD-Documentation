---
title: Ottenere riferimenti a file esterni
type: docs
weight: 36
url: /it/net/developer-guide/how-to/get-references-to-external-files/
---

## **Come ottenere riferimenti a file esterni**

**Problema:** Come ottenere riferimenti a file esterni (CADNET-110).

**Suggerimenti:** Per ottenere riferimenti a file esterni per disegni nel blocco entità, c'è un campo XRef PathName per le immagini raster. CadRasterImage viene utilizzato per il sottofondo esterno, CadDgnUnderlay viene utilizzato e il suo campo UnderlayPath.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
