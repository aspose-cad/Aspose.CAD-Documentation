---
title: Licencjonowanie
type: docs
weight: 40
url: /pl/jasperreports/getting-started/licensing/
---
## **Wywołaj setLicense**
Aby zastosować licencję:

Zapisz plik licencji w folderze na swoim dysku. Na przykład C:\Lic\Aspose.CAD.JasperReport.lic.
Wywołaj metodę License.setLicense(filename) i przekaż nazwę pliku jako argument. Gdy to polecenie jest wywoływane, licencja jest ustawiana, a komunikat o ocenie nie będzie już pojawiał się na górze obrazów.
Poniższy fragment kodu ustawia licencję dla Aspose.CAD dla JasperReports.

{{< highlight java >}}

// Ustaw licencję

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Musisz wywołać metodę setLicense() tylko raz na proces lub aplikację.

{{% /alert %}}

## **Ustaw parametr licencji eksportera w applicationContext.xml**
{{% alert color="primary" %}}
Ta metoda ma zastosowanie do użycia z JasperServer.
{{% /alert %}}
1. Pobierz licencję na swój komputer i skopiuj ją do folderu \apache-tomcat\webapps\jasperserver\WEB-INF, gdzie znajduje się katalog instalacji JasperServer.
2. Zlokalizuj plik \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml i dodaj następujące linie:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
