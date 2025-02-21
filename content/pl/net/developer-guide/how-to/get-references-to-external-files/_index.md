---
title: Uzyskiwanie odniesień do plików zewnętrznych
type: docs
weight: 36
url: /pl/net/developer-guide/how-to/get-references-to-external-files/
---

## **Jak uzyskać odniesienia do plików zewnętrznych**

**Problem:** Jak uzyskać odniesienia do plików zewnętrznych (CADNET-110).

**Wskazówki:** Aby uzyskać odniesienia do plików zewnętrznych dla rysunków w bloku encji, istnieje pole XRef PathName dla obrazów rastrowych, CadRasterImage jest używane dla zewnętrznego podkładu, CadDgnUnderlay jest używane, a jego pole UnderlayPath.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
