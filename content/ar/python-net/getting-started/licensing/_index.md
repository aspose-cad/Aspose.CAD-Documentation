---
title: الترخيص
type: docs
weight: 40
url: /ar/python-net/licensing/
---
## **استدعاء setLicense**
لتطبيق ترخيص:

احفظ ملف الترخيص في مجلد على القرص الخاص بك. على سبيل المثال C:\Lic\Aspose.CAD.Python.lic.
استدعِ طريقة License.set_license(filename) ومرر اسم الملف كوسيط. عند استدعاء هذه العبارة، يتم تعيين الترخيص ولن تظهر رسالة التقييم في أعلى الصور مرة أخرى.
يقوم مقتطف الكود التالي بتعيين الترخيص لـ Aspose.CAD لبايثون.

{{< highlight java >}}

// تعيين الترخيص

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

 تحتاج إلى استدعاء طريقة set_license() مرة واحدة فقط لكل عملية أو تطبيق.

{{% /alert %}}

## **تعيين معلمة ترخيص المصدر في applicationContext.xml**
{{% alert color="primary" %}}
هذه الطريقة قابلة للاستخدام مع JasperServer.
{{% /alert %}}
1. قم بتنزيل الترخيص إلى جهاز الكمبيوتر الخاص بك وانسخه إلى مجلد \apache-tomcat\webapps\jasperserver\WEB-INF، حيث يمثل دليل تثبيت JasperServer.
2. حدد موقع ملف \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml وأضف الأسطر التالية:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
