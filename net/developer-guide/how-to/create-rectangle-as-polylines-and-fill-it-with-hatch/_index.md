---
title: Create rectangle as polylines and fill it with hatch
type: docs
weight: 10
url: /net/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **How to create rectangle as polylines and fill it with hatch**

**Issue:** How to create rectangle as polylines and fill it with hatch (CADNET-1351).

**Tips:** To do this, create a CadLwPolyline and add point coordinates to it, use CadHatch to work with color and use CadEdgeBoundaryPath to connect, use CadHatch to work with angles and CadHatchPatternData for pattern.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}