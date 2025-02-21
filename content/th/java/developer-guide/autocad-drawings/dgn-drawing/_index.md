---
title: การวาด DGN
type: docs
weight: 10
url: /th/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **การวาดรูปแบบ DGN เป็นส่วนหนึ่งของ DWG**

Aspose.CAD สำหรับ Java ช่วยให้ผู้พัฒนาสามารถส่งออกไฟล์ DWG พร้อมการฝัง DGN ใต้เลเยอร์ภายใน ภายใต้คือโค้ดที่แสดงวิธีการเข้าถึงใต้เลเยอร์ DGN ภายในไฟล์ DWG ขณะส่งออกไฟล์ DWG

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **การสนับสนุนเอนทิตี้ 3D สำหรับ DGN v7**

Aspose.CAD สำหรับ Java API ได้แนะนำความสามารถในการโหลดไฟล์ DGN AutoCAD และรองรับเอนทิตี้ 3D สำหรับ DGN v7 คลาส [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) มีวัตถุประสงค์ดังกล่าว รูปภาพ DGN แต่ละรูปสนับสนุน 9 มุมมองที่กำหนดล่วงหน้า มันจะถูกจัดลำดับจาก 1 ถึง 9 หากมุมมองไม่ได้ถูกกำหนดบนการส่งออก สำหรับฟอร์แมตเอาต์พุตหลายหน้าที่มีหน้า (เช่น PDF) มุมมองทั้งหมดจะถูกส่งออก โดยแต่ละมุมมองอยู่ในหน้าที่แยกต่างหาก เอนทิตี้ 3D ได้รับการสนับสนุนในรูปแบบไฟล์ DGN เช่นเดียวกับ 2D
VectorRasterizationOptions.TypeOfEntities ไม่ถูกใช้แล้วสำหรับรูปแบบ DGN (ทั้ง 2D และ 3D ได้รับการสนับสนุนพร้อมกัน)

โค้ดตัวอย่างเพื่อดูองค์ประกอบ DGN ที่ได้รับการสนับสนุน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
