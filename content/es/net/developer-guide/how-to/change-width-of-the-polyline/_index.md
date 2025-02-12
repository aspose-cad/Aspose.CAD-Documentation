---
title: Cambiar el ancho de la polilínea 
type: docs
weight: 20
url: /es/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Cómo cambiar el ancho de la polilínea**

**Problema:** Cómo cambiar el ancho de la polilínea (CADNET-459-460).

**Consejos:** Para cambiar el ancho en CadBaseEntity (si el tipo es CadEntityTypeName.LWPOLYLINE) utiliza (entity as CadLwPolyline).ConstantWidth = 2 o para entidades regulares LineWeight.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
