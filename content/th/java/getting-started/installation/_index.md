---
title: การติดตั้ง
type: docs
weight: 30
url: /th/java/getting-started/installation/
---

## **การติดตั้ง Aspose.CAD สำหรับ Java จาก Maven Repository**

Aspose โฮสต์ API Java ทั้งหมดไว้ที่ [Maven repository](https://releases.aspose.com/java/repo/com/aspose/). คุณสามารถใช้ [Aspose.CAD สำหรับ Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API ได้โดยตรงในโครงการ Maven ของคุณด้วยการกำหนดค่าที่ง่ายดาย

### **กำหนดค่าการเก็บ Maven Repository**

ก่อนอื่นคุณจำเป็นต้องกำหนดค่าหรือที่ตั้งของ Aspose Maven Repository ในไฟล์ pom.xml ของ Maven ดังนี้:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **กำหนดการพึ่งพา API Aspose.CAD สำหรับ Java**

จากนั้นให้กำหนดการพึ่งพา API Aspose.CAD สำหรับ Java ในไฟล์ pom.xml ของคุณดังนี้:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

หลังจากดำเนินการขั้นตอนข้างต้นแล้ว การพึ่งพา Aspose.CAD สำหรับ Java จะถูกกำหนดให้มีอยู่ในโครงการ Maven ของคุณ

## **แพลตฟอร์มที่รองรับ**

Aspose.CAD สำหรับ Java รองรับแพลตฟอร์มการพัฒนาและการปรับใช้ที่เป็นที่นิยมมากที่สุด

|**ฟีเจอร์**|**คำอธิบาย**|
| :- | :- |
|แอปพลิเคชันเดสก์ท็อป|Aspose.CAD สำหรับ Java สามารถใช้พัฒนาแอปพลิเคชันเดสก์ท็อปใน MS Windows ได้|
|แอปพลิเคชันเว็บในองค์กร|Aspose.CAD สำหรับ Java รองรับแอปพลิเคชันเว็บอย่างสมบูรณ์|
|Linux/Unix|Aspose.CAD สำหรับ Java เป็น API ที่ไม่ขึ้นกับแพลตฟอร์มและสามารถทำงานในสภาพแวดล้อม Linux และ Unix ได้|

## **รุ่น Java ที่รองรับ**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
