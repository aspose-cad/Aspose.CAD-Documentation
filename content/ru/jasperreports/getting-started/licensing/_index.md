---
title: Лицензирование
type: docs
weight: 40
url: /ru/jasperreports/getting-started/licensing/
---
## **Вызов setLicense**
Чтобы применить лицензию:

Сохраните файл лицензии в папке на вашем диске. Например, C:\Lic\Aspose.CAD.JasperReport.lic.
Вызовите метод License.setLicense(filename) и передайте имя файла в качестве аргумента. Когда это выражение будет вызвано, лицензия будет установлена, и сообщение об оценке больше не будет отображаться над изображениями.
Следующий фрагмент кода устанавливает лицензию для Aspose.CAD для JasperReports.

{{< highlight java >}}

// Установить лицензию

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Вы должны вызывать метод setLicense() только один раз за процесс или приложение.

{{% /alert %}}

## **Установите параметр лицензии Exporter в applicationContext.xml**
{{% alert color="primary" %}}
Этот метод применим для использования с JasperServer.
{{% /alert %}}
1. Скачайте лицензию на свой компьютер и скопируйте ее в папку \apache-tomcat\webapps\jasperserver\WEB-INF, где указывается каталог установки JasperServer.
2. Найдите файл \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml и добавьте следующие строки:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
