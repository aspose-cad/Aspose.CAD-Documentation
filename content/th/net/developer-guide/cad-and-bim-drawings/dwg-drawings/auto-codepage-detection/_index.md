---
title: การตรวจจับรหัสหน้าอัตโนมัติ
type: docs
weight: 10
url: /th/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **การตรวจจับรหัสหน้าอัตโนมัติ**

Aspose.CAD รองรับการตรวจจับรหัสหน้าอัตโนมัติสำหรับ [DWG](https://docs.fileformat.com/cad/dwg/) และ [DWF](https://docs.fileformat.com/cad/dwf/) ไฟล์ หากคุณไม่ต้องการใช้ฟีเจอร์นี้ คุณสามารถเขียนทับได้โดยการตั้งค่าคุณสมบัติของ [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) คลาส.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): ตั้งค่าการเข้ารหัสที่ใช้ในการอ่านข้อมูลข้อความจากรูปแบบ DXF และ DWG ที่ไม่ใช่ Unicode โดยค่าเริ่มต้นจะตรวจจับอัตโนมัติ
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): ตั้งค่าการเข้ารหัสที่ใช้ในการอ่านสัญลักษณ์ที่เข้ารหัสด้วย MIF สำหรับการเข้ารหัส CJK (รูปแบบ M+nXXXX) โดยค่าเริ่มต้นจะตรวจจับอัตโนมัติ
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): กำหนดว่าตัวอักษร CIF (U+XXXX) และตัวอักษรที่เข้ารหัสด้วย MIF จะถูกถอดรหัสหรือไม่ หากพวกเขาไม่มีรูปแบบ AutoCAD ที่เหมาะสม (AutoCAD จะนำสัญลักษณ์เหล่านี้มาก่อนด้วยแบ็กสแลช) โดยค่าเริ่มต้นพวกเขาจะถูกถอดรหัส

## ตัวอย่างโค้ด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการเขียนทับการตรวจจับรหัสหน้าอัตโนมัติใน Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
