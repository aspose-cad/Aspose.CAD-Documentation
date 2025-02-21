---
title: DWG Arka Planına Görüntü Ekleme
type: docs
weight: 15
url: /tr/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **DWG'ye arka plan olarak bir görüntü nasıl eklenir**

**Sorun:** DWG'ye arka plan olarak bir görüntü nasıl eklenir.

**İpuçları:** Bunu yapmak için, arka plan görüntüsü için bir CadRasterImageDef nesnesi oluşturun, çizim için arka planı eklemek üzere bir CadRasterImage nesnesi oluşturun, bir CadRasterImage nesnesini çizim nesnelerine ekleyin, bir CadBaseObject CadBaseObject oluşturun ve bunu cadImage.Objects'a ekleyin, her şeyi CadBlockTableObject aracılığıyla işleyin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
