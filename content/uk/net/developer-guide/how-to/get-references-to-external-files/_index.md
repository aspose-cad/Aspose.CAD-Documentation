---
title: Отримати посилання на зовнішні файли
type: docs
weight: 36
url: /uk/net/developer-guide/how-to/get-references-to-external-files/
---

## **Як отримати посилання на зовнішні файли**

**Проблема:** Як отримати посилання на зовнішні файли (CADNET-110).

**Поради:** Щоб отримати посилання на зовнішні файли для креслень у блоці сутності, існує поле XRef PathName для растрових зображень. CadRasterImage використовується для зовнішнього покриття, CadDgnUnderlay використовується та його поле UnderlayPath.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
