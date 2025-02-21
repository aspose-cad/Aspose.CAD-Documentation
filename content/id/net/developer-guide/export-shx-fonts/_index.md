---
title: Mengekspor font SHX
type: docs
weight: 40
url: /id/net/developer-guide/export-shx-fonts/
---

## **Mengekspor font SHX untuk gambar DXF/DWG**

Beberapa gambar mungkin mengandung font dalam format SHX khusus, yang menyimpan simbol font dalam bentuk bentuk. Format ini memerlukan prosedur pemuatan tambahan untuk setiap font yang digunakan dalam gambar. Apose.CAD dapat mengekspor gambar dengan teks yang ditulis dalam SHX dan memiliki berbagai opsi untuk melakukannya. Cara termudah untuk melakukannya adalah dengan menggunakan properti 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) dari objek 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Adalah mungkin untuk menghindari pengaturan semua jalur ke beberapa font SHX dengan contoh berikut:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts dengan contoh folder example.cs">}}
	
Setiap font SHX datang dengan kode halaman yang sesuai. Asosiasi ini diketahui dan sebagian tersemat dalam Aspose.CAD untuk font SHX yang dikenal.
Dalam kasus beberapa font SHX kustom digunakan, adalah mungkin untuk menerapkan properti ShxCodePages dan mengatur jalur ke file SHX dan kode halaman yang sesuai. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
