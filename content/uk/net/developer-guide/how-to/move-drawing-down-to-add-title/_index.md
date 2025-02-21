---
title: Перемістіть малюнок вниз, щоб додати назву
type: docs
weight: 40
url: /uk/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Як перемістити малюнок вниз, щоб додати назву**

**Проблема:** Як перемістити малюнок вниз, щоб додати назву (CADNET-980).

**Поради:** Для цього створіть об'єкт CadText з параметрами, додайте цей блок до малюнка, а потім оновіть малюнок з новими розмірами за допомогою UpdateSize, додайте полілайн, який буде рамкою навколо малюнка, додайте полілайн до BlockEntities["*Model_Space"] і знову оновіть за допомогою UpdateSize.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
