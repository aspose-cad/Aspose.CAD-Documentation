---
title: לשנות את רוחב הפוליליניה 
type: docs
weight: 20
url: /he/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **איך לשנות את רוחב הפוליליניה**

**בעיה:** איך לשנות את רוחב הפוליליניה (CADNET-459-460).

**טיפים:** כדי לשנות את הרוחב ב-CadBaseEntity (אם סוג CadEntityTypeName.LWPOLYLINE) השתמשו ב-(entity as CadLwPolyline).ConstantWidth = 2 או עבור ישויות רגילות LineWeight.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
