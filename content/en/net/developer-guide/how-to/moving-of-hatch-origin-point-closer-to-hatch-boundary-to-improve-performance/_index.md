---
title: Moving of hatch origin point closer to hatch boundary to improve performance
type: docs
weight: 41
url: /net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **How to move the hatch origin point closer to hatch boundary to improve performance**

**Issue:** How to move the hatch origin point closer to hatch boundary to improve performance (CADNET-1340).

**Tips:** To do this, get the CadHatch entities from the drawing, set the required points with Point2D, calculate the distance and in CadHatchPatternData set LineBasePoint for X and Y.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}