---
title: Lizenzierung
type: docs
weight: 40
url: /de/jasperreports/lizenzierung/
---
## **Rufen Sie setLicense auf**
Um eine Lizenz anzuwenden:

Speichern Sie die Lizenzdatei in einem Ordner auf Ihrer Festplatte. Zum Beispiel C:\Lic\Aspose.CAD.JasperReports.lic.
Rufen Sie die Methode License.setLicense(Dateiname) auf und übergeben Sie den Dateinamen als Argument. Wenn diese Anweisung aufgerufen wird, wird die Lizenz festgelegt und die Evaluierungsnachricht erscheint nicht mehr oben auf den Bildern.
Der folgende Codeausschnitt setzt die Lizenz für Aspose.CAD für JasperReports.

{{< highlight java >}}

// Lizenz setzen

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Sie müssen die setLicense()-Methode nur einmal pro Prozess oder Anwendung aufrufen.

{{% /alert %}}

## **Setzen Sie den Lizenz-Exporter-Parameter in applicationContext.xml**
{{% alert color="primary" %}}
Diese Methode gilt für die Verwendung mit JasperServer.
{{% /alert %}}
1. Laden Sie die Lizenz auf Ihren Computer herunter und kopieren Sie sie in den Ordner \apache-tomcat\webapps\jasperserver\WEB-INF, wobei für das JasperServer-Installationsverzeichnis steht.
2. Suchen Sie die Datei \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml und fügen Sie die folgenden Zeilen hinzu:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
