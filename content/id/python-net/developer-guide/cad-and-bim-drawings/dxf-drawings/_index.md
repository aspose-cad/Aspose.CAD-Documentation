---
title: Gambar DXF
type: docs
weight: 10
url: /id/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Mengekspor Gambar DXF ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar DXF AutoCAD dan merendernya sebagai gambar seluruhnya ke format PDF. Pendekatan konversi DXF ke PDF bekerja sebagai berikut:

1. Memuat file gambar DXF menggunakan metode pabrik **Image.load**.
1. Membuat objek dari kelas **CadRasterizationOptions** dan mengatur properti **page_height** & **page_width**.
1. Membuat objek dari kelas **PdfOptions** dan mengatur properti **VectorRasterizationOptions**.
1. Memanggil **Image.save** dengan melewatkan objek **PdfOptions** sebagai parameter kedua.

Cuplikan kode di bawah ini menunjukkan cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Format yang Didukung**

Saat ini kami sepenuhnya mendukung format file AutoCAD DXF 2010. Versi DXF sebelumnya tidak dijamin 100% valid. Kami berencana untuk memasukkan lebih banyak format dan fitur di versi Aspose.CAD mendatang.

### **Entitas yang Didukung**

Saat ini kami mendukung semua entitas 2D yang umum dan parameter default dasarnya sebagai berikut:

1. Dimensi Terpadu
1. Dimensi Sudut
1. Busur
1. Atribut
1. Referensi Blok
1. Lingkaran
1. Dimensi Diameter
1. Elips
1. Isian
1. Garis
1. Teks Multigaris
1. Dimensi Ordinat
1. Titik
1. Poligon
1. Dimensi Radial
1. Sinar
1. Dimensi Berputar
1. Tabel
1. Teks
1. Garis X

{{% alert color="primary" %}}

Jika selama pemrosesan kami menemukan entitas atau properti yang tidak kami dukung, entitas atau properti tersebut akan diabaikan tanpa pemberitahuan.

{{% /alert %}}

## **Ekspor DGN Bundled untuk format DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD dan mengekspor DGN yang terbenam untuk format DXF.

Cuplikan kode di bawah ini menunjukkan cara memenuhi persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Dukungan untuk Menyimpan File DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD, melakukan perubahan di dalamnya, dan menyimpannya lagi sebagai file DXF.

Cuplikan kode di bawah ini menunjukkan cara memenuhi persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Ekspor DXF ke WMF**

Pendekatan ini bekerja sebagai berikut:

1. Memuat file gambar DXF menggunakan metode pabrik **Image.load**.
1. Membuat objek dari kelas **CadRasterizationOptions** dan memuat file PDF.
1. Mengatur properti **page_height** & **page_width**.
1. Memanggil **Image.save** dan menyimpan file.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
