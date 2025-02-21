---
title: Sprawdź, czy zewnętrzne obrazy referencyjne istnieją i zastąp referencje
type: docs
weight: 22
url: /pl/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Jak edytować hiperłącza w obiektach**

**Problem:** Jak sprawdzić, czy zewnętrzne obrazy referencyjne istnieją i zastąpić referencje (CADNET-8088).

**Wskazówki:** Aby to zrobić, uzyskaj encję typu CadObjectTypeName.IMAGEDEF z encji rysunku i użyj CadRasterImageDef, aby przeprowadzić weryfikację.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
