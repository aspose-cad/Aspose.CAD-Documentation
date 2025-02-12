---
title: Änderung der Breite der Polylinie 
type: docs
weight: 20
url: /de/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Wie man die Breite der Polylinie ändert**

**Problem:** Wie man die Breite der Polylinie ändert (CADNET-459-460).

**Tipps:** Um die Breite in CadBaseEntity zu ändern (wenn der Typ CadEntityTypeName.LWPOLYLINE ist), verwenden Sie (entity as CadLwPolyline).ConstantWidth = 2 oder für reguläre Entitäten LineWeight.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
