---
title: Periksa apakah gambar yang dirujuk secara eksternal ada dan ganti referensi
type: docs
weight: 22
url: /id/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Cara mengedit hyperlink pada objek**

**Masalah:** Cara memeriksa apakah gambar yang dirujuk secara eksternal ada dan ganti referensi (CADNET-8088).

**Tips:** Untuk melakukan ini, ambil entitas dengan tipe CadObjectTypeName.IMAGEDEF dari entitas gambar dan gunakan CadRasterImageDef untuk memeriksa.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
