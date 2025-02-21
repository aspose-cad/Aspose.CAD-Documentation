---
title: Licensiering
type: docs
weight: 40
url: /sv/python-net/getting-started/licensing/
---
## **Anropa setLicense**
För att tillämpa en licens:

Spara licensfilen i en mapp på din disk. Till exempel C:\Lic\Aspose.CAD.Python.lic. 
Anropa metoden License.set_license(filename) och skicka filnamnet som ett argument. När detta uttalande anropas, sätts licensen och utvärderingsmeddelandet kommer inte längre att visas högst upp på bilderna. 
Följande kodsnutt sätter licensen för Aspose.CAD för Python.

{{< highlight java >}}

// Sätt licens

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Du behöver bara anropa metoden set_license() en gång per process eller applikation.

{{% /alert %}}

## **Sätt licens Exporter Parameter i applicationContext.xm**
{{% alert color="primary" %}}
Denna metod är tillämplig för användning med JasperServer.
{{% /alert %}}
1. Ladda ner licensen till din dator och kopiera den till mappen \apache-tomcat\webapps\jasperserver\WEB-INF, där som står för installationskatalogen för JasperServer.
2. Lokalisera filen \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml och lägg till följande rader:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
