---
title: Buat persegi panjang sebagai poligon dan isi dengan pola
type: docs
weight: 24
url: /id/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Cara membuat persegi panjang sebagai poligon dan mengisinya dengan pola**

**Masalah:** Cara membuat persegi panjang sebagai poligon dan mengisinya dengan pola (CADNET-1351).

**Tips:** Untuk melakukan ini, buat CadLwPolyline dan tambahkan koordinat titik ke dalamnya, gunakan CadHatch untuk bekerja dengan warna dan gunakan CadEdgeBoundaryPath untuk menghubungkan, gunakan CadHatch untuk bekerja dengan sudut dan CadHatchPatternData untuk pola.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
