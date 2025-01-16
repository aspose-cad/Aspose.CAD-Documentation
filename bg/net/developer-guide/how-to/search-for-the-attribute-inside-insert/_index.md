---
title: Търсене на атрибут вътре в инсерт
type: docs
weight: 44
url: /bg/net/how-to/search-for-the-attribute-inside-insert/
---

## **Как да търсим за атрибут вътре в инсерт**

**Проблем:** Как да търсим за атрибут вътре в инсерт (CADNET-8050).

**Съвети:** За да направите това, вземете ентитет с тип CadEntityTypeName.ATTDEF и в него поле PromptString със стойност "StringToSearch".

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
