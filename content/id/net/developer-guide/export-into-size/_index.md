---
title: Mengekspor gambar dan tata letak DWG/DXF ke ukuran tertentu
type: docs
weight: 40
url: /id/net/developer-guide/export-into-size/
---

## **Ekspor Model dan semua tata letak ke ukuran PDF A4**

API Aspose.CAD memungkinkan Anda untuk mengekspor semua lembar dari file DWG/DXF ke ukuran PDF fisik yang ditentukan.

Kode contoh berikut mengatur ukuran objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) untuk mencapai ukuran PDF yang diinginkan.
Ukuran lembar kertas A4 adalah 210x297 milimeter atau 8,27x11,69 inci dan nilai-nilai ini digunakan dalam kode.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Ekspor Tata Letak CAD ke PDF dalam ukuran yang berbeda**

Terkadang diperlukan untuk mengekspor tata letak ke ukuran fisiknya. Contoh di bawah ini menunjukkan ekspor gambar ke PDF multipage di mana setiap halaman dengan konten tata letak memiliki ukuran PDF fisik masing-masing. Contoh ini menggunakan properti [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
