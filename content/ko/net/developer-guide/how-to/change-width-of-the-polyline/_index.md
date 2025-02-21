---
title: 다각선의 너비 변경
type: docs
weight: 20
url: /ko/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **다각선의 너비 변경 방법**

**문제:** 다각선의 너비를 변경하는 방법 (CADNET-459-460).

**팁:** CadBaseEntity에서 너비를 변경하려면 (type CadEntityTypeName.LWPOLYLINE) (entity as CadLwPolyline).ConstantWidth = 2 또는 일반 엔티티에 대해 LineWeight를 사용하십시오.

**예:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
