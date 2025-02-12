---
title: Licences
type: docs
weight: 40
url: /fr/jasperreports/getting-started/licensing/
---
## **Appeler setLicense**
Pour appliquer une licence :

Enregistrez le fichier de licence dans un dossier de votre disque. Par exemple C:\Lic\Aspose.CAD.JasperReport.lic.
Appelez la méthode License.setLicense(filename) et passez le nom de fichier en argument. Lorsque cette instruction est exécutée, la licence est définie et le message d'évaluation n'apparaîtra plus en haut des images.
Le snippet de code suivant définit la licence pour Aspose.CAD pour JasperReports.

{{< highlight java >}}

// Définir la licence

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Vous devez appeler la méthode setLicense() une seule fois par processus ou application.

{{% /alert %}}

## **Définir le paramètre d'exportation de licence dans applicationContext.xml**
{{% alert color="primary" %}}
Cette méthode est applicable pour une utilisation avec JasperServer.
{{% /alert %}}
1. Téléchargez la licence sur votre ordinateur et copiez-la dans le dossier \apache-tomcat\webapps\jasperserver\WEB-INF, où se trouve le répertoire d'installation de JasperServer.
2. Localisez le fichier \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml et ajoutez les lignes suivantes :
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
