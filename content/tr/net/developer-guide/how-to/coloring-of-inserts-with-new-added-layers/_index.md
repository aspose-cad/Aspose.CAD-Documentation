---
title: Yeni Eklenen Katmanlarla Eklemleri Renklendirme
type: docs
weight: 23
url: /tr/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Yeni Eklenen Katmanlarla Eklemleri Renklendirme (CADNET-1146)**

**Sorun:** Yeni eklenen katmanlarla eklemleri nasıl renklendireceğim (CADNET-1146).

**İpuçları:** Bunu yapmak için, yeni bir katmanı çizime eklemek için CadLayerTable sınıfını kullanın, birden fazla katman eklemek için CadLayersList'i de kullanabilirsiniz.

**Örnek:**

{{% alert color="primary" %}}

İlk dosya, "1", "2", "3", "4" ve "5" adlarına sahip 5 ek içerir ve bunların hepsi varsayılan 0 katmanında bulunmaktadır.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
