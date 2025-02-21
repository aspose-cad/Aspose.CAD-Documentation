---
title: Wijzig de breedte van de polyline
type: docs
weight: 20
url: /nl/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Hoe de breedte van de polyline te wijzigen**

**Probleem:** Hoe de breedte van de polyline wijzigen (CADNET-459-460).

**Tips:** Om de breedte in CadBaseEntity te wijzigen (indien type CadEntityTypeName.LWPOLYLINE) gebruik (entity as CadLwPolyline).ConstantWidth = 2 of voor reguliere entiteiten LineWeight.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
