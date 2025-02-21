---
title: Mengekspor gambar dan layout DWG/DXF ke ukuran tertentu
type: docs
weight: 40
url: /id/java/developer-guide/export-into-size/
---

## **Ekspor Model dan semua layout ke ukuran PDF A4**

API Aspose.CAD memungkinkan Anda untuk mengekspor semua lembar dari file DWG/DXF ke ukuran PDF fisik yang ditentukan. 
Kode contoh berikut mengatur ukuran objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) untuk mencapai ukuran PDF yang diinginkan. 
Ukuran lembar kertas A4 adalah 210x297 milimeter atau 8.27x11.69 inci dan nilai-nilai ini digunakan dalam kode.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Ekspor Layout CAD ke PDF dalam ukuran yang berbeda**

Terkadang diperlukan untuk mengekspor layout ke ukuran fisiknya. Contoh di bawah ini menunjukkan ekspor gambar ke PDF multipage di mana setiap halaman dengan konten layout memiliki ukuran PDF fisiknya sendiri. Contoh ini menggunakan properti [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) .

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
