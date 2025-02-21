---
title: Колір вставок з новими доданими шарами
type: docs
weight: 23
url: /uk/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Як забарвити вставки з новими доданими шарами (CADNET-1146)**

**Проблема:** Як забарвити вставки з новими доданими шарами (CADNET-1146).

**Поради:** Для цього використовуйте клас CadLayerTable для створення шару, щоб мати можливість додати новий шар до малюнка, також можна використовувати CadLayersList для додавання кількох шарів.

**Приклад:**

{{% alert color="primary" %}}

Початковий файл містить 5 вставок з іменами "1", "2", "3", "4" та "5", і всі вони знаходяться в стандартному 0 шарі.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
