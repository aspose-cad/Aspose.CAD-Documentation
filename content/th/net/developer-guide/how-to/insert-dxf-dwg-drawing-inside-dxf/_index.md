---
title: แทรกรูปวาด DXF/DWG ภายใน DXF
type: docs
weight: 39
url: /th/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **วิธีการแทรกรูปวาด DXF/DWG ภายใน DXF**

**ปัญหา:** วิธีการแทรกรูปวาด DXF/DWG ภายใน DXF.

**เคล็ดลับ:** เพื่อทำเช่นนี้ คุณต้องสร้าง CadInsertObject ก่อนด้วยค่าที่จำเป็น จากนั้นเรียกดูบล็อกทั้งหมดใน CadBlockDictionary สร้างบล็อก CadBlockEntity ใหม่และเพิ่มเข้าไปใน CadBlockDictionary เพิ่ม CadBlockDictionary ลงใน BlockEntities ของการวาด เพิ่ม CadInsertObject ลงในเอนทิตีของการวาดสำหรับอาเรย์

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
