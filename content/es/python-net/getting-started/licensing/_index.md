---
title: Licenciamiento
type: docs
weight: 40
url: /es/python-net/getting-started/licensing/
---
## **Llamar setLicense**
Para aplicar una licencia:

Guarda el archivo de licencia en una carpeta en tu disco. Por ejemplo C:\Lic\Aspose.CAD.Python.lic.
Llama al método License.set_license(filename) y pasa el nombre del archivo como argumento. Cuando se llama esta declaración, la licencia se establece y el mensaje de evaluación ya no aparecerá en la parte superior de las imágenes.
El siguiente fragmento de código establece la licencia para Aspose.CAD para Python.

{{< highlight java >}}

// Establecer licencia

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Solo necesitas llamar al método set_license() una vez por proceso o aplicación.

{{% /alert %}}

## **Establecer el parámetro de exportación de licencia en applicationContext.xm**
{{% alert color="primary" %}}
Este método es aplicable para su uso con JasperServer.
{{% /alert %}}
1. Descarga la licencia a tu computadora y cópiala en la carpeta \apache-tomcat\webapps\jasperserver\WEB-INF, donde representa el directorio de instalación de JasperServer.
2. Localiza el archivo \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml y agrega las siguientes líneas:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
