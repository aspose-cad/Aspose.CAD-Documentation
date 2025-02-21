---
title: Gambar DXB
type: docs
weight: 90
url: /id/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Ekspor Format DXB ke PDF**

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor file DXB ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi DXB ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar DXB menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **vector_rasterization_options**.
1. Panggil **Image.save** sambil mengirimkan objek **PdfOptions** sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
