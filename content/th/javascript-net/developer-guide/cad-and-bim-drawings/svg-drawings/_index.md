---
title: การวาดภาพ SVG
type: docs
weight: 70
url: /th/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **การส่งออกฟอร์แมต SVG เป็น PNG**

Aspose.CAD สำหรับ Javascript ใน Angular ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [SVG](https://docs.fileformat.com/page-description-language/svg/) เป็นฟอร์แมต [PNG](https://docs.fileformat.com/image/png/) ได้
วิธีการแปลง [SVG](https://docs.fileformat.com/page-description-language/svg/) เป็น [PNG](https://docs.fileformat.com/image/png/) ทำงานดังนี้:

1. โหลดไฟล์วาด [SVG](https://docs.fileformat.com/page-description-language/svg/) โดยใช้วิธี **Image.load**
1. เรียกใช้ **Image.save** โดยส่งออบเจ็กต์ของ **PngOptions** เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

โค้ดด้านล่างแสดงวิธีการบรรลุเป้าหมายเดียวกันโดยใช้ Aspose.CAD สำหรับ JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
