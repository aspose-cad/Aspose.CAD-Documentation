---
title: Gambar DGN
type: docs
weight: 10
url: /id/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Gambar Format DGN Sebagai Bagian dari DWG**

Aspose.CAD untuk Java memungkinkan pengembang untuk mengekspor file DWG dengan DGN underlay yang disematkan di dalamnya. Berikut adalah kode yang menunjukkan cara mengakses DGN underlay di dalam file DWG saat mengekspor file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Dukungan entitas 3D untuk DGN v7**

Aspose.CAD untuk Java API telah memperkenalkan fungsionalitas untuk memuat file DGN AutoCAD dan mendukung entitas 3D untuk DGN v7. Kelas [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) memiliki tujuan tersebut. Setiap gambar DGN mendukung 9 tampilan yang telah ditentukan sebelumnya. Ini dinyatakan dari 1 hingga 9. Jika tampilan tidak didefinisikan pada ekspor, untuk format keluaran multi-halaman (seperti PDF) semua tampilan akan diekspor, masing-masing pada halaman terpisah. Entitas 3D didukung pada format file DGN, serta 2D.
VectorRasterizationOptions.TypeOfEntities tidak lagi digunakan untuk format DGN (baik 2D maupun 3D didukung secara bersamaan).

Kode contoh untuk melihat elemen DGN yang didukung.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
