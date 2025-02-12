---
title: Přesunutí kresby dolů pro přidání nadpisu
type: docs
weight: 40
url: /cs/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Jak přesunout kresbu dolů pro přidání nadpisu**

**Problém:** Jak přesunout kresbu dolů pro přidání nadpisu (CADNET-980).

**Tipy:** Pro provedení tohoto úkonu vytvořte objekt CadText s parametry, přidejte tento blok do kresby, pak aktualizujte kresbu s novými rozměry pomocí UpdateSize, přidejte polyline, která bude rámečkem kolem kresby, přidejte polyline do BlockEntities["*Model_Space"] a znovu aktualizujte velikost pomocí UpdateSize.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
