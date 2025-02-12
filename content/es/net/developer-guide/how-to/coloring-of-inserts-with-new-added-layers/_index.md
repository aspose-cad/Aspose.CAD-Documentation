---
title: Coloración de insertos con nuevas capas añadidas
type: docs
weight: 23
url: /es/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Cómo colorear insertos con nuevas capas añadidas (CADNET-1146)**

**Problema:** Cómo colorear insertos con nuevas capas añadidas (CADNET-1146).

**Consejos:** Para hacer esto, usa la clase CadLayerTable para crear una capa y poder añadir una nueva capa al dibujo; también puedes usar CadLayersList para añadir múltiples capas.

**Ejemplo:**

{{% alert color="primary" %}}

El archivo inicial contiene 5 insertos con nombres "1", "2", "3", "4" y "5" y todos están en la capa predeterminada 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
