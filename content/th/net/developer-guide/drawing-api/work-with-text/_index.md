---
title: ทำงานกับข้อความ
type: docs
weight: 40
url: /th/net/developer-guide/drawing-api/work-with-text/
---

## **ทำงานกับข้อความ**

เกือบทุกการวาดภาพมีวัตถุข้อความและตัวอย่างเหล่านี้จะแสดงวิธีการดำเนินการกับพวกเขา
มีประเภทต่างๆ ของเอนทิตีสำหรับ DWG/DXF ที่สามารถจัดเก็บข้อความได้ ได้แก่ [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib สองประเภทสุดท้ายมักเกี่ยวข้อง 
กับ [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
และจัดเก็บภายในหรือในบล็อกที่สอดคล้องกัน

นี่คือตัวอย่างบางส่วนที่บรรยายถึงการดำเนินการกับข้อความ

### **ค้นหาข้อความ**

ตัวอย่างนี้แสดงวิธีการค้นหาค่าข้อความในไฟล์ DWG/DXF และอาจถูกใช้สำหรับการแทนที่ค่าข้อความด้วย

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **เพิ่มรายการ Text และ MText ใหม่**

นี่คือตัวอย่างวิธีการเพิ่มวัตถุ Text/Mtext ใหม่ไปยังการวาดภาพ การเพิ่มเอนทิตีใหม่อาจเปลี่ยนขนาดของการวาดภาพ ดังนั้นจึงแนะนำ
ให้เรียก UpdateSize() หลังจากการดำเนินการเหล่านี้

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
