---
title: Rechercher un attribut à l'intérieur d'un insert
type: docs
weight: 44
url: /fr/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Comment rechercher un attribut à l'intérieur d'un insert**

**Problème :** Comment rechercher un attribut à l'intérieur d'un insert (CADNET-8050).

**Conseils :** Pour ce faire, obtenez une entité avec le type CadEntityTypeName.ATTDEF et dans celle-ci un champ PromptString avec la valeur "StringToSearch".

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
