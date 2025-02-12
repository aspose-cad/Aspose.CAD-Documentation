---
title: Lizenzierung
type: docs
weight: 40
url: /de/python-net/getting-started/licensing/
---
## **Methode setLicense aufrufen**
Um eine Lizenz anzuwenden:

Speichern Sie die Lizenzdatei in einem Ordner auf Ihrer Festplatte. Zum Beispiel C:\Lic\Aspose.CAD.Python.lic.
Rufen Sie die Methode License.set_license(filename) auf und übergeben Sie den Dateinamen als Argument. Wenn diese Anweisung aufgerufen wird, wird die Lizenz gesetzt und die Evaluierungsnachricht erscheint nicht mehr oben auf den Bildern.
Der folgende Codeausschnitt setzt die Lizenz für Aspose.CAD für Python.

{{< highlight java >}}

// Lizenz setzen

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Sie müssen die Methode set_license() nur einmal pro Prozess oder Anwendung aufrufen.

{{% /alert %}}

## **Setzen Sie den Lizenz-Exporter-Parameter in applicationContext.xml**
{{% alert color="primary" %}}
Diese Methode ist für die Verwendung mit JasperServer geeignet.
{{% /alert %}}
1. Laden Sie die Lizenz auf Ihren Computer herunter und kopieren Sie sie in den \apache-tomcat\webapps\jasperserver\WEB-INF Ordner, wobei für das Installationsverzeichnis von JasperServer steht.
2. Suchen Sie die Datei \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml und fügen Sie die folgenden Zeilen hinzu:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
