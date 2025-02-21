---
title: การทำงานกับรูปแบบไฟล์ OBJ
type: docs
weight: 120
url: /th/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD ตอนนี้รองรับรูปแบบไฟล์ OBJ รูปแบบไฟล์ OBJ เป็นเรขาคณิต 3D ที่มีแผนที่พื้นผิว, พิกัด 3D, หน้าแบบหลายเหลี่ยม, และข้อมูลวัตถุอื่นๆ

{{% /alert %}}

## **การส่งออกรูปแบบ OBJ เป็น PNG**

Aspose.CAD สำหรับ Javascript ใน Angular ช่วยให้นักพัฒนา สามารถส่งออกไฟล์ [OBJ](https://docs.fileformat.com/3d/obj/) เป็นรูปแบบ [PNG](https://docs.fileformat.com/image/png/) ได้
วิธีการแปลงจาก [OBJ](https://docs.fileformat.com/3d/obj/) เป็น [PNG](https://docs.fileformat.com/image/png/) ทำงานตามขั้นตอนดังนี้:

1. โหลดไฟล์วาด [OBJ](https://docs.fileformat.com/3d/obj/) โดยใช้วิธี **Image.load**
2. เรียกใช้ **Image.save** โดยส่งวัตถุของ **PngOptions** เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

โค้ดด้านล่างแสดงวิธีการบรรลุเป้าหมายเดียวกันโดยใช้ Aspose.CAD สำหรับ JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
