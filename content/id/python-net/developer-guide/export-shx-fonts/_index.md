---
title: Mengekspor Font SHX
type: docs
weight: 40
url: /id/python-net/developer-guide/export-shx-fonts/
---

## **Mengekspor Font SHX untuk Gambar DXF/DWG**

Beberapa gambar mungkin mengandung font dalam format SHX khusus, yang menyimpan simbol font dalam bentuk bentuk. Format ini memerlukan prosedur pemuatan tambahan untuk setiap font yang digunakan dalam gambar. Apose.CAD dapat mengekspor gambar dengan teks yang ditulis dalam SHX dan memiliki berbagai opsi untuk melakukannya. Cara termudah untuk melakukannya adalah dengan menggunakan 
**ShxFonts** properti dari 
**CadRasterizationOptions** objek.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
