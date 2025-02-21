---
title: การส่งออก DGN AutoCAD
type: docs
weight: 50
url: /th/java/developer-guide/exporting-dgn-autocad/
---

## **การส่งออก DGN AutoCAD รูปแบบไปยัง PDF**

Aspose.CAD สำหรับ Java API ได้แนะนำฟังก์ชันการทำงานในการโหลดไฟล์ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD และแปลงเป็นรูปแบบ [PDF](https://docs.fileformat.com/pdf/) คลาส [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) มีวัตถุประสงค์นี้

คุณต้องโหลดไฟล์ DGN ที่มีอยู่ในรูปแบบ [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) สร้างอินสแตนซ์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าคุณสมบัติต่างๆ สร้างอินสแตนซ์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) และส่งอินสแตนซ์ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ตอนนี้เรียกใช้วิธี [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ของอินสแตนซ์คลาส [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)

### ตัวอย่างโค้ด

ด้านล่างนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก DGN ไปยังรูปแบบ PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **การส่งออก DGN AutoCAD รูปแบบไปยังรูปแบบภาพเรสเตอร์**

Aspose.CAD สำหรับ Java API ได้แนะนำฟังก์ชันการทำงานในการโหลดไฟล์ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD และแปลงเป็นภาพเรสเตอร์ คลาส [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) มีวัตถุประสงค์นี้

คุณต้องโหลดไฟล์ DGN ที่มีอยู่ในรูปแบบ [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) สร้างอินสแตนซ์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าคุณสมบัติต่างๆ สร้างอินสแตนซ์ของคลาส [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) และส่งอินสแตนซ์ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ตอนนี้เรียกใช้วิธี [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ของอินสแตนซ์คลาส [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)

### ตัวอย่างโค้ด

ด้านล่างนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก [DGN](https://docs.fileformat.com/cad/dgn/) เป็นภาพ [JPEG](https://docs.fileformat.com/image/jpeg/) 

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
