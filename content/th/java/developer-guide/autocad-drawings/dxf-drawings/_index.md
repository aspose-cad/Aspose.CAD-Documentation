---
title: แบบเขียน DXF
type: docs
weight: 60
url: /th/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **การส่งออกแบบเขียน DXF ไปยัง PDF**

Aspose.CAD มีฟีเจอร์ในการโหลดหน่วยวัดแบบเขียน DXF ของ AutoCAD และเรนเดอร์เป็นแบบเขียนทั้งหมดในรูปแบบ PDF วิธีการแปลง DXF เป็น PDF ทำงานดังนี้:

1. โหลดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างวัตถุของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าพร็อพเพอร์ตี้ [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)
1. สร้างวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าพร็อพเพอร์ตี้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. เรียกใช้ Image.Save โดยส่งวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) เป็นพารามิเตอร์ตัวที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าเริ่มต้น

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **รูปแบบที่รองรับ**

ในขณะนี้เรารองรับรูปแบบไฟล์ AutoCAD DXF 2010 อย่างเต็มที่ รูปแบบ DXF ที่ก่อนหน้านี้ไม่รับประกันว่าจะถูกต้อง 100% เรากำลังวางแผนที่จะรวมรูปแบบและฟีเจอร์เพิ่มเติมในเวอร์ชัน Aspose.CAD ในอนาคต

### **หน่วยที่รองรับ**

ในขณะนี้เรารองรับหน่วย 2D ที่มีการใช้กันอย่างแพร่หลายทั้งหมดพร้อมกับพารามิเตอร์เริ่มต้นพื้นฐาน ได้แก่:

1. มิติที่จัดเรียง
1. มิติองศา
1. อาร์ค
1. แอตทริบิวต์
1. การอ้างอิงบล็อก
1. วงกลม
1. มิติเส้นผ่านศูนย์กลาง
1. เอลลิปส์
1. แฮทช์
1. เส้น
1. ข้อความหลายบรรทัด
1. มิติออร์ดิเนต
1. จุด
1. โพลี่ไลน์
1. มิติเรเดียล
1. รังสี
1. มิติที่หมุน
1. ตาราง
1. ข้อความ
1. Xline

{{% alert color="primary" %}}

หากในระหว่างการวิเคราะห์พบหน่วยหรือพร็อพเพอร์ตี้ที่เราไม่รองรับ หน่วยหรือพร็อพเพอร์ตี้นั้นจะถูกละเว้นโดยไม่มีการแจ้งเตือน

{{% /alert %}}

### **การจัดการหน่วยความจำ**

พร็อพเพอร์ตี้ [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) สามารถใช้เพื่อควบคุมการจัดสรรหน่วยความจำใหม่ การจัดสรรใหม่จะเกิดขึ้นได้มากที่สุดสำหรับแคชที่ถูกจัดสรรไว้ล่วงหน้า อาจเกิดขึ้นเมื่อระบบตรวจสอบว่าพื้นที่ที่จัดสรรไว้นั้นไม่เพียงพอ

- หากตั้งค่าพร็อพเพอร์ตี้ [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) เป็นค่เริ่มต้น **False** พื้นที่จะถูกจัดสรรใหม่ไปที่สื่อเดิม
- เมื่อถูกตั้งค่าเป็น **True**, การจัดสรรใหม่ไม่สามารถเกินพื้นที่สูงสุดที่กำหนด ในกรณีนี้ แคชในหน่วยความจำที่จัดสรรไว้ (ซึ่งต้องการการจัดสรรใหม่) จะถูกปล่อยและจัดสรรพื้นที่เพิ่มเติมบนดิสก์

