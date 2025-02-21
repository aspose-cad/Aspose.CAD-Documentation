---
title: สร้างสี่เหลี่ยมผืนผ้าเป็นโพลีไลน์และเติมด้วยลวดลาย
type: docs
weight: 24
url: /th/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **วิธีการสร้างสี่เหลี่ยมผืนผ้าเป็นโพลีไลน์และเติมด้วยลวดลาย**

**ปัญหา:** วิธีการสร้างสี่เหลี่ยมผืนผ้าเป็นโพลีไลน์และเติมด้วยลวดลาย (CADNET-1351).

**เคล็ดลับ:** เพื่อทำเช่นนี้ให้สร้าง CadLwPolyline และเพิ่มพิกัดจุดไปยังมัน ใช้ CadHatch เพื่อทำงานกับสีและใช้ CadEdgeBoundaryPath เพื่อเชื่อมต่อ ใช้ CadHatch เพื่อทำงานกับมุมและ CadHatchPatternData สำหรับลวดลาย

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
