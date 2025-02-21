---
title: Gambar COLLADA
type: docs
weight: 70
url: /id/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Ekspor Format COLLADA ke PDF**

Aspose.CAD untuk .NET memungkinkan pengembang untuk mengekspor berkas [COLLADA](https://docs.fileformat.com/3d/dae/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [COLLADA](https://docs.fileformat.com/3d/dae/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat berkas gambar [COLLADA](https://docs.fileformat.com/3d/dae/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil melewatkan objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
