---
title: เพิ่มเอนทิตีใหม่ TEXT/MTEXT ไปทางขวาของเอนทิตีก่อนหน้า
type: docs
weight: 17
url: /th/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **วิธีการเพิ่มเอนทิตีใหม่ TEXT/MTEXT ไปทางขวาของเอนทิตีก่อนหน้า**

**ปัญหา:** วิธีการเพิ่มเอนทิตีใหม่ TEXT/MTEXT ไปทางขวาของเอนทิตีก่อนหน้า (CADNET-8172).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้สร้างอ็อบเจ็กต์ CadBaseEntity สร้าง CadMText หรือ CadText ด้วยข้อความ ในอ็อบเจ็กต์ใหม่ให้เพิ่ม cadImage.Layouts["Model"].BlockTableRecordHandle จากรูปวาดและเพิ่มเข้ากับบล็อก cadImage.BlockEntities[" *MODEL_SPACE"] และเพิ่มอ็อบเจ็กต์ใหม่ไปยังเอนทิตีในรูปวาด.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
