---
title: การส่งออกฟอนต์ SHX
type: docs
weight: 40
url: /th/java/developer-guide/export-shx-fonts/
---

## **การส่งออกฟอนต์ SHX สำหรับภาพวาด DXF/DWG**

ภาพวาดบางภาพอาจมีฟอนต์ในรูปแบบ SHX พิเศษ ซึ่งเก็บสัญลักษณ์ของฟอนต์ในรูปแบบของรูปร่าง
รูปแบบนี้ต้องการกระบวนการโหลดเพิ่มเติมสำหรับแต่ละฟอนต์ที่ใช้ในภาพวาด
Apose.CAD สามารถส่งออกภาพวาดที่มีข้อความเขียนใน SHX และมีตัวเลือกที่แตกต่างกันในการทำเช่นนี้
วิธีที่ง่ายที่สุดในการทำเช่นนี้คือการใช้ [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-)
คุณสมบัติของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) อ็อบเจ็กต์.	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

แต่ละฟอนต์ SHX มาพร้อมกับรหัสหน้า (codepage) ที่เกี่ยวข้องกับมัน การเชื่อมโยงเหล่านี้เป็นที่รู้จักกันและฝังอยู่บางส่วนใน Aspose.CAD สำหรับฟอนต์ SHX ที่รู้จัก
ในกรณีที่ใช้ฟอนต์ SHX ที่กำหนดเอง จะสามารถใช้คุณสมบัติ **setShxCodePages** และตั้งค่าพาธไปยังไฟล์ SHX พร้อมกับรหัสหน้า (code page) ที่เกี่ยวข้อง
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
