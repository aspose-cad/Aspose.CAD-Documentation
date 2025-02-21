---
title: Gambar FBX
type: docs
weight: 110
url: /id/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Ekspor Format FBX ke PDF**

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor file [FBX](https://docs.fileformat.com/3d/fbx/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [FBX](https://docs.fileformat.com/3d/fbx/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [FBX](https://docs.fileformat.com/3d/fbx/) menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **PageHeight** & **PageWidth**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **vector_rasterization_options**.
1. Panggil **Image.save** sambil mengoper objek dari **PdfOptions** sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
