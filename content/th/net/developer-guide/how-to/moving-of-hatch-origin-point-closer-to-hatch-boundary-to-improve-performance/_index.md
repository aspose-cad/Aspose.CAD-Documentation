---
title: ย้ายจุดกำเนิดของแฮชให้ใกล้ขอบเขตของแฮชเพื่อปรับปรุงประสิทธิภาพ
type: docs
weight: 41
url: /th/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **วิธีการย้ายจุดกำเนิดของแฮชให้ใกล้ขอบเขตของแฮชเพื่อปรับปรุงประสิทธิภาพ**

**ปัญหา:** วิธีการย้ายจุดกำเนิดของแฮชให้ใกล้ขอบเขตของแฮชเพื่อปรับปรุงประสิทธิภาพ (CADNET-1340).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้ดึงหน่วย CadHatch จากการวาดภาพ ตั้งค่าจุดที่ต้องการด้วย Point2D คำนวณระยะทางและใน CadHatchPatternData ตั้งค่า LineBasePoint สำหรับ X และ Y.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
