---
title: การส่งออก DGN AutoCAD
type: docs
weight: 50
url: /th/python-net/developer-guide/exporting-dgn-autocad/
---

## **การส่งออกไฟล์ DGN AutoCAD เป็น PDF**

Aspose.CAD สำหรับ Python API ได้แนะนำฟังก์ชันการทำงานในการโหลดไฟล์ DGN AutoCAD และแปลงเป็นรูปแบบ PDF **คลาส CadImage** มีวัตถุประสงค์นี้

คุณจำเป็นต้องโหลดไฟล์ DGN ที่มีอยู่เป็น **CadImage** สร้างอินซ์แตนซ์ของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติต่างๆ สร้างอินซ์แตนซ์ของคลาส **PdfOptions** และส่งผ่านอินซ์แตนซ์ **CadRasterizationOptions** ตอนนี้เรียกใช้เมธอด **save** ของอินซ์แตนซ์คลาส **CadImage**

### โค้ดตัวอย่าง

ต่อไปนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก [DGN](https://docs.fileformat.com/cad/dgn/) เป็น [PDF](https://docs.fileformat.com/pdf/) 

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}

## **การส่งออกไฟล์ DGN AutoCAD เป็นรูปแบบ Raster Image**

Aspose.CAD สำหรับ Python API ได้แนะนำฟังก์ชันการทำงานในการโหลดไฟล์ DGN AutoCAD และแปลงเป็นรูปภาพแบบ Raster **คลาส CadImage** มีวัตถุประสงค์นี้

คุณจำเป็นต้องโหลดไฟล์ DGN ที่มีอยู่เป็น **CadImage** สร้างอินซ์แตนซ์ของคลาส **CadRasterizationOptions** และตั้งค่าคุณสมบัติต่างๆ สร้างอินซ์แตนซ์ของคลาส **JpegOptions** และส่งผ่านอินซ์แตนซ์ **CadRasterizationOptions** ตอนนี้เรียกใช้เมธอด **save** ของอินซ์แตนซ์คลาส **CadImage**

### โค้ดตัวอย่าง

ต่อไปนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก [DGN](https://docs.fileformat.com/cad/dgn/) เป็นรูปภาพ [JPEG](https://docs.fileformat.com/image/jpeg/) 

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **การสนับสนุนเอนทิตี 3D สำหรับ DGN v7**

Aspose.CAD สำหรับ Python API ได้แนะนำฟังก์ชันการทำงานในการโหลดไฟล์ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD และสนับสนุนเอนทิตี 3D สำหรับ DGN v7 **คลาส CadImage** มีวัตถุประสงค์นี้ ภาพ [DGN](https://docs.fileformat.com/cad/dgn/) แต่ละภาพสนับสนุน 9 มุมมองที่กำหนดไว้ล่วงหน้า มันถูกนับจาก 1 ถึง 9 หากมุมมองไม่ได้กำหนดในการส่งออก สำหรับรูปแบบเอาต์พุตหลายหน้า (เช่น PDF) จะมีการส่งออกมุมมองทั้งหมด โดยแต่ละมุมมองจะอยู่บนหน้าแยกต่างหาก เอนทิตี 3D รองรับในรูปแบบไฟล์ DGN รวมถึง 2D สำหรับสิ่งนี้ **VectorRasterizationOptions** จะถูกใช้, TypeOfEntities จะไม่ถูกใช้อีกต่อไปสำหรับรูปแบบ DGN (รองรับ 2D และ 3D พร้อมกัน)

### โค้ดตัวอย่าง

ต่อไปนี้คือโค้ดตัวอย่างเพื่อดูที่องค์ประกอบ DGN ที่รองรับ


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
