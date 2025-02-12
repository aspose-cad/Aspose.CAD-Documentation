---
title: Buscar el atributo dentro de insert
type: docs
weight: 44
url: /es/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Cómo buscar un atributo dentro de insert**

**Problema:** Cómo buscar un atributo dentro de insert (CADNET-8050).

**Consejos:** Para hacer esto, obtén una entidad con el tipo CadEntityTypeName.ATTDEF y en ella un campo PromptString con el valor "StringToSearch".

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
