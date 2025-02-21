---
title: การส่งออกภาพวาด DXF
type: docs
weight: 60
url: /th/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **การส่งออกภาพวาด DXF ไปยัง PDF**

Aspose.CAD มีฟีเจอร์ในการโหลดวัตถุของภาพวาด AutoCAD DXF และเรนเดอร์พวกเขาเป็นภาพวาดทั้งหมดในรูปแบบ PDF วิธีการแปลง DXF เป็น PDF ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าอสมการ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าอสมการ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ในขณะที่ส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าเริ่มต้น

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **รูปแบบที่รองรับ**

ในขณะนี้เราสนับสนุนรูปแบบไฟล์ AutoCAD DXF 2010 อย่างเต็มที่ รูปแบบ DXF ก่อนหน้านี้ไม่รับประกันว่าจะถูกต้อง 100% เราวางแผนที่จะรวมรูปแบบและฟีเจอร์เพิ่มเติมในเวอร์ชัน Aspose.CAD ในอนาคต

### **หน่วยงานที่รองรับ**

ในขณะนี้เราสนับสนุนหน่วยงาน 2D ที่แพร่หลายทั้งหมดและพารามิเตอร์เริ่มต้นพื้นฐานของพวกเขาดังต่อไปนี้:

1. มิติที่เรียงพิมพ์
1. มิติที่มุม
1. อาร์ค
1. แอตทริบิวต์
1. อ้างอิงบล็อก
1. วงกลม
1. มิติเส้นผ่านศูนย์กลาง
1. รูปไข่
1. การขีด
1. เส้น
1. ข้อความหลายบรรทัด
1. มิติที่กำหนด
1. จุด
1. โพลีไลน์
1. มิติรัศมี
1. รังสี
1. มิติที่หมุน
1. ตาราง
1. ข้อความ
1. Xline

{{% alert color="primary" %}}

หากในระหว่างการพาร์สเราพบหน่วยงานหรือสมบัติที่เราไม่สนับสนุนหน่วยงานหรือสมบัติจะถูกละเลยอย่างเงียบๆ

{{% /alert %}}

### **การจัดการหน่วยความจำ**

อสมการ [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) ของคลาส [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) สามารถใช้ควบคุมการจัดสรรหน่วยความจำใหม่ การจัดสรรใหม่จะเกิดขึ้นได้เมื่อแคชที่จัดสรรล่วงหน้าไม่เพียงพอ

- หากตั้งค่า [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) เป็นค่าเริ่มต้น **False** พื้นที่จะถูกจัดสรรใหม่ไปยังสื่อเดิม
- เมื่อถูกตั้งค่าเป็น **True** การจัดสรรใหม่ไม่สามารถเกินพื้นที่สูงสุดที่กำหนด ในกรณีนี้แคชในหน่วยความจำที่มีอยู่ (ซึ่งต้องมีการจัดสรรใหม่) จะถูกปล่อยและพื้นที่เพิ่มเติมจะถูกจัดสรรในดิสก์

## **การส่งออกเลเยอร์เฉพาะของภาพวาด DXF ไปยัง PDF**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และระบุอสมการ [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. เพิ่มเลเยอร์ไปยังอ็อบเจ็กต์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. สร้างอินสแตนซ์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ตั้งค่าอสมการ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index)
1. เรียกใช้วิธี [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) และส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลเยอร์เฉพาะของ DXF เป็น PDF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **เรนเดอร์ไฟล์ PDF เป็นส่วนหนึ่งของภาพวาด DXF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และโหลดไฟล์ PDF
1. ตั้งค่าอสมการ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) และบันทึกไฟล์

ตัวอย่างโค้ดด้านล่างแสดงวิธีการเรนเดอร์ไฟล์ PDF เป็นส่วนหนึ่งของภาพวาด DXF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **การส่งออก DGN ที่ถูกฝังอยู่สำหรับรูปแบบ DXF**

Aspose.CAD มีฟีเจอร์ในการโหลดไฟล์ AutoCAD DXF และส่งออก DGN ที่ถูกฝังอยู่สำหรับรูปแบบ DXF

ตัวอย่างโค้ดด้านล่างแสดงวิธีการบรรลุความต้องการที่กำหนด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **การสนับสนุนการบันทึกไฟล์ DXF**

Aspose.CAD มีฟีเจอร์ในการโหลดไฟล์ AutoCAD DXF และทำการเปลี่ยนแปลงในไฟล์นั้นและบันทึกลงในไฟล์ DXF อีกครั้ง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการบรรลุความต้องการที่กำหนด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **การส่งออก DXF ไปยัง WMF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และโหลดไฟล์ PDF
1. ตั้งค่าอสมการ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) และบันทึกไฟล์

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **การส่งออกเลย์เอาต์เฉพาะ DXF ไปยัง PDF**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และระบุอสมการ [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. ระบุชื่อเลย์เอาต์ที่ต้องการโดยใช้อสมการ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)
1. สร้างอินสแตนซ์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ตั้งค่าอสมการ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index)
1. ส่งออกภาพวาดไปยัง PDF โดยเรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) และส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลย์เอาต์เฉพาะของ DXF เป็น PDF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

อสมการ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) เป็นประเภทอาร์เรย์ของสตริงดังนั้นคุณสามารถระบุเลย์เอาต์มากกว่าหนึ่งเลย์เอาต์ได้ในครั้งเดียว สำหรับการแปลงเป็นรูปแบบ PDF ที่เป็นไปได้ ในขณะที่ระบุเลย์เอาต์หลายเลย์เอาต์สำหรับ อสมการ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)  PDF ที่เกิดขึ้นจะมีหลายหน้า ซึ่งแต่ละหน้าจะแสดงเลย์เอาต์ AutoCAD เดี่ยว

{{% /alert %}}

## **การสนับสนุนการตัดบล็อก**

Aspose.CAD มีฟีเจอร์การตัดบล็อก วิธีการตัดบล็อกทำงานดังนี้:

1. โหลดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และโหลดไฟล์ PDF
1. ตั้งค่าสมบัติที่ต้องการของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ในขณะที่ส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สองและบันทึกไฟล์

ตัวอย่างโค้ดด้านล่างแสดงวิธีการตัดบล็อกทำงาน

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **การส่งภาพไปยัง DXF**

ด้วยการใช้ Aspose.CAD คุณสามารถส่งภาพไปยังรูปแบบ DXF โดยใช้วิธีการนี้คุณสามารถทำการกระทำต่อไปนี้:

1. ตั้งฟอนต์ใหม่
1. ซ่อนหน่วยงาน
1. ปรับปรุงข้อความ

ตัวอย่างโค้ดด้านล่างแสดงวิธีการดำเนินการตามรายการด้านบน

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **การส่งออกเลเยอร์เฉพาะของภาพวาด DXF ไปยังภาพ**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์ภาพวาด DXF โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index)
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และระบุอสมการ [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) และ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. เพิ่มเลเยอร์ไปยังอ็อบเจ็กต์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. สร้างอินสแตนซ์ของ [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) และตั้งค่าอสมการ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) 
1. ส่งออกภาพวาดไปยัง PDF โดยใช้วิธี [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลเยอร์เฉพาะของ DXF เป็นภาพ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
