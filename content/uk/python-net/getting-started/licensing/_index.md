---
title: Ліцензування
type: docs
weight: 40
url: /uk/python-net/getting-started/licensing/
---
## **Виклик setLicense**
Щоб застосувати ліцензію:

Збережіть файл ліцензії в папку на вашому диску. Наприклад C:\Lic\Aspose.CAD.Python.lic.
Викличте метод License.set_license(filename) та передайте ім'я файлу як аргумент. Коли цей оператор викликаний, ліцензія встановлена, і повідомлення про оцінку більше не з'являтиметься на зображеннях.
Наступний фрагмент коду встановлює ліцензію для Aspose.CAD для Python.

{{< highlight java >}}

// Встановити ліцензію

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Вам потрібно викликати метод set_license() лише один раз за процес або додаток.

{{% /alert %}}

## **Встановіть параметр ліцензії Exporter у applicationContext.xml**
{{% alert color="primary" %}}
Цей метод підходить для використання з JasperServer.
{{% /alert %}}
1. Завантажте ліцензію на свій комп'ютер та скопіюйте її в папку \apache-tomcat\webapps\jasperserver\WEB-INF, де розташована директорія установки JasperServer.
2. Знайдіть файл \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml та додайте наступні рядки:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
