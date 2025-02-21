---
title: การเพิ่มภาพเป็นพื้นหลังใน DXF
type: docs
weight: 16
url: /th/net/developer-guide/how-to/addition-of-image-as-background-into-dxf/
---

## **วิธีการเพิ่มภาพเป็นพื้นหลังใน DXF**

**ปัญหา:** วิธีการเพิ่มภาพเป็นพื้นหลังใน DXF.

**เคล็ดลับ:** เพื่อทำเช่นนี้ สร้างวัตถุ CadRasterImageDef สำหรับภาพพื้นหลัง สร้างวัตถุ CadRasterImage เพื่อแทรกพื้นหลังสำหรับการวาดภาพ และเพิ่มวัตถุ CadRasterImage ลงในเอนทิตีการวาดภาพ.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dxf.cs" >}}
