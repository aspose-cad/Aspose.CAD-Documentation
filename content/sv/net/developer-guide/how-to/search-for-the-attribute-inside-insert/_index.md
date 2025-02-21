---
title: Sök efter attributet inuti insatsen
type: docs
weight: 44
url: /sv/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Hur man söker efter ett attribut inuti insatsen**

**Problem:** Hur man söker efter ett attribut inuti insatsen (CADNET-8050).

**Tips:** För att göra detta, hämta en entitet med typen CadEntityTypeName.ATTDEF och i den ett PromptString-fält med värdet "StringToSearch".

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
