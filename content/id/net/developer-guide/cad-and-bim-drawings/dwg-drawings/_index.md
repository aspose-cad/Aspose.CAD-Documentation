---
title: Gambar DWG
type: docs
weight: 40
url: /id/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Ekspor Gambar DWG ke PDF**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format [DWG](https://docs.fileformat.com/cad/dwg/) dan mengkonversinya ke [PDF](https://docs.fileformat.com/pdf/). Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi DWG ke format PDF melalui langkah-langkah sederhana seperti yang ditentukan di bawah ini.

{{% alert color="primary" %}}

API mendukung revisi DWG AutoCAD berikut:

- Versi DWG 2004 versi 16.0 rilis 18
- Versi DWG 2005 versi 16.1
- Versi DWG 2010 versi 18.0
- Versi DWG 2013 versi 19.0

{{% /alert %}}

### **Format File DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) adalah file biner yang berisi data gambar vektor dan metadata. Data gambar vektor memberikan instruksi kepada aplikasi CAD tentang cara menampilkan DWG; metadata dapat berisi berbagai informasi tentang file termasuk data spesifik lokasi dan juga data klien. Spesifikasi terbuka untuk format file DWG dapat ditemukan [dalam PDF ini](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Mengonversi File DWG ke PDF**

Langkah-langkah sederhana berikut diperlukan untuk mengonversi [DWG](https://docs.fileformat.com/cad/dwg/) ke [PDF](https://docs.fileformat.com/pdf/).

1. Muat file DWG menjadi instance dari [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) sambil meneruskan objek dari [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengekspor Gambar DWG ke PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Membuat PDF Tunggal dengan Ukuran Tata Letak Berbeda**

Aspose.CAD untuk .NET memungkinkan Anda untuk mengonversi file DWG menjadi PDF tunggal dengan ukuran tata letak yang berbeda. Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur tinggi dan lebar halaman hasil.
1. Tambahkan [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) yang diperlukan untuk objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Ekspor gambar ke PDF menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara membuat satu [PDF](https://docs.fileformat.com/pdf/) dengan tata letak yang berbeda.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Primitif AutoCAD yang Didukung**

Primitif AutoCAD berikut didukung.

- TEKS
- MTEXT
- ATTDEF
- ATTRIB
- BUSUR
- ELLIPSE
- HATCH
- LEADER
- TITIK
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- SINAR
- BULAT
- DIMENSI ORDINAT
- DIMENSI LINEAR
- DIMENSI SEJALUR
- DIMENSI ANG 3Pt
- DIMENSI ANG 2Ln
- DIMENSI JARI-JARI
- DIMENSI DIAMETER
- BENTUK
- PADAT
- SPLINE
- MLINE
- GARIS
- XLINE
- GAYA
- DIMSTYLE
- LTIPE
- GAYA MLINE
- LAPIS
- VIEWPORT
- TATA LETAK

## **Ekspor Tata Letak DWG Tertentu ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur tinggi dan lebar halaman hasil.
1. Atur properti [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) untuk objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Ekspor gambar ke PDF menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara mengonversi tata letak DWG tertentu ke PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Render dokumen DWG dengan menentukan koordinat**

Aspose.CAD untuk .NET API kini menyediakan fitur untuk merender dokumen DWG dengan memberikan koordinat lebar dan tinggi dokumen.

Contoh kode di bawah ini menunjukkan cara me-render dokumen DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Ekspor DWG ke Raster atau PDF menggunakan Ukuran Tetap**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG, dan mengkonversinya ke PDF atau Raster menggunakan ukuran tetap.

Contoh kode di bawah ini menunjukkan cara mengimplementasikan fitur ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Ekspor DWG ke PDF/A dan PDF/E**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Atur properti kepatuhan PDF dan simpan.
1. Ekspor gambar ke PDF menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara mengonversi file DWG ke PDF/A dan PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Dukungan untuk garis tersembunyi membulat saat mengekspor DWG/DXF ke BMP dan PDF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur tinggi dan lebar halaman hasil.
1. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Ekspor gambar ke PDF menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara mengimplementasikan fitur ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Dukungan untuk menetapkan area cetak untuk gambar DWG dalam PDF yang diekspor**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG, dan mengkonversinya ke PDF. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai dukungan menetapkan area cetak untuk gambar DWG dalam PDF yang diekspor.

Contoh kode di bawah ini menunjukkan cara mengimplementasikan fitur ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Dukungan untuk membaca metadata XREF untuk file DWG**

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Telusuri setiap entitas gambar.
1. Jika entitas tersebut adalah CadUnderlay, maka entitas XREF dengan metadata.

Contoh kode di bawah ini menunjukkan cara mencapai fitur ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) adalah dari tipe array string sehingga Anda dapat menentukan lebih dari satu tata letak sekaligus untuk konversi ke format PDF yang mungkin. Saat menentukan beberapa tata letak untuk properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), PDF hasilnya akan memiliki beberapa halaman, di mana setiap halaman mewakili tata letak AutoCAD individual.

### **Daftar Semua Tata Letak**

Anda dapat mencantumkan semua tata letak yang ada dalam gambar AutoCAD menggunakan cuplikan kode berikut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Mengakses Bendera Underlay untuk Format DWG**

Aspose.CAD untuk .NET telah mengimplementasikan bendera underlay untuk format DWG dan memungkinkan pengembang untuk mengaksesnya. Berikut adalah demonstrasi kode yang sederhana.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Dukungan untuk Entitas DWG**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan.

### **Dukungan untuk Entitas MLeader**

DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan contoh bekerja dengan entitas MLeader di dalam file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Dukungan untuk Ekspor Entitas DWG ke Gambar**

DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan contoh mengekspor entitas DWG tertentu ke dalam gambar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Dukungan untuk Menambahkan Teks di DWG**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan. DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan bagaimana kita dapat menambahkan teks di dalam file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Dukungan untuk Mengimpor Gambar ke File DWG**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan. DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan bagaimana kita dapat mengimpor gambar ke dalam file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Dukungan untuk Mesh dalam DWG**

Aspose.CAD untuk .NET API kini dapat mengakses entitas yang mendukung mesh yang mencakup tipe [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) dan [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Contoh berikut menjelaskan bagaimana kita dapat mengakses tipe mesh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Mengonversi Gambar DWG ke DXF**

Aspose.CAD menyediakan fitur untuk memuat file DWG AutoCAD dan mengekspornya ke format DXF. Pendekatan konversi DWG ke DXF bekerja sebagai berikut:

1. Muat file gambar DWG menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Ekspor gambar DWG ke DXF menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara mengonversi file DWG ke format DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Mengonversi Gambar DWG ke SVG**

Aspose.CAD untuk .NET API dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya ke SVG. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi DWG ke format SVG melalui langkah-langkah sederhana seperti yang ditentukan di bawah ini.

1. Muat file DWG menjadi instance dari [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Buat objek dari kelas [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) dan atur properti yang diperlukan.
1. Ekspor gambar DWG ke SVG menggunakan metode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah ini menunjukkan cara mengonversi file DWG ke format SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Muat File DWG Besar**

Aspose.CAD untuk .NET memberikan fasilitas untuk membuka file DWG yang sangat besar menggunakan kelas [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Sekarang Anda dapat dengan mudah membuka file besar dengan bantuan kode contoh di bawah ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
