---
title: Polyline'ın genişliğini değiştirme 
type: docs
weight: 20
url: /tr/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Polyline'ın genişliğini nasıl değiştirilir**

**Sorun:** Polyline'ın genişliğini nasıl değiştirebiliriz (CADNET-459-460).

**İpuçları:** CadBaseEntity'de genişliği değiştirmek için (eğer tip CadEntityTypeName.LWPOLYLINE ise) (entity as CadLwPolyline).ConstantWidth = 2 veya normal varlıklar için LineWeight kullanın.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
