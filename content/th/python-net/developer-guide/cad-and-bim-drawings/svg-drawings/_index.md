---
title: การวาด SVG
type: docs
weight: 170
url: /th/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **ส่งออกไฟล์ SVG เป็น PDF**

Aspose.CAD สำหรับ Python อนุญาตให้นักพัฒนาส่งออกไฟล์ [SVG](https://docs.fileformat.com/page-description-language/svg/) เป็นรูปแบบ [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลงจาก [SVG](https://docs.fileformat.com/page-description-language/svg/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์การวาด SVG โดยใช้วิธีการโรงงาน **Image.load**.
1. สร้างวัตถุของคลาส **CadRasterizationOptions** และตั้งค่า คุณสมบัติ **page_height** และ **page_width**.
1. สร้างวัตถุของคลาส **PdfOptions** และตั้งค่า คุณสมบัติ **VectorRasterizationOptions**.
1. เรียกใช้ **Image.save** โดยส่งผ่านวัตถุของ **PdfOptions** เป็นพารามิเตอร์ที่สอง.

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
