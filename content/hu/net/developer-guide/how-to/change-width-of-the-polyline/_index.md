---
title: A poligon szélességének megváltoztatása
type: docs
weight: 20
url: /hu/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **A poligon szélességének megváltoztatása**

**Probléma:** Hogyan lehet megváltoztatni a poligon szélességét (CADNET-459-460).

**Tippek:** A szélesség megváltoztatásához a CadBaseEntity-ben (ha a típusa CadEntityTypeName.LWPOLYLINE) használja a (entity as CadLwPolyline).ConstantWidth = 2 vagy a normál entitások esetén a LineWeight-et.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
