---
title: การสนับสนุนไฟล์ CTB
type: docs
weight: 40
url: /th/net/developer-guide/support-ctb/
---

## **การสนับสนุนไฟล์ CTB**

บางครั้งสี, น้ำหนักเส้น และตัวเลือกอื่น ๆ สำหรับการวาดภาพอาจจะใช้ไม่เพียง แต่จากการวาดภาพเองเท่านั้น แต่ยังมาจากรูปแบบการพิมพ์ในไฟล์ CTB แยกต่างหาก 
วิธีที่ง่ายที่สุดในการใช้ข้อมูลนี้คือการวางไฟล์ CTB ที่เกี่ยวข้องใกล้กับไฟล์ที่มีการวาดภาพในรูปแบบ DWG/DXF และข้อมูลจากไฟล์เหล่านั้นจะถูกนำไปใช้ 
โดยอัตโนมัติในระหว่างการส่งออก

นอกจากนี้ยังสามารถโหลดไฟล์ CTB ทั้งหมดในรูปแบบ Stream โดยใช้ 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) ของ 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) วัตถุ

นี่คือตัวอย่างวิธีการทำเช่นนี้:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
