---
title: Gambar DWF
type: docs
weight: 50
url: /id/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Mengekspor Gambar DWF ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar [DWF](https://docs.fileformat.com/cad/dwf/) AutoCAD dan merendernya sebagai gambar utuh ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [DWF](https://docs.fileformat.com/cad/dwf/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **vector_rasterization_options**.
1. Panggil **Image.save** sambil mengoper objek **PdfOptions** sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Mengekspor Gambar DWF ke BMP**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar [DWF](https://docs.fileformat.com/cad/dwf/) AutoCAD dan merendernya sebagai gambar utuh ke format [BMP](https://docs.fileformat.com/image/bmp/). Pendekatan konversi [DWF](https://docs.fileformat.com/cad/dwf/) ke [BMP](https://docs.fileformat.com/image/bmp/) bekerja sebagai berikut:

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik **Image.load**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **BmpOptions** dan atur properti **vector_rasterization_options**.
1. Panggil **Image.save** sambil mengoper objek **BmpOptions** sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan cara mengonversi file [DWF](https://docs.fileformat.com/cad/dwf/) ke [BMP](https://docs.fileformat.com/image/bmp/) menggunakan pengaturan default.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
