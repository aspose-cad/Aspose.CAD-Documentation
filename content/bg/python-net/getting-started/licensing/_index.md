---
title: Лицензиране
type: docs
weight: 40
url: /bg/python-net/licensing/
---
## **Извикване на setLicense**
За да приложите лиценз:

Запазете лицензния файл в папка на вашия диск. Например C:\Lic\Aspose.CAD.Python.lic.
Извикайте метода License.set_license(filename) и предайте името на файла като аргумент. Когато този оператор се извика, лицензът се задава и оценъчното съобщение няма да се появява вече отгоре на изображенията.
Следният откъс код задава лиценза за Aspose.CAD за Python.

{{< highlight java >}}

// Задаване на лиценз

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Трябва да извикате метода set_license() само веднъж на процес или приложение.

{{% /alert %}}

## **Задайте параметъра на лицензния износ в applicationContext.xm**
{{% alert color="primary" %}}
Този метод е приложим за използване с JasperServer.
{{% /alert %}}
1. Изтеглете лиценза на вашия компютър и я копирайте в папката \apache-tomcat\webapps\jasperserver\WEB-INF, където стои за директорията за инсталиране на JasperServer.
2. Открийте файла \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml и добавете следните редове:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
