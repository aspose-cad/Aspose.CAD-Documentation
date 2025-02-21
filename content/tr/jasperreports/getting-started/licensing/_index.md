---
title: Lisanslama
type: docs
weight: 40
url: /tr/jasperreports/getting-started/licensing/
---
## **setLicense çağrısı**
Bir lisans uygulamak için:

Lisans dosyasını diskinizde bir klasöre kaydedin. Örneğin C:\Lic\Aspose.CAD.JasperReport.lic.
License.setLicense(filename) yöntemini çağırın ve dosya adını bir argüman olarak iletin. Bu ifade çağrıldığında, lisans ayarlanır ve değerlendirme mesajı görüntülerin üzerine bir daha çıkmayacaktır.
Aşağıdaki kod örneği, Aspose.CAD için JasperReports için lisansı ayarlar.

{{< highlight java >}}

// Lisansı ayarla

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

setLicense() yöntemini yalnızca her süreç veya uygulama için bir kez çağırmanız gerekiyor.

{{% /alert %}}

## **applicationContext.xml'de lisans İhracatçı Parametresini Ayarla**
{{% alert color="primary" %}}
Bu yöntem JasperServer ile kullanılmak üzere geçerlidir.
{{% /alert %}}
1. Lisansı bilgisayarınıza indirin ve \apache-tomcat\webapps\jasperserver\WEB-INF klasörüne kopyalayın; burada, JasperServer kurulum dizinini temsil eder.
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml dosyasını bulun ve aşağıdaki satırları ekleyin:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
