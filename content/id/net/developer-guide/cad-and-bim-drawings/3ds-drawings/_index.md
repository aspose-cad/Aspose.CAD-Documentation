---
title: Gambar 3DS
type: docs
weight: 70
url: /id/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Ekspor Format 3DS ke PDF**

Aspose.CAD untuk .NET memungkinkan pengembang untuk mengekspor file [3DS](https://docs.fileformat.com/3d/3ds/) ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi [3DS](https://docs.fileformat.com/3d/3ds/) ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar [3DS](https://docs.fileformat.com/3d/3ds/) menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil melewatkan objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

## Contoh Kode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
