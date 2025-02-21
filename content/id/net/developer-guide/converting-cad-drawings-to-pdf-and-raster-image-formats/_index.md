---
title: DWG DXF ke PDF C# | Konversi File Auto CAD ke PDF JPEG PNG di C# .NET
type: docs
weight: 30
url: /id/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG ke PDF C#, DXF ke PDF C#, DWF DWT ke PDF C#, konversi AutoCAD, konversi DWG, konversi DWF, konversi DWT, konversi DXF, konversi autocad ke pdf, konversi DWG ke PDF, konversi DWG ke PNG, konversi DWG ke TIFF, konversi DWG ke JPG"
description: Gunakan konverter C# .NET AutoCAD ke PDF untuk mengonversi DWG atau DXF ke PDF di C#. Anda dapat mengonversi DWG, DWF, DWT, dan DXF ke PDF, JPEG, PNG, BMP, GIF, dan TIFF di C# .NET juga.
---

## **Konversi DWG atau DXF ke PNG JPEG BMP GIF atau TIFF di C#**

Aspose.CAD untuk .NET dapat mengonversi format gambar AutoCAD seperti [DXF](https://docs.fileformat.com/cad/dxf/) dan [DWG](https://docs.fileformat.com/cad/dwg/) ke [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) dan [GIF](https://docs.fileformat.com/image/gif/). Ini telah mengekspos API yang efisien dan mudah digunakan untuk mencapai tujuan ini.

Anda dapat mengonversi format gambar AutoCAD yang didukung ke format gambar raster menggunakan langkah-langkah sederhana seperti yang dijelaskan di bawah ini.

1. Muat file DWG atau DXF AutoCAD ke dalam kelas [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Buat instance dari [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Atur/ganti ukuran gambar menggunakan [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) dan [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Buat instance dari [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Setel properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) ke [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) yang dibuat di langkah sebelumnya.
1. Simpan gambar AutoCAD sebagai PDF dengan [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) yang dibuat di langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Secara default, API hanya merender layout "Model". Namun, Anda juga dapat menentukan layout sesuai keinginan Anda saat mengonversi gambar CAD ke format gambar.

## **Kustomisasi Konversi CAD**

Prosedur konversi CAD ke [PDF](https://docs.fileformat.com/pdf/) & CAD ke format gambar raster sangat dapat dikonfigurasi karena kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) telah diterapkan sedemikian rupa sehingga menyediakan banyak fitur opsional yang dapat mengubah proses rendering sesuai dengan kebutuhan aplikasi.

### **Kelas CadRasterizationOptions**

Kelas **CadRasterizationOptions** sama untuk semua format CAD yang didukung seperti DWG & DXF oleh karena itu, informasi yang dibagikan dalam artikel ini berlaku untuk kedua format CAD yang disebutkan di atas.

Properti kelas **CadRasterizationOptions** yang paling berguna adalah:

|**Properti**|**Nilai Default**|**Diperlukan**|**Deskripsi**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ya|Menentukan lebar halaman.|
|**PageHeight**|**0**|Ya|Menentukan tinggi halaman|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Tidak|Menentukan apakah gambar harus secara otomatis diukur. Nilai default secara otomatis mengecilkan gambar agar sesuai dengan ukuran kanvas. Beralih ke mode **GrowToFit**, atau gunakan pengaturan **None** untuk menonaktifkan pengukuran otomatis.|
|**BackgroundColor**|**Color.White**|Tidak|Menentukan warna latar belakang gambar keluaran.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Tidak|Menentukan mode pewarnaan entitas. Tentukan opsi **UseObjectColor** untuk menggambar entitas dengan warna aslinya, atau opsi **UseDrawColor** untuk menimpa warna asli.|
|**DrawColor**|**Color.Black**|Tidak|Menentukan warna entitas yang ditimpa (hanya jika **DrawType** disetel ke nilai properti **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Tidak|Menentukan apakah pengukuran layout otomatis harus dilakukan untuk mencocokkan layout Model.|

### **Menetapkan Ukuran Kanvas & Mode**

Ekspor dari CAD ke PDF atau CAD ke format gambar raster bukanlah tugas yang sepele. Karena PDF atau gambar hasil membutuhkan ukuran kanvas yang harus didefinisikan, kita perlu menentukan dimensi keluaran untuk halaman PDF agar gambar dirender dengan benar. Atur properti **CadRasterizationOptions.PageWidth** dan **CadRasterizationOptions.PageHeight** secara eksplisit, atau Anda mungkin mendapatkan **ImageSaveException**.

Selain itu, Anda dapat menetapkan opsi skala dimensi. Opsi skala diatur dengan properti **CadRasterizationOptions.ScaleMethod**. Gunakan opsi ini untuk secara otomatis menyesuaikan dimensi gambar sesuai dengan nilai **CadRasterizationOptions.PageWidth** dan **CadRasterizationOptions.PageHeight**. Secara default, **CadRasterizationOptions.ScaleMethod** diatur ke mode **ScaleType.ShrinkToFit**. Properti ini mendefinisikan perilaku berikut:

- Jika dimensi gambar CAD lebih besar dari ukuran kanvas yang dihasilkan, maka dimensi gambar akan dikurangi agar sesuai dengan kanvas yang dihasilkan sambil mempertahankan rasio aspek.
- Jika dimensi gambar CAD lebih kecil dari ukuran kanvas yang dihasilkan, setel properti **CadRasterizationOptions.ScaleMethod** ke **ScaleType.GrowToFit** untuk meningkatkan ukuran gambar agar sesuai dengan kanvas PDF sambil mempertahankan rasio aspek.
- Atau nonaktifkan pengukuran otomatis dengan opsi **ScaleType.None**.

Contoh kode di bawah ini menunjukkan opsi pengukuran otomatis yang sedang digunakan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Menetapkan Latar Belakang & Warna Gambar**

Secara default, palet warna untuk kanvas hasil diatur ke skema dokumen umum. Itu berarti bahwa semua entitas di dalam gambar CAD digambar dengan pena warna hitam di latar belakang putih solid. Pengaturan ini dapat diubah dengan properti **CadRasterizationOptions.BackgroundColor** dan **CadRasterizationOptions.DrawColor**. Mengubah properti **CadRasterizationOptions.DrawColor** juga memerlukan pengaturan properti **CadRasterizationOptions.DrawType** untuk memanfaatkan warna gambar yang digunakan. Properti **CadRasterizationOptions.DrawType** mengontrol apakah entitas CAD mempertahankan warna mereka atau diubah ke warna kustom. Untuk mempertahankan warna entitas, tentukan **CadRasterizationOptions.DrawType** sebagai **CadDrawTypeMode.UseObjectColor**, jika tidak, tentukan nilai **CadDrawTypeMode.UseDrawColor**.

Contoh kode di bawah ini menunjukkan bagaimana menggunakan berbagai properti warna.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Mengaktifkan Skala Layout Otomatis**

Sebagian besar gambar CAD memiliki lebih dari satu layout yang disimpan dalam satu file, dan setiap layout dapat memiliki dimensi yang berbeda. Saat merender gambar CAD seperti itu ke PDF, setiap halaman PDF dapat memiliki skala yang berbeda sesuai dengan ukuran layout. Untuk membuat rendering seragam, API Aspose.CAD telah mengekspos properti **CadRasterizationOptions.AutomaticLayoutsScaling**. Nilai defaultnya adalah **false**, tetapi ketika **true**, API akan mencoba mencari skala yang sesuai untuk setiap layout terpisah dan menggambarnya dengan cara yang sesuai dengan melakukan operasi pengukuran otomatis sesuai dengan ukuran halaman.

Berikut adalah cara kerja properti **CadRasterizationOptions.AutomaticLayoutsScaling** dalam kolaborasi dengan properti **CadRasterizationOptions.ScaleMethod**.

1. Jika **ScaleMethod** disetel ke **ScaleType.ShrinkToFit** atau **ScaleType.GrowToFit** dengan **AutomaticLayoutsScaling** disetel ke false, maka semua layout (termasuk Model) akan diproses sesuai dengan opsi pertama.
1. Jika **ScaleMethod** disetel ke **ScaleType.ShrinkToFit** atau **ScaleType.GrowToFit** dengan **AutomaticLayoutsScaling** disetel ke true, maka semua layout (kecuali Model) akan diproses sesuai ukuran mereka sementara Model akan diproses sesuai dengan opsi pertama.
1. Jika **ScaleMethod** disetel ke **ScaleType.None** dengan **AutomaticLayoutsScaling** disetel ke true atau false maka tidak ada pengukuran yang akan dilakukan.

Contoh kode di bawah ini menunjukkan bagaimana mengatur pengukuran layout otomatis untuk konversi CAD ke PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Konversi Layout DXF atau DWG AutoCAD ke PNG atau Format Gambar Lainnya di C#**

API Aspose.CAD untuk .NET dapat mengonversi layout CAD dari format yang didukung seperti DXF dan DWG ke PNG BMP TIFF JPEG dan GIF. API ini juga menyediakan dukungan untuk merender layout tertentu dari gambar CAD ke layer PSD yang berbeda.

Berikut adalah cara Anda dapat mencapai hal yang sama dalam langkah-langkah sederhana berikut.

- Muat file DWG atau DXF AutoCAD menggunakan kelas **Image**.
- Atur/ganti lebar dan tinggi gambar.
- Atur nama layout yang diinginkan menggunakan properti **CadRasterizationOptions.Layouts**.
- Buat instance dari **ImageOptionsBase** dan atur properti **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat di langkah sebelumnya.
- Simpan layout CAD sebagai TIFF atau gambar.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Properti **CadRasterizationOptions.Layouts** adalah dari tipe array string sehingga Anda dapat menentukan lebih dari satu layout sekaligus untuk kemungkinan konversi ke format gambar. Saat menentukan beberapa layout untuk properti **CadRasterizationOptions.Layouts**, gambar TIFF yang dihasilkan akan memiliki beberapa halaman, gambar GIF akan memiliki beberapa bingkai dan format [PSD](https://docs.fileformat.com/image/psd/) akan memiliki beberapa layer, di mana setiap halaman/bingkai/layer mewakili layout AutoCAD individu. Jika format gambar lain seperti PNG, BMP, JPEG dipilih untuk menyimpan hasilnya maka API hanya merender layout default; yaitu "Model".

{{% /alert %}}

## **Mengaktifkan Pelacakan untuk Proses Rendering CAD**

Aspose.CAD telah memperkenalkan serangkaian kelas dan bidang enumerasi pendukung untuk membantu pelacakan proses rendering CAD. Dengan perubahan ini, konversi CAD ke PDF sekarang dapat dicapai seperti berikut sambil mengaktifkan pelacakan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Pelacakan proses rendering CAD dapat mendeteksi kemungkinan masalah berikut.

1. Informasi header yang hilang atau korup.
1. Informasi layout yang hilang.
1. Entitas blok yang hilang.
1. Gaya dimensi yang hilang.
1. Gaya yang hilang.

## **Mengganti Font saat Mengonversi Gambar CAD**

Sangat mungkin bahwa gambar CAD tertentu menggunakan font spesifik yang tidak tersedia di mesin di mana konversi CAD ke PDF atau CAD ke gambar raster dilakukan. Dalam situasi seperti itu, API Aspose.CAD akan memicu pengecualian yang sesuai untuk menyoroti font yang hilang dan menghentikan proses konversi karena API memerlukan font ini untuk merender konten dengan benar ke PDF atau gambar yang dihasilkan.

API Aspose.CAD menyediakan cara mudah untuk menggunakan mekanisme mengganti font yang dibutuhkan dengan font yang tersedia. Properti **CadImage.Styles** mengembalikan instance dari **CadStylesDictionary** yang pada gilirannya berisi **CadStyleTableObject** untuk setiap gaya dalam gambar CAD, sedangkan **CadStyleTableObject.PrimaryFontName** dapat digunakan untuk menentukan nama font yang tersedia.

Cuplikan kode berikut menunjukkan penggunaan Aspose.CAD untuk .NET API untuk mengubah font semua gaya dalam gambar CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Anda juga dapat mengubah font hanya untuk satu gaya tertentu dengan mengaksesnya melalui nama gaya. Cuplikan kode berikut menunjukkan penggunaan pendekatan ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Konversi Layer CAD ke Format Gambar Raster**

API Aspose.CAD untuk .NET telah mengekspos cara yang efisien & mudah digunakan untuk menentukan nama layer CAD yang diperlukan dan merendernya ke format gambar raster. Berikut adalah cara Anda dapat mencapai hal yang sama dalam 5 langkah sederhana seperti yang tercantum di bawah ini.

1. Muat file CAD ke dalam instance **Image** menggunakan metode pabrik **Load**.
1. Buat instance dari **CadRasterizationOptions** dan atur propertinya yang wajib seperti **PageWidth** & **PageHeight**.
1. Tambahkan nama layer yang diinginkan menggunakan metode **CadRasterizationOptions.Layers.Add**.
1. Buat instance dari **ImageOptionsBase** dan atur properti **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat di langkah sebelumnya.
1. Panggil metode **Image.Save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari **ImageOptionsBase** yang dibuat di langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Mengonversi Semua Layer CAD ke Gambar Terpisah**

Anda dapat mengambil semua layer dari gambar CAD menggunakan **CadImage.Layers** dan merender setiap layer ke gambar terpisah seperti yang ditunjukkan di bawah ini.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Mengonversi Layer CAD DWF ke Format Gambar Raster**

API Aspose.CAD untuk .NET telah mengekspos cara yang efisien & mudah digunakan untuk menentukan nama layer CAD yang diperlukan dan merendernya ke format gambar raster. Berikut adalah cara Anda dapat mencapai hal yang sama dalam 5 langkah sederhana seperti yang tercantum di bawah ini.

1. Muat file CAD DWF ke dalam instance **Image** menggunakan metode pabrik **Load**.
1. Buat instance dari **CadRasterizationOptions** dan atur propertinya yang wajib seperti **PageWidth** & **PageHeight**.
1. Tambahkan nama layer yang diinginkan menggunakan metode **CadRasterizationOptions.Layers.Add**.
1. Buat instance dari **ImageOptionsBase** dan atur properti **VectorRasterizationOptions** ke instance dari **CadRasterizationOptions** yang dibuat di langkah sebelumnya.
1. Panggil metode **Image.Save** dengan melewatkan jalur file (atau objek MemoryStream) serta instance dari **ImageOptionsBase** yang dibuat di langkah sebelumnya.

Berikut adalah kode sumber lengkapnya.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD untuk .NET langsung menulis informasi tentang API dan Nomor Versi dalam dokumen keluaran. Misalnya, setelah merender Dokumen ke PDF, Aspose.CAD untuk .NET mengisi bidang Aplikasi dengan nilai 'Aspose.CAD' dan bidang Produsen PDF dengan nilai, misalnya 'Aspose.CAD v 17.10'.

Harap dicatat bahwa Anda tidak dapat meminta Aspose.CAD untuk .NET untuk mengubah atau menghapus informasi ini dari Dokumen keluaran.
