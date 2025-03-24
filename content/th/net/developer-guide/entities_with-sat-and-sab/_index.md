---
title: เอนติธีส์ที่มีโครงสร้าง SAT/SAB
type: docs
weight: 40
url: /th/net/developer-guide/entities_with-sat-and-sab/
---

## **เอนติธีส์ที่มีโครงสร้าง SAT/SAB**

เอนติธีส์บางประเภทจัดเก็บข้อมูลโครงสร้างในรูปแบบ ACIS SAT/SAB เอนติธีส์เหล่านี้สามารถส่งออกได้บางส่วนในโหมด 2D wireframe เอนติธีส์ที่รองรับได้แก่:

*	วัตถุ 3DSOLID: กล่อง, 球体, ปิรามิด, ทร่อ, สูบ, กระบอก, ทอเรส, โพลีโซลิด
*	พื้นผิว: แผ่นเรียบ, ขยาย, หมุน, กวาด
*	ภูมิภาค

ด้านล่างคือตัวอย่างผลการส่งออก (ไฟล์ DWG ทางด้านซ้าย, ผล PDF ทางด้านขวา)

![Export of cone and spheres](/cad/_assets/guide/coneAndSpheres.png)

การส่งออกเอนติธีส์ ACIS ไม่ต้องการตัวเลือกพิเศษใดๆ เพื่อเพิ่มประสิทธิภาพขนาดการวาดภาพ โดยเฉพาะเมื่อการวาดภาพประกอบด้วยเอนติธีส์ ACIS อย่างเดียว ให้นึกถึงการใช้ฟังก์ชัน cadImage.UpdateSize() เพื่อปรับขนาดการวาดภาพเริ่มต้นให้ถูกต้อง

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
