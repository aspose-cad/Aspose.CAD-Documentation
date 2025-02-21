---
title: Gambar DWG
type: docs
weight: 40
url: /id/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Ekspor Gambar DWG ke PDF**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya menjadi PDF. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi dari DWG ke format PDF melalui langkah-langkah sederhana yang ditentukan berikut.

{{% alert color="primary" %}}

API mendukung revisi DWG AutoCAD berikut:

- Versi 16.0 rilis 18 DWG 2004
- Versi 16.1 DWG 2005
- Versi 18.0 DWG 2010
- Versi 19.0 DWG 2013

{{% /alert %}}

### **Format File DWG**

DWG adalah file biner yang berisi data gambar vektor dan metadata. Data gambar vektor memberikan instruksi kepada aplikasi CAD tentang cara menampilkan DWG; metadata dapat berisi berbagai informasi tentang file termasuk data spesifik lokasi dan juga data klien. Spesifikasi terbuka untuk format file DWG dapat ditemukan [dalam PDF ini](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Mengonversi File DWG ke PDF**

Langkah-langkah sederhana berikut diperlukan untuk mengonversi DWG ke PDF.

1. Muat file DWG ke dalam instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
3. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
4. Panggil metode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) dan teruskan objek [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengekspor Gambar DWG ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Membuat PDF Tunggal dengan Ukuran Layout Berbeda**

Aspose.CAD untuk Java memungkinkan Anda mengonversi file DWG menjadi satu PDF dengan ukuran layout yang berbeda. Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur tinggi dan lebar halaman hasil.
3. Tambahkan [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) yang diperlukan untuk objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Ekspor gambar ke PDF menggunakan metode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan cara membuat satu PDF dengan layout yang berbeda.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Ekspor DWG ke PDF/A dan PDF/E**

Langkah-langkah sederhana berikut diperlukan untuk mengonversi DWG ke PDF.

1. Muat file DWG ke dalam instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
3. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
4. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metode dan teruskan objek [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengekspor Gambar DWG ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Primitif AutoCAD yang Didukung**

Primitif AutoCAD berikut didukung.

- TEKS
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- TITIK
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- BULAT
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- GARIS
- XLINE
- GAYA
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAPIS
- VIEWPORT
- LAYOUT

## **Ekspor Layout DWG Spesifik ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur tinggi dan lebar halaman hasil.
3. Atur properti [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) untuk objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Ekspor gambar ke PDF menggunakan metode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan cara mengonversi layout spesifik dari DWG ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Ekspor DWG ke Raster atau PDF menggunakan Ukuran Tetap**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya menjadi PDF atau Raster menggunakan ukuran tetap.

Contoh kode di bawah ini menunjukkan cara menerapkan fitur ini.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Dukungan untuk garis tersembunyi yang dibulatkan saat mengekspor DWG/DXF ke BMP dan PDF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file DWG menggunakan metode [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
2. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) .
3. Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur tinggi dan lebar halaman hasil.
4. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Ekspor gambar ke PDF menggunakan metode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan cara menerapkan fitur ini.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Dukungan untuk pengaturan area cetak untuk gambar DWG dalam PDF yang diekspor**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya menjadi PDF. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai dukungan untuk pengaturan area cetak untuk gambar DWG dalam PDF yang diekspor.

Contoh kode di bawah ini menunjukkan cara menerapkan fitur ini.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Dukungan untuk membaca metadata XREF untuk file DWG**

1. Muat file DWG menggunakan metode [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
2. Telusuri setiap entitas gambar.
3. Jika entitas adalah [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) maka entitas XREF dengan metadata.

Contoh kode di bawah ini menunjukkan cara mencapai fitur ini.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Dokumen DWG dengan menentukan koordinat**

Aspose.CAD untuk API Java sekarang menyediakan fitur untuk merender dokumen DWG dengan memberikan koordinat lebar dan tinggi dokumen.

Contoh kode di bawah ini menunjukkan cara merender dokumen DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) adalah tipe array string sehingga Anda dapat menentukan lebih dari satu layout sekaligus untuk kemungkinan konversi ke format PDF. Saat menentukan beberapa layout untuk properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) , PDF hasil akan memiliki beberapa halaman, di mana setiap halaman mewakili layout AutoCAD individu.

### **Daftar Semua Layout**

Anda dapat mencantumkan semua layout yang ada dalam gambar AutoCAD menggunakan potongan kode berikut.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Dapatkan Nilai Atribut Blok dari Referensi Eksternal**

Aspose.CAD untuk API Java memungkinkan Anda untuk mendapatkan referensi eksternal dari atribut blok. API Aspose.CAD mengekspos properti [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) untuk mendapatkan referensi eksternal dari atribut blok dalam koleksi [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Kode berikut menunjukkan cara mendapatkan referensi eksternal dari atribut blok.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Cari Teks Dalam File AutoCAD DWG**

Aspose.CAD untuk API Java memungkinkan Anda untuk mencari teks dalam file DWG AutoCAD. API Aspose.CAD mengekspos kelas [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) yang mewakili entitas teks dalam file DWG AutoCAD. Kelas [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) juga termasuk dalam API Aspose.CAD karena beberapa entitas lain mungkin juga berisi teks.

Kode berikut menunjukkan cara mencari teks dalam file DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Cari Teks di Layout Spesifik**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Mengakses Bendera Underlay untuk Format DWG**

Aspose.CAD untuk Java telah menerapkan bendera underlay untuk format DWG dan memungkinkan pengembang untuk mengaksesnya. Berikut adalah demonstrasi kode sederhana.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Dukungan untuk Entitas DWG**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan.

### **Dukungan untuk Entitas MLeader**

DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan contoh bekerja dengan entitas MLeader di dalam file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Dukungan untuk Mengekspor Entitas DWG ke Gambar**

DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan contoh mengekspor entitas DWG tertentu ke gambar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Dukungan untuk Mengimpor Gambar ke File DWG**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan. DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan bagaimana kita dapat mengimpor gambar ke dalam file DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Dukungan untuk Menambahkan Teks dalam DWG**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWG dan mendukung berbagai entitas untuk dikerjakan. DWG adalah file biner yang berisi data gambar vektor dan metadata. Ada berbagai entitas dalam file DWG. Bagian berikut menjelaskan bagaimana kita dapat menambahkan teks ke dalam file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Dukungan untuk Mesh dalam DWG**

Aspose.CAD untuk API Java sekarang dapat mengakses entitas yang mendukung mesh yang mencakup tipe [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) dan [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Contoh berikut menjelaskan bagaimana kita dapat mengakses tipe mesh.

## **Mengonversi Gambar DWG ke DXF**

Aspose.CAD menyediakan fitur untuk memuat file DWG AutoCAD dan mengekspor ke format DXF. Pendekatan konversi DWG ke DXF bekerja sebagai berikut:

1. Muat file gambar DWG menggunakan metode [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
2. Ekspor gambar DWG ke DXF menggunakan metode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan cara mengonversi file DWG ke format DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Mengonversi Gambar DWG ke SVG**

API Aspose.CAD dapat memuat gambar AutoCAD dalam format DWG, dan mengonversinya menjadi SVG. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi dari DWG ke format SVG melalui langkah-langkah sederhana yang ditentukan di bawah ini.

1. Muat file DWG ke dalam instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Buat objek dari kelas [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) dan atur properti yang diperlukan.
3. Ekspor gambar DWG ke SVG menggunakan metode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan cara mengonversi file DWG ke format SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
