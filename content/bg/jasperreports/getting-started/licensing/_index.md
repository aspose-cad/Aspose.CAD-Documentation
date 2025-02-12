---
title: Лицензиране
type: docs
weight: 40
url: /bg/jasperreports/getting-started/licensing/
---
## **Викайте setLicense**
За да приложите лиценз:

Запишете лицензионния файл в папка на диска си. Например C:\Lic\Aspose.CAD.JasperReport.lic.
Викайте метода License.setLicense(filename) и предайте името на файла като аргумент. Когато това изявление бъде извикано, лицензът се задава и съобщението за оценка вече няма да се появява отгоре на изображенията.
Следният кодов фрагмент задава лиценза за Aspose.CAD за JasperReports.

{{< highlight java >}}

// Задаване на лиценз

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Трябва да извикате метода setLicense() само веднъж на процес или приложение.

{{% /alert %}}

## **Настройте лиценза Exporter Параметър в applicationContext.xml**
{{% alert color="primary" %}}
Този метод е приложим за използване с JasperServer.
{{% /alert %}}
1. Изтеглете лиценза на компютъра си и го копирайте в папката \apache-tomcat\webapps\jasperserver\WEB-INF, където стои директорията на инсталацията на JasperServer.
2. Намерете файла \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml и добавете следните редове:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
