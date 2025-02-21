---
title: การตั้งค่าเดโม
type: docs
weight: 40
url: /th/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD สำหรับ JasperReports รวมโครงการเดโมจำนวนมากเพื่อช่วยให้คุณเริ่มต้น

เดโมที่มีให้กับ Aspose.CAD สำหรับ JasperReports เป็นเดโม JasperReports มาตรฐานที่ได้รับการปรับแต่งเพื่อแสดงการใช้ผู้ส่งออกใหม่

{{% /alert %}}

ในการเรียกใช้เดโมของ Aspose.CAD สำหรับ JasperReports ให้ทำตามขั้นตอนต่อไปนี้:

1. ดาวน์โหลด JasperReports (เช่น https://sourceforge.net/projects/jasperreports/files/archive/). ให้แน่ใจว่าคุณดาวน์โหลดโครงการที่เก็บถาวรทั้งหมดพร้อมกับซอสโค้ดและเดโม ไม่ใช่แค่วิดีโอ JAR เดียว
1. ออกเก็บโครงการที่เก็บถาวรไปยังตำแหน่งใดๆ บนฮาร์ดดิสก์ของคุณ เช่น C:\.
1. คัดลอกโฟลเดอร์เดโมทั้งหมดจากโฟลเดอร์ \samples ของ **aspose-cad-xx.x.zip** ไปยัง **\InstallDir\demo\samples** ซึ่ง "\InstallDir" คือสถานที่ที่คุณได้ทำการแยก JasperReports ออกไป ขั้นตอนนี้เป็นสิ่งจำเป็นเพราะสคริปต์สร้างเดโมขึ้นอยู่กับโครงสร้างโฟลเดอร์ของ JasperReports มิฉะนั้นคุณจะต้องแก้ไขสคริปต์การสร้าง
1. คัดลอก **aspose-cad-jasperreports-xx.x.jar** จากโฟลเดอร์ \lib ของ **aspose-cad-jasperreports-xx.x.zip** ไปยัง **\InstallDir\lib**.
1. เตรียมเครื่องมือการสร้าง Ant และ Ivy Dependency Manager ดู **\InstallDir\readme.txt**.
1. แก้ไข **build.xml** ที่ **\InstallDir\demo\samples** เพิ่ม aspose-cad-jasperreports-xx.x.jar ลงใน classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. เปลี่ยนไดเรกทอรีปัจจุบันไปที่ **\InstallDir\demo\hsqldb** และรันคำสั่งในบรรทัดคำสั่งดังต่อไปนี้:
   **Ant runServer**
1. เปลี่ยนไดเรกทอรีปัจจุบันไปยังหนึ่งในเดโมของ Aspose.CAD สำหรับ JasperReports เช่น **\InstallDir\demo\samples\charts.ai** และรันคำสั่งดังต่อไปนี้ในบรรทัดคำสั่ง:
   **ant test** - เพื่อสร้างไฟล์รายงาน
1. เปิดหนึ่งในเอกสารที่สร้างขึ้นเพื่อตรวจสอบ เช่น **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
