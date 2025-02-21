---
title: DGN AutoCAD'ı Dışa Aktarma
type: docs
weight: 50
url: /tr/python-net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD Formatını PDF'ye Dışa Aktarma**

Aspose.CAD for Python API, bir DGN AutoCAD dosyasını yükleme ve PDF formatına dönüştürme işlevselliğini tanıttı. **CadImage** sınıfı bu amaca hizmet eder.

Mevcut bir DGN dosyasını **CadImage** olarak yüklemeniz gerekir. **CadRasterizationOptions** sınıfının bir örneğini oluşturun ve farklı özellikleri ayarlayın. **PdfOptions** sınıfının bir örneğini oluşturun ve **CadRasterizationOptions** örneğini geçirin. Şimdi **CadImage** sınıfı örneğinin **save** yöntemini çağırın.

### Örnek Kod

Aşağıda, [DGN](https://docs.fileformat.com/cad/dgn/) formatını [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürme/dışa aktarma işlemini gösteren kod yer almaktadır.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **DGN AutoCAD Formatını Raster Görüntü Formatına Dışa Aktarma**

Aspose.CAD for Python API, bir DGN AutoCAD dosyasını yükleme ve raster bir görüntüye dönüştürme işlevselliğini tanıttı. **CadImage** sınıfı bu amaca hizmet eder.

Mevcut bir DGN dosyasını **CadImage** olarak yüklemeniz gerekir. **CadRasterizationOptions** sınıfının bir örneğini oluşturun ve farklı özellikleri ayarlayın. **JpegOptions** sınıfının bir örneğini oluşturun ve **CadRasterizationOptions** örneğini geçirin. Şimdi **CadImage** sınıfı örneğinin **save** yöntemini çağırın.

### Örnek Kod

Aşağıda, [DGN](https://docs.fileformat.com/cad/dgn/) formatını [JPEG](https://docs.fileformat.com/image/jpeg/) görüntüsüne dönüştürme/dışa aktarma işlemini gösteren kod yer almaktadır.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **DGN v7 için 3D varlık desteği**

Aspose.CAD for Python API, bir [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dosyasını yükleme ve DGN v7 için 3D varlık desteği tanıtma işlevselliğini ekledi. **CadImage** sınıfı bu amaca hizmet eder. Her [DGN](https://docs.fileformat.com/cad/dgn/) görüntüsü 9 ön tanımlı görüntüyü destekler. Bu, 1'den 9'a kadar numaralandırılmıştır. Dışa aktarımda görüntü tanımlanmazsa, çok sayfalı çıktı formatları (PDF gibi) için tüm görüntüler dışa aktarılacak, her biri ayrı bir sayfada olacaktır. DGN dosya formatında 3D varlıklar desteklenmektedir; ayrıca 2D varlıklar da desteklenir. Bunun için **VectorRasterizationOptions** kullanılır, TypeOfEntities artık DGN formatında kullanılmamaktadır (hem 2D hem de 3D aynı anda desteklenmektedir).

### Örnek Kod

Desteklenen DGN öğelerini incelemek için aşağıdaki örnek kod yer almaktadır.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
