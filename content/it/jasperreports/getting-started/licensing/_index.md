---
title: Licenza
type: docs
weight: 40
url: /it/jasperreports/getting-started/licensing/
---
## **Chiama setLicense**
Per applicare una licenza:

Salva il file di licenza in una cartella sul tuo disco. Ad esempio C:\Lic\Aspose.CAD.JasperReport.lic.
Chiama il metodo License.setLicense(filename) e passa il nome del file come argomento. Quando questa istruzione viene chiamata, la licenza viene impostata e il messaggio di valutazione non apparirà più sopra le immagini.
Il seguente frammento di codice imposta la licenza per Aspose.CAD per JasperReports.

{{< highlight java >}}

// Imposta la licenza

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

È necessario chiamare il metodo setLicense() solo una volta per processo o applicazione.

{{% /alert %}}

## **Imposta il parametro Exporter della licenza in applicationContext.xm**
{{% alert color="primary" %}}
Questo metodo è applicabile per l'uso con JasperServer.
{{% /alert %}}
1. Scarica la licenza sul tuo computer e copialo nella cartella \apache-tomcat\webapps\jasperserver\WEB-INF, dove rappresenta la directory di installazione di JasperServer.
2. Individua il file \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml e aggiungi le seguenti righe:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
