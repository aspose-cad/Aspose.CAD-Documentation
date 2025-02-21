---
title: Deteksi Kode Halaman Otomatis
type: docs
weight: 10
url: /id/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Deteksi Kode Halaman Otomatis**

Aspose.CAD mendukung deteksi kode halaman otomatis untuk [DWG](https://docs.fileformat.com/cad/dwg/) dan [DWF](https://docs.fileformat.com/cad/dwf/) file. Jika Anda tidak ingin menggunakan fitur ini, Anda dapat menindihnya dengan mengatur properti berikut dari kelas [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): mengatur pengkodean yang digunakan untuk membaca data teks dari format DXF dan DWG yang tidak mendukung Unicode. Secara default terdeteksi otomatis.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): mengatur pengkodean yang digunakan untuk membaca simbol yang terkode MIF dari pengkodean CJK (format M+nXXXX). Secara default terdeteksi otomatis.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): menentukan apakah karakter terkode CIF (U+XXXX) dan MIF akan didekode jika mereka tidak memiliki format AutoCAD yang benar (AutoCAD mendahului simbol-simbol ini dengan garis miring terbalik). Secara default, mereka didekode.

## Contoh Kode

Contoh kode di bawah ini menunjukkan bagaimana cara menindih deteksi kode halaman otomatis di Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
