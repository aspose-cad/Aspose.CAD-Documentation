---
title: Gambar DRC
type: docs
weight: 15
url: /id/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Mengekspor Gambar DRC ke PDF**

Aspose.CAD menyediakan fitur untuk memuat entitas gambar [DRC](https://docs.fileformat.com/3d/drc/) AutoCAD dan merendernya sebagai gambar keseluruhan ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi dari [DRC](https://docs.fileformat.com/3d/drc/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [DRC](https://docs.fileformat.com/3d/drc/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil melewatkan objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

### Contoh Kode

Contoh kode di bawah ini menunjukkan cara mengonversi file menggunakan pengaturan default.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
