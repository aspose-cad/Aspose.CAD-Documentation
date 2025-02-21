---
title: ส่งออกด้วยตัวเลือก 3D
type: docs
weight: 40
url: /th/net/developer-guide/export-with-3d-options/
---

## **ส่งออกด้วยตัวเลือก 3D**

มีตัวเลือกบางอย่างที่ถูกนำเสนอเพื่อส่งออกโมเดล 3D ไปยัง PDF/raster จากรูปแบบ FBX, OBJ, STL ที่เกี่ยวข้อง

นี่คือตัวอย่างของฉาก 3D จากมุมมองที่แตกต่างกัน:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

คุณสมบัติ ObserverPoint ช่วยให้สามารถหมุนฉาก 3D ตามมุมที่กำหนดรอบแกน ตัวอย่างนี้แสดงโค้ดและผลลัพธ์การส่งออกโดยใช้มุมการหมุนแบบสุ่มบางอย่าง

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

การเปลี่ยน ObserverAngle เป็น ObserverPoint = new ObserverPoint(5, 60, 0) จะช่วยให้หมุนฉากได้

![Export with changed rotation](/_assets/guide/3d/fig4.png)

คุณสมบัติ RenderMode3D อื่นช่วยให้สามารถระบุว่าผลลัพธ์การส่งออกควรจะแสดงผลอย่างไร มี 3 โหมด: Solid (ค่าเริ่มต้น), Wireframe, และ SolidWithEdges

ตัวอย่างด้านล่างช่วยให้สร้างโมเดล wireframe สำหรับวัตถุทรงกลม

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

ตัวอย่างด้านล่างแสดงความแตกต่างระหว่างโหมด Solid และ SolidWithEdges

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
