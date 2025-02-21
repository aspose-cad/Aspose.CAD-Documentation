---
title: Lisanslama
type: docs
weight: 40
url: /tr/python-net/getting-started/licensing/
---
## **setLicense Çağrısı**
Bir lisans uygulamak için:

Lisans dosyasını diskinizde bir klasöre kaydedin. Örneğin C:\Lic\Aspose.CAD.Python.lic.
License.set_license(filename) metodunu çağırın ve dosya adını bir argüman olarak geçin. Bu ifade çağrıldığında, lisans ayarlanır ve değerlendirme mesajı artık görüntülerin üstünde görünmeyecektir.
Aşağıdaki kod parçası, Aspose.CAD için Python lisansını ayarlar.

{{< highlight java >}}

// Lisansı ayarlayın

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

set_license() metodunu yalnızca işlem veya uygulama başına bir kez çağırmanız gerekir.

{{% /alert %}}

## **applicationContext.xml'de lisans İhracatçı Parametresini Ayarlayın**
{{% alert color="primary" %}}
Bu yöntem JasperServer ile kullanılmak üzere geçerlidir.
{{% /alert %}}
1. Lisansı bilgisayarınıza indirin ve \apache-tomcat\webapps\jasperserver\WEB-INF klasörüne kopyalayın, burada JasperServer kurulum dizini için geçerlidir.
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml dosyasını bulun ve aşağıdaki satırları ekleyin:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
