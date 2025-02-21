---
title: Sadece bazı katmanların yeniden ölçeklendirme ile dışa aktarılması 
type: docs
weight: 31
url: /tr/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **Sadece bazı katmanların yeniden ölçeklendirme ile dışa aktarılması (CADNET-559)**

**Sorun:** Sadece bazı katmanların yeniden ölçeklendirme ile nasıl dışa aktarılacağı (CADNET-559).

**İpuçları:** Bunu yapmak için gerekli katmanları seçin, bunları CadBaseEntity dizisine ekleyin, ardından onları çizim varlıklarına atayın ve UpdateSize işlevini gerçekleştirin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
