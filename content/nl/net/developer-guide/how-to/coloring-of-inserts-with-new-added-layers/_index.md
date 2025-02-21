---
title: Kleuren van inserts met nieuw toegevoegde lagen
type: docs
weight: 23
url: /nl/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Hoe inserts te kleuren met nieuw toegevoegde lagen (CADNET-1146)**

**Probleem:** Hoe inserts te kleuren met nieuw toegevoegde lagen (CADNET-1146).

**Tips:** Gebruik hiervoor de CadLayerTable-klasse om een laag te maken zodat je een nieuwe laag aan de tekening kunt toevoegen. Je kunt ook CadLayersList gebruiken om meerdere lagen toe te voegen.

**Voorbeeld:**

{{% alert color="primary" %}}

Het oorspronkelijke bestand bevat 5 inserts met de namen "1", "2", "3", "4" en "5" en allemaal bevinden ze zich in de standaard laag 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
