---
title: Проверете дали външните референтни изображения съществуват и заменете референциите
type: docs
weight: 22
url: /bg/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Как да редактирам хипервръзки върху обекти**

**Проблем:** Как да проверите дали съществуват външни референтни изображения и да ги замените (CADNET-8088).

**Съвети:** За да направите това, вземете един елемент от тип CadObjectTypeName.IMAGEDEF от елементите на чертежа и използвайте CadRasterImageDef за проверка.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
