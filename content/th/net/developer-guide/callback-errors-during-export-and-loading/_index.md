---
title: ข้อผิดพลาดในการเรียกกลับระหว่างการส่งออกและการโหลด
type: docs
weight: 40
url: /th/net/developer-guide/callback-errors-during-export-and-loading/
---

## **การตรวจสอบข้อผิดพลาดในการเรียกกลับระหว่างการส่งออกและการโหลด**

เป็นไปได้ว่าระหว่างการส่งออกหรือโหลดภาพวาดเราอาจพบข้อผิดพลาดที่เกี่ยวข้องกับโครงสร้างของไฟล์ 
(เช่น หมวดหมู่ในไฟล์เป็นสิ่งที่จำเป็นในปัจจุบันแต่ไม่จำเป็นในอดีต) 
บางส่วนของพวกเขาเป็นสิ่งที่สำคัญมากและในกรณีเช่นนี้จะมีการโยนข้อยกเว้น แต่เรายังสามารถละเลยบางส่วนของพวกเขาภายในและแจ้งให้ทราบเกี่ยวกับมันโดยใช้ข้อความเรียกกลับ
ไม่ว่าอย่างไรก็ตาม ข้อความทั้งหมดเหล่านี้ต้องการความสนใจเนื่องจากพวกเขาอาจอธิบายเช่น เอนติทีที่หายไปในผลลัพธ์การส่งออกหรือผลกระทบอื่น ๆ


### **ข้อผิดพลาดระหว่างการส่งออก**

มีฟิลด์ RenderResult ใน [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
ที่รวม IsRenderComplete เพื่อดูว่ามีข้อผิดพลาดระหว่างการส่งออกหรือไม่และพิมพ์ข้อมูลเกี่ยวกับพวกเขา:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **ข้อผิดพลาดระหว่างการโหลด**

อาจมีปัญหาบางอย่างกับภาพวาดที่สังเกตเห็นได้ก่อนที่กระบวนการส่งออกจะเริ่มขึ้น 
คุณสมบัติ [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) ใน
วัตถุ [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) ถูกใช้เพื่อเก็บข้อความเกี่ยวกับพวกเขา
คุณสมบัติ [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) เป็นประโยชน์ในการตัดสินใจว่าสมควรที่จะโยนข้อยกเว้นในข้อผิดพลาดการโหลดหรือไม่

นี่คือตัวอย่างการใช้คุณสมบัติ Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
