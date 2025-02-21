---
title: DWG dosyasını okuma, güncelleme ve yazma
type: docs
weight: 11
url: /tr/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **DWG dosyasını nasıl okur, günceller ve yazarız**

**Sorun:** DWG dosyasını nasıl okur, günceller ve yazarız.

**İpuçları:** Bunu yapmak için, load metodunu kullanarak dosyayı alabilir, gerekli varlıkları edinebilir ve bunlar üzerinde başlangıç ve bitiş noktalarını veya çizgilerin kalınlığını değiştirmek gibi değişiklikler yapabilirsiniz.

**Not:** Bu kod kesiti, bir dwg dosyasını okuma örneği, nesneleri değiştirme: çizgilerin, dairelerin, metin değerlerinin konumları (okuma/yazma desteklenen diğer nesneler ve bu nesnelerin değerleri için değişiklikler ekleyebilirsiniz) ve ardından yeni bir dosyaya kaydetme gösterir. Böylece AutoCAD'de yeni bir dosya açabilir ve değiştirilmiş değerlere sahip nesneleri görebilirsiniz.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
