---
title: Gambar DRC
type: docs
weight: 40
url: /id/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Ekspor Format DRC ke PDF**

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor berkas [DRC](https://docs.fileformat.com/3d/drc/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [DRC](https://docs.fileformat.com/3d/drc/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat berkas gambar DRC menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **VectorRasterizationOptions**.
1. Panggil **Image.save** sambil meneruskan objek **PdfOptions** sebagai parameter kedua.

## Contoh Kode


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
