---
title: مجوزها
type: docs
weight: 40
url: /fa/python-net/licensing/
---
## **فراخوانی setLicense**
برای اعمال یک مجوز:

فایل مجوز را در یک پوشه روی دیسک خود ذخیره کنید. به عنوان مثال C:\Lic\Aspose.CAD.Python.lic.
متد License.set_license(filename) را فراخوانی کنید و نام فایل را به عنوان آرگومان منتقل کنید. هنگامی که این عبارت فراخوانی می‌شود، مجوز تنظیم می‌شود و پیام ارزیابی دیگر در بالای تصاویر ظاهر نخواهد شد.
قطعه کد زیر مجوز را برای Aspose.CAD برای پایتون تنظیم می‌کند.

{{< highlight java >}}

// تنظیم مجوز

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

شما تنها باید متد set_license() را یک بار در هر فرآیند یا برنامه فراخوانی کنید.

{{% /alert %}}

## **تنظیم پارامتر مجوزExporter در applicationContext.xml**
{{% alert color="primary" %}}
این متد برای استفاده با JasperServer قابل کاربرد است.
{{% /alert %}}
1. مجوز را دانلود کنید و آن را به کامپیوتر خود کپی کنید و به پوشه \apache-tomcat\webapps\jasperserver\WEB-INF منتقل کنید، که به جای نام دایرکتوری نصب JasperServer است.
2. فایل \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml را پیدا کنید و خطوط زیر را اضافه کنید:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
