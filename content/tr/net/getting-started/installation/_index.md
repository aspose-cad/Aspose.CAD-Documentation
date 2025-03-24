---
title: Kurulum
type: docs
weight: 30
url: /tr/net/getting-started/installation/
---

## **NuGet ile .NET için Aspose.CAD Kurulumu**

NuGet, .NET için Aspose API'lerini indirmek ve kurmak için en kolay yoldur. Microsoft Visual Studio ve NuGet paket yöneticisini açın. İstediğiniz Aspose API'sini bulmak için "aspose" kelimesini aratın. "Kur" butonuna tıklayın, seçilen API projenize indirilecektir ve referans olarak eklenecektir.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Bir .NET Projesinden Aspose.CAD'a Referans Verme**

Aşağıdaki adımları izleyin (Microsoft Visual Studio kullandığınızı varsayıyoruz):

1. **Çözüm Gezgini**'nde, bir referans eklemek istediğiniz proje düğümünü genişletin.
1. Proje için **Referanslar** düğümüne sağ tıklayın ve kısayol menüsünden **Referans Ekle**'yi seçin.
1. **Referans Ekle** iletişim kutusunda DLL dosyasının konumunu tarayın.
1. *Aspose.CAD* DLL dosyasını seçin ve **Tamam** butonuna tıklayın.
1. *Aspose.CAD* referansı projenizin **Referanslar** düğümünde görünecektir.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Paket Yöneticisi Konsolu kullanarak Aspose.CAD'ı Kurun veya Güncelleyin**

Paket yöneticisi konsolu kullanarak [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) 'na referans vermek için aşağıdaki adımları izleyebilirsiniz:

1. Visual Studio'da çözüm/projenizi açın.
1. Menüden Araçlar -> Kütüphane Paket Yöneticisi -> Paket Yöneticisi Konsolu'nu seçerek paket yöneticisi konsolunu açın.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

"**Install-Package Aspose.CAD**" komutunu yazın ve uygulamanıza son sürümü yüklemek için enter tuşuna basın. Alternatif olarak, en son sürümün yanı sıra sıcak düzeltmeleri de belirtmek için komuta "**-prerelease**" sonekini ekleyebilirsiniz.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

"Downloading Aspose.CAD..." ipucu, indirmenin işlemde olduğunu belirten bir mesaj olarak pencerenin sol alt kısmında görünecektir.

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

İndirildikten sonra aşağıdaki onay mesajlarını göreceksiniz. Eğer [Aspose EULA](https://about.aspose.com/legal/eula) ile tanışık değilseniz, belirtilen URL'deki lisansı okumanız iyi bir fikir olacaktır.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Artık Aspose.CAD'ın uygulamanıza başarıyla eklenip referans verildiğini göreceksiniz.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

Paket yöneticisi konsolunda, "Update-Package Aspose.CAD" komutunu kullanabilir ve enter tuşuna basarak Aspose.CAD paketinin güncellemelerini kontrol edebilir ve mevcutsa kurabilirsiniz. En son sürümü güncellemek için "-prerelease" sonekini de ekleyebilirsiniz.

## **Paylaşılan Sunucu Ortamında Çalışırken Dikkat Edilmesi Gerekenler**

Tüm Aspose .NET bileşenlerinin Tam Güven izin seti ile çalıştırılması önerilir. Bunun nedeni, Aspose .NET bileşenlerinin bazen sanal dizin dışında bulunan ayarlar ve dosyalara erişmesi gerektiğidir; örneğin, yazı tiplerini okumak gibi. Ayrıca, Aspose.NET bileşenleri, bazı durumlarda çalışmak için de Tam Güven iznine ihtiyaç duyan temel .NET sistem sınıflarına dayanmaktadır.

Farklı şirketlerin birden fazla uygulamasını barındıran İnternet Servis Sağlayıcıları genellikle Orta Güvenlik seviyesini uygularlar. .NET 2.0 durumunda, böyle bir güvenlik seviyesi aşağıdaki kısıtlamaları getirebilir ve bunun sonucunda Aspose.CAD'ın düzgün çalışabilme yeteneğini etkileyebilir.

- **RegistryPermission** mevcut değildir. Bu, yazdırılan belgelerin içindeki yüklü yazı tiplerini sıralamak için gereken kayıt defterine erişemeyeceğiniz anlamına gelir.
- **FileIOPermission** kısıtlıdır. Bu, yalnızca uygulamanızın sanal dizin hiyerarşisindeki dosyalara erişebileceğiniz anlamına gelir. Bu, yazı tiplerinin dışa aktarım sırasında okunamayacağı anlamına gelebilir.

Yukarıda belirtilen nedenlerden dolayı, Aspose.CAD'ın Tam Güven izinleri ile çalıştırılması önerilir. Orta güven ortamında farklı görevler yerine getirirken bazı kütüphane özelliklerinin çalışabileceğini görebilirsiniz, ancak bazı özelliklerin çalışamayabileceği (örneğin, görüntü işleme için GDI+ çağrıları nedeniyle) unutulmamalıdır.

## **Sistem Gereksinimleri**

### **İşletim Sistemleri**

Aspose.CAD, .NET veya Mono çerçevesinin kurulu olduğu her türlü 32-bit veya 64-bit işletim sistemini destekler; bunlar arasında, ancak bunlarla sınırlı olmamak üzere:

- Microsoft Windows masaüstü (XP, Vista, 7, 8, 10) ve sunucu işletim sistemleri (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS ve diğerleri)
- Mac OS X

### **Çerçeveler**

Aspose.CAD, .NET için:

- 2.0'dan 4.5'e kadar olan .NET Framework sürümlerini destekler (İstemci Profil sürümleri dahil)
- .NET Core
- Mono 2.6.7 veya sonraki sürümleri destekler

### **Geliştirme Ortamları**

Aspose.CAD'ı, .NET platformuna yönelik herhangi bir geliştirme ortamında uygulama geliştirmek için kullanabilirsiniz, ancak aşağıdaki ortamlar açıkça desteklenmektedir:

- Microsoft Visual Studio 2010 veya daha yüksek
- MonoDevelop 2.4 ve sonrası
