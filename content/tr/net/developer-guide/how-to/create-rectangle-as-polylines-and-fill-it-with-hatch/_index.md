---
title: Polylineler olarak dikdörtgen oluştur ve dolgulu hale getir
type: docs
weight: 24
url: /tr/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Polylineler olarak dikdörtgen oluştur ve dolgulu hale getir**

**Sorun:** Polylineler olarak dikdörtgen oluşturma ve dolgulu hale getirme (CADNET-1351).

**İpuçları:** Bunu yapmak için bir CadLwPolyline oluşturun ve ona nokta koordinatları ekleyin, renk ile çalışmak için CadHatch kullanın ve bağlantı kurmak için CadEdgeBoundaryPath'ı kullanın, açılarla çalışmak için CadHatch kullanın ve desen için CadHatchPatternData kullanın.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
