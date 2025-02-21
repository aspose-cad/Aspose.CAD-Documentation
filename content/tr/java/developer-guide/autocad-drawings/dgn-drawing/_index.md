---
title: DGN Çizimi
type: docs
weight: 10
url: /tr/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **DWG'nin Bir Parçası Olarak DGN Formatını Çizme**

Aspose.CAD for Java, geliştiricilerin içinde gömülü DGN alt katmanı olan bir DWG dosyasını dışa aktarmasına olanak tanır. Aşağıda, DWG dosyasını dışa aktarırken bir DWG dosyasının içindeki DGN alt katmanına nasıl erişileceğini gösteren kod bulunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **DGN v7 için 3D varlık desteği**

Aspose.CAD for Java API, bir DGN AutoCAD dosyasını yükleme yeteneği eklemiş ve DGN v7 için 3D varlıkları desteklemiştir. [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) sınıfı bu amaçla kullanılır. Her DGN görüntüsü 9 ön tanımlı görünümü destekler. 1'den 9'a kadar numaralandırılmıştır. Dışa aktarımda görünüm tanımlanmadıysa, çok sayfalı çıktı formatları (PDF gibi) için tüm görünümler ayrı bir sayfada dışa aktarılacaktır. 3D varlıklar DGN dosya formatında, aynı zamanda 2D'yi de desteklemektedir.
VectorRasterizationOptions.TypeOfEntities artık DGN formatı için kullanılmamaktadır (hem 2D hem de 3D aynı anda desteklenmektedir).

Desteklenen DGN öğelerini görmek için örnek kod.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
