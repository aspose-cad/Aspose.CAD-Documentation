---
title: การอนุญาตแบบมิเตอร์
type: docs
weight: 60
url: /th/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD อนุญาตให้ผู้พัฒนานำคีย์แบบมิเตอร์ไปใช้ นี่คือกลไกการออกใบอนุญาตแบบใหม่ กลไกการออกใบอนุญาตใหม่จะถูกใช้ร่วมกับวิธีการออกใบอนุญาตที่มีอยู่ ลูกค้าที่ต้องการถูกเรียกเก็บเงินตามการใช้ฟีเจอร์ของ API สามารถใช้การอนุญาตแบบมิเตอร์ สำหรับรายละเอียดเพิ่มเติม กรุณาอ้างอิงไปที่ [คำถามที่พบบ่อยเกี่ยวกับการอนุญาตแบบมิเตอร์](https://purchase.aspose.com/faqs/licensing/metered) 

{{% /alert %}} 
## **การอนุญาตแบบมิเตอร์**
นี่คือขั้นตอนง่ายๆ ในการใช้คลาส Metered

1. สร้างอินสแตนซ์ของคลาส Metered
1. ส่งคีย์สาธารณะและคีย์ส่วนตัวไปยังวิธีการ setMeteredKey
1. ดำเนินการ (ทำภารกิจ)
1. เรียกใช้วิธีการ getConsumptionQuantity ของคลาส Metered
1. มันจะส่งคืนจำนวน/ปริมาณของคำขอ API ที่คุณได้ใช้ไปจนถึงปัจจุบัน

ต่อไปนี้คือโค้ดตัวอย่างที่แสดงวิธีการตั้งค่าคีย์สาธารณะและคีย์ส่วนตัวแบบมิเตอร์:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
