---
title: SHX yazı tiplerini dışa aktarma
type: docs
weight: 40
url: /tr/net/developer-guide/export-shx-fonts/
---

## **DXF/DWG çizimleri için SHX yazı tiplerini dışa aktarma**

Bazı çizimler, yazı tipinin sembollerini şekil olarak saklayan özel SHX formatında yazı tipleri içerebilir. Bu format, çizimde kullanılan her yazı tipi için ek bir yükleme prosedürü gerektirir. Apose.CAD, SHX ile yazılmış metin içeren çizimleri dışa aktarabilir ve bunu yapmak için farklı seçeneklere sahiptir. Bunu yapmanın en basit yolu, 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) nesnesinin 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) özelliğini kullanmaktır.

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts örneği.cs">}}

Aşağıdaki örnekle birden fazla SHX yazı tipi için tüm yolları ayarlamaktan kaçınılması mümkündür:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Folder ile ShxFonts örneği.cs">}}
	
Her SHX yazı tipi ile ilişkili uygun bir kod sayfası gelir. Bu ilişkiler bilinen SHX yazı tipleri için bilinir ve kısmen Apose.CAD içine gömülüdür. Özel bir SHX yazı tipi kullanıldığında, ShxCodePages özelliğini uygulamak ve SHX dosyasının yolunu ve ilgili kod sayfasını ayarlamak mümkündür.

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages örneği.cs">}}
