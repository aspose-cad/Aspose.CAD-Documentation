---
title: Gambar SVG
type: docs
weight: 170
url: /id/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Mengekspor Format SVG ke PDF**

Aspose.CAD untuk Python memungkinkan pengembang untuk mengekspor file [SVG](https://docs.fileformat.com/page-description-language/svg/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [SVG](https://docs.fileformat.com/page-description-language/svg/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar SVG menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **VectorRasterizationOptions**.
1. Panggil **Image.save** sambil meneruskan objek **PdfOptions** sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
