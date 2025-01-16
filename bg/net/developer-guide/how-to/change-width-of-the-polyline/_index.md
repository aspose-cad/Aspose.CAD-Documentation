---
title: Промяна на ширината на многоъгълника 
type: docs
weight: 20
url: /bg/net/how-to/change-width-of-the-polyline/
---

## **Как да промените ширината на многоъгълника**

**Проблем:** Как да промените ширината на многоъгълника (CADNET-459-460).

**Съвети:** За да промените ширината в CadBaseEntity (ако типът е CadEntityTypeName.LWPOLYLINE), използвайте (entity as CadLwPolyline).ConstantWidth = 2 или за обикновени елементи LineWeight.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
