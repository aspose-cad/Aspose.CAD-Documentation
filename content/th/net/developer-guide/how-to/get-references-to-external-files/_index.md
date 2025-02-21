---
title: วิธีการรับอ้างอิงไปยังไฟล์ภายนอก
type: docs
weight: 36
url: /th/net/developer-guide/how-to/get-references-to-external-files/
---

## **วิธีการรับอ้างอิงไปยังไฟล์ภายนอก**

**ปัญหา:** วิธีการรับอ้างอิงไปยังไฟล์ภายนอก (CADNET-110).

**เคล็ดลับ:** เพื่อรับอ้างอิงไปยังไฟล์ภายนอกสำหรับภาพวาดในบล็อกเอนทิตี จะมีฟิลด์ XRef PathName สำหรับภาพเรสเตอร์ CadRasterImage Def ที่ใช้สำหรับการรองรับภายนอก CadDgnUnderlay ที่ใช้และฟิลด์ UnderlayPath ของมัน

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
