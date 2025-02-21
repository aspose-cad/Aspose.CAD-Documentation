---
title: Kolorowanie wstawek z nowo dodanymi warstwami
type: docs
weight: 23
url: /pl/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Jak kolorować wstawki z nowo dodanymi warstwami (CADNET-1146)**

**Problem:** Jak kolorować wstawki z nowo dodanymi warstwami (CADNET-1146).

**Wskazówki:** Aby to zrobić, użyj klasy CadLayerTable do stworzenia warstwy, aby móc dodać nową warstwę do rysunku, możesz również użyć CadLayersList, aby dodać wiele warstw.

**Przykład:**

{{% alert color="primary" %}}

Początkowy plik zawiera 5 wstawek o nazwach "1", "2", "3", "4" i "5", a wszystkie z nich znajdują się w domyślnej warstwie 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
