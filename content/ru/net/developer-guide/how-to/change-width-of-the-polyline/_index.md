---
title: Изменение ширины полилинии
type: docs
weight: 20
url: /ru/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Как изменить ширину полилинии**

**Проблема:** Как изменить ширину полилинии (CADNET-459-460).

**Советы:** Чтобы изменить ширину в CadBaseEntity (если тип CadEntityTypeName.LWPOLYLINE), используйте (entity as CadLwPolyline).ConstantWidth = 2 или для обычных объектов LineWeight.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
