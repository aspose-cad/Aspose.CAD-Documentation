---
title: Licencelés
type: docs
weight: 40
url: /hu/python-net/getting-started/licensing/
---
## **Hívja meg a setLicense-t**
Licenc alkalmazásához:

Mentse a licencfájlt egy mappába a számítógépén. Például C:\Lic\Aspose.CAD.Python.lic.
Hívja meg a License.set_license(filename) metódust, és adja át a fájl nevét argumentumként. Amikor ezt az utasítást hívják meg, a licenc beállításra kerül, és az értékelési üzenet nem jelenik meg többé a képek tetején.
Az alábbi kódrészlet az Aspose.CAD for Python licencét állítja be.

{{< highlight java >}}

// Licenc beállítása

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

A set_license() metódust csak egyszer kell meghívni folyamat vagy alkalmazás során.

{{% /alert %}}

## **Állítsa be a licencek Exporter Paramétert az applicationContext.xm fájlban**
{{% alert color="primary" %}}
Ez a módszer a JasperServerrel való használatra alkalmazható.
{{% /alert %}}
1. Töltse le a licencet a számítógépére, és másolja a \apache-tomcat\webapps\jasperserver\WEB-INF mappába, ahol az a JasperServer telepítési könyvtára.
2. Keresd meg a \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml fájlt és add hozzá az alábbi sorokat:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
