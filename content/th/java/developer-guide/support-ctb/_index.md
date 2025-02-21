---
title: การสนับสนุนไฟล์ CTB
type: docs
weight: 40
url: /th/java/developer-guide/support-ctb/
---

## **การสนับสนุนไฟล์ CTB**

บางครั้งสี, น้ำหนักเส้น และตัวเลือกอื่น ๆ สำหรับการวาดอาจถูกใช้ไม่เพียงแต่จากการวาดเอง แต่ยังมาจากสไตล์การพล็อตในไฟล์ CTB แยกต่างหากอีกด้วย
วิธีที่ง่ายที่สุดในการใช้ข้อมูลนี้คือการวางไฟล์ CTB ที่เกี่ยวข้องใกล้กับไฟล์ที่มีการวาดในรูปแบบ DWG/DXF และข้อมูลจากไฟล์เหล่านั้นจะถูกนำไปใช้
โดยอัตโนมัติในระหว่างการส่งออก

นอกจากนี้ยังสามารถโหลดไฟล์ CTB ทั้งหมดในรูปแบบของ Stream โดยใช้ 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) property ของ 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) วัตถุ

นี่คือตัวอย่างวิธีการทำเช่นนี้:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
