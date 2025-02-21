---
title: Licenze
type: docs
weight: 40
url: /it/python-net/getting-started/licensing/
---
## **Chiama setLicense**
Per applicare una licenza:

Salva il file di licenza in una cartella sul tuo disco. Ad esempio C:\Lic\Aspose.CAD.Python.lic.
Chiama il metodo License.set_license(filename) e passa il nome del file come argomento. Quando questa istruzione viene chiamata, la licenza viene impostata e il messaggio di valutazione non apparirà più sopra le immagini.
Il seguente frammento di codice imposta la licenza per Aspose.CAD per Python.

{{< highlight java >}}

// Imposta la licenza

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

È necessario chiamare il metodo set_license() solo una volta per processo o applicazione.

{{% /alert %}}

## **Imposta il parametro Exporter della licenza in applicationContext.xml**
{{% alert color="primary" %}}
Questo metodo è applicabile per l'uso con JasperServer.
{{% /alert %}}
1. Scarica la licenza sul tuo computer e copiala nella cartella \apache-tomcat\webapps\jasperserver\WEB-INF, dove indica la directory di installazione di JasperServer.
2. Individua il file \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml e aggiungi le seguenti righe:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
