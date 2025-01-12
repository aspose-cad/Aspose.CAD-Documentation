---
title: Move drawing down to add title
type: docs
weight: 40
url: /net/how-to/move-drawing-down-to-add-title/
---

## **How to move drawing down to add title**

**Issue:** How to move drawing down to add title (CADNET-980).

**Tips:** To do this, create a CadText object with parameters, add this block to the drawing, then update the drawing with the new dimensions with UpdateSize, add a polyline that is a frame around the drawing, add the polyline to BlockEntities["*Model_Space"] and update again with UpdateSize.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}