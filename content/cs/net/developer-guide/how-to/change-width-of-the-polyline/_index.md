---
title: Změna šířky polygonové čáry 
type: docs
weight: 20
url: /cs/jak-na/zmena-sirky-polygonove-cary/
---

## **Jak změnit šířku polygonové čáry**

**Problém:** Jak změnit šířku polygonové čáry (CADNET-459-460).

**Tipy:** Pro změnu šířky v CadBaseEntity (pokud je typ CadEntityTypeName.LWPOLYLINE) použijte (entita jako CadLwPolyline).ConstantWidth = 2 nebo pro běžné entity LineWeight.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
