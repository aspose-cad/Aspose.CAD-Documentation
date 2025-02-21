---
title: เปลี่ยนความกว้างของเส้นโค้ง
type: docs
weight: 20
url: /th/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **วิธีเปลี่ยนความกว้างของเส้นโค้ง**

**ปัญหา:** วิธีเปลี่ยนความกว้างของเส้นโค้ง (CADNET-459-460).

**เคล็ดลับ:** เพื่อเปลี่ยนความกว้างใน CadBaseEntity (ถ้าเป็นประเภท CadEntityTypeName.LWPOLYLINE) ใช้ (entity as CadLwPolyline).ConstantWidth = 2 หรือสำหรับเอนทิตีปกติ LineWeight.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
