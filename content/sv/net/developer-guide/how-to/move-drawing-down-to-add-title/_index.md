---
title: Flytta ritningen ner för att lägga till titel
type: docs
weight: 40
url: /sv/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Hur man flyttar ritningen ner för att lägga till titel**

**Problem:** Hur man flyttar ritningen ner för att lägga till titel (CADNET-980).

**Tips:** För att göra detta, skapa ett CadText-objekt med parametrar, lägg till denna block till ritningen, uppdatera sedan ritningen med de nya dimensionerna med UpdateSize, lägg till en polyline som är en ram runt ritningen, lägg till polyline till BlockEntities["*Model_Space"] och uppdatera igen med UpdateSize.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
