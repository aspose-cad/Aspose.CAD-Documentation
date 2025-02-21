---
title: Menyisipkan gambar DXF/DWG ke dalam DWG
type: docs
weight: 38
url: /id/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Cara menyisipkan gambar DXF/DWG ke dalam DWG**

**Masalah:** Cara menyisipkan gambar DXF/DWG ke dalam DWG.

**Tips:** Untuk melakukan ini, pertama buat CadInsertObject dengan nilai yang diperlukan, kemudian dapatkan semua blok dalam CadBlockDictionary, buat blok CadBlockEntity baru dan tambahkan ke CadBlockDictionary, tambahkan CadBlockDictionary ke BlockEntities dari gambar, tambahkan CadInsertObject ke entitas gambar untuk array, buat CadBlockTableObject berdasarkan referensi, kemudian tambahkan blok ke gambar.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
