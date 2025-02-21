---
title: การส่งออกภาพวาด DWG/DXF และเลย์เอาต์ไปยังขนาดที่กำหนด
type: docs
weight: 40
url: /th/net/developer-guide/export-into-size/
---

## **ส่งออกโมเดลและเลย์เอาต์ทั้งหมดเป็นขนาด PDF A4**

Aspose.CAD API ช่วยให้คุณสามารถส่งออกรายการทั้งหมดของไฟล์ DWG/DXF ไปยังขนาด PDF ทางกายภาพที่กำหนด

โค้ดตัวอย่างต่อไปนี้จะตั้งค่าขนาดของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) เพื่อให้ได้ขนาด PDF ที่ต้องการ
ขนาดของแผ่นกระดาษ A4 คือ 210x297 มิลลิเมตร หรือ 8.27x11.69 นิ้ว และค่าที่ได้จะถูกใช้ในโค้ด

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **ส่งออกเลย์เอาต์ CAD เป็น PDF ในขนาดที่แตกต่างกัน**

บางครั้งมีความจำเป็นต้องส่งออกเลย์เอาต์ในขนาดทางกายภาพของมัน ตัวอย่างด้านล่างแสดงการส่งออกภาพวาดไปยัง PDF หลายหน้า ซึ่งแต่ละหน้าที่มีเนื้อหาเลย์เอาต์
มีขนาด PDF ทางกายภาพของตนเอง ตัวอย่างนี้ใช้ [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
คุณสมบัติ

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
