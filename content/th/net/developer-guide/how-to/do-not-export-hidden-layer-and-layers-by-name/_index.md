---
title: ไม่ส่งออกชั้นที่ซ่อนอยู่และชั้นตามชื่อ
type: docs
weight: 26
url: /th/net/developer-guide/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **วิธีไม่ส่งออกชั้นที่ซ่อนอยู่และชั้นตามชื่อ**

**ปัญหา:** วิธีไม่ส่งออกชั้นที่ซ่อนอยู่และชั้นตามชื่อ

**เคล็ดลับ:** เพื่อทำเช่นนี้ คุณต้องสร้างอาร์เรย์ของชั้นที่ไม่มีชื่อว่า "LayerToHide" และเพิ่มไปยัง rasterizationOptions.Layers

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}
