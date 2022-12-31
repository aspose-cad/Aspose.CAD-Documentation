---
title: Change width of the polyline 
type: docs
weight: 10
url: /net/how-to/change-width-of-the-polyline/
---

## **How to change width of the polyline**

**Issue:** How to change width of the polyline (CADNET-459-460).

**Tips:** To change the width in CadBaseEntity (if type CadEntityTypeName.LWPOLYLINE) use (entity as CadLwPolyline).ConstantWidth = 2 or for regular entities LineWeight.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}