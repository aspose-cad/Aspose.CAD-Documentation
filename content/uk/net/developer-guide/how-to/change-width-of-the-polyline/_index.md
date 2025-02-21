---
title: Змінити ширину полігональної лінії 
type: docs
weight: 20
url: /uk/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Як змінити ширину полігональної лінії**

**Проблема:** Як змінити ширину полігональної лінії (CADNET-459-460).

**Поради:** Щоб змінити ширину в CadBaseEntity (якщо тип CadEntityTypeName.LWPOLYLINE) використовуйте (entity as CadLwPolyline).ConstantWidth = 2 або для звичайних сутностей LineWeight.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
