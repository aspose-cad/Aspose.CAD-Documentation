---
title: Licencjonowanie
type: docs
weight: 40
url: /pl/python-net/getting-started/licensing/
---
## **Wywołaj setLicense**
Aby zastosować licencję:

Zapisz plik licencji w folderze na swoim dysku. Na przykład C:\Lic\Aspose.CAD.Python.lic.
Wywołaj metodę License.set_license(filename) i przekaż nazwę pliku jako argument. Gdy to polecenie zostanie wywołane, licencja zostanie ustawiona, a komunikat o ewaluacji nie będzie już pojawiał się na górze obrazów.
Poniższy fragment kodu ustawia licencję dla Aspose.CAD dla Pythona.

{{< highlight java >}}

// Ustaw licencję

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Musisz wywołać metodę set_license() tylko raz na proces lub aplikację.

{{% /alert %}}

## **Ustaw parametr eksportera licencji w applicationContext.xml**
{{% alert color="primary" %}}
Ta metoda ma zastosowanie do JasperServer.
{{% /alert %}}
1. Pobierz licencję na swój komputer i skopiuj ją do folderu \apache-tomcat\webapps\jasperserver\WEB-INF, gdzie oznacza katalog instalacji JasperServer.
2. Zlokalizuj plik \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml i dodaj następujące linie:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
