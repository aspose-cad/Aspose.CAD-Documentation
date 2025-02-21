---
title: Пошук атрибута всередині вставки
type: docs
weight: 44
url: /uk/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **Як шукати атрибут всередині вставки**

**Проблема:** Як шукати атрибут всередині вставки (CADNET-8050).

**Поради:** Для цього отримайте сутність з типом CadEntityTypeName.ATTDEF і в ній поле PromptString зі значенням "StringToSearch".

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
