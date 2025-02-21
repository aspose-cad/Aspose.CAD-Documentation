---
title: การวาด DWG
type: docs
weight: 40
url: /th/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **การส่งออกภาพวาด DWG เป็น PDF**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น PDF หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้การแปลง DWG เป็นรูปแบบ PDF ผ่านขั้นตอนที่ง่ายตามที่กำหนดไว้ข้างหน้า

{{% alert color="primary" %}}

API รองรับการปรับปรุง DWG ของ AutoCAD ดังต่อไปนี้:

- DWG 2004 เวอร์ชัน 16.0 รุ่น 18
- DWG 2005 เวอร์ชัน 16.1
- DWG 2010 เวอร์ชัน 18.0
- DWG 2013 เวอร์ชัน 19.0

{{% /alert %}}

### **รูปแบบไฟล์ DWG**

DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และเมตาดาต้า ข้อมูลภาพเวกเตอร์ให้คำแนะนำแก่แอปพลิเคชัน CAD เกี่ยวกับวิธีการแสดงผล DWG; เมตาดาต้าอาจมีข้อมูลหลากหลายเกี่ยวกับไฟล์รวมถึงข้อมูลที่เฉพาะเจาะจงตามตำแหน่งและข้อมูลของลูกค้า สเปคทางเปิดสำหรับรูปแบบไฟล์ DWG สามารถพบได้ [ใน PDF นี้](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **แปลงไฟล์ DWG เป็น PDF**

ขั้นตอนง่าย ๆ ต่อไปนี้ต้องการเพื่อแปลง DWG เป็น PDF

1. โหลดไฟล์ DWG เข้าสู่วิธี [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. เรียกใช้ [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) และส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออกภาพวาด DWG เป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **สร้าง PDF เดียวที่มีขนาดเลย์เอาต์ต่างกัน**

Aspose.CAD สำหรับ Java อนุญาตให้คุณแปลงไฟล์ DWG เป็น PDF เดียวที่มีขนาดเลย์เอาต์ต่างกัน วิธีนี้ทำงานดังต่อไปนี้:

1. โหลดไฟล์ DWG โดยใช้วิธี [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าสูงและกว้างของหน้า
1. เพิ่ม [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) ตามที่ต้องการสำหรับอ็อบเจ็กต์ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. ส่งออกรูปภาพไปยัง PDF โดยใช้วิธี [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการสร้าง PDF เดียวที่มีเลย์เอาต์ต่างๆ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **การส่งออก DWG เป็น PDF/A และ PDF/E**

ขั้นตอนง่าย ๆ ต่อไปนี้ต้องการเพื่อแปลง DWG เป็น PDF

1. โหลดไฟล์ DWG เข้าสู่วิธี [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่า [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 
1. เรียกใช้ [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) และส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออกภาพวาด DWG เป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **รูปแบบหลักของ AutoCAD ที่รองรับ**

รูปแบบหลักของ AutoCAD ที่รองรับ ได้แก่

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

## **การส่งออกเลย์เอาต์ DWG เฉพาะไปยัง PDF**

วิธีนี้ทำงานดังต่อไปนี้:

1. โหลดไฟล์ DWG โดยใช้วิธี [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าสูงและกว้างของหน้า
1. ตั้งค่าคุณสมบัติ [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) สำหรับอ็อบเจ็กต์ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. ส่งออกรูปภาพไปยัง PDF โดยใช้วิธี [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลย์เอาต์เฉพาะของ DWG เป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **การส่งออก DWG เป็น Raster หรือ PDF โดยใช้ขนาดคงที่**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น PDF หรือ Raster โดยใช้ขนาดคงที่

ตัวอย่างโค้ดด้านล่างแสดงวิธีการดำเนินการนี้

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **การสนับสนุนสำหรับเส้นซ่อนกลมเมื่อส่งออก DWG/DXF ไปยัง BMP และ PDF**

วิธีนี้ทำงานดังต่อไปนี้:

1. โหลดไฟล์ DWG โดยใช้วิธี [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)  
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)  
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าสูงและกว้างของหน้า
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 
1. ส่งออกรูปภาพไปยัง PDF โดยใช้วิธี [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการดำเนินการนี้

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **การสนับสนุนสำหรับการตั้งค่าพื้นที่พิมพ์สำหรับรูปภาพ DWG ใน PDF ที่ส่งออก**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น PDF หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้การสนับสนุนในการตั้งค่าพื้นที่พิมพ์สำหรับรูปภาพ DWG ใน PDF ที่ส่งออก

ตัวอย่างโค้ดด้านล่างแสดงวิธีการดำเนินการนี้

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **การสนับสนุนสำหรับการอ่าน metadata XREF สำหรับไฟล์ DWG**

1. โหลดไฟล์ DWG โดยใช้วิธี [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)  
1. เดินทางผ่านทุกเอนทิตีภาพ
1. หากเอนทิตีนั้นคือ [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) ก็จะเป็นเอนทิตี XREF ที่มี metadata

ตัวอย่างโค้ดด้านล่างแสดงวิธีการบรรลุคุณสมบัตินี้

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **เอกสาร DWG โดยการระบุพิกัด**

Aspose.CAD สำหรับ Java API ในปัจจุบันมีฟีเจอร์ในการเรนเดอร์เอกสาร DWG โดยการให้พิกัดของความกว้างและความสูงของเอกสาร

ตัวอย่างโค้ดด้านล่างแสดงวิธีการเรนเดอร์เอกสาร DWG

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

คุณสมบัติ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) เป็นชนิดอาร์เรย์ของสตริงดังนั้นคุณจึงสามารถระบุเลย์เอาต์มากกว่าหนึ่งตัวในคราวเดียวสำหรับการแปลงเป็นรูปแบบ PDF ขณะระบุเลย์เอาต์หลายรายการสำหรับคุณสมบัติ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) PDF ที่ได้จะมีหลายหน้า โดยแต่ละหน้าจะแสดงถึงเลย์เอาต์ AutoCAD แต่ละรายการ

### **รายการเลย์เอาต์ทั้งหมด**

คุณสามารถแสดงรายการเลย์เอาต์ทั้งหมดที่มีอยู่ในภาพวาด AutoCAD โดยใช้โค้ดสั้น ๆ ต่อไปนี้

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **รับค่าพารามิเตอร์ของบล็อกอ้างอิงภายนอก**

Aspose.CAD สำหรับ Java API อนุญาตให้คุณรับการอ้างอิงภายนอกของบล็อกพารามิเตอร์ Aspose.CAD API เปิดเผย [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) เพื่อให้ได้รับการอ้างอิงภายนอกของบล็อกพารามิเตอร์ในคอลเล็กชันของ [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary)

โค้ดต่อไปนี้แสดงวิธีการได้รับการอ้างอิงภายนอกของบล็อกพารามิเตอร์

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **ค้นหาข้อความในไฟล์ DWG AutoCAD**

Aspose.CAD สำหรับ Java API อนุญาตให้คุณค้นหาข้อความในไฟล์ DWG AutoCAD Aspose.CAD API เปิดเผยคลาส [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) ที่เป็นตัวแทนของเอนทิตีข้อความในไฟล์ DWG AutoCAD คลาส [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) ก็รวมเข้ากับ Aspose.CAD API เนื่องจากเอนทิตีอื่น ๆ อาจมีข้อความด้วย

โค้ดต่อไปนี้แสดงวิธีการค้นหาข้อความในไฟล์ DWG AutoCAD

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **ค้นหาข้อความในเลย์เอาต์เฉพาะ**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **การเข้าถึงธงอันเดอร์เลย์สำหรับรูปแบบ DWG**

Aspose.CAD สำหรับ Java ได้ดำเนินการธงอันเดอร์เลย์สำหรับรูปแบบ DWG และอนุญาตให้นักพัฒนาสามารถเข้าถึงได้ ด้านล่างนี้คือการสาธิตโค้ดอย่างง่าย

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **การสนับสนุนสำหรับเอนทิตี DWG**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และสนับสนุนเอนทิตีต่าง ๆ ในการทำงาน

### **การสนับสนุนสำหรับเอนทิตี MLeader**

DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และเมตาดาต้า มีเอนทิตีที่แตกต่างกันในไฟล์ DWG ส่วนด้านล่างนี้อธิบายถึงตัวอย่างการทำงานกับเอนทิตี MLeader ภายในไฟล์ DWG

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **การสนับสนุนการส่งออกเอนทิตี DWG เป็นภาพ**

DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และเมตาดาต้า มีเอนทิตีที่แตกต่างกันในไฟล์ DWG ส่วนด้านล่างนี้อธิบายถึงตัวอย่างการส่งออกเอนทิตี DWG เฉพาะไปยังภาพ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **การสนับสนุนการนำเข้าภาพไปยังไฟล์ DWG**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และสนับสนุนเอนทิตีที่แตกต่างกันในการทำงาน DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และเมตาดาต้า มีเอนทิตีที่แตกต่างกันในไฟล์ DWG ส่วนด้านล่างนี้อธิบายว่าจะนำเข้าสามารถทำได้อย่างไรภายในไฟล์ DWG

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **การสนับสนุนในการเพิ่มข้อความใน DWG**

Aspose.CAD สำหรับ Java API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และสนับสนุนเอนทิตีที่แตกต่างกันในการทำงาน DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และเมตาดาต้า มีเอนทิตีที่แตกต่างกันในไฟล์ DWG ส่วนด้านล่างนี้อธิบายวิธีการเพิ่มข้อความภายในไฟล์ DWG

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **การสนับสนุนสำหรับ Mesh ใน DWG**

Aspose.CAD สำหรับ Java API ในตอนนี้สามารถเข้าถึงเอนทิตีที่สนับสนุน Mesh ซึ่งรวมถึงประเภท [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) และ [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) ตัวอย่างต่อไปนี้อธิบายวิธีการเข้าถึงประเภท Mesh

## **แปลงภาพวาด DWG เป็น DXF**

Aspose.CAD มีฟีเจอร์ในการโหลดไฟล์ DWG ของ AutoCAD และส่งออกไปยังรูปแบบ DXF วิธีการแปลง DWG เป็น DXF ทำงานดังต่อไปนี้:

1. โหลดไฟล์ภาพวาด DWG โดยใช้วิธี [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)  
1. ส่งออกภาพวาด DWG เป็น DXF โดยใช้วิธี [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG ไปยังรูปแบบ DXF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **แปลงภาพวาด DWG เป็น SVG**

Aspose.CAD API สามารถโหลดภาพวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น SVG หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้การแปลง DWG เป็นรูปแบบ SVG ผ่านขั้นตอนที่ง่ายตามที่กำหนดไว้ด้านล่าง

1. โหลดไฟล์ DWG เข้าสู่วิธี [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 
1. สร้างอ็อบเจ็กต์ของคลาส [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) และตั้งค่าคุณสมบัติที่ต้องการ
1. ส่งออกภาพวาด DWG เป็น SVG โดยใช้วิธี [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็นรูปแบบ SVG

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
