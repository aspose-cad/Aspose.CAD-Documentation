---
title: Gambar COLLADA
type: docs
weight: 20
url: /id/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Men экспортирующий COLLADA Format ke PDF**

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor file [COLLADA](https://docs.fileformat.com/3d/dae/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [COLLADA](https://docs.fileformat.com/3d/dae/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [COLLADA](https://docs.fileformat.com/3d/dae/) menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **vector_rasterization_options**.
1. Panggil **Image.save** sambil meneruskan objek **PdfOptions** sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
