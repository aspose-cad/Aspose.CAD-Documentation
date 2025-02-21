---
title: Wyszukiwanie atrybutu wewnątrz wstawienia
type: docs
weight: 44
url: /pl/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Jak wyszukiwać atrybut wewnątrz wstawienia**

**Problem:** Jak wyszukiwać atrybut wewnątrz wstawienia (CADNET-8050).

**Wskazówki:** Aby to zrobić, uzyskaj encję typu CadEntityTypeName.ATTDEF, a w niej pole PromptString z wartością "StringToSearch".

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
