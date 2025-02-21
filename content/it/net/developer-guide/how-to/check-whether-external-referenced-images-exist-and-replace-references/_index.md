---
title: Controlla se le immagini referenziate esternamente esistono e sostituisci i riferimenti
type: docs
weight: 22
url: /it/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Come modificare i collegamenti ipertestuali sugli oggetti**

**Problema:** Come controllare se le immagini referenziate esternamente esistono e sostituire i riferimenti (CADNET-8088).

**Consigli:** Per fare ciò, ottieni un'entità di tipo CadObjectTypeName.IMAGEDEF dalle entità di disegno e utilizza CadRasterImageDef per controllare.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
