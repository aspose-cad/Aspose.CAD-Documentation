---
title: Pewarnaan sisipan dengan lapisan baru yang ditambahkan
type: docs
weight: 23
url: /id/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Cara mewarnai sisipan dengan lapisan baru yang ditambahkan (CADNET-1146)**

**Masalah:** Cara mewarnai sisipan dengan lapisan baru yang ditambahkan (CADNET-1146).

**Tips:** Untuk melakukan ini, gunakan kelas CadLayerTable untuk membuat lapisan agar dapat menambahkan lapisan baru ke gambar, Anda juga bisa menggunakan CadLayersList untuk menambahkan beberapa lapisan.

**Contoh:**

{{% alert color="primary" %}}

File awal berisi 5 sisipan dengan nama "1", "2", "3", "4" dan "5" dan semuanya berada di lapisan default 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
