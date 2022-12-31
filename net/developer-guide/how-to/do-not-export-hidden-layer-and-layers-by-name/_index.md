---
title: Do not export hidden layer and layers by name
type: docs
weight: 26
url: /net/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **How not to export hidden layer and layers by name**

**Issue:** How not to export hidden layer and layers by name.

**Tips:** To do this, you need to create an array of layers that are not named "LayerToHide" and add them to rasterizationOptions.Layers.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}