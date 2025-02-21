---
title: การส่งออกเฉพาะชั้นบางส่วนพร้อมการปรับขนาด
type: docs
weight: 31
url: /th/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **การส่งออกเฉพาะชั้นบางส่วนพร้อมการปรับขนาด (CADNET-559)**

**ปัญหา:** วิธีการส่งออกเฉพาะชั้นบางส่วนพร้อมการปรับขนาด (CADNET-559).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้เลือกชั้นที่จำเป็น เพิ่มไปยังอาร์เรย์ CadBaseEntity จากนั้นกำหนดให้กับเอนทิตีการวาดและเรียกใช้ UpdateSize.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
