---
title: Harici referanslı resimlerin var olup olmadığını kontrol etme ve referansları değiştirme
type: docs
weight: 22
url: /tr/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Nesnelerdeki köprülerin nasıl düzenleneceği**

**Sorun:** Harici referanslı resimlerin var olup olmadığını nasıl kontrol edilir ve referanslar nasıl değiştirilir (CADNET-8088).

**İpuçları:** Bunu yapmak için, çizim öğelerinden CadObjectTypeName.IMAGEDEF türünde bir varlık alın ve kontrol etmek için CadRasterImageDef kullanın.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
