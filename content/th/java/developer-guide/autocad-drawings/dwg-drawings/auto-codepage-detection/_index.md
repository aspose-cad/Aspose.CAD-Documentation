---
title: การตรวจจับโค้ดเพจโดยอัตโนมัติ
type: docs
weight: 10
url: /th/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **การตรวจจับโค้ดเพจโดยอัตโนมัติ**

Aspose.CAD สนับสนุนการตรวจจับโค้ดเพจโดยอัตโนมัติสำหรับ [DWG](https://docs.fileformat.com/cad/dwg/) และ [DWF](https://docs.fileformat.com/cad/dwf/) ไฟล์ หากคุณไม่ต้องการใช้ฟีเจอร์นี้ คุณสามารถยกเลิกโดยการตั้งค่าคุณสมบัติด้านล่างของ [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) คลาส

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): ตั้งค่ารหัสที่ใช้เพื่ออ่านข้อมูลข้อความจากรูปแบบ DXF และ DWG ที่ไม่ใช่ Unicode โดยค่าเริ่มต้นจะตรวจจับโดยอัตโนมัติ
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): ตั้งค่ารหัสที่ใช้เพื่ออ่านสัญลักษณ์ที่เข้ารหัส MIF ของการเข้ารหัส CJK (รูปแบบ M+nXXXX) โดยค่าเริ่มต้นจะตรวจจับโดยอัตโนมัติ
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): กำหนดว่าตัวละคร CIF (U+XXXX) และตัวละครที่เข้ารหัส MIF จะถูกถอดรหัสหรือไม่ หากพวกเขาไม่มีรูปแบบ AutoCAD ที่ถูกต้อง (AutoCAD วางสัญลักษณ์เหล่านี้ด้วยเครื่องหมายย้อนกลับ) โดยค่าเริ่มต้นจะถูกถอดรหัส

## ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการยกเลิกการตรวจจับโค้ดเพจโดยอัตโนมัติใน Aspose.CAD

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
