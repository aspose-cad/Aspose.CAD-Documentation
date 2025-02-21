---
title: การส่งออกฟอนต์ SHX
type: docs
weight: 40
url: /th/net/developer-guide/export-shx-fonts/
---

## **การส่งออกฟอนต์ SHX สำหรับการวาด DXF/DWG**

การวาดบางอย่างอาจมีฟอนต์ในรูปแบบ SHX พิเศษ ซึ่งเก็บสัญลักษณ์ของฟอนต์ในรูปแบบของรูปทรง รูปแบบนี้ต้องการกระบวนการโหลดเพิ่มเติมสำหรับฟอนต์แต่ละตัวที่ใช้ในภาพวาด Apose.CAD สามารถส่งออกการวาดที่มีข้อความเขียนใน SHX และมีตัวเลือกที่แตกต่างกันเพื่อทำเช่นนี้ วิธีที่ง่ายที่สุดในการทำคือเพียงใช้ 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) ของ 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) วัตถุ
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


สามารถหลีกเลี่ยงการตั้งค่าทุกเส้นทางไปยังฟอนต์ SHX หลายตัวโดยใช้ตัวอย่างต่อไปนี้:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
ฟอนต์ SHX แต่ละตัวมาพร้อมกับรหัสหน้า (codepage) ที่เหมาะสมที่เกี่ยวข้อง ฟอนต์เหล่านี้ได้รับการรู้จักและฝังเข้ามาใน Aspose.CAD สำหรับฟอนต์ SHX ที่รู้จัก ในกรณีที่มีการใช้ฟอนต์ SHX ที่กำหนดเอง สามารถใช้คุณสมบัติ ShxCodePages และตั้งค่าเส้นทางไปยังไฟล์ SHX และรหัสหน้าที่ตรงกัน
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
