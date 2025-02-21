---
title: Zmień szerokość polilinii
type: docs
weight: 20
url: /pl/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Jak zmienić szerokość polilinii**

**Problem:** Jak zmienić szerokość polilinii (CADNET-459-460).

**Porady:** Aby zmienić szerokość w CadBaseEntity (jeśli typ CadEntityTypeName.LWPOLYLINE) użyj (entity as CadLwPolyline).ConstantWidth = 2 lub dla zwykłych encji LineWeight.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
