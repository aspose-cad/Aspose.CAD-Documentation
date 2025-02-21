---
title: Thay đổi độ rộng của polyline
type: docs
weight: 20
url: /vi/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Cách thay đổi độ rộng của polyline**

**Vấn đề:** Làm thế nào để thay đổi độ rộng của polyline (CADNET-459-460).

**Mẹo:** Để thay đổi độ rộng trong CadBaseEntity (nếu loại là CadEntityTypeName.LWPOLYLINE) sử dụng (entity as CadLwPolyline).ConstantWidth = 2 hoặc đối với các thực thể thông thường LineWeight.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
