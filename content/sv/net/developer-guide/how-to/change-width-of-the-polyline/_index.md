---
title: Ändra bredden på polylinje
type: docs
weight: 20
url: /sv/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Hur man ändrar bredden på polylinje**

**Problem:** Hur man ändrar bredden på polylinje (CADNET-459-460).

**Tips:** För att ändra bredden i CadBaseEntity (om typen är CadEntityTypeName.LWPOLYLINE) använd (entity as CadLwPolyline).ConstantWidth = 2 eller för vanliga entiteter LineWeight.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
