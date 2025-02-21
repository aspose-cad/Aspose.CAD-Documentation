---
title: การคำนวณพื้นที่และเส้นรอบวงของวงกลม
type: docs
weight: 18
url: /th/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **วิธีการคำนวณพื้นที่และเส้นรอบวงของวงกลม**

**ปัญหา:** วิธีการคำนวณพื้นที่และเส้นรอบวงของวงกลม (CADNET-1153).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้รับรัศมีจาก CadEntityTypeName.CIRCLE จากเอนทิตีและใช้สูตร **"2 * Math.PI * radius"**.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
