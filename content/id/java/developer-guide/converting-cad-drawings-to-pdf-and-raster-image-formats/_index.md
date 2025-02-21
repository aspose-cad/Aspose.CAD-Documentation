---
title: Mengonversi Gambar CAD ke Format PDF dan Gambar Raster
type: docs
weight: 30
url: /id/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD untuk Java secara langsung menuliskan informasi tentang API dan Nomor Versi pada dokumen keluaran. Sebagai contoh, saat merender Dokumen ke PDF, Aspose.CAD untuk Java mengisi kolom Aplikasi dengan nilai 'Aspose.CAD' dan kolom PDF Producer dengan nilai, misalnya 'Aspose.CAD v 17.9'.

Harap dicatat bahwa Anda tidak dapat menginstruksikan Aspose.CAD untuk Java untuk mengubah atau menghapus informasi ini dari Dokumen keluaran.

{{% /alert %}} 
## **Mengonversi Gambar CAD ke Format Gambar Raster**
Aspose.CAD untuk Java mampu mengonversi format gambar CAD seperti [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) ke format gambar raster yang didukung seperti [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD untuk Java telah menyediakan cara yang efisien & mudah digunakan untuk mencapai tujuan ini.
Anda dapat mengonversi format gambar CAD yang didukung ke format gambar raster menggunakan langkah-langkah sederhana sebagai dijelaskan di bawah ini.

1. Muat file CAD ke dalam sebuah instance dari [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Buat instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) dan atur properti wajibnya seperti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Buat instance dari **ImageOptionsBase** dan atur propertinya [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) ke instance dari **CadRasterizationOptions** yang dibuat pada langkah sebelumnya.
1. Panggil **Image.save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) yang dibuat pada langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Secara default, API hanya merender layout "Model". Namun, Anda juga dapat menentukan layout pilihan Anda saat mengonversi gambar CAD ke format gambar.
## **Kustomisasi Konversi CAD**
Prosedur konversi CAD ke [PDF](https://docs.fileformat.com/pdf/) & CAD ke konversi gambar raster sangat dapat dikonfigurasi karena kelas [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) telah diimplementasikan sedemikian rupa sehingga menyediakan banyak fitur opsional yang jika diatur dapat menggantikan proses rendering sesuai kebutuhan aplikasi.
### **Kelas CadRasterizationOptions**
Kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) umum untuk semua format CAD yang didukung seperti [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), oleh karena itu, informasi yang dibagikan dalam artikel ini berlaku untuk kedua format CAD tersebut.

Properti kelas **CadRasterizationOptions** yang paling berguna adalah:

