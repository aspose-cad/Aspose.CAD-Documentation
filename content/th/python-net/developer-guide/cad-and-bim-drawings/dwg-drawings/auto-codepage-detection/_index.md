---
title: การตรวจจับรหัสอัตโนมัติ
type: docs
weight: 10
url: /th/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **การตรวจจับรหัสอัตโนมัติ**

Aspose.CAD รองรับการตรวจจับรหัสอัตโนมัติสำหรับ [DWG](https://docs.fileformat.com/cad/dwg/) และ [DWF](https://docs.fileformat.com/cad/dwf/) ไฟล์ หากคุณไม่ต้องการใช้ฟีเจอร์นี้ คุณสามารถแทนที่ได้โดยการตั้งค่าคุณสมบัติต่อไปนี้ของคลาส **LoadOptions**

- **specified_encoding**: ตั้งค่าสัญ encoding ที่ใช้ในการอ่านข้อมูลข้อความจากรูปแบบ DXF และ DWG ที่ไม่ใช่ Unicode มันจะถูกตรวจจับโดยอัตโนมัติเป็นค่าเริ่มต้น
- **specified_mif_encoding**: ตั้งค่าสัญ encoding ที่ใช้ในการอ่านสัญลักษณ์ที่เข้ารหัสด้วย MIF ของการเข้ารหัส CJK (M+nXXXX format) มันจะถูกตรวจจับโดยอัตโนมัติเป็นค่าเริ่มต้น
- **recover_malformed_cif_mif**: กำหนดว่าตัวอักษร CIF (U+XXXX) และ MIF ที่เข้ารหัสจะถูกถอดรหัสหรือไม่หากพวกเขาไม่มีรูปแบบ AutoCAD ที่เหมาะสม (AutoCAD นำสัญลักษณ์เหล่านี้หน้าจริงด้วยแบ็คสแลช) โดยค่าเริ่มต้นพวกเขาจะถูกถอดรหัส

## โค้ดตัวอย่าง

โค้ดตัวอย่างด้านล่างแสดงวิธีการแทนที่การตรวจจับรหัสอัตโนมัติใน Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
