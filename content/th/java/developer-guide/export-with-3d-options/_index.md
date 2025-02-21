---
title: ส่งออกด้วยตัวเลือก 3D
type: docs
weight: 40
url: /th/java/developer-guide/export-with-3d-options/
---

## **ส่งออกด้วยตัวเลือก 3D**

มีตัวเลือกเล็กน้อยที่ถูกนำเสนอเพื่อส่งออกโมเดล 3D ไปยัง PDF/raster จากรูปแบบ FBX, OBJ, STL ที่เกี่ยวข้อง

นี่คือตัวอย่างของฉาก 3D จากมุมมองที่แตกต่างกัน:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

คุณสมบัติ ObserverPoint ช่วยให้สามารถหมุนฉาก 3D ตามมุมที่กำหนดรอบแกน ตัวอย่างนี้แสดงให้เห็นโค้ดและผลลัพธ์การส่งออกโดยใช้มุมการหมุนที่เลือกแบบสุ่ม

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

การเปลี่ยน ObserverAngle เป็น ObserverPoint = new ObserverPoint(5, 60, 0) จะช่วยให้หมุนฉาก

![Export with changed rotation](/_assets/guide/3d/fig4.png)

คุณสมบัติ RenderMode3D อื่นๆ ช่วยให้สามารถระบุวิธีการนำเสนอผลลัพธ์การส่งออก ซึ่งมีอยู่ 3 โหมด: Solid (ค่าเริ่มต้น), Wireframe และ SolidWithEdges

ตัวอย่างด้านล่างช่วยให้สร้างโมเดลเส้นตาข่ายสำหรับวัตถุทรงกลม

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

ตัวอย่างด้านล่างแสดงความแตกต่างระหว่างโหมด Solid และ SolidWithEdges

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
