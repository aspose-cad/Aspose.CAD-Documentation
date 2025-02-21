---
title: Mengekspor Format DGN AutoCAD
type: docs
weight: 50
url: /id/net/developer-guide/exporting-dgn-autocad/
---

## **Mengekspor Format DGN AutoCAD Ke PDF**

Aspose.CAD untuk .NET API telah memperkenalkan fungsionalitas untuk memuat file DGN AutoCAD dan mengonversinya ke format PDF. Kelas [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) memenuhi tujuan tersebut.

Anda perlu memuat file DGN yang ada sebagai [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur berbagai properti. Buat instance dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan berikan instance [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Sekarang panggil metode [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dari instance kelas [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Contoh Kode

Berikut adalah demonstrasi kode untuk mengonversi/mengekspor [DGN](https://docs.fileformat.com/cad/dgn/) ke format [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Mengekspor Format DGN AutoCAD Ke Format Gambar Raster**

Aspose.CAD untuk .NET API telah memperkenalkan fungsionalitas untuk memuat file DGN AutoCAD dan mengonversinya ke gambar raster. Kelas [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) memenuhi tujuan tersebut.

Anda perlu memuat file DGN yang ada sebagai [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Buat instance dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur berbagai properti. Buat instance dari kelas [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) dan berikan instance [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Sekarang panggil metode [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dari instance kelas [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Contoh Kode

Berikut adalah demonstrasi kode untuk mengonversi/mengekspor [DGN](https://docs.fileformat.com/cad/dgn/) ke gambar [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Dukungan Entitas 3D untuk DGN v7**

Aspose.CAD untuk .NET API telah memperkenalkan fungsionalitas untuk memuat file [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dan mendukung entitas 3D untuk DGN v7. Kelas [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) memenuhi tujuan tersebut. Setiap gambar [DGN](https://docs.fileformat.com/cad/dgn/) mendukung 9 tampilan yang telah ditentukan sebelumnya. Ini dinyatakan dari 1 hingga 9. Jika tampilan tidak didefinisikan saat ekspor, untuk format output multi-halaman (seperti PDF) semua tampilan akan diekspor, masing-masing pada halaman terpisah. Entitas 3D didukung pada format file DGN, serta 2D. Untuk ini, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) digunakan, TypeOfEntities tidak digunakan lagi untuk format DGN (baik 2D maupun 3D didukung secara bersamaan).

### Contoh Kode

Berikut adalah contoh kode untuk melihat elemen DGN yang didukung.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
