---
title: Alterar a largura da polilinha
type: docs
weight: 20
url: /pt/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Como alterar a largura da polilinha**

**Problema:** Como alterar a largura da polilinha (CADNET-459-460).

**Dicas:** Para alterar a largura em CadBaseEntity (se o tipo for CadEntityTypeName.LWPOLYLINE) use (entity as CadLwPolyline).ConstantWidth = 2 ou para entidades regulares LineWeight.

**Exemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
