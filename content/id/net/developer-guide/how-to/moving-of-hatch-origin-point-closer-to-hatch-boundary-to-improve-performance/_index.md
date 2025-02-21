---
title: Memindahkan titik asal hatch lebih dekat ke batas hatch untuk meningkatkan kinerja
type: docs
weight: 41
url: /id/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Cara memindahkan titik asal hatch lebih dekat ke batas hatch untuk meningkatkan kinerja**

**Masalah:** Cara memindahkan titik asal hatch lebih dekat ke batas hatch untuk meningkatkan kinerja (CADNET-1340).

**Tips:** Untuk melakukan ini, ambil entitas CadHatch dari gambar, setel titik yang diperlukan dengan Point2D, hitung jarak dan di CadHatchPatternData setel LineBasePoint untuk X dan Y.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
