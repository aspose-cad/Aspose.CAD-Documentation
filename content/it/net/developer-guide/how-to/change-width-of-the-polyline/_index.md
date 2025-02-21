---
title: Cambiare la larghezza della polilinea 
type: docs
weight: 20
url: /it/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Come cambiare la larghezza della polilinea**

**Problema:** Come cambiare la larghezza della polilinea (CADNET-459-460).

**Suggerimenti:** Per cambiare la larghezza in CadBaseEntity (se il tipo è CadEntityTypeName.LWPOLYLINE) usa (entity as CadLwPolyline).ConstantWidth = 2 o per entità regolari LineWeight.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
