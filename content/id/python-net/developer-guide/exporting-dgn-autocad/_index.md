---
title: Mengekspor Format DGN AutoCAD
type: docs
weight: 50
url: /id/python-net/developer-guide/exporting-dgn-autocad/
---

## **Mengekspor Format DGN AutoCAD ke PDF**

Aspose.CAD untuk API Python telah memperkenalkan fungsi untuk memuat file DGN AutoCAD dan mengonversinya ke format PDF. Kelas **CadImage** melayani tujuan tersebut.

Anda perlu memuat file DGN yang ada sebagai **CadImage**. Buat instance dari kelas **CadRasterizationOptions** dan setel berbagai properti. Buat instance dari kelas **PdfOptions** dan lewati instance **CadRasterizationOptions**. Sekarang panggil metode **save** dari instance kelas **CadImage**.

### Contoh Kode

Berikut adalah demonstrasi kode untuk mengonversi/mengekspor [DGN](https://docs.fileformat.com/cad/dgn/) ke format [PDF](https://docs.fileformat.com/pdf/).


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Mengekspor Format DGN AutoCAD ke Format Gambar Raster**

Aspose.CAD untuk API Python telah memperkenalkan fungsi untuk memuat file DGN AutoCAD dan mengonversinya ke gambar raster. Kelas **CadImage** melayani tujuan tersebut.

Anda perlu memuat file DGN yang ada sebagai **CadImage**. Buat instance dari kelas **CadRasterizationOptions** dan setel berbagai properti. Buat instance dari kelas **JpegOptions** dan lewati instance **CadRasterizationOptions**. Sekarang panggil metode **save** dari instance kelas **CadImage**.

### Contoh Kode

Berikut adalah demonstrasi kode untuk mengonversi/mengekspor [DGN](https://docs.fileformat.com/cad/dgn/) ke gambar [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Dukungan entitas 3D untuk DGN v7**

Aspose.CAD untuk API Python telah memperkenalkan fungsi untuk memuat file [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dan mendukung entitas 3D untuk DGN v7. Kelas **CadImage** melayani tujuan tersebut. Setiap gambar [DGN](https://docs.fileformat.com/cad/dgn/) mendukung 9 tampilan yang telah ditentukan sebelumnya. Itu diperingkat dari 1 hingga 9. Jika tampilan tidak didefinisikan pada ekspor, untuk format output multi-halaman (seperti PDF) semua tampilan akan diekspor, masing-masing di halaman terpisah. Entitas 3D didukung pada format file DGN, serta 2D. Untuk ini, **VectorRasterizationOptions** digunakan, TypeOfEntities tidak digunakan lagi untuk format DGN (baik 2D maupun 3D didukung secara bersamaan).

### Contoh Kode

Berikut adalah contoh kode untuk melihat elemen DGN yang didukung.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
