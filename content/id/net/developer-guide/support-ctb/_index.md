---
title: Dukungan File CTB
type: docs
weight: 40
url: /id/net/developer-guide/support-ctb/
---

## **Dukungan File CTB**

Terkadang warna, ketebalan garis, dan beberapa opsi lainnya untuk gambar dapat digunakan tidak hanya dari gambar itu sendiri tetapi juga dari gaya cetak dalam file CTB terpisah. 
Cara termudah untuk menggunakan informasi ini adalah dengan menempatkan file CTB yang sesuai dekat dengan file gambar dalam format DWG/DXF dan informasi dari file tersebut akan diterapkan
secara otomatis saat ekspor.

Juga mungkin untuk memuat semua file CTB dalam bentuk Stream menggunakan 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) properti dari 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objek.

Berikut adalah contoh cara melakukannya:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
