---
title: การส่งออกภาพ DWF
type: docs
weight: 20
url: /th/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **การส่งออกภาพ DWF เป็น PDF**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีการวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และแสดงผลเป็นภาพวาดทั้งหมดในรูปแบบ [PDF](https://docs.fileformat.com/pdf/). วิธีการแปลงจาก [DWF](https://docs.fileformat.com/cad/dwf/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์การวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีฟาร์ม [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าทรัพย์สิน [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าทรัพย์สิน [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งผ่านอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าพื้นฐาน.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **การดึงเลเยอร์จากภาพวาด DWF**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีการวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และแสดงผลเป็นภาพวาดทั้งหมดในรูปแบบ [JPEG](https://docs.fileformat.com/image/jpeg/).

1. โหลดไฟล์การวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีฟาร์ม [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. ดึงชื่อเลเยอร์โดยใช้อ็อบเจ็กต์ [JPEG](https://docs.fileformat.com/image/jpeg/).
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งผ่านอ็อบเจ็กต์ของ [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าพื้นฐาน.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **การสนับสนุนเลเยอร์ใน DWF**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีการวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และแสดงผลเป็นภาพวาดทั้งหมดในรูปแบบ [JPEG](https://docs.fileformat.com/image/jpeg/).

1. โหลดไฟล์การวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีฟาร์ม [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. เพิ่มเลเยอร์ที่ต้องการ.
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งผ่านอ็อบเจ็กต์ของ [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าพื้นฐาน.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **การส่งออกภาพ DWF เป็น BMP**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีการวาด AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) และแสดงผลเป็นภาพวาดทั้งหมดในรูปแบบ [BMP](https://docs.fileformat.com/image/bmp/) ฟีเจอร์การแปลงจาก [DWF](https://docs.fileformat.com/cad/dwf/) เป็น [BMP](https://docs.fileformat.com/image/bmp/) ทำงานดังนี้:

1. โหลดไฟล์การวาด [DWF](https://docs.fileformat.com/cad/dwf/) โดยใช้วิธีฟาร์ม [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าทรัพย์สิน [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างอ็อบเจ็กต์ของคลาส [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) และตั้งค่าทรัพย์สิน [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งผ่านอ็อบเจ็กต์ของ [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) เป็นพารามิเตอร์ที่สอง.

### ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ [DWF](https://docs.fileformat.com/cad/dwf/) ไปยัง [BMP](https://docs.fileformat.com/image/bmp/) โดยใช้การตั้งค่าพื้นฐาน.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
