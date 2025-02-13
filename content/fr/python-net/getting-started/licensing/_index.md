---
title: Licences
type: docs
weight: 40
url: /fr/python-net/getting-started/licensing/
---
## **Appeler setLicense**
Pour appliquer une licence :

Enregistrez le fichier de licence dans un dossier de votre disque. Par exemple C:\Lic\Aspose.CAD.Python.lic.
Appelez la méthode License.set_license(filename) et passez le nom de fichier en tant qu'argument. Lorsque cette instruction est appelée, la licence est définie et le message d’évaluation n’apparaîtra plus en haut des images.
Le code suivant définit la licence pour Aspose.CAD pour Python.

{{< highlight java >}}

// Définir la licence

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Vous devez appeler la méthode set_license() seulement une fois par processus ou application.

{{% /alert %}}

## **Définir le paramètre de licence Exporter dans applicationContext.xml**
{{% alert color="primary" %}}
Cette méthode est applicable pour une utilisation avec JasperServer.
{{% /alert %}}
1. Téléchargez la licence sur votre ordinateur et copiez-la dans le dossier \apache-tomcat\webapps\jasperserver\WEB-INF, où se trouve le répertoire d'installation de JasperServer.
2. Localisez le fichier \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml et ajoutez les lignes suivantes :
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
