---
title: SHX fontlarını Dışa Aktarma
type: docs
weight: 40
url: /tr/java/developer-guide/export-shx-fonts/
---

## **DXF/DWG çizimleri için SHX fontlarını Dışa Aktarma**

Bazı çizimler, fontun sembollerini şekil biçiminde depolayan özel SHX formatında fontlar içerebilir.
Bu format, çizimde kullanılan her font için ek bir yükleme prosedürü gerektirir.
Apose.CAD, SHX ile yazılmış metinlere sahip çizimleri dışa aktarabilir ve bunu yapmak için farklı seçeneklere sahiptir.
Bunu yapmanın en basit yolu, [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesinin [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) özelliğini kullanmaktır.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Her SHX fontu ile ilişkili uygun bir kod sayfası gelir. Bu ilişkiler bilinir ve tanınmış SHX fontları için Aspose.CAD'e kısmen yerleştirilmiştir.
Eğer özel bir SHX fontu kullanılıyorsa, **setShxCodePages** özelliğini uygulamak ve SHX dosyasına giden yol ile ilgili kod sayfasını ayarlamak mümkündür.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
