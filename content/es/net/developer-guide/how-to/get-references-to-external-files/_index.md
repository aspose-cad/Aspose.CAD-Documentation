---
title: Obtener referencias a archivos externos
type: docs
weight: 36
url: /es/net/developer-guide/how-to/get-references-to-external-files/
---

## **Cómo obtener referencias a archivos externos**

**Problema:** Cómo obtener referencias a archivos externos (CADNET-110).

**Consejos:** Para obtener referencias a archivos externos para dibujos en el bloque de entidad, hay un campo XRef PathName para imágenes de ráster. CadRasterImage se utiliza para subyacentes externos, CadDgnUnderlay se utiliza y su campo UnderlayPath.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
