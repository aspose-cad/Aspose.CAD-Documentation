---
title: Lisanslama
type: docs
weight: 50
url: /tr/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Aspose.CAD for .NET değerlendirmesinden memnun kaldığınızda, Aspose web sitesinden bir lisans satın alın: [Satın Alma Portalı](https://purchase.aspose.com/buy). Farklı lisans türleri hakkında bilgi edinin. Herhangi bir sorunuz varsa, [Aspose satış ekibiyle iletişime geçin](https://about.aspose.com/contact) ve size yardımcı olmaktan memnuniyet duyarlar.

Her Aspose lisansı, bu süre zarfında çıkan yeni versiyonlar veya düzeltmeler için ücretsiz güncellemeler içeren bir yıllık bir abonelik taşıyan bir lisansdır. Hem lisanslı hem de değerlendirme kullanıcılarına ücretsiz ve sınırsız teknik destek sağlıyoruz.

Lisans, ürün adı, lisanslı geliştirici sayısı, abonelik sona erme tarihi gibi bilgileri içeren düz metin XML dosyasıdır. Dosya dijital olarak imzalanmıştır, bu nedenle dosyayı değiştirmeyin: dosyaya ekstra bir satır boşluk eklemek bile geçersiz kılar.

{{% /alert %}}

## **Lisans Ne Zaman Uygulanmalı**

Bu basit kuralları takip edin:

- Lisans yalnızca her uygulama alanında bir kez ayarlanmalıdır.
- Herhangi bir başka Aspose.CAD sınıfını kullanmadan önce lisansı ayarlamanız gerekir.
- SetLicense'ı birden fazla kez çağırmak zarar vermez, ancak işlemci süresini boşa harcar.
- Windows Forms veya konsol uygulaması geliştiriyorsanız, Aspose.CAD sınıflarını kullanmadan önce başlangıç kodunda SetLicense'ı çağırın.
- ASP.NET uygulaması geliştirirken, Global.asax.cs (Global.asax.vb) dosyasından Application_Start korumalı yönteminde SetLicense'ı çağırın. Uygulama başladığında bir kez çağrılır.
- Web sayfası her yüklendiğinde lisansın yükleneceği anlamına geldiğinden, Page_Load yöntemleri içinden SetLicense'ı çağırmayın.
- Bir sınıf kütüphanesi geliştiriyorsanız, Aspose.CAD kullanan sınıfın statik yapıcısından SetLicense'ı çağırın. Statik yapıcı, sınıfınızın bir örneği oluşturulmadan önce çalışır ve Aspose.CAD lisansının düzgün bir şekilde ayarlandığından emin olur.

## **Dosya veya Akış Nesnesi Kullanarak Lisans Uygulama**

Bileşeni lisanslamak için **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** yöntemini kullanın. Lisansı ayarlamanın en kolay yolu, lisans dosyasını Aspose.CAD.dll ile aynı klasöre koymak ve aşağıda gösterildiği gibi dosya adını belirtmektir.

### **Dosyadan Lisans Yükleme**

Bu kod parçası, bir dosyada veya yerleşik bir kaynakta saklanan bir lisansı başlatır.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Akış Nesnesinden Lisans Yükleme**

Bu kod parçası, akıştan lisansı başlatır.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
