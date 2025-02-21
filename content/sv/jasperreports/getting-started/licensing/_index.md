---
title: Licensiering
type: docs
weight: 40
url: /sv/jasperreports/getting-started/licensing/
---
## **Anropa setLicense**
För att tillämpa en licens:

Spara licensfilen i en mapp på din disk. Till exempel C:\Lic\Aspose.CAD.JasperReport.lic.
Anropa metoden License.setLicense(filename) och skicka filnamnet som ett argument. När detta uttalande anropas, sätts licensen och utvärderingsmeddelandet kommer inte längre visas ovanpå bilderna.
Följande kodsnutt sätter licensen för Aspose.CAD för JasperReports.

{{< highlight java >}}

// Sätt licens

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Du behöver endast anropa metoden setLicense() en gång per process eller applikation.

{{% /alert %}}

## **Ställ in licens Exporter Parameter i applicationContext.xml**
{{% alert color="primary" %}}
Denna metod är tillämplig för användning med JasperServer.
{{% /alert %}}
1. Ladda ner licensen till din dator och kopiera den till mappen \apache-tomcat\webapps\jasperserver\WEB-INF, där står för installationskatalogen för JasperServer.
2. Lokalisera filen \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml och lägg till följande rader:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
