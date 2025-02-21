---
title: Bekerja dengan Teks
type: docs
weight: 40
url: /id/net/developer-guide/drawing-api/work-with-text/
---

## **Bekerja dengan Teks**

Hampir semua gambar mengandung objek teks dan contoh-contoh ini menunjukkan cara melakukan operasi dengannya. 
Ada berbagai jenis entitas untuk DWG/DXF yang dapat menyimpan teks, yaitu [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Dua jenis terakhir biasanya terkait 
dengan [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
dan disimpan di dalamnya atau di blok yang sesuai.

Berikut adalah beberapa contoh yang menggambarkan operasi dengan teks.

### **Mencari teks**

Contoh ini menunjukkan cara menemukan nilai teks dalam file DWG/DXF dan dapat juga digunakan untuk menggantikan nilai teks.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Menambahkan item Teks dan MText baru**

Ini adalah contoh cara menambahkan objek Teks/Mtext baru ke gambar. Penambahan entitas baru dapat mengubah ukuran gambar, jadi disarankan
untuk memanggil UpdateSize() setelah operasi ini.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
