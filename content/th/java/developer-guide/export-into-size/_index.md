---
title: การส่งออกแบบ DWG/DXF และเลเอาต์ไปยังขนาดที่กำหนด
type: docs
weight: 40
url: /th/java/developer-guide/export-into-size/
---

## **ส่งออกโมเดลและเลเอาต์ทั้งหมดไปยังขนาด PDF A4**

Aspose.CAD API ช่วยให้คุณสามารถส่งออกทุกแผ่นของไฟล์ DWG/DXF ไปยังขนาด PDF ที่กำหนดได้ ขนาดของแผ่นกระดาษ A4 มีขนาด 210x297 มิลลิเมตร หรือ 8.27x11.69 นิ้ว และค่าต่างๆ เหล่านี้จะถูกใช้ในโค้ด

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **ส่งออกเลเอาต์ CAD ไปยัง PDF ในขนาดที่แตกต่างกัน**

บางครั้งจำเป็นต้องส่งออกเลเอาต์ไปยังขนาดจริงของมัน ตัวอย่างด้านล่างแสดงการส่งออกแบบลงใน PDF หลายหน้า โดยแต่ละหน้าที่มีเนื้อหาเลเอาต์จะมีขนาด PDF ที่แตกต่างกัน ตัวอย่างนี้ใช้คุณสมบัติ [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) 

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
