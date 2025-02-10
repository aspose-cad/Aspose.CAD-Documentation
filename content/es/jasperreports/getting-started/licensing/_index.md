---
title: Licencias
type: docs
weight: 40
url: /es/jasperreports/licensing/
---
## **Llamar a setLicense**
Para aplicar una licencia:

Guarda el archivo de licencia en una carpeta de tu disco. Por ejemplo C:\Lic\Aspose.CAD.JasperReport.lic.
Llama al método License.setLicense(filename) y pasa el nombre del archivo como argumento. Cuando se llama a esta instrucción, la licencia se establece y el mensaje de evaluación ya no aparecerá en la parte superior de las imágenes.
El siguiente fragmento de código establece la licencia para Aspose.CAD para JasperReports.

{{< highlight java >}}

// Establecer licencia

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Necesitas llamar al método setLicense() solo una vez por proceso o aplicación.

{{% /alert %}}

## **Establecer el parámetro Exporter de licencia en applicationContext.xml**
{{% alert color="primary" %}}
Este método es aplicable para su uso con JasperServer.
{{% /alert %}}
1. Descarga la licencia en tu computadora y cópiala en la carpeta \apache-tomcat\webapps\jasperserver\WEB-INF, donde se encuentra el directorio de instalación de JasperServer.
2. Localiza el archivo \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml y añade las siguientes líneas:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
