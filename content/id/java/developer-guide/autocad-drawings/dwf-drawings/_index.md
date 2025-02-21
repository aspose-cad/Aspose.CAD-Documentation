---
title: Gambar DWF
type: docs
weight: 20
url: /id/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Ekspor Gambar DWF ke PDF**

Aspose.CAD untuk API Java dapat memuat gambar AutoCAD dalam format DWF, dan mengonversinya menjadi PDF. Topik ini menjelaskan penggunaan API Aspose.CAD untuk mencapai konversi DWF ke format PDF melalui langkah-langkah sederhana seperti yang didefinisikan di depan.

### **Konversi File DWF ke PDF**

Langkah-langkah sederhana berikut diperlukan untuk mengonversi DWF ke PDF.

1. Muat file DWF ke dalam sebuah instance dari [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan setel properti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) dan setel properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) sambil mengoper objek dari [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengekspor Gambar DWF ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Dukungan Lapisan dalam DWF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar DWF AutoCAD dan merendernya sebagai gambar keseluruhan ke format JPG.

1. Muat file gambar DWF menggunakan metode pabrik [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Tambahkan lapisan yang diinginkan.
1. Panggil [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) sambil mengoper objek dari [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) sebagai parameter kedua.

Contoh kode di bawah ini menunjukkan cara mengonversi file menggunakan pengaturan default.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
