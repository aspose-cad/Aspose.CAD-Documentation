---
title: Tambahkan entitas TEXT/MTEXT baru di sebelah entitas yang sudah ada
type: docs
weight: 17
url: /id/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Cara menambahkan entitas TEXT/MTEXT baru di sebelah entitas yang sudah ada**

**Masalah:** Cara menambahkan entitas TEXT/MTEXT baru di sebelah entitas yang sudah ada (CADNET-8172).

**Tip:** Untuk melakukan ini, buat objek CadBaseEntity, buat CadMText atau CadText dengan teks, di objek baru tambahkan cadImage.Layouts["Model"].BlockTableRecordHandle dari gambar dan tambahkan ke blok cadImage.BlockEntities[" *MODEL_SPACE"] dan tambahkan objek baru ke entitas gambar.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
