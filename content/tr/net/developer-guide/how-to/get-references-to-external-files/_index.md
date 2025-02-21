---
title: Harici dosyalara referanslar alma
type: docs
weight: 36
url: /tr/net/developer-guide/how-to/get-references-to-external-files/
---

## **Harici dosyalara referanslar nasıl alınır**

**Sorun:** Harici dosyalara referanslar nasıl alınır (CADNET-110).

**İpuçları:** Varlık bloğundaki çizimler için harici dosyalara referanslar almak üzere raster görüntüler için bir XRef PathName alanı vardır. Harici altlık için CadRasterImage Def kullanılır, CadDgnUnderlay kullanılır ve onun UnderlayPath alanı.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
