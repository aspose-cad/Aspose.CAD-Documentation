---
title: Gambar DWF
type: docs
weight: 20
url: /id/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Ekspor Gambar DWF ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) dan merendernya sebagai gambar keseluruhan ke dalam format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [DWF](https://docs.fileformat.com/cad/dwf/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dengan melewatkan objek dari [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Ekstrak Lapisan dari Gambar DWF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) dan merendernya sebagai gambar keseluruhan ke dalam format [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ekstrak nama lapisan menggunakan objek [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dengan melewatkan objek dari [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Dukungan Lapisan di DWF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) dan merendernya sebagai gambar keseluruhan ke dalam format [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Tambahkan lapisan yang diinginkan.
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dengan melewatkan objek dari [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Ekspor Gambar DWF ke BMP**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) dan merendernya sebagai gambar keseluruhan ke dalam format [BMP](https://docs.fileformat.com/image/bmp/). Pendekatan konversi [DWF](https://docs.fileformat.com/cad/dwf/) ke [BMP](https://docs.fileformat.com/image/bmp/) bekerja sebagai berikut:

1. Muat file gambar [DWF](https://docs.fileformat.com/cad/dwf/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dengan melewatkan objek dari [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan bagaimana cara mengonversi file [DWF](https://docs.fileformat.com/cad/dwf/) ke [BMP](https://docs.fileformat.com/image/bmp/) menggunakan pengaturan default.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
