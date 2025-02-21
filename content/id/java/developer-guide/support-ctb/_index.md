---
title: Dukungan File CTB
type: docs
weight: 40
url: /id/java/developer-guide/support-ctb/
---

## **Dukungan File CTB**

Terkadang warna, ketebalan garis, dan beberapa opsi lainnya untuk gambar mungkin digunakan tidak hanya dari gambar itu sendiri tetapi juga dari gaya plot dalam file CTB terpisah. 
Cara termudah untuk menggunakan informasi ini adalah dengan menempatkan file CTB yang sesuai di dekat file dengan gambar dalam format DWG/DXF dan informasi dari file tersebut akan diterapkan 
secara otomatis selama ekspor.

Juga dimungkinkan untuk memuat semua file CTB dalam bentuk Stream menggunakan 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) properti dari 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objek.

Berikut adalah contoh cara melakukannya:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
