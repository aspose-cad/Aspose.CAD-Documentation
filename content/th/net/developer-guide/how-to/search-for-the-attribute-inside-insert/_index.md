---
title: ค้นหาคุณสมบัติภายในคำสั่งแทรก
type: docs
weight: 44
url: /th/net/developer-guide/how-to/search-for-the-attribute-inside-insert/
---

## **วิธีการค้นหาคุณสมบัติภายในคำสั่งแทรก**

**ปัญหา:** วิธีการค้นหาคุณสมบัติภายในคำสั่งแทรก (CADNET-8050).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้ใช้เอนทิตี้ที่มีประเภท CadEntityTypeName.ATTDEF และในนั้นให้มีฟิลด์ PromptString ที่มีค่าเป็น "StringToSearch".

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "search-for-the-attribute-inside-insert.cs" >}}
