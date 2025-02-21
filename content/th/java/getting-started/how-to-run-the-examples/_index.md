---
title: วิธีการรันตัวอย่าง
type: docs
weight: 70
url: /th/java/getting-started/how-to-run-the-examples/
---

## **ดาวน์โหลดจาก GitHub**

ตัวอย่างทั้งหมดของ Aspose.CAD สำหรับ Java ถูกโฮสต์อยู่บน [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java) คุณสามารถโคลนที่เก็บโดยใช้ไคลเอนต์ Github ที่คุณชื่นชอบหรือดาวน์โหลดไฟล์ ZIP จาก [ที่นี่](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip)

คลายซิปเนื้อหาของไฟล์ ZIP ไปยังโฟลเดอร์ใดก็ได้ในคอมพิวเตอร์ของคุณ ตัวอย่างทั้งหมดอยู่ในโฟลเดอร์ **Examples**

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**รูปภาพ: โฟลเดอร์ตัวอย่าง Aspose.CAD**|

## **นำเข้าตัวอย่างเข้าสู่ IDE**

โปรเจกต์นี้ใช้ระบบสร้าง Maven โปรแกรม IDE ที่ทันสมัยสามารถเปิดหรือลงโปรเจกต์และการพึ่งพาได้อย่างง่ายดาย ด้านล่างนี้เราจะแสดงวิธีการใช้ IDE ที่เป็นที่นิยมในการสร้างและรันตัวอย่าง

### **IntelliJ IDEA**

คลิกที่เมนู **File** แล้วเลือก **Open** เลื่อนหาไปยังโฟลเดอร์โปรเจกต์และเลือกไฟล์ **pom.xml**

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**รูปภาพ: เลือกไฟล์หรือโฟลเดอร์เพื่อนำเข้า**|
จะเปิดโปรเจกต์และดาวน์โหลดการพึ่งพาโดยอัตโนมัติ จากแท็บ Project ให้เลื่อนดูตัวอย่างในโฟลเดอร์ **src/main/java** เพื่อรันตัวอย่าง เพียงคลิกขวาที่ไฟล์แล้วเลือก "Run .." ตัวอย่างจะถูกรันและผลลัพธ์จะถูกแสดงในหน้าต่างเอาต์พุตคอนโซลที่สร้างขึ้นในตัว

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**รูปภาพ: รันตัวอย่าง**|

### **Eclipse**

คลิกที่เมนู **File** แล้วเลือก **Import** เลือก **Maven** - Existing Maven Projects

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**รูปภาพ: นำเข้า**|
เลื่อนหาไปยังโฟลเดอร์ที่คุณโคลนหรือลงจาก GitHub แล้วเลือกไฟล์ **pom.xml** จะเปิดโปรเจกต์และดาวน์โหลดการพึ่งพาโดยอัตโนมัติ จากแท็บ Package Explorer ให้เลื่อนดูตัวอย่างในโฟลเดอร์ **src/main/java** เพื่อรันตัวอย่าง เพียงคลิกขวาที่ไฟล์และเลือก **Run As** - **Java Application** ตัวอย่างจะถูกรันและผลลัพธ์จะแสดงในหน้าต่างเอาต์พุตคอนโซลที่สร้างขึ้นในตัว

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**รูปภาพ: รันตัวอย่าง**|

### **NetBeans**

คลิกที่เมนู **File** แล้วเลือก **Open Project** เลื่อนหาไปยังโฟลเดอร์ที่คุณโคลนหรือลงจาก GitHub ไอคอนของโฟลเดอร์ **Examples** จะบอกว่ามันเป็นโครงการ Maven เลือก Examples และเปิดมัน

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**รูปภาพ: เปิดโปรเจกต์**|
จะเปิดโปรเจกต์และดาวน์โหลดการพึ่งพาโดยอัตโนมัติ จากแท็บ Projects ให้เลื่อนดูตัวอย่างใน **source packages** เพื่อรันตัวอย่าง เพียงคลิกขวาที่ไฟล์และเลือก **Run File** ตัวอย่างจะถูกรันและผลลัพธ์จะแสดงในหน้าต่างเอาต์พุตคอนโซลที่สร้างขึ้นในตัว

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**รูปภาพ: รันตัวอย่าง**|

## **เพิ่ม Aspose.CAD ไลบรารีลงใน Repository ท้องถิ่นของ Maven**

เมื่อคุณนำเข้าโปรเจกต์ **Aspose.CAD Examples** เข้าสู่ IDE Maven จะดาวน์โหลดไฟล์ JAR ของ aspose.cad โดยอัตโนมัติจาก [Aspose Maven Repository](https://releases.aspose.com/java/repo/) ในกรณีที่คุณไม่สามารถเข้าถึงอินเทอร์เน็ต คุณสามารถเพิ่ม JAR ด้วยตนเองในที่เก็บท้องถิ่นของคุณ

### **mvn install**

ดาวน์โหลด [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) คลายซิปมันและคัดลอก aspose.cad-version.jar ไปยังที่อื่น เช่น ไดรฟ์ c ออกคำสั่งด้านล่างนี้:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

ตอนนี้ไฟล์ JAR **aspose.cad** ถูกคัดลอกไปยังที่เก็บท้องถิ่นของคุณใน Maven

### **pom.xml**

หลังจากติดตั้งแล้ว เพียงประกาศพิกัด **aspose.cad** ใน pom.xml

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **เสร็จสิ้น**

สร้างมัน ตอนนี้ไฟล์ JAR **aspose.cad** สามารถเรียกคืนจากที่เก็บท้องถิ่นของคุณใน Maven

## **มีส่วนร่วม**

หากคุณต้องการเพิ่มหรือปรับปรุงตัวอย่างใด ๆ เราขอสนับสนุนให้คุณมีส่วนร่วมในโปรเจกต์ ตัวอย่างและโปรเจกต์นำเสนอทั้งหมดในที่เก็บนี้เป็นโอเพ่นซอร์สและสามารถใช้งานได้ฟรีในแอปพลิเคชันของคุณเอง

ในการมีส่วนร่วม คุณสามารถโฟกัสที่เก็บ ปรับแก้ไขโค้ดต้นฉบับและสามารถส่ง Pull Request เราจะตรวจสอบการเปลี่ยนแปลงและรวมเข้าไปในที่เก็บหากพบว่ามีประโยชน์
