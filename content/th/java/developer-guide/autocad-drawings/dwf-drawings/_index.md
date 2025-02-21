---
title: แบบแปลน DWF
type: docs
weight: 20
url: /th/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **การส่งออกแบบแปลน DWF เป็น PDF**

Aspose.CAD สำหรับ Java API สามารถโหลดแบบแปลน AutoCAD ในรูปแบบ DWF และแปลงเป็น PDF หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อให้สามารถแปลงจาก DWF เป็นรูปแบบ PDF ผ่านขั้นตอนง่ายๆ ตามที่ระบุไว้ด้านล่าง

### **แปลงไฟล์ DWF เป็น PDF**

ขั้นตอนง่ายๆ ต่อไปนี้จำเป็นต้องใช้ในการแปลง DWF เป็น PDF

1. โหลดไฟล์ DWF เข้าสู่ตัวอย่างของ [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. สร้างวัตถุของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. เรียก [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ในขณะที่ส่งวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออกแบบแปลน DWF เป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **การสนับสนุนชั้นใน DWF**

Aspose.CAD มีฟีเจอร์ในการโหลดเอนทิตีแบบแปลน DWF ของ AutoCAD และเรนเดอร์เป็นแบบแปลนทั้งหมดในรูปแบบ JPG

1. โหลดไฟล์แบบแปลน DWF โดยใช้เมธอดโรงงาน [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. เพิ่มชั้นที่ต้องการ
1. เรียก [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ในขณะที่ส่งวัตถุของ [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าพื้นฐาน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
