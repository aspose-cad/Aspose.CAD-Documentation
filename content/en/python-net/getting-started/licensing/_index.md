---
title: Licensing
type: docs
weight: 40
url: /python-net/getting-started/licensing/
---
## **Call setLicense**
To apply a license:

Save the license file to a folder on your disk. For example C:\Lic\Aspose.CAD.Python.lic.
Call the License.set_license(filename) method and pass the file name as an argument. When this statement is called, the license is set and the evaluation message will no longer appears on top of the images.
The following code snippet sets the license for Aspose.CAD for Python.

{{< highlight java >}}

// Set license

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

You need to call the set_license() method only once per process or application.

{{% /alert %}}

## **Set the license Exporter Parameter in applicationContext.xm**
{{% alert color="primary" %}}
This method is applicable for use with JasperServer.
{{% /alert %}}
1. Download the license to your computer and copy it to the \apache-tomcat\webapps\jasperserver\WEB-INF folder, where stands for the JasperServer installation directory.
2. Locate the \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml file and add the following lines:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
