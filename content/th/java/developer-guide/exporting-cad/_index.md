---
title: การส่งออก CAD
type: docs
weight: 40
url: /th/java/developer-guide/exporting-cad/
---

## **ส่งออกภาพ 3D AutoCAD ไปยัง PDF**
Aspose.CAD ช่วยให้คุณสามารถส่งออกภาพ 3D AutoCAD ไปยัง PDF ได้ โปรดใช้ **TypeOfEntities.Entities3D** ใน **ImageOptions.CadRasterizationOptions** เพื่อระบุว่าคุณต้องการส่งออกเอนทิตี 3D
ตัวอย่างโค้ดด้านล่างโหลดไฟล์ AutoCAD 3D และส่งออกไปยัง PDF เมื่อไฟล์ถูกแปลงเป็น PDF คุณสามารถเปิดด้วย PDF viewer ที่คุณชื่นชอบ

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออกภาพ 3D AutoCAD ไปยัง PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}


## **การส่งออก CAD Layouts ไปยัง PDF**
Aspose.CAD สำหรับ Java ช่วยให้คุณส่งออก CAD layouts ไปยัง PDF ได้ **save** วิธีการของคลาส **CadImage** สามารถใช้ส่งออกเลย์เอาต์ไปยังรูปแบบ PDF 
ตัวอย่างโค้ดด้านล่างโหลดไฟล์ CAD และส่งออกเลย์เอาต์ "Model" ไปยัง PDF เมื่อไฟล์ถูกแปลงเป็น PDF คุณสามารถเปิดด้วย PDF viewer ที่คุณชื่นชอบ

นี่คือตัวอย่างโค้ด

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}
## **สนับสนุนการตั้งค่าปากกาในการส่งออก**
Aspose.CAD สำหรับ Java ช่วยให้คุณเพิ่มตัวเลือกปากกาในการส่งออกคุณสมบัติของ CAD โดยใช้ rasterizationOptions เราสามารถตั้งค่าตัวเลือกคุณสมบัติของปากกาได้

ด้านล่างคือตัวอย่างโค้ดเพื่อให้บรรลุตามความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **ย่อยวัตถุ Cad Insert**
Aspose.CAD สำหรับ Java ช่วยให้คุณสามารถย่อยวัตถุ cad และประมวลผลเอนทิตีแยกภายในการแทรก ด้านล่างคือ ตัวอย่างโค้ดเพื่อให้บรรลุตามความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}
## **สนับสนุนเอนทิตี ACAD Proxy**
Aspose.CAD สำหรับ Java ช่วยให้คุณสามารถอ่านและส่งออกเอนทิตี ACAD_PROXY_ENTITY ด้านล่างคือ ตัวอย่างโค้ดเพื่อให้บรรลุตามความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **รวมฟอร์แมต IGES**
Aspose.CAD สำหรับ Java ช่วยให้คุณอ่านและส่งออกฟอร์แมต IGES ด้านล่างคือ ตัวอย่างโค้ดเพื่อให้บรรลุตามความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}
## **สนับสนุนโมเดล Mesh**
Aspose.CAD สำหรับ Java ช่วยให้คุณสามารถดำเนินการและนับโมเดล mesh เช่นขอบ, จุดยอด และหน้าต่างที่ใช้การแทนรูปแบบพอดี ด้านล่างคือ ตัวอย่างโค้ดเพื่อให้บรรลุตามความต้องการที่ระบุ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}
## **ตั้งค่ามุมมองที่กำหนดเอง**
Aspose.CAD สำหรับ Java ช่วยให้คุณตั้งค่ามุมมองที่กำหนดเองสำหรับเลย์เอาต์โมเดล โดยใช้ **vectorRasterizationOptions** คุณสามารถตั้งค่ามุมมองที่กำหนดเอง ตัวอย่างโค้ดด้านล่างแสดงวิธีการตั้งค่ามุมมองที่กำหนดเอง

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
