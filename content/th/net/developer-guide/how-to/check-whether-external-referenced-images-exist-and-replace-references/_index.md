---
title: ตรวจสอบว่าภาพที่อ้างอิงจากภายนอกมีอยู่จริงและแทนที่การอ้างอิง
type: docs
weight: 22
url: /th/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **วิธีการแก้ไขลิงก์บนวัตถุ**

**ปัญหา:** วิธีการตรวจสอบว่าภาพที่อ้างอิงจากภายนอกมีอยู่จริงและแทนที่การอ้างอิง (CADNET-8088).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้รับเอนทิตีของประเภท CadObjectTypeName.IMAGEDEF จากเอนทิตีการวาดภาพและใช้ CadRasterImageDef เพื่อตรวจสอบ

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
