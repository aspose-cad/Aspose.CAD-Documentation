---
title: Gambar DWG
type: docs
weight: 70
url: /id/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Ekspor Gambar DWG ke PDF**

Aspose.CAD untuk API Python dapat memuat gambar AutoCAD dalam format [DWG](https://docs.fileformat.com/cad/dwg/) dan mengkonversinya menjadi [PDF](https://docs.fileformat.com/pdf/). Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi DWG ke format PDF melalui langkah-langkah sederhana seperti yang dijelaskan di depan.

{{% alert color="primary" %}}

API mendukung revisi DWG AutoCAD berikut:

- DWG versi 2004 rilis 16.0 versi 18
- DWG versi 2005 versi 16.1
- DWG versi 2010 versi 18.0
- DWG versi 2013 versi 19.0

{{% /alert %}}

### **Format File DWG**

Sebuah [DWG](https://docs.fileformat.com/cad/dwg/) adalah file biner yang berisi data gambar vektor dan metadata. Data gambar vektor memberikan instruksi kepada aplikasi CAD tentang cara menampilkan DWG; metadata dapat berisi berbagai informasi tentang file termasuk data spesifik lokasi dan juga data klien. Spesifikasi terbuka untuk format file DWG dapat ditemukan [di PDF ini](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Mengonversi File DWG ke PDF**

Langkah-langkah sederhana berikut diperlukan untuk mengonversi [DWG](https://docs.fileformat.com/cad/dwg/) ke [PDF](https://docs.fileformat.com/pdf/).

1. Muat file DWG ke dalam instance **Image**.
1. Buat objek dari kelas **CadRasterizationOptions** dan atur properti **page_height** & **page_width**.
1. Buat objek dari kelas **PdfOptions** dan atur properti **VectorRasterizationOptions**.
1. Panggil **Image.save** sambil menyerahkan objek **PdfOptions** sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengekspor Gambar DWG ke PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Primitif AutoCAD yang Didukung**

Primitif AutoCAD berikut didukung.

- TEKS
- MTEXT
- ATTDEF
- ATTRIB
- ARK
- ELLIPSE
- HATCH
- PEMIMPIN
- TITIK
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSI ORDINAT
- DIMENSI LINIER
- DIMENSI TERHUBUNG
- DIMENSI ANG 3Pt
- DIMENSI ANG 2Ln
- DIMENSI JARAK
- DIMENSI DIAMETER
- BENTUK
- PADAT
- SPLINE
- MLINE
- GARIS
- XLINE
- GAYA
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Ekspor Layout DWG Spesifik ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik **Aspose.CAD.Image.load**.
1. Buat instance dari kelas **CadRasterizationOptions** dan atur tinggi dan lebar halaman hasil.
1. Atur properti **Layouts** untuk objek **CadRasterizationOptions**.
1. Buat instance dari kelas **PdfOptions** dan atur properti **VectorRasterizationOptions**-nya.
1. Ekspor gambar ke PDF menggunakan metode **Image.save()**.

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi layout spesifik DWG ke PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Ekspor DWG ke PDF/A dan PDF/E**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik **Image.load**.
1. Buat instance dari kelas **CadRasterizationOptions**.
1. Buat instance dari kelas **PdfOptions** dan atur properti **VectorRasterizationOptions**-nya.
1. Atur properti kepatuhan PDF dan simpan.
1. Ekspor gambar ke PDF menggunakan metode **Image.save()**.

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file DWG ke PDF/A dan PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Mengonversi Gambar DWG ke DXF**

Aspose.CAD menyediakan fitur untuk memuat file DWG AutoCAD dan mengekspornya ke format DXF. Pendekatan konversi DWG ke DXF bekerja sebagai berikut:

1. Muat file gambar DWG menggunakan metode pabrik **Image.load**.
1. Ekspor gambar DWG ke DXF menggunakan metode **Image.save()**.

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file DWG ke format DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Mengonversi Gambar DWG ke SVG**

Aspose.CAD untuk API Python dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya menjadi SVG. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi DWG ke format SVG melalui langkah-langkah sederhana seperti yang dijelaskan di bawah.

1. Muat file DWG ke dalam instance **Image**.
1. Buat objek dari kelas **SvgOptions** dan atur properti yang diperlukan.
1. Ekspor gambar DWG ke SVG menggunakan metode **Image.save()**.

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file DWG ke format SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
