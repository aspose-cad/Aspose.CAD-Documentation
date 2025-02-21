---
title: Додавання зображення в якості фону у DWG
type: docs
weight: 15
url: /uk/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Як додати зображення як фон у DWG**

**Проблема:** Як додати зображення як фон у DWG.

**Поради:** Щоб це зробити, створіть об'єкт CadRasterImageDef для зображення фону, створіть об'єкт CadRasterImage для вставки фону для малюнка, додайте об'єкт CadRasterImage до об'єктів малюнка, створіть CadBaseObject CadBaseObject і додайте його до cadImage.Objects, обробіть все через CadBlockTableObject.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
