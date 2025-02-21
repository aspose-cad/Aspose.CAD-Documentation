---
title: Licenties
type: docs
weight: 40
url: /nl/python-net/getting-started/licensing/
---
## **Roep setLicense aan**
Om een licentie toe te passen:

Sla het licentiebestand op in een map op je schijf. Bijvoorbeeld C:\Lic\Aspose.CAD.Python.lic.
Roep de License.set_license(bestandsnaam) methode aan en geef de bestandsnaam door als argument. Wanneer deze instructie wordt aangeroepen, wordt de licentie ingesteld en zal het evaluatiebericht niet langer bovenaan de afbeeldingen verschijnen.
De volgende codefragment stelt de licentie in voor Aspose.CAD voor Python.

{{< highlight java >}}

// Stel licentie in

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Je moet de set_license() methode maar één keer per proces of applicatie aanroepen.

{{% /alert %}}

## **Stel de licentie-exportparameter in applicationContext.xml**
{{% alert color="primary" %}}
Deze methode is toepasbaar voor gebruik met JasperServer.
{{% /alert %}}
1. Download de licentie naar je computer en kopieer deze naar de \apache-tomcat\webapps\jasperserver\WEB-INF map, waar staat voor de installatie directory van JasperServer.
2. Zoek het \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml bestand en voeg de volgende regels toe:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
