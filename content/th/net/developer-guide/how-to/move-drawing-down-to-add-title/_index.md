---
title: ย้ายการวาดลงเพื่อเพิ่มชื่อเรื่อง
type: docs
weight: 40
url: /th/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **วิธีการย้ายการวาดลงเพื่อเพิ่มชื่อเรื่อง**

**ปัญหา:** วิธีการย้ายการวาดลงเพื่อเพิ่มชื่อเรื่อง (CADNET-980).

**เคล็ดลับ:** เพื่อทำสิ่งนี้ สร้างอ็อบเจ็กต์ CadText ด้วยพารามิเตอร์ เพิ่มบล็อกนี้ลงในภาพวาด จากนั้นอัปเดตภาพวาดด้วยขนาดใหม่โดยใช้ UpdateSize เพิ่มเส้นโพลีไลน์ที่เป็นกรอบรอบภาพวาด เพิ่มโพลีไลน์ลงใน BlockEntities["*Model_Space"] และอัปเดตอีกครั้งด้วย UpdateSize.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
