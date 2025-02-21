---
title: Поиск атрибута внутри вставки
type: docs
weight: 44
url: /ru/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Как искать атрибут внутри вставки**

**Проблема:** Как искать атрибут внутри вставки (CADNET-8050).

**Советы:** Для этого получите объект типа CadEntityTypeName.ATTDEF и в нем поле PromptString со значением "StringToSearch".

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
