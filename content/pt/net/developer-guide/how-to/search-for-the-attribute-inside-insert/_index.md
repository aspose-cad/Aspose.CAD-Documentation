---
title: Pesquisar o atributo dentro da inserção
type: docs
weight: 44
url: /pt/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Como pesquisar um atributo dentro da inserção**

**Problema:** Como pesquisar um atributo dentro da inserção (CADNET-8050).

**Dicas:** Para fazer isso, obtenha uma entidade com o tipo CadEntityTypeName.ATTDEF e, nela, um campo PromptString com o valor "StringToSearch".

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
