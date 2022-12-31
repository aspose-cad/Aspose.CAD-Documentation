---
title: Coloring of inserts with new added layers
type: docs
weight: 10
url: /net/how-to/coloring-of-inserts-with-new-added-layers/
---

## **How to coloring of inserts with new added layers (CADNET-1146)**

**Issue:** How to coloring of inserts with new added layers (CADNET-1146).

**Tips:** To do this, use the CadLayerTable class to create a layer to be able to add a new layer to the drawing, you can also use CadLayersList to add multiple layers.

**Example:**

{{% alert color="primary" %}}

The initial file contains 5 inserts with names "1", "2", "3", "4' and "5" and all of them are in the default 0 layer.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}