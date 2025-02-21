---
title: แบบภาพ DXB
type: docs
weight: 90
url: /th/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **การส่งออกรูปแบบ DXB เป็น PDF**

Aspose.CAD สำหรับ Python อนุญาตให้นักพัฒนาส่งออกไฟล์ DXB เป็นรูปแบบ [PDF](https://docs.fileformat.com/pdf/). วิธีการแปลง DXB เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์รูปภาพ DXB โดยใช้วิธี **Image.load** factory.
1. สร้างอ็อบเจ็กต์ของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติ **page_height** & **page_width**.
1. สร้างอ็อบเจ็กต์ของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **vector_rasterization_options**.
1. เรียกใช้ **Image.save** ขณะส่งอ็อบเจ็กต์ของ **PdfOptions** เป็นพารามิเตอร์ที่สอง.

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
