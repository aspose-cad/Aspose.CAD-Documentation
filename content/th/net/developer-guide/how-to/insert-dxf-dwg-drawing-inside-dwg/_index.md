---
title: แทรกภาพวาด DXF/DWG ภายใน DWG
type: docs
weight: 38
url: /th/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **วิธีการแทรกภาพวาด DXF/DWG ภายใน DWG**

**ปัญหา:** วิธีการแทรกภาพวาด DXF/DWG ภายใน DWG

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้สร้าง CadInsertObject พร้อมค่าที่ต้องการก่อน จากนั้นดึงบล็อกทั้งหมดใน CadBlockDictionary สร้างบล็อก CadBlockEntity ใหม่และเพิ่มเข้ากับ CadBlockDictionary เพิ่ม CadBlockDictionary ไปยัง BlockEntities ของภาพวาด เพิ่ม CadInsertObject ไปยังเอนทิตีของภาพวาดสำหรับอาเรย์ สร้าง CadBlockTableObject โดยอ้างอิง จากนั้นเพิ่มบล็อกไปยังภาพวาด

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
