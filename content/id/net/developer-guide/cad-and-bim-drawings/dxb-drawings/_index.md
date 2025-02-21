---
title: Gambar DXB
type: docs
weight: 70
url: /id/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Ekspor Format DXB Ke PDF**

Aspose.CAD untuk .NET memungkinkan pengembang untuk mengekspor file DXB ke format [PDF](https://docs.fileformat.com/pdf/). Pendekatan konversi DXB ke [PDF](https://docs.fileformat.com/pdf/) bekerja sebagai berikut:

1. Muat file gambar DXB menggunakan metode pabrik [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Buat objek dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) dan atur properti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Buat objek dari kelas [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) dan atur properti [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Panggil [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) sambil melewatkan objek [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sebagai parameter kedua.

## Kode Contoh

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
