---
title: Vyhledání atributu uvnitř vložení
type: docs
weight: 44
url: /cs/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Jak najít atribut uvnitř vložení**

**Problém:** Jak najít atribut uvnitř vložení (CADNET-8050).

**Tipy:**  Abyste mohli provést toto, získejte entitu s typem CadEntityTypeName.ATTDEF a v ní pole PromptString s hodnotou "StringToSearch".

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "vyhledani-atributu-uvnitr-vlozeni.cs" >}}
