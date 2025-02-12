---
title: الترخيص
type: docs
weight: 40
url: /ar/jasperreports/getting-started/licensing/
---
## **استدعاء setLicense**
لتطبيق الترخيص:

احفظ ملف الترخيص في مجلد على القرص الخاص بك. على سبيل المثال C:\Lic\Aspose.CAD.JasperReport.lic.
استدعاء طريقة License.setLicense(filename) وتمرير اسم الملف كوسيلة. عند استدعاء هذا البيان، يتم تعيين الترخيص ولن تظهر رسالة التقييم مرة أخرى على الصور.
يحدد جزء الكود التالي الترخيص لـ Aspose.CAD لـ JasperReports.

{{< highlight java >}}

// تعيين الترخيص

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

تحتاج إلى استدعاء طريقة setLicense() مرة واحدة فقط لكل عملية أو تطبيق.

{{% /alert %}}

## **تعيين معلمة الترخيص في applicationContext.xml**
{{% alert color="primary" %}}
هذه الطريقة قابلة للاستخدام مع JasperServer.
{{% /alert %}}
1. قم بتنزيل الترخيص إلى جهاز الكمبيوتر الخاص بك وانسخه إلى مجلد \apache-tomcat\webapps\jasperserver\WEB-INF، حيث يُشير إلى دليل تثبيت JasperServer.
2. ابحث عن ملف \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml وأضف الأسطر التالية:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}