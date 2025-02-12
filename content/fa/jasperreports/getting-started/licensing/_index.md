---
title: مجوز
type: docs
weight: 40
url: /fa/jasperreports/licensing/
---
## **فراخوانی setLicense**
برای اعمال یک مجوز:

فایل مجوز را در یک پوشه در دیسک خود ذخیره کنید. به عنوان مثال C:\Lic\Aspose.CAD.JasperReport.lic.
متد License.setLicense(filename) را فراخوانی کنید و نام فایل را به عنوان آرگومان ارسال کنید. وقتی این بیانیه فراخوانی می‌شود، مجوز تنظیم می‌شود و پیام ارزیابی دیگر در بالای تصاویر نمایش داده نخواهد شد.
قطعه کد زیر مجوز را برای Aspose.CAD برای JasperReports تنظیم می‌کند.

{{< highlight java >}}

// تنظیم مجوز

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

شما تنها باید متد setLicense() را یک بار در هر فرآیند یا برنامه فراخوانی کنید.

{{% /alert %}}

## **تنظیم پارامتر مجوز Exporter در applicationContext.xml**
{{% alert color="primary" %}}
این روش برای استفاده با JasperServer قابل استفاده است.
{{% /alert %}}
1. مجوز را به رایانه خود دانلود کرده و آن را به پوشه \apache-tomcat\webapps\jasperserver\WEB-INF کپی کنید، که به عنوان پوشه نصب JasperServer شناخته می‌شود.
2. فایل \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml را پیدا کرده و خطوط زیر را اضافه کنید:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
