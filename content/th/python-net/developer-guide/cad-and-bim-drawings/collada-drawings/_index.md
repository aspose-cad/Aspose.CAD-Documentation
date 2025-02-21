---
title: แผนภาพ COLLADA
type: docs
weight: 20
url: /th/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **การส่งออกฟอร์แมต COLLADA เป็น PDF**

Aspose.CAD สำหรับ Python อนุญาตให้นักพัฒนาส่งออกไฟล์ [COLLADA](https://docs.fileformat.com/3d/dae/) เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลง [COLLADA](https://docs.fileformat.com/3d/dae/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์แผนภาพ [COLLADA](https://docs.fileformat.com/3d/dae/) โดยใช้วิธีการโรงงาน **Image.load** 
1. สร้างออบเจ็กต์ของคลาส **CadRasterizationOptions** และตั้งค่าแอตทริบิวต์ **page_height** และ **page_width**
1. สร้างออบเจ็กต์ของคลาส **PdfOptions** และตั้งค่าแอตทริบิวต์ **vector_rasterization_options**
1. เรียก **Image.save** ขณะที่ส่งผ่านออบเจ็กต์ของ **PdfOptions** เป็นพารามิเตอร์ที่สอง

## โค้ดตัวอย่าง

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
