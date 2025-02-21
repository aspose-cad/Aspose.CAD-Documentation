---
title: การส่งออกภาพวาด DWF
type: docs
weight: 50
url: /th/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **การส่งออกภาพวาด DWF เป็น PDF**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีภาพวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และเรนเดอร์เป็นภาพวาดทั้งหมดไปยังรูปแบบ [PDF](https://docs.fileformat.com/pdf/). วิธีการแปลงจาก [DWF](https://docs.fileformat.com/cad/dwf/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีการ **Image.load**.
1. สร้างอ็อบเจ็กต์ของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติ **page_height** & **page_width**.
1. สร้างอ็อบเจ็กต์ของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **vector_rasterization_options**.
1. เรียกใช้ **Image.save** โดยส่งอ็อบเจ็กต์ของ **PdfOptions** เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าเริ่มต้น.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **การส่งออกภาพวาด DWF เป็น BMP**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีภาพวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และเรนเดอร์เป็นภาพวาดทั้งหมดไปยังรูปแบบ [BMP](https://docs.fileformat.com/image/bmp/). วิธีการแปลงจาก [DWF](https://docs.fileformat.com/cad/dwf/) เป็น [BMP](https://docs.fileformat.com/image/bmp/) ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีการ **Image.load**.
1. สร้างอ็อบเจ็กต์ของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติ **page_height** & **page_width**.
1. สร้างอ็อบเจ็กต์ของคลาส **BmpOptions** และตั้งค่าคุณสมบัติ **vector_rasterization_options**.
1. เรียกใช้ **Image.save** โดยส่งอ็อบเจ็กต์ของ **BmpOptions** เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ [DWF](https://docs.fileformat.com/cad/dwf/) เป็น [BMP](https://docs.fileformat.com/image/bmp/) โดยใช้การตั้งค่าเริ่มต้น.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
