---
title: Licencování
type: docs
weight: 40
url: /cs/python-net/licencovani/
---
## **Zavolejte setLicense**
Pro použití licence:

Uložte licenční soubor do složky na vašem disku. Například C:\Lic\Aspose.CAD.Python.lic.
Zavolejte metodu License.set_license(název_souboru) a předejte název souboru jako argument. Po zavolání tohoto příkazu bude licence nastavena a výhodící se zpráva se již na vrchu obrázků nezobrazí.
Následující úryvek kódu nastavuje licenci pro Aspose.CAD pro Python.

{{< highlight java >}}

// Nastavení licence

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Python.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Metodu set_license() je potřeba zavolat pouze jednou pro každý proces nebo aplikaci.

{{% /alert %}}

## **Nastavení parametru exportní licence v applicationContext.xm**
{{% alert color="primary" %}}
Tato metoda je použitelná s JasperServerem.
{{% /alert %}}
1. Stáhněte licenci do počítače a zkopírujte ji do složky \apache-tomcat\webapps\jasperserver\WEB-INF, kde označuje instalační adresář pro JasperServer.
2. Najděte soubor \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml a přidejte následující řádky:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
