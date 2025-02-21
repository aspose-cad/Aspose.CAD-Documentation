---
title: DWG/DXF çizimlerini ve yerleşimlerini belirli boyuta dışa aktarma
type: docs
weight: 40
url: /tr/java/developer-guide/export-into-size/
---

## **Modeli ve tüm yerleşimleri A4 PDF boyutuna dışa aktarma**

Aspose.CAD API'si, DWG/DXF dosyasının tüm sayfalarını belirli fiziksel PDF boyutuna dışa aktarmanıza olanak tanır. 
Aşağıdaki örnek kod, istenen PDF boyutunu elde etmek için [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) nesnesinin boyutunu ayarlar. 
A4 kağıt sayfasının boyutu 210x297 milimetre veya 8.27x11.69 inçtir ve bu değerler kodda kullanılmıştır.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **CAD Yerleşimlerini Farklı Boyutlarda PDF'ye Dışa Aktarma**

Bazen yerleşimi fiziksel boyutunda dışa aktarmak gerekebilir. Aşağıdaki örnek, her sayfası yerleşim içeriği ile birlikte kendi fiziksel PDF boyutuna sahip olan çok sayfalı bir PDF'ye çizimin dışa aktarımını göstermektedir. Bu örnek, [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) özelliğini kullanır.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
