---
title: Pindahkan gambar ke bawah untuk menambahkan judul
type: docs
weight: 40
url: /id/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Cara memindahkan gambar ke bawah untuk menambahkan judul**

**Masalah:** Cara memindahkan gambar ke bawah untuk menambahkan judul (CADNET-980).

**Tips:** Untuk melakukan ini, buat objek CadText dengan parameter, tambahkan blok ini ke gambar, kemudian perbarui gambar dengan ukuran baru menggunakan UpdateSize, tambahkan polyline yang merupakan bingkai di sekitar gambar, tambahkan polyline ke BlockEntities["*Model_Space"] dan perbarui lagi dengan UpdateSize.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
