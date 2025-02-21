---
title: Baca, perbarui, dan tulis file DWG
type: docs
weight: 11
url: /id/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Cara membaca, memperbarui, dan menulis file DWG**

**Masalah:** Cara membaca, memperbarui, dan menulis file DWG.

**Tips:** Untuk melakukan ini, Anda dapat mengambil file menggunakan metode load, mendapatkan entitas yang diperlukan dan melakukan perubahan pada mereka, seperti mengubah titik awal dan akhir atau ketebalan garis.

**Catatan:** Potongan kode ini menunjukkan contoh membaca file dwg, mengubah objek: posisi garis, lingkaran, nilai teks (Anda dapat menambahkan perubahan pada objek lain dan nilai mereka yang didukung untuk dibaca/ditulis) dan kemudian menyimpan di file baru. Jadi Anda dapat membuka file baru di AutoCAD dan melihat objek dengan nilai yang diubah.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
