---
title: หน่วยงานที่มีโครงสร้าง SAT/SAB
type: docs
weight: 40
url: /th/java/developer-guide/entities_with-sat-and-sab/
---

## **หน่วยงานที่มีโครงสร้าง SAT/SAB**

หน่วยงานบางแห่งจัดเก็บข้อมูลโครงสร้างในรูปแบบ ACIS SAT/SAB โดยหน่วยงานเหล่านี้สามารถส่งออกได้บางส่วนในโหมดลวดลาย 2D หน่วยงานที่รองรับได้แก่:

*	วัตถุ 3DSOLID: กล่อง, ลูกโลก, ปิรามิด, ตัวหนีบ, กรวย, กระบอก, โทริส, โพลีโซลิด
*	พื้นผิว: แผ่นเรียบ, ถูกดึงออก, ถูกหมุน, ถูกกำหนดรูปแบบ
*	ภูมิภาค

ด้านล่างคือตัวอย่างผลลัพธ์การส่งออก (ไฟล์ DWG ทางด้านซ้าย, ผลลัพธ์ PDF ทางด้านขวา)

![Export of cone and spheres](/cad/_assets/guide/coneAndSpheres.png)

การส่งออกหน่วยงาน ACIS ไม่ต้องการตัวเลือกพิเศษใดๆ เพื่อเพิ่มประสิทธิภาพขนาดการวาดภาพ โดยเฉพาะเมื่อการวาดภาพมีหน่วยงาน ACIS โดยเฉพาะ ควรพิจารณาการใช้ฟังก์ชัน cadImage.updateSize() เพื่อปรับขนาดการวาดภาพในเบื้องต้นอย่างแม่นยำ

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
