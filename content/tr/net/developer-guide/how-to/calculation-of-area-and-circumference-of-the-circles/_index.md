---
title: Dairelerin alanını ve çevresini hesaplama
type: docs
weight: 18
url: /tr/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Dairelerin alanını ve çevresini nasıl hesaplayabilirsiniz**

**Sorun:** Dairelerin alanını ve çevresini nasıl hesaplayabilirsiniz (CADNET-1153).

**İpuçları:** Bunu yapmak için, varlıklardan CadEntityTypeName.CIRCLE'dan yarıçapı alın ve **"2 * Math.PI * radius"** formülünü kullanın.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
