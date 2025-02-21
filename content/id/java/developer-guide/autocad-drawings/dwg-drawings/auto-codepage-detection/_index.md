---
title: Deteksi Halaman Kode Otomatis
type: docs
weight: 10
url: /id/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Deteksi Halaman Kode Otomatis**

Aspose.CAD mendukung deteksi halaman kode otomatis untuk [DWG](https://docs.fileformat.com/cad/dwg/) dan [DWF](https://docs.fileformat.com/cad/dwf/) file. Jika Anda tidak ingin menggunakan fitur ini, Anda dapat menimpanya dengan mengatur properti berikut dari [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) kelas.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): mengatur encoding yang digunakan untuk membaca data teks dari format DXF dan DWG non-Unicode. Ini terdeteksi secara otomatis secara default.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): mengatur encoding yang digunakan untuk membaca simbol-simbol yang dikodekan MIF dari encoding CJK (format M+nXXXX). Ini terdeteksi secara otomatis secara default.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): menentukan apakah karakter CIF (U+XXXX) dan karakter yang dikodekan MIF akan didekode jika mereka tidak memiliki format AutoCAD yang benar (AutoCAD mendahului simbol-simbol ini dengan backslash). Secara default, mereka didekode.

## Contoh Kode

Contoh kode di bawah ini menunjukkan cara untuk menimpa deteksi halaman kode otomatis di Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
