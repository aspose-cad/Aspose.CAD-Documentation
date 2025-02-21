---
title: Colorazione degli inserti con nuovi strati aggiunti
type: docs
weight: 23
url: /it/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Come colorare gli inserti con nuovi strati aggiunti (CADNET-1146)**

**Problema:** Come colorare gli inserti con nuovi strati aggiunti (CADNET-1146).

**Suggerimenti:** Per fare questo, usa la classe CadLayerTable per creare uno strato per poter aggiungere un nuovo strato al disegno, puoi anche usare CadLayersList per aggiungere più strati.

**Esempio:**

{{% alert color="primary" %}}

Il file iniziale contiene 5 inserti con i nomi "1", "2", "3", "4" e "5" e tutti sono nello strato predefinito 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
