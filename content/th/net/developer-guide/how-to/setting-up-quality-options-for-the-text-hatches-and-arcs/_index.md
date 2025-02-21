---
title: การตั้งค่าตัวเลือกคุณภาพสำหรับข้อความ, ลายและส่วนโค้ง
type: docs
weight: 46
url: /th/net/developer-guide/how-to/setting-up-quality-options-for-the-text-hatches-and-arcs/
---

## **วิธีการตั้งค่าตัวเลือกคุณภาพสำหรับข้อความ, ลายและส่วนโค้ง**

**ปัญหา:** วิธีการตั้งค่าตัวเลือกคุณภาพสำหรับข้อความ, ลายและส่วนโค้ง (CADNET-986).

**เคล็ดลับ:** เพื่อตั้งค่าพารามิเตอร์คุณภาพสำหรับข้อความ, เส้นและส่วนโค้ง การปรับค่าต่างๆ จะดำเนินการในคลาส rasterizationOptions (rasterizationOptions.Quality.Text, rasterizationOptions.Quality.Hatch, rasterizationOptions.Quality.Arc, rasterizationOptions.Quality.ObjectsPrecision)
.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "setting-up-quality-options-for-the-text-hatches-and-arcs.cs" >}}
