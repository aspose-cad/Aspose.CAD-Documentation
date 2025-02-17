---
title: Licencelés
type: docs
weight: 40
url: /hu/jasperreports/getting-started/licensing/
---
## **Hívja meg a setLicense-t**
Licenc alkalmazásához:

Mentse el a licencfájlt egy mappába a merevlemezén. Például C:\Lic\Aspose.CAD.JasperReport.lic.
Hívja meg a License.setLicense(filename) metódust és adja át a fájlnevet argumentumként. Amikor ezt a parancsot végrehajtja, a licenc beállításra kerül, és az értékelési üzenet többé nem fog megjelenni a képek tetején.
Az alábbi kódrészlet beállítja az Aspose.CAD licencét a JasperReports számára.

{{< highlight java >}}

// Licenc beállítása

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

A setLicense() metódust csak egyszer kell meghívni folyamatonként vagy alkalmazásonként.

{{% /alert %}}

## **Állítsa be a licenc Exporter Paramétert az applicationContext.xml-ben**
{{% alert color="primary" %}}
Ez a módszer a JasperServer-rel való használatra alkalmazható.
{{% /alert %}}
1. Töltse le a licencet a számítógépére, és másolja a \apache-tomcat\webapps\jasperserver\WEB-INF mappába, ahol a JasperServer telepítési könyvtára található.
2. Keresse meg a \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml fájlt, és adja hozzá az alábbi sorokat:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
