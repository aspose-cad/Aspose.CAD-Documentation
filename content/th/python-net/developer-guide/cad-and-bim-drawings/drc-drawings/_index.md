---
title: วาดภาพ DRC
type: docs
weight: 40
url: /th/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **การส่งออกฟอร์แมต DRC ไปยัง PDF**

Aspose.CAD สำหรับ Python ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [DRC](https://docs.fileformat.com/3d/drc/) เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) ได้ แนวทางการแปลง [DRC](https://docs.fileformat.com/3d/drc/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์วาดภาพ DRC โดยใช้วิธีการแฟคทอรี **Image.load** 
1. สร้างวัตถุของคลาส **CadRasterizationOptions** และตั้งค่าแอตทริบิวต์ **page_height** & **page_width** 
1. สร้างวัตถุของคลาส **PdfOptions** และตั้งค่าแอตทริบิวต์ **VectorRasterizationOptions** 
1. เรียกใช้ **Image.save** โดยส่งวัตถุของ **PdfOptions** เป็นพารามิเตอร์ที่สอง 

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
