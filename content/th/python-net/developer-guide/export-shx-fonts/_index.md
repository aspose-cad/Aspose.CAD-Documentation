---
title: การส่งออกแบบอักษร SHX
type: docs
weight: 40
url: /th/python-net/developer-guide/export-shx-fonts/
---

## **การส่งออกแบบอักษร SHX สำหรับภาพวาด DXF/DWG**

ภาพวาดบางชิ้นอาจมีแบบอักษรในรูปแบบ SHX พิเศษ ซึ่งเก็บสัญลักษณ์ของแบบอักษรในรูปทรงต่างๆ รูปแบบนี้ต้องการขั้นตอนการโหลดเพิ่มเติมสำหรับแต่ละแบบอักษรที่ใช้ในภาพวาด Apose.CAD สามารถส่งออกภาพวาดที่มีข้อความเขียนด้วย SHX และมีตัวเลือกที่แตกต่างกันในการทำเช่นนี้ วิธีที่ง่ายที่สุดในการทำคือเพียงใช้
**ShxFonts** ของ 
**CadRasterizationOptions** อ็อบเจ็กต์

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
