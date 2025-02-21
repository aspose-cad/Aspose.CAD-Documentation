---
title: การวาดภาพ FBX
type: docs
weight: 110
url: /th/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **การส่งออกฟอร์แมต FBX เป็น PDF**

Aspose.CAD สำหรับ Python ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [FBX](https://docs.fileformat.com/3d/fbx/) ไปยังฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) ได้ วิธีการแปลง [FBX](https://docs.fileformat.com/3d/fbx/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานตามขั้นตอนดังต่อไปนี้:

1. โหลดไฟล์วาด [FBX](https://docs.fileformat.com/3d/fbx/) โดยใช้วิธีการแฟคตอรี **Image.load** 
1. สร้างอ็อบเจ็กต์ของคลาส **CadRasterizationOptions** และตั้งค่า properties **PageHeight** & **PageWidth** 
1. สร้างอ็อบเจ็กต์ของคลาส **PdfOptions** และตั้งค่า property **vector_rasterization_options** 
1. เรียกใช้ **Image.save** โดยส่งอ็อบเจ็กต์ของ **PdfOptions** เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
