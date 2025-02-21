---
title: Deteksi Halaman Kode Otomatis
type: docs
weight: 10
url: /id/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Deteksi Halaman Kode Otomatis**

Aspose.CAD mendukung deteksi halaman kode otomatis untuk [DWG](https://docs.fileformat.com/cad/dwg/) dan [DWF](https://docs.fileformat.com/cad/dwf/) file. Jika Anda tidak ingin menggunakan fitur ini, Anda dapat menimpanya dengan mengatur properti berikut dari kelas **LoadOptions**.

- **specified_encoding**: menetapkan enkoding yang digunakan untuk membaca data teks dari format DXF dan DWG non-Unicode. Ini secara otomatis terdeteksi secara default.
- **specified_mif_encoding**: menetapkan enkoding yang digunakan untuk membaca simbol-simbol yang dikodekan MIF dari enkoding CJK (format M+nXXXX). Ini secara otomatis terdeteksi secara default.
- **recover_malformed_cif_mif**: mendefinisikan apakah karakter CIF (U+XXXX) dan karakter yang dikodekan MIF akan didekode jika mereka tidak memiliki format AutoCAD yang tepat (AutoCAD mendahului simbol-simbol ini dengan backslash). Secara default, mereka didekode.

## Contoh Kode

Contoh kode di bawah ini menunjukkan cara menimpa deteksi halaman kode otomatis di Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
