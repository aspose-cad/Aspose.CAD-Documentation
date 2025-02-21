---
title: Memasukkan gambar DXF/DWG ke dalam DXF
type: docs
weight: 39
url: /id/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Cara memasukkan gambar DXF/DWG ke dalam DXF**

**Masalah:** Cara memasukkan gambar DXF/DWG ke dalam DXF.

**Tips:** Untuk melakukan ini, Anda harus terlebih dahulu membuat CadInsertObject dengan nilai yang diperlukan, kemudian mengambil semua blok di CadBlockDictionary, membuat blok CadBlockEntity baru dan menambahkannya ke CadBlockDictionary, menambahkan CadBlockDictionary ke BlockEntities dari gambar, menambahkan CadInsertObject ke entitas gambar untuk array.

**Contoh:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
