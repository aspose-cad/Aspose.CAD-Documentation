---
title: Calculation of area and circumference of the circles
type: docs
weight: 18
url: /net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **How to сalculation of area and circumference of the circles**

**Issue:** How to сalculation of area and circumference of the circles (CADNET-1153).

**Tips:** To do this, get the radius from CadEntityTypeName.CIRCLE from the entities and use the formula **"2 * Math.PI * radius"**.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}