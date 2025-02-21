---
title: Gambar DXF
type: docs
weight: 60
url: /id/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Mengekspor Gambar DXF ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar DXF AutoCAD dan merendernya sebagai gambar keseluruhan ke format PDF. Pendekatan konversi DXF ke PDF bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil mengoper objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

Contoh kode di bawah menunjukkan cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Format yang Didukung**

Saat ini kami sepenuhnya mendukung format file DXF AutoCAD 2010. Versi DXF sebelumnya tidak dijamin 100% valid. Kami berencana untuk menyertakan lebih banyak format dan fitur di versi Aspose.CAD mendatang.

### **Entitas yang Didukung**

Saat ini kami mendukung semua entitas 2D yang umum dan parameter default dasar mereka sebagai berikut:

1. Dimensi Sejajar
1. Dimensi Sudut
1. Busur
1. Atribut
1. Referensi Blok
1. Lingkaran
1. Dimensi Diameter
1. Elips
1. Hachur
1. Garis
1. Teks Multiline
1. Dimensi Ordinat
1. Titik
1. Polyline
1. Dimensi Radial
1. Sinar
1. Dimensi Putar
1. Tabel
1. Teks
1. Xline

{{% alert color="primary" %}}

Jika selama parsing kami menemui entitas atau properti yang tidak kami dukung, entitas atau properti tersebut akan diabaikan tanpa pemberitahuan.

{{% /alert %}}

### **Manajemen Memori**

Properti [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) dari kelas [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) dapat digunakan untuk mengontrol realokasi memori. Realokasi paling mungkin terjadi untuk cache yang sudah dialokasikan sebelumnya. Hal ini dapat terjadi ketika sistem menyadari bahwa ruang yang dialokasikan tidak cukup.

- Jika [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) diatur ke nilai default, **False**, ruang akan dialokasikan kembali ke media yang sama.
- Ketika diatur ke **True**, realokasi tidak dapat melebihi ruang maksimum yang ditentukan. Dalam hal ini, cache dalam memori yang sudah ada (yang memerlukan realokasi) dibebaskan dan ruang tambahan dialokasikan di disk.

## **Mengekspor Lapisan Spesifik dari Gambar DXF ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Buat sebuah instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Tambahkan lapisan ke objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Buat sebuah instance dari [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) -nya.
1. Panggil metode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dan oper objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

Contoh kode di bawah menunjukkan cara mengonversi lapisan tertentu dari DXF ke PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Menerapkan File PDF sebagai Bagian dari Gambar DXF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) pabrik.
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan muat file PDF.
1. Atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dan simpan file.

Contoh kode di bawah menunjukkan cara menerapkan file PDF sebagai bagian dari gambar DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Mengekspor DGN Underlay yang Terdapat di dalam untuk format DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD dan mengekspor DGN underlay yang terdapat di dalamnya untuk format DXF.

Contoh kode di bawah menunjukkan cara mencapai persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Dukungan untuk Menyimpan File DXF**

Aspose.CAD menyediakan fitur untuk memuat file DXF AutoCAD dan melakukan perubahan di dalamnya serta menyimpannya kembali sebagai file DXF.

Contoh kode di bawah menunjukkan cara mencapai persyaratan yang ditentukan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Mengekspor DXF ke WMF**

Pendekatan ini bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) pabrik.
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan muat file PDF.
1. Atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dan simpan file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Mengekspor Layout DXF Spesifik ke PDF**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) pabrik.
1. Buat sebuah instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Tentukan nama layout yang diinginkan menggunakan properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Buat sebuah instance dari [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) -nya.
1. Ekspor gambar ke PDF dengan memanggil metode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil mengoper objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

Contoh kode di bawah menunjukkan cara mengonversi layout spesifik DXF ke PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) bertipe array string sehingga Anda dapat menentukan lebih dari satu layout pada satu waktu untuk kemungkinan konversi ke format PDF. Saat menentukan beberapa layout untuk properti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), PDF yang dihasilkan akan memiliki beberapa halaman, di mana setiap halaman mewakili individual layout AutoCAD.

{{% /alert %}}

## **Dukungan Clipping Blok**

Aspose.CAD menyediakan fitur Clipping Blok. Pendekatan Clipping Blok bekerja sebagai berikut:

1. Muat file gambar DXF menggunakan metode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) pabrik.
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan muat file PDF.
1. Atur properti yang diinginkan dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil mengoper objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua dan simpan filenya.

Contoh kode di bawah menunjukkan bagaimana Clipping Blok bekerja.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Mengekspor Gambar ke DXF**

Dengan menggunakan Aspose.CAD, Anda dapat mengekspor gambar ke format DXF. Dengan pendekatan ini, Anda dapat melakukan tindakan berikut:

1. Atur font baru
1. Sembunyikan entitas
1. Perbarui teks

Potongan kode berikut menunjukkan cara melakukan tindakan yang disebutkan di atas.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Mengekspor Lapisan Spesifik dari Gambar DXF ke Gambar**

Pendekatan ini bekerja sebagai berikut:

1. Buka file gambar DXF menggunakan metode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) pabrik.
1. Buat sebuah instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan tentukan properti [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) dan [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Tambahkan lapisan ke objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Buat sebuah instance dari [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Ekspor gambar ke PDF menggunakan metode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Contoh kode di bawah menunjukkan cara mengonversi lapisan spesifik DXF ke Gambar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
