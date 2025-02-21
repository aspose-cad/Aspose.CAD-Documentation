---
title: การเพิ่มภาพเป็นพื้นหลังใน DWG
type: docs
weight: 15
url: /th/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **วิธีการเพิ่มภาพเป็นพื้นหลังใน DWG**

**ปัญหา:** วิธีการเพิ่มภาพเป็นพื้นหลังใน DWG.

**เคล็ดลับ:** เพื่อทำสิ่งนี้ ให้สร้างวัตถุ CadRasterImageDef สำหรับภาพพื้นหลัง สร้างวัตถุ CadRasterImage เพื่อแทรกพื้นหลังสำหรับการวาดภาพ เพิ่มวัตถุ CadRasterImage ไปยังวัตถุการวาด สร้างวัตถุ CadBaseObject และเพิ่มไปยัง cadImage.Objects ประมวลผลทุกอย่างผ่าน CadBlockTableObject.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
