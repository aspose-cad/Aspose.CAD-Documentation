---
title: Penambahan gambar sebagai latar belakang ke DWG
type: docs
weight: 15
url: /id/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Cara menambahkan gambar sebagai latar belakang di DWG**

**Isu:** Cara menambahkan gambar sebagai latar belakang di DWG.

**Tips:** Untuk melakukan ini, buat objek CadRasterImageDef untuk gambar latar belakang, buat objek CadRasterImage untuk menyisipkan latar belakang untuk gambar, tambahkan objek CadRasterImage ke objek gambar, buat objek CadBaseObject dan tambahkan ke cadImage.Objects, proses semuanya melalui CadBlockTableObject.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
