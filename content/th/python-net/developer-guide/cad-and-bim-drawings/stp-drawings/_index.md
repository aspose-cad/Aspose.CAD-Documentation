---
title: การวาดภาพ STP
type: docs
weight: 160
url: /th/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **การส่งออกฟอร์แมต STP เป็น PDF**

Aspose.CAD สำหรับ Python ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [STP](https://docs.fileformat.com/3d/stp/) เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลง [STP](https://docs.fileformat.com/3d/stp/) เป็น [PDF](https://docs.fileformat.com/pdf/) มีดังนี้:

1. โหลดไฟล์วาดภาพ [STP](https://docs.fileformat.com/3d/stp/) โดยใช้เมธอดโรงงาน **Image.load** 
1. สร้างวัตถุของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติ **page_height** & **page_width** 
1. สร้างวัตถุของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **vector_rasterization_options** 
1. เรียกใช้ **Image.save** โดยส่งวัตถุของ **PdfOptions** เป็นพารามิเตอร์ที่สอง 

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
