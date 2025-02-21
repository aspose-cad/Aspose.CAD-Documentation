---
title: Başlığı Eklemek İçin Çizimi Aşağı Taşıma
type: docs
weight: 40
url: /tr/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Başlığı Eklemek İçin Çizimi Aşağı Taşıma**

**Sorun:** Çizimi aşağı taşımak için başlık ekleme (CADNET-980).

**İpuçları:** Bunu yapmak için, parametrelerle bir CadText nesnesi oluşturun, bu bloğu çizime ekleyin, ardından yeni boyutlarla çizimi UpdateSize ile güncelleyin, çizimin etrafında bir çerçeve olarak bir poligon ekleyin, poligonu BlockEntities["*Model_Space"]'e ekleyin ve tekrar UpdateSize ile güncelleyin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
