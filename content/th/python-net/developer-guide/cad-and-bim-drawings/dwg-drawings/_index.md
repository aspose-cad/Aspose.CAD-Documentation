---
title: การส่งออกภาพวาด DWG
type: docs
weight: 70
url: /th/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **การส่งออกภาพวาด DWG เป็น PDF**

Aspose.CAD สำหรับ Python API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ [DWG](https://docs.fileformat.com/cad/dwg/) และแปลงเป็น [PDF](https://docs.fileformat.com/pdf/). หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้บรรลุการแปลง DWG เป็น PDF ผ่านขั้นตอนง่ายๆ ตามที่กำหนดไว้ข้างหน้า

{{% alert color="primary" %}}

API รองรับการปรับปรุง DWG ของ AutoCAD ดังต่อไปนี้:

- DWG 2004  เวอร์ชัน 16.0 วางจำหน่าย 18
- DWG 2005 เวอร์ชัน  16.1
- DWG 2010 เวอร์ชัน 18.0
- DWG 2013 เวอร์ชัน 19.0

{{% /alert %}}

### **รูปแบบไฟล์ DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) เป็นไฟล์ไบนารีที่ประกอบด้วยข้อมูลภาพเวกเตอร์และข้อมูลเมตา ข้อมูลภาพเวกเตอร์ให้คำแนะนำแก่แอปพลิเคชัน CAD เกี่ยวกับวิธีการแสดงผล DWG; ข้อมูลเมตาอาจมีข้อมูลมากมายเกี่ยวกับไฟล์ รวมถึงข้อมูลเฉพาะสถานที่และข้อมูลลูกค้า ข้อกำหนดเปิดสำหรับรูปแบบไฟล์ DWG สามารถพบได้ [ใน PDF นี้](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **การแปลงไฟล์ DWG เป็น PDF**

ขั้นตอนง่ายๆ ต่อไปนี้เป็นสิ่งจำเป็นในการแปลง [DWG](https://docs.fileformat.com/cad/dwg/) เป็น [PDF](https://docs.fileformat.com/pdf/).

1. โหลดไฟล์ DWG เข้าไปในอินสแตนซ์ของ **Image**.
1. สร้างวัตถุของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติ **page_height** และ **page_width**.
1. สร้างวัตถุของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions**.
1. เรียกใช้ **Image.save** โดยส่งวัตถุของ **PdfOptions** เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออกภาพวาด DWG เป็น PDF

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **พรีมิติฟส์ของ AutoCAD ที่รองรับ**

พรีมิติฟส์ของ AutoCAD ต่อไปนี้ได้รับการสนับสนุน

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **การส่งออกเลย์เอาต์ DWG เฉพาะเป็น PDF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธี **Aspose.CAD.Image.load** 
1. สร้างอินสแตนซ์ของคลาส **CadRasterizationOptions** และตั้งค่าความสูงและความกว้างของหน้าที่ได้ผล
1. ตั้งค่าคุณสมบัติ **Layouts** สำหรับวัตถุ **CadRasterizationOptions** 
1. สร้างอินสแตนซ์ของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions**
1. ส่งออกภาพเป็น PDF โดยใช้วิธี **Image.save()** 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลย์เอาต์เฉพาะของ DWG เป็น PDF

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **การส่งออก DWG เป็น PDF/A และ PDF/E**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธี **Image.load** 
1. สร้างอินสแตนซ์ของคลาส **CadRasterizationOptions**
1. สร้างอินสแตนซ์ของคลาส **PdfOptions** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions**
1. ตั้งค่าคุณสมบัติการปฏิบัติตาม PDF และบันทึก
1. ส่งออกภาพเป็น PDF โดยใช้วิธี **Image.save()**

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็น PDF/A และ PDF/E

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **การแปลงภาพวาด DWG เป็น DXF**

Aspose.CAD มีคุณสมบัติในการโหลดไฟล์ AutoCAD DWG และส่งออกเป็นรูปแบบ DXF วิธีการแปลง DWG เป็น DXF ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด DWG โดยใช้วิธี **Image.load** 
1. ส่งออกภาพวาด DWG เป็น DXF โดยใช้วิธี **Image.save()** 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็นรูปแบบ DXF

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **การแปลงภาพวาด DWG เป็น SVG**

Aspose.CAD สำหรับ Python API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น SVG หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้บรรลุการแปลง DWG เป็น SVG ผ่านขั้นตอนง่ายๆ ตามที่กำหนดไว้ข้างล่าง

1. โหลดไฟล์ DWG เข้าไปในอินสแตนซ์ของ **Image**.
1. สร้างวัตถุของคลาส **SvgOptions** และตั้งค่าคุณสมบัติที่ต้องการ
1. ส่งออกภาพวาด DWG เป็น SVG โดยใช้วิธี **Image.save()** 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็นรูปแบบ SVG

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
