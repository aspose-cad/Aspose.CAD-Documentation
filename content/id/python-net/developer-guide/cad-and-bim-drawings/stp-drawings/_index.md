---
title: Gambar STP
type: docs
weight: 160
url: /id/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## ** Mengekspor Format STP ke PDF **

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor file [STP](https://docs.fileformat.com/3d/stp/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [STP](https://docs.fileformat.com/3d/stp/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Memuat file gambar [STP](https://docs.fileformat.com/3d/stp/) menggunakan metode pabrik **Image.load**.
1. Membuat objek dari kelas **CadRasterizationOptions** dan mengatur properti **page_height** & **page_width**.
1. Membuat objek dari kelas **PdfOptions** dan mengatur properti **vector_rasterization_options**.
1. Memanggil **Image.save** dengan melewatkan objek **PdfOptions** sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
