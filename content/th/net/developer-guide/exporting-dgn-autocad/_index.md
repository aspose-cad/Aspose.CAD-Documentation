---
title: การส่งออกฟอร์แมต DGN AutoCAD
type: docs
weight: 50
url: /th/net/developer-guide/exporting-dgn-autocad/
---

## **การส่งออกฟอร์แมต DGN AutoCAD เป็น PDF**

Aspose.CAD สำหรับ .NET API ได้มีการแนะนำฟังก์ชันการทำงานเพื่อโหลดไฟล์ DGN AutoCAD และแปลงเป็นฟอร์แมต PDF คลาส [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) ทำหน้าที่นี้

คุณต้องโหลดไฟล์ DGN ที่มีอยู่เป็น [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) สร้างตัวอย่างของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติต่างๆ สร้างตัวอย่างของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และส่งตัวอย่าง [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ไปยังมัน ตอนนี้ให้เรียกใช้เมธอด [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ของตัวอย่างคลาส [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)

### โค้ดตัวอย่าง

ต่อไปนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก [DGN](https://docs.fileformat.com/cad/dgn/) เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **การส่งออกฟอร์แมต DGN AutoCAD เป็นฟอร์แมตภาพ Bitmap**

Aspose.CAD สำหรับ .NET API ได้มีการแนะนำฟังก์ชันการทำงานเพื่อโหลดไฟล์ DGN AutoCAD และแปลงเป็นภาพ Bitmap คลาส [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) ทำหน้าที่นี้

คุณต้องโหลดไฟล์ DGN ที่มีอยู่เป็น [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) สร้างตัวอย่างของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติต่างๆ สร้างตัวอย่างของคลาส [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) และส่งตัวอย่าง [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ไปยังมัน ตอนนี้ให้เรียกใช้เมธอด [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ของตัวอย่างคลาส [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)

### โค้ดตัวอย่าง

ต่อไปนี้คือการสาธิตโค้ดเพื่อแปลง/ส่งออก [DGN](https://docs.fileformat.com/cad/dgn/) เป็นภาพ [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **การสนับสนุนเอนทิตี 3D สำหรับ DGN v7**

Aspose.CAD สำหรับ .NET API ได้มีการแนะนำฟังก์ชันการทำงานเพื่อโหลดไฟล์ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD และสนับสนุนเอนทิตี 3D สำหรับ DGN v7 คลาส [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) ทำหน้าที่นี้ ภาพ [DGN](https://docs.fileformat.com/cad/dgn/) แต่ละภาพสนับสนุนมุมมองที่กำหนดไว้ล่วงหน้า 9 มุมมอง เรียงลำดับจาก 1 ถึง 9 หากไม่มีการกำหนดมุมมองในการส่งออก สำหรับฟอร์แมตที่มีหลายหน้า (เช่น PDF) มุมมองทั้งหมดจะถูกส่งออก โดยแต่ละหน้าอยู่ในหน้าแยกต่างหาก เอนทิตี 3D ที่สนับสนุนในฟอร์แมตไฟล์ DGN เช่นเดียวกับ 2D สำหรับสิ่งนี้ใช้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) TypeOfEntities จะไม่ได้รับการใช้อีกต่อไปสำหรับฟอร์แมต DGN (ทั้ง 2D และ 3D สนับสนุนพร้อมกัน)

### โค้ดตัวอย่าง

ต่อไปนี้คือโค้ดตัวอย่างเพื่อดูเอนทิตี DGN ที่สนับสนุน

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
