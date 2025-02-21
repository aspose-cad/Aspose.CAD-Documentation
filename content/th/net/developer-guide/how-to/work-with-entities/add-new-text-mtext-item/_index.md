---
title: เพิ่มรายการ TEXT/MTEXT ใหม่
type: docs
weight: 20
url: /th/net/developer-guide/how-to/work-with-entities/add-new-text-mtext-item/
---


## **วิธีการเพิ่มรายการ TEXT/MTEXT ใหม่**

**ปัญหา:** วิธีการเพิ่มรายการ TEXT/MTEXT ใหม่

**เคล็ดลับ:** สำหรับสิ่งนี้คุณสามารถใช้คุณสมบัติ BlockEntities["*Model_Space"] และ AddEntity เพื่อเพิ่มเอนทิตีใหม่ไปยังการวาด และอย่าลืมวิธี UpdateSize เพื่ออัปเดตขนาด

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-item.cs" >}}
