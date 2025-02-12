---
title: Mover el dibujo hacia abajo para agregar un título
type: docs
weight: 40
url: /es/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Cómo mover el dibujo hacia abajo para agregar un título**

**Problema:** Cómo mover el dibujo hacia abajo para agregar un título (CADNET-980).

**Consejos:** Para hacer esto, crea un objeto CadText con parámetros, agrega este bloque al dibujo, luego actualiza el dibujo con las nuevas dimensiones utilizando UpdateSize, agrega una polilínea que sea un marco alrededor del dibujo, agrega la polilínea a BlockEntities["*Model_Space"] y actualiza nuevamente con UpdateSize.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
