---
title: ใบอนุญาต
type: docs
weight: 40
url: /th/jasperreports/getting-started/licensing/
---
## **เรียกใช้ setLicense**
เพื่อใช้ใบอนุญาต:

บันทึกไฟล์ใบอนุญาตลงในโฟลเดอร์ในฮาร์ดดิสก์ของคุณ ตัวอย่างเช่น C:\Lic\Aspose.CAD.JasperReport.lic.
เรียกใช้วิธี License.setLicense(filename) และส่งชื่อไฟล์เป็นอาร์กิวเมนต์ เมื่อตัวแปรนี้ถูกเรียกใช้ ใบอนุญาตจะถูกตั้งค่าและข้อความการประเมินจะไม่ปรากฏอีกต่อไปบนภาพ
โค้ดส่วนนี้ตั้งค่าใบอนุญาตสำหรับ Aspose.CAD สำหรับ JasperReports.

{{< highlight java >}}

// ตั้งค่าใบอนุญาต

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

คุณต้องเรียกใช้วิธี setLicense() เพียงครั้งเดียวต่อกระบวนการหรือแอปพลิเคชัน

{{% /alert %}}

## **ตั้งค่าพารามิเตอร์ใบอนุญาต Exporter ใน applicationContext.xm**
{{% alert color="primary" %}}
วิธีนี้สามารถใช้กับ JasperServer ได้
{{% /alert %}}
1. ดาวน์โหลดใบอนุญาตไปยังคอมพิวเตอร์ของคุณและคัดลอกไปยังโฟลเดอร์ \apache-tomcat\webapps\jasperserver\WEB-INF ซึ่งหมายถึงไดเรกทอรีการติดตั้ง JasperServer.
2. หาตำแหน่งไฟล์ \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml และเพิ่มบรรทัดต่อไปนี้:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
