---
title: Kapak köken noktası daha iyi performans için kapak sınırına yaklaştırma
type: docs
weight: 41
url: /tr/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Kapak köken noktasını kapak sınırına daha iyi performans için nasıl yaklaştırılır**

**Sorun:** Kapak köken noktasını kapak sınırına daha iyi performans için nasıl yaklaştırılır (CADNET-1340).

**İpuçları:** Bunu yapmak için, çizimden CadHatch varlıklarını alın, gerekli noktaları Point2D ile ayarlayın, mesafeyi hesaplayın ve CadHatchPatternData'da X ve Y için LineBasePoint'i ayarlayın.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
