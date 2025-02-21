---
title: การอนุญาต
type: docs
weight: 40
url: /th/python-net/getting-started/licensing/
---
## **เรียกใช้ setLicense**
เพื่อใช้ใบอนุญาต:

บันทึกไฟล์ใบอนุญาตไปยังโฟลเดอร์บนดิสก์ของคุณ เช่น C:\Lic\Aspose.CAD.Python.lic
เรียกใช้เมธอด License.set_license(filename) และส่งชื่อไฟล์เป็นพารามิเตอร์ เมื่อเรียกใช้คำสั่งนี้ ใบอนุญาตจะถูกตั้งค่าและข้อความการประเมินจะไม่ปรากฏขึ้นเหนือรูปภาพอีกต่อไป
โค้ดตัวอย่างต่อไปนี้จะตั้งค่าใบอนุญาตสำหรับ Aspose.CAD สำหรับ Python

{{< highlight java >}}

// ตั้งค่าใบอนุญาต

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

คุณต้องเรียกใช้เมธอด set_license() เพียงครั้งเดียวต่อกระบวนการหรือแอปพลิเคชัน

{{% /alert %}}

## **ตั้งค่าใบอนุญาต พารามิเตอร์ Exporter ใน applicationContext.xml**
{{% alert color="primary" %}}
วิธีนี้ใช้ได้กับ JasperServer
{{% /alert %}}
1. ดาวน์โหลดใบอนุญาตลงในคอมพิวเตอร์ของคุณและคัดลอกไปยังโฟลเดอร์ \apache-tomcat\webapps\jasperserver\WEB-INF ซึ่งแทนที่ด้วยไดเรกทอรีการติดตั้ง JasperServer
2. ค้นหาไฟล์ \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml และเพิ่มบรรทัดต่อไปนี้:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