## **การส่งออกชั้นเฉพาะของแบบเขียน DXF ไปยัง PDF**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และระบุพร็อพเพอร์ตี้ [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)
1. เพิ่มชั้นไปยังวัตถุของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. สร้างอินสแตนซ์ของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ตั้งค่าพร็อพเพอร์ตี้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. ส่งออกแบบเขียนไปยัง PDF โดยใช้วิธี [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงชั้นเฉพาะของ DXF ไปยัง PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **การส่งออกชั้นเฉพาะของแบบเขียน DXF ไปยังรูปภาพ**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และระบุพร็อพเพอร์ตี้ [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)
1. เพิ่มชั้นไปยังวัตถุของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. สร้างอินสแตนซ์ของ [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & ตั้งค่าพร็อพเพอร์ตี้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. ส่งออกแบบเขียนไปยัง PDF โดยใช้วิธี [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงชั้นเฉพาะของ DXF ไปยังรูปภาพ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **เรนเดอร์ไฟล์ PDF เป็นส่วนหนึ่งของแบบเขียน DXF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และโหลดไฟล์ PDF
1. ตั้งค่าพร็อพเพอร์ตี้ [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)
1. เรียกใช้ [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) และบันทึกไฟล์

ตัวอย่างโค้ดด้านล่างแสดงวิธีการเรนเดอร์ไฟล์ PDF เป็นส่วนหนึ่งของแบบเขียน DXF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **การส่งออก DXF ไปที่ WMF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และโหลดไฟล์ PDF
1. ตั้งค่าพร็อพเพอร์ตี้ [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)
1. เรียกใช้ [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) และบันทึกไฟล์

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออก DXF ไปที่ WMF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **การสนับสนุนการบันทึกไฟล์ DXF**

Aspose.CAD มีฟีเจอร์ในการโหลดไฟล์ DXF ของ AutoCAD และทำการเปลี่ยนแปลงในนั้นและบันทึกมันอีกครั้งในรูปแบบไฟล์ DXF ตัวอย่างโค้ดด้านล่างแสดงวิธีการบรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **การส่งออก DGN ที่ฝังอยู่สำหรับรูปแบบ DXF**

Aspose.CAD มีฟีเจอร์ในการโหลดไฟล์ DXF ของ AutoCAD และส่งออก DGN ที่ฝังอยู่สำหรับรูปแบบ DXF 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการบรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **การส่งออกเลย์เอาต์ DXF เฉพาะไปยัง PDF**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และระบุพร็อพเพอร์ตี้ [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)
1. ระบุชื่อเลย์เอาต์ที่ต้องการโดยใช้พร็อพเพอร์ตี้ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-)
1. สร้างอินสแตนซ์ของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ตั้งค่าพร็อพเพอร์ตี้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)
1. ส่งออกแบบเขียนไปยัง PDF โดยใช้วิธี [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลย์เอาต์เฉพาะของ DXF เป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

พร็อพเพอร์ตี้ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) เป็นประเภท array ของ string ดังนั้นคุณสามารถระบุเลย์เอาต์มากกว่าหนึ่งเลย์เอาต์ได้ในเวลาเดียวกันสำหรับการแปลงเป็นรูปแบบ PDF สำหรับการระบุเลย์เอาต์หลายรายการสำหรับพร็อพเพอร์ตี้ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) PDF ที่ได้จะมีหลายหน้า โดยแต่ละหน้าจะแสดงเลย์เอาต์ AutoCAD ของแต่ละรายการ

{{% /alert %}}

## **เข้าถึงวัตถุ ATTRIB และ MTEXT**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. เข้าถึงหน่วยภายในไฟล์ CAD
1. ตรวจสอบ [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) และ [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) หน่วย
1. เพิ่มไปยังรายการชั่วคราวเพื่อการประมวลผลต่อไป

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **การแยกวัตถุ CAD Insert**

วิธีการนี้ทำงานดังนี้:

1. เปิดไฟล์ **DXF** โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. เข้าถึงหน่วยภายในไฟล์ CAD
1. ตรวจสอบหน่วย [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT)
1. ตรวจสอบรายการประเภท [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity)
1. ประมวลผลหน่วย

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **การสนับสนุนการตัดบล็อก**

Aspose.CAD มีฟีเจอร์ของการตัดบล็อก วิธีการตัดบล็อกทำงานดังนี้:

1. โหลดไฟล์แบบเขียน DXF โดยใช้ [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และโหลดไฟล์ PDF
1. ตั้งค่าพร็อพเพอร์ตี้ที่ต้องการของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. เรียกใช้ [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) พร้อมส่งวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) เป็นพารามิเตอร์ตัวที่สองและบันทึกไฟล์

ตัวอย่างโค้ดด้านล่างแสดงวิธีที่การตัดบล็อกทำงาน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **ส่งออกรูปภาพเป็น DXF**

โดยใช้ Aspose.CAD คุณสามารถส่งออกรูปภาพเป็นรูปแบบ DXF โดยใช้วิธีนี้คุณสามารถทำการดำเนินการดังต่อไปนี้:

1. ตั้งค่าฟอนต์ใหม่
1. ซ่อนหน่วย
1. อัปเดตข้อความ

ตัวอย่างโค้ดด้านล่างแสดงวิธีการดำเนินการตามรายการที่แสดงด้านบน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
