---
title: Cerca l'attributo all'interno dell'inserimento
type: docs
weight: 44
url: /it/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Come cercare un attributo all'interno dell'inserimento**

**Problema:** Come cercare un attributo all'interno dell'inserimento (CADNET-8050).

**Suggerimenti:** Per fare ciò, ottenere un'entità con il tipo CadEntityTypeName.ATTDEF e in essa un campo PromptString con il valore "StringToSearch".

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
