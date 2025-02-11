---
title: Comprobar si existen imágenes referenciadas externamente y reemplazar referencias
type: docs
weight: 22
url: /es/net/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Cómo editar hipervínculos en objetos**

**Problema:** Cómo comprobar si existen imágenes referenciadas externamente y reemplazar referencias (CADNET-8088).

**Consejos:** Para ello, obtenga una entidad del tipo CadObjectTypeName.IMAGEDEF de las entidades de dibujo y utilice CadRasterImageDef para comprobar.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
