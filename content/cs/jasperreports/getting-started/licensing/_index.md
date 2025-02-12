---
title: Licencování
type: docs
weight: 40
url: /cs/jasperreports/licensing/
---
## **Volání metody setLicense**
Pro aplikaci licence:

Uložte licenční soubor do složky na vašem disku. Například C:\Lic\Aspose.CAD.JasperReport.lic. 
Zavolejte metodu License.setLicense(nazevSouboru) a předejte název souboru jako argument. Jakmile je tato instrukce zavolána, licence je nastavena a evaluční zpráva se již nebude zobrazovat nad obrázky.
Následující ukázka kódu nastavuje licenci pro Aspose.CAD pro JasperReports.

{{< highlight java >}}

// Nastavení licence 

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Metodu setLicense() je třeba volat pouze jednou na jeden proces nebo aplikaci.

{{% /alert %}}

## **Nastavení parametru Exporter Licence v souboru applicationContext.xml**
{{% alert color="primary" %}}
Tato metoda je použitelná s JasperServerem.
{{% /alert %}}
1. Stáhněte licenci na váš počítač a zkopírujte ji do složky \apache-tomcat\webapps\jasperserver\WEB-INF, kde symbolizuje adresář instalace JasperServeru.
2. Najděte soubor \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml a přidejte následující řádky:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
