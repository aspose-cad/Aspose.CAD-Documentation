---
title: Lisanslama
type: docs
weight: 50
url: /tr/java/getting-started/licensing/
---

{{% alert color="primary" %}}

**Aspose.CAD** için Java'nın değerlendirme sürümünü [indirilebileceği sayfasından](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) indirebilirsiniz. Değerlendirme sürümü, ürünün lisanslı sürümüyle tamamen aynı yetenekleri sunmaktadır. Ayrıca, değerlendirme sürümü, bir lisans satın aldığınızda ve lisansı uygulamak için birkaç satır kod eklediğinizde, lisanslı hale gelir.

**Aspose.CAD**’nın değerlendirmesiyle memnun kaldıysanız, Aspose web sitesinde [bir lisans satın alabilirsiniz](https://purchase.aspose.com/buy). Sunulan farklı abonelik türleriyle tanışın. Herhangi bir sorunuz varsa, Aspose satış ekibiyle iletişime geçmekten çekinmeyin.

Her Aspose lisansı, bu süre zarfında çıkan yeni sürümler veya düzeltmeler için ücretsiz güncellemeler sağlayan bir yıllık bir abonelik taşır. Teknik destek, hem lisanslı hem de değerlendirme kullanıcılarına ücretsiz ve sınırsız olarak sağlanmaktadır.

{{% /alert %}}

Değerlendirme sürümü sınırlamaları olmadan **Aspose.CAD**'yı test etmek istiyorsanız, 30 günlük geçici bir lisans talep edin. Daha fazla bilgi için [Geçici Lisans Nasıl Alınır?](https://purchase.aspose.com/temporary-license) bölümüne başvurun.

## **Lisans Ayarlama**

Lisans, ürün adı, lisansın verildiği geliştirici sayısı, abonelik son kullanma tarihi gibi detayları içeren düz metin XML dosyasıdır. Dosya dijital olarak imzalanmıştır, bu yüzden dosyayı değiştirmeyin; dosyaya kazara bir ekstra boşluk eklenmesi bile geçersiz kılacaktır.

AutoCAD dosyalarıyla herhangi bir işlem gerçekleştirmeden önce bir lisans ayarlamalısınız. Her uygulama veya işlem için yalnızca bir kez lisans ayarlamanız gerekir.

Lisans, aşağıdaki konumlardan bir akış veya dosyadan yüklenebilir:

1. Açık yol.
1. Aspose.CAD.jar dosyasını içeren klasör.

Bileşeni lisanslamak için License.setLicense() yöntemini kullanın. Genellikle, lisansı ayarlamanın en kolay yolu, lisans dosyasını Aspose.CAD.jar ile aynı klasöre koymak ve aşağıdaki örnekte gösterildiği gibi yol olmadan yalnızca dosya adını belirtmektir:

### **Örnek 1**

Bu örnekte **Aspose.CAD**, lisans dosyasını uygulamanızın JAR'larını içeren klasörde bulmaya çalışacaktır.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Örnek 2**

Bir akıştan bir lisansı başlatır.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Lisansı Doğrulama**

Lisansın doğru bir şekilde ayarlanıp ayarlanmadığını doğrulamak mümkündür. License sınıfında lisans doğru bir şekilde ayarlandığında true döndürecek isLicensed alanı bulunmaktadır.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Lisans Ayarlandı!");

}

{{< /highlight >}}
