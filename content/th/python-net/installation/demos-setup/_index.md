---
title: การตั้งค่าการสาธิต
type: docs
weight: 40
url: /th/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD สำหรับ Python มีโปรเจ็กต์สาธิตจำนวนหนึ่งเพื่อช่วยให้คุณเริ่มต้น

การสาธิตที่มีให้พร้อมกับ Aspose.CAD สำหรับ Python เป็นการสาธิต Python มาตรฐานที่มีการปรับเปลี่ยนเพื่อแสดงการใช้งานของผู้ส่งออกใหม่

{{% /alert %}}

ในการเรียกใช้งานการสาธิตของ Aspose.CAD สำหรับ Python ให้ดำเนินการตามขั้นตอนต่อไปนี้:

1. ดาวน์โหลด Python (เช่น https://sourceforge.net/projects/python-net/files/archive/). ให้แน่ใจว่าคุณได้ดาวน์โหลดโปรเจ็กต์ที่บีบอัดทั้งหมดพร้อมกับโค้ดต้นฉบับและการสาธิต ไม่ใช่เพียงแค่ JAR เดียว
1. แยกโปรเจ็กต์ที่บีบอัดไปยังสถานที่บางแห่งในฮาร์ดดิสก์ของคุณ เช่น C:\.
1. คัดลอกโฟลเดอร์การสาธิตทั้งหมดจากโฟลเดอร์ \samples ของ **aspose-cad-xx.x.zip** ไปยัง **\InstallDir\demo\samples** โดยที่ "\InstallDir" คือสถานที่ที่คุณได้ทำการแยก Python ออกมา ขั้นตอนนี้มีความจำเป็นเนื่องจากสคริปต์สร้างการสาธิตพึ่งพาโครงสร้างโฟลเดอร์ของ Python มิฉะนั้นคุณจะต้องแก้ไขสคริปต์การสร้าง
1. คัดลอก **aspose-cad-pythons-xx.x.jar** จากโฟลเดอร์ \lib ของ **aspose-cad-pythons-xx.x.zip** ไปยัง **\InstallDir\lib**.
1. จัดเตรียมเครื่องมือการสร้าง Ant และ Ivy Dependency Manager ดูที่ **\InstallDir\readme.txt**.
1. แก้ไข **build.xml** ที่ **\InstallDir\demo\samples** เพิ่ม aspose-cad-pythons-xx.x.jar ลงใน classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. เปลี่ยนไดเรกทอรีปัจจุบันไปที่ **\InstallDir\demo\hsqldb** และเรียกใช้คำสั่งในบรรทัดคำสั่งต่อไปนี้:
   **ant runServer**
1. เปลี่ยนไดเรกทอรีปัจจุบันไปยังหนึ่งในการสาธิตของ Aspose.CAD สำหรับ Python เช่น **\InstallDir\demo\samples\charts.ai** และเรียกใช้คำสั่งต่อไปนี้ในบรรทัดคำสั่ง:
   **ant test** - เพื่อผลิตไฟล์รายงาน
1. เปิดเอกสารที่ได้ผลลัพธ์หนึ่งเพื่อดู เช่น **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
