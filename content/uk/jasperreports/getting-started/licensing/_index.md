---
title: Ліцензування
type: docs
weight: 40
url: /uk/jasperreports/getting-started/licensing/
---
## **Виклик setLicense**
Щоб застосувати ліцензію:

Збережіть ліцензійний файл у папку на вашому диску. Наприклад C:\Lic\Aspose.CAD.JasperReport.lic.
Викличте метод License.setLicense(filename) і передайте ім'я файлу як аргумент. Коли ця інструкція буде виконана, ліцензія буде встановлена, і повідомлення про оцінку більше не з'являтиметься на зображеннях.
Наступний фрагмент коду задає ліцензію для Aspose.CAD для JasperReports.

{{< highlight java >}}

// Встановіть ліцензію

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Вам потрібно викликати метод setLicense() лише один раз на процес або додаток.

{{% /alert %}}

## **Встановіть параметр ліцензії експортер у applicationContext.xml**
{{% alert color="primary" %}}
Цей метод застосовується для використання з JasperServer.
{{% /alert %}}
1. Завантажте ліцензію на ваш комп'ютер і скопіюйте її в папку \apache-tomcat\webapps\jasperserver\WEB-INF, де стоїть директорія встановлення JasperServer.
2. Знайдіть файл \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml і додайте наступні рядки:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
