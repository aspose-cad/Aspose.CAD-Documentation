---
title: Mengekspor Font SHX
type: docs
weight: 40
url: /id/java/developer-guide/export-shx-fonts/
---

## **Mengekspor Font SHX untuk Gambar DXF/DWG**

Beberapa gambar mungkin mengandung font dalam format khusus SHX, yang menyimpan simbol font dalam bentuk bentuk.
Format ini memerlukan prosedur pemuatan tambahan untuk setiap font yang digunakan dalam gambar.
Apose.CAD dapat mengekspor gambar dengan teks yang ditulis dalam SHX dan memiliki berbagai opsi untuk melakukannya.
Cara paling sederhana untuk melakukannya adalah dengan menggunakan properti [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) dari objek [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Setiap font SHX dilengkapi dengan kode halaman yang sesuai. Asosiasi ini diketahui dan sebagian tertanam dalam Aspose.CAD untuk font SHX yang dikenal.
Dalam kasus beberapa font SHX kustom digunakan, dimungkinkan untuk menerapkan properti **setShxCodePages** dan menyiapkan jalur ke file SHX dan kode halaman yang sesuai.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
