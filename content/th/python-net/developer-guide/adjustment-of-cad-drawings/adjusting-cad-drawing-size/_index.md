---
title: ปรับขนาดการวาด CAD
type: docs
weight: 10
url: /th/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

โดยการใช้ห้องสมุด Aspose.CAD สำหรับ Python นักพัฒนาสามารถปรับขนาดการวาด CAD ในระหว่างการแปลงไปยังรูปแบบที่รองรับได้ทุกประเภท หัวข้อนี้อธิบายวิธีการปรับขนาดโดยอัตโนมัติหรือด้วยตนเองโดยใช้ **UnitType** enum ของคลาส **ImageOptions** 

{{% /alert %}}

## **การปรับขนาดการวาด CAD**

Aspose.CAD สำหรับ Python มีการจำแนกประเภท **UnitType** เพื่อปรับขนาดการวาดในระหว่างการแปลงรูปแบบ CAD มีสองวิธีในการปรับขนาดการวาด

1. การปรับขนาดอัตโนมัติ 
1. ปรับขนาดโดยใช้การจำแนกประเภท **UnitType** ของคลาส **ImageOptions**

ในการปรับขนาดโดยอัตโนมัติ นักพัฒนาจะไม่จำเป็นต้องระบุคุณสมบัติ Width และ Height ของคลาส **CadRasterizationOptions** โค้ดที่ให้ด้านล่างเป็นตัวอย่างของการปรับขนาดอัตโนมัติ

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

การจำแนกประเภท **UnitType** ช่วยให้สามารถปรับการปรับขนาดเมื่อไม่มีการตั้งค่าคุณสมบัติ Width และ Height โค้ดที่ให้ด้านล่างแสดงวิธีการใช้ **UnitType** 

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
