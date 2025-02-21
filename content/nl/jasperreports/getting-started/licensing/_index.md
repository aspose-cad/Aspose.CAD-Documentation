---
title: Licenties
type: docs
weight: 40
url: /nl/jasperreports/getting-started/licensing/
---
## **Roep setLicense aan**
Om een licentie toe te passen:

Sla het licentiebestand op in een map op uw schijf. Bijvoorbeeld C:\Lic\Aspose.CAD.JasperReport.lic.
Roep de methode License.setLicense(filename) aan en geef de bestandsnaam door als argument. Wanneer deze verklaring wordt aangeroepen, wordt de licentie ingesteld en verschijnt de evaluatieboodschap niet langer bovenaan de afbeeldingen.
De volgende codefragment stelt de licentie in voor Aspose.CAD voor JasperReports.

{{< highlight java >}}

// Stel licentie in

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

U hoeft de setLicense() methode slechts één keer per proces of applicatie aan te roepen.

{{% /alert %}}

## **Stel de licentie Exporter Parameter in applicationContext.xml**
{{% alert color="primary" %}}
Deze methode is toepasbaar voor gebruik met JasperServer.
{{% /alert %}}
1. Download de licentie naar uw computer en kopieer deze naar de \apache-tomcat\webapps\jasperserver\WEB-INF map, waar staat voor de installatie directory van JasperServer.
2. Zoek het \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml bestand en voeg de volgende regels toe:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
