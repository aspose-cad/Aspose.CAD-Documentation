---
title: Лицензирование
type: docs
weight: 40
url: /ru/python-net/getting-started/licensing/
---
## **Вызов setLicense**
Чтобы применить лицензию:

Сохраните файл лицензии в папку на вашем диске. Например, C:\Lic\Aspose.CAD.Python.lic.
Вызовите метод License.set_license(filename) и передайте имя файла в качестве аргумента. Когда это утверждение будет вызвано, лицензия будет установлена, и сообщение о проверке больше не будет появляться на изображениях.
Следующий фрагмент кода устанавливает лицензию для Aspose.CAD для Python.

{{< highlight java >}}

// Установить лицензию

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Вам нужно вызвать метод set_license() только один раз за процесс или приложение.

{{% /alert %}}

## **Установите параметр лицензии Exporter в applicationContext.xm**
{{% alert color="primary" %}}
Этот метод применим для использования с JasperServer.
{{% /alert %}}
1. Скачайте лицензию на ваш компьютер и скопируйте ее в папку \apache-tomcat\webapps\jasperserver\WEB-INF, где находится директория установки JasperServer.
2. Найдите файл \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml и добавьте следующие строки:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
