---
title: Gambar DXF
type: docs
weight: 60
url: /id/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Ekspor Gambar DXF ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar DXF AutoCAD dan merendernya sebagai gambar keseluruhan ke format PDF. Pendekatan konversi DXF ke PDF bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Panggil Image.Save dengan melewatkan objek dari [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Format yang Didukung**

Saat ini, kami sepenuhnya mendukung format file AutoCAD DXF 2010. Versi DXF sebelumnya tidak dijamin 100% valid. Kami berencana untuk memasukkan lebih banyak format dan fitur di versi Aspose.CAD mendatang.

### **Entitas yang Didukung**

Saat ini kami mendukung semua entitas 2D yang luas dan parameter default dasarnya sebagai berikut:

1. Dimensi Teratur
1. Dimensi Sudut
1. Busur
1. Atribut
1. Referensi Blok
1. Lingkaran
1. Dimensi Diameter
1. Elips
1. Hatching
1. Garis
1. Teks Multiline
1. Dimensi Ordinat
1. Titik
1. Garis Poligon
1. Dimensi Radial
1. Sinar
1. Dimensi Rotasi
1. Tabel
1. Teks
1. Garis X

{{% alert color="primary" %}}

Jika selama parsing kami menemukan entitas atau properti yang tidak kami dukung, entitas atau properti tersebut akan diabaikan tanpa suara.

{{% /alert %}}

### **Manajemen Memori**

Properti [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) dapat digunakan untuk mengontrol alokasi memori ulang. Alokasi ulang kemungkinan besar akan terjadi untuk cache yang dialokasikan sebelumnya. Hal ini dapat terjadi ketika sistem menyadari bahwa ruang yang dialokasikan tidak akan cukup.

- Jika [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) diatur ke nilai default, **False**, ruang alokasinya akan dipindahkan ke media yang sama.
- Ketika diatur ke **True**, alokasi tidak dapat melebihi ruang maksimum yang ditentukan. Dalam hal ini, cache yang ada dalam memori yang memerlukan alokasi ulang akan dibebaskan dan ruang tambahan dialokasikan di disk.

## **Ekspor Lapisan Tertentu dari Gambar DXF ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Tambah lapisan ke objek dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Buat instance dari [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) dari instans tersebut.
1. Ekspor gambar ke PDF menggunakan metode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi lapisan tertentu dari DXF ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Ekspor Lapisan Tertentu dari Gambar DXF ke Gambar**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Tambah lapisan ke objek dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Buat instance dari [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) dari instans tersebut.
1. Ekspor gambar ke PDF menggunakan metode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi lapisan tertentu dari DXF ke Gambar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Render file PDF sebagai bagian dari gambar DXF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan muat file PDF.
1. Atur properti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) dan simpan file.

Contoh kode di bawah ini menunjukkan bagaimana cara merender file PDF sebagai bagian dari gambar DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Ekspor DXF ke WMF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan muat file PDF.
1. Atur properti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) dan simpan file.

Contoh kode di bawah ini menunjukkan bagaimana cara mengekspor DXF ke WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Dukungan untuk Menyimpan File DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD, membuat perubahan di dalamnya, dan menyimpannya kembali sebagai file DXF. Contoh kode di bawah ini menunjukkan bagaimana mencapai persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Ekspor DGN underlay terbenam untuk format DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD dan mengekspor DGN underlay terbenam untuk format DXF.

Contoh kode di bawah ini menunjukkan bagaimana mencapai persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Ekspor Layout DXF Tertentu ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Tentukan nama layout yang diinginkan menggunakan properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Buat instance dari [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) dari instans tersebut.
1. Ekspor gambar ke PDF menggunakan metode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi layout tertentu dari DXF ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) adalah berupa array string sehingga Anda dapat menentukan lebih dari satu layout pada satu waktu untuk kemungkinan konversi ke format PDF. Ketika menentukan beberapa layout untuk properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), PDF yang dihasilkan akan memiliki beberapa halaman, di mana setiap halaman mewakili layout AutoCAD individu.

{{% /alert %}}

## **Akses objek ATTRIB dan MTEXT**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Akses entitas di dalam file CAD.
1. Periksa entitas [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) dan [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Tambahkan ke daftar sementara untuk pemrosesan lebih lanjut.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Dekomposisi Objek Insert CAD**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar **DXF** menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Akses entitas di dalam file CAD.
1. Periksa entitas [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Periksa daftar tipe [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Proses entitas.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Dukungan Pemotongan Blok**

Aspose.CAD menyediakan fitur Pemotongan Blok. Pendekatan Pemotongan Blok bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan muat file PDF.
1. Atur properti yang diinginkan dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) sambil melewatkan objek dari [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sebagai parameter kedua dan simpan file.

Contoh kode di bawah ini menunjukkan bagaimana Pemotongan Blok berfungsi.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Ekspor Gambar ke DXF**

Dengan menggunakan Aspose.CAD, Anda dapat mengekspor gambar ke format DXF. Menggunakan pendekatan ini, Anda dapat melakukan tindakan berikut:

1. Atur font baru.
1. Sembunyikan entitas.
1. Perbarui teks.

Cuplikan kode berikut menunjukkan cara melakukan tindakan yang terdaftar di atas.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
