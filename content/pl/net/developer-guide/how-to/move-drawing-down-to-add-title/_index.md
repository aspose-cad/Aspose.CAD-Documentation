---
title: Przenieś rysunek w dół, aby dodać tytuł
type: docs
weight: 40
url: /pl/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Jak przenieść rysunek w dół, aby dodać tytuł**

**Problem:** Jak przenieść rysunek w dół, aby dodać tytuł (CADNET-980).

**Wskazówki:** Aby to zrobić, stwórz obiekt CadText z parametrami, dodaj ten blok do rysunku, następnie zaktualizuj rysunek za pomocą nowych wymiarów przy użyciu UpdateSize, dodaj polilinię, która jest ramką wokół rysunku, dodaj polilinię do BlockEntities["*Model_Space"] i ponownie zaktualizuj przy użyciu UpdateSize.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
