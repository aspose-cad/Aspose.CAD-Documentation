---
title: ความสามารถในการซ้อนและปรับแต่งข้อความบนภาพ DWF ซึ่งช่วยให้สามารถแก้ไขผลลัพธ์ที่สร้างขึ้นได้ในระดับหนึ่ง
type: docs
weight: 20
url: /th/net/developer-guide/how-to/work-with-text/ability-to-superimpose-and-adjust-text-on-dwf-images/
---

## **วิธีการซ้อนและปรับแต่งข้อความบนภาพ DWF**

**ปัญหา:** วิธีการซ้อนและปรับแต่งข้อความบนภาพ DWF

**เคล็ดลับ:** เพื่อทำเช่นนี้ คุณจะต้องสร้าง DwfWhipText กำหนดพารามิเตอร์ที่จำเป็นและเพิ่มมันลงในภาพวาดโดยใช้วิธี AddElement หรือถ้าคุณต้องการลบมัน คุณสามารถใช้วิธี RemoveElement

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "superimpose-and-adjust-text-on-dwf.cs" >}}