|**Property**|**Nilai Default**|**Diperlukan**|**Deskripsi**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ya|Menentukan lebar halaman.|
|**PageHeight**|**0**|Ya|Menentukan tinggi halaman|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Tidak|Menentukan apakah gambar harus secara otomatis diskalakan. Nilai default secara otomatis mengecilkan gambar agar sesuai dengan ukuran kanvas. Beralih ke mode **GrowToFit**, atau gunakan pengaturan **None** untuk menonaktifkan penskalaan otomatis.|
|**BackgroundColor**|**Color.White**|Tidak|Menentukan warna latar belakang gambar keluaran.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Tidak|Menentukan mode pewarnaan entitas. Tentukan opsi **UseObjectColor** untuk menggambar entitas menggunakan warna aslinya, atau opsi **UseDrawColor** untuk mengganti warna asli.|
|**DrawColor**|**Color.Black**|Tidak|Menentukan warna entitas yang diganti (hanya jika **DrawType** diatur ke nilai properti **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Salah|Tidak|Menentukan apakah penskalaan layout otomatis harus dilakukan untuk mencocokkan layout Model.|
### **Menetapkan Ukuran Kanvas & Mode**
Ekspor dari CAD ke PDF atau CAD ke format gambar raster bukanlah tugas yang sepele. Karena PDF atau gambar yang dihasilkan memerlukan ukuran kanvas untuk didefinisikan, kita perlu menentukan dimensi keluaran untuk halaman PDF agar gambar dapat dirender dengan benar. Tetapkan properti **CadRasterizationOptions.PageWidth** dan **CadRasterizationOptions.PageHeight** secara eksplisit, atau Anda mungkin mendapatkan **ImageSaveException**.

Selain itu, Anda dapat menentukan opsi skala dimensi. Opsi penskalaan diatur dengan properti **CadRasterizationOptions.ScaleMethod**. Gunakan opsi ini untuk secara otomatis menyesuaikan dimensi gambar sesuai dengan nilai **CadRasterizationOptions.PageWidth** dan **CadRasterizationOptions.PageHeight**. Secara default, **CadRasterizationOptions.ScaleMethod** diatur ke mode **ScaleType.ShrinkToFit**. Properti ini mendefinisikan perilaku berikut:

- Jika dimensi gambar CAD lebih besar dari ukuran kanvas yang dihasilkan, maka dimensi gambar akan dikurangi agar sesuai dengan kanvas yang dihasilkan sambil mempertahankan rasio aspek.
- Jika dimensi gambar CAD lebih kecil dari ukuran kanvas yang dihasilkan, atur properti **CadRasterizationOptions.ScaleMethod** ke **ScaleType.GrowToFit** untuk meningkatkan ukuran gambar agar sesuai dengan kanvas PDF sekaligus mempertahankan rasio aspek.
- Atau nonaktifkan penskalaan otomatis dengan opsi **ScaleType.None**.

Contoh kode di bawah ini menunjukkan opsi penskalaan otomatis yang digunakan.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Menetapkan Warna Latar Belakang & Gambar**
Secara default, palet warna untuk kanvas yang dihasilkan diatur ke skema dokumen umum. Artinya, semua entitas di dalam gambar CAD digambar dengan pena berwarna hitam di latar belakang putih solid. Pengaturan ini dapat diubah dengan properti **CadRasterizationOptions.BackgroundColor** dan **CadRasterizationOptions.DrawColor**. Mengubah properti **CadRasterizationOptions.DrawColor** juga memerlukan pengaturan properti **CadRasterizationOptions.DrawType** agar dapat menggunakan warna gambar yang akan digunakan. Properti **CadRasterizationOptions.DrawType** mengontrol apakah entitas CAD mempertahankan warna mereka atau dikonversi ke warna kustom. Untuk mempertahankan warna entitas, tentukan **CadRasterizationOptions.DrawType** sebagai **CadDrawTypeMode.UseObjectColor**, jika tidak tentukan nilai **CadDrawTypeMode.UseDrawColor**.

Contoh kode di bawah ini menunjukkan cara menggunakan berbagai properti warna.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Menetapkan Penskalaan Layout Otomatis**
Sebagian besar gambar CAD memiliki lebih dari satu layout yang disimpan dalam satu file, dan setiap layout dapat memiliki dimensi yang berbeda. Saat merender gambar CAD semacam itu menjadi PDF, setiap halaman PDF dapat memiliki skala yang berbeda sesuai dengan ukuran layout. Untuk membuat rendering tetap homogen, API Aspose.CAD telah mengekspose properti **CadRasterizationOptions.AutomaticLayoutsScaling**. Nilai defaultnya adalah **false** tetapi ketika benar, API akan mencoba mencari skala yang sesuai untuk setiap layout terpisah dan menggambarnya dengan cara yang sesuai dengan melakukan operasi ukuran otomatis sesuai dengan ukuran halaman.

Berikut adalah cara kerja properti **CadRasterizationOptions.AutomaticLayoutsScaling** dalam kolaborasi dengan properti **CadRasterizationOptions.ScaleMethod**.

1. Jika **ScaleMethod** diatur ke **ScaleType.ShrinkToFit** atau **ScaleType.GrowToFit** dengan **AutomaticLayoutsScaling** yang diatur ke false, maka semua layout (termasuk Model) akan diproses berdasarkan opsi pertama.
1. Jika **ScaleMethod** diatur ke **ScaleType.ShrinkToFit** atau **ScaleType.GrowToFit** dengan **AutomaticLayoutsScaling** diatur ke true, maka semua layout (kecuali Model) akan diproses berdasarkan ukuran mereka sedangkan Model akan diproses sesuai dengan opsi pertama.
1. Jika **ScaleMethod** diatur ke **ScaleType.None** dengan **AutomaticLayoutsScaling** diatur ke true atau false, maka tidak akan ada penskalaan yang dilakukan.

Contoh kode di bawah ini menunjukkan cara menetapkan penskalaan layout otomatis untuk konversi CAD ke PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Mengonversi Layout CAD ke Format Gambar Raster**
API Aspose.CAD untuk Java mampu mengonversi layout CAD dari format yang didukung seperti DXF & DWG ke gambar raster seperti PNG, BMP, TIFF, JPEG & GIF. API ini juga memberikan dukungan untuk merender layout spesifik dari gambar CAD ke berbagai lapisan PSD.  
API Aspose.CAD untuk Java telah menyediakan cara yang efisien & mudah digunakan untuk menentukan daftar layout CAD yang diperlukan dan merendernya ke format gambar raster. Berikut adalah cara Anda dapat mencapainya dalam 5 langkah sederhana sebagai dijelaskan di bawah ini.

1. Muat file CAD ke dalam sebuah instance dari **Image** menggunakan metode pabrik **load**.
1. Buat instance dari **CadRasterizationOptions** dan atur properti wajibnya seperti **PageWidth** & **PageHeight**.
1. Tentukan nama layout yang diinginkan menggunakan properti CadRasterizationOptions.Layouts.
1. Buat instance dari **ImageOptionsBase** dan atur propertinya **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat pada langkah sebelumnya.
1. Panggil metode **Image.Save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari **ImageOptionsBase** yang dibuat pada langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Properti **CadRasterizationOptions.Layouts** bertipe array string sehingga Anda dapat menentukan lebih dari satu layout sekaligus untuk kemungkinan konversi ke format gambar. Saat menentukan beberapa layout untuk properti **CadRasterizationOptions.Layouts**, gambar TIFF yang dihasilkan akan memiliki beberapa halaman, gambar GIF akan memiliki beberapa frame, dan format PSD akan memiliki beberapa lapisan, di mana setiap halaman/frame/lapisan mewakili layout AutoCAD individu. Jika format gambar lain seperti PNG, BMP, JPEG dipilih untuk menyimpan hasil, maka API akan hanya merender layout default; yaitu "Model".

{{% /alert %}} 
## **Mengaktifkan Pelacakan untuk Proses Rendering CAD**
Aspose.CAD telah memperkenalkan serangkaian kelas dan bidang enumerasi pendukung untuk membantu pelacakan proses rendering CAD. Dengan perubahan ini, konversi CAD ke PDF sekarang dapat dicapai seperti berikut sambil mengaktifkan pelacakan.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Pelacakan proses rendering CAD dapat mendeteksi masalah yang mungkin terjadi berikut ini.

1. Informasi header yang hilang atau rusak.
1. Informasi layout yang hilang.
1. Entitas blok yang hilang.
1. Gaya dimensi yang hilang.
1. Gaya yang hilang.
## **Mengganti Font saat Mengonversi Gambar CAD**
Kemungkinan suatu gambar CAD menggunakan font tertentu yang tidak tersedia di mesin tempat konversi CAD ke PDF atau CAD ke gambar raster dilakukan. Dalam situasi seperti itu, API Aspose.CAD akan memicu pengecualian yang sesuai untuk menyoroti font (font) yang hilang dan menghentikan proses konversi karena API memerlukan font ini untuk merender konten dengan benar ke PDF dan/atau gambar yang dihasilkan.
API Aspose.CAD menyediakan cara yang mudah untuk menggunakan mekanisme untuk mengganti font (font) yang diperlukan dengan font (font) yang tersedia. Properti **CadImage.Styles** mengembalikan instance dari **CadStylesDictionary** yang pada gilirannya berisi **CadStyleTableObject** untuk setiap gaya dalam gambar CAD, sedangkan **CadStyleTableObject.PrimaryFontName** dapat digunakan untuk menentukan nama font yang tersedia.

Snippet kode berikut menunjukkan penggunaan API Aspose.CAD untuk Java untuk mengubah font dari semua gaya dalam gambar CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Juga mungkin untuk mengubah font dari hanya satu gaya tertentu dengan mengaksesnya melalui nama gaya. Snippet kode berikut menunjukkan penggunaan pendekatan ini.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Mengonversi Layer CAD ke Format Gambar Raster**
API Aspose.CAD untuk Java telah menyediakan cara yang efisien & mudah digunakan untuk menentukan nama layer CAD yang diperlukan dan merendernya ke format gambar raster. Berikut adalah cara Anda dapat mencapainya dalam 5 langkah sederhana seperti yang dijelaskan di bawah ini.

1. Muat file CAD ke dalam sebuah instance dari **Image** menggunakan metode pabrik **load**.
1. Buat instance dari **CadRasterizationOptions** dan atur properti wajibnya seperti **PageWidth** & **PageHeight**.
1. Tambahkan nama layer yang diinginkan menggunakan metode **CadRasterizationOptions.Layers.add**.
1. Buat instance dari **ImageOptionsBase** dan atur propertinya **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat pada langkah sebelumnya.
1. Panggil metode **Image.save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari **ImageOptionsBase** yang dibuat pada langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Mengonversi Semua Layer CAD ke Gambar Terpisah**
Anda dapat mendapatkan semua layer dari gambar CAD menggunakan **CadImage.Layers** dan merender setiap layer ke gambar terpisah seperti yang ditunjukkan di bawah ini.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Mengonversi Layer CAD DWF ke Format Gambar Raster**
API Aspose.CAD untuk Java telah menyediakan cara yang efisien & mudah digunakan untuk menentukan nama layer CAD yang diperlukan dan merendernya ke format gambar raster. Berikut adalah cara Anda dapat mencapainya dalam 5 langkah sederhana seperti yang dijelaskan di bawah ini.

1. Muat file CAD DWF ke dalam sebuah instance dari **Image** menggunakan metode pabrik **Load**.
1. Buat instance dari **CadRasterizationOptions** dan atur properti wajibnya seperti **PageWidth** & **PageHeight**.
1. Tambahkan nama layer yang diinginkan menggunakan metode **CadRasterizationOptions.Layers.Add**.
1. Buat instance dari **ImageOptionsBase** dan atur propertinya **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat pada langkah sebelumnya.
1. Panggil metode **Image.Save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari **ImageOptionsBase** yang dibuat pada langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
