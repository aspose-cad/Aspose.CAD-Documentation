---
title: Menyesuaikan Ukuran Gambar CAD
type: docs
weight: 10
url: /id/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Dengan menggunakan pustaka Aspose.CAD untuk Python, pengembang dapat menyesuaikan ukuran gambar CAD selama konversi ke format yang didukung. Topik ini menjelaskan pendekatan untuk menyesuaikan ukuran secara otomatis atau manual menggunakan enum **UnitType** dari kelas **ImageOptions**.

{{% /alert %}}

## **Menyesuaikan ukuran gambar CAD**

Aspose.CAD untuk Python menyediakan enumerasi **UnitType** untuk menyesuaikan ukuran gambar selama konversi format CAD. Ada dua cara untuk menyesuaikan ukuran gambar.

1. Penyesuaian ukuran otomatis.
1. Menyesuaikan ukuran dengan menggunakan enumerasi **UnitType** dari kelas **ImageOptions**

Untuk penyesuaian ukuran otomatis, pengembang tidak perlu memberikan properti Width dan Height dari kelas **CadRasterizationOptions**. Di bawah ini adalah cuplikan kode yang disediakan sebagai contoh penyesuaian ukuran otomatis.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Enumerasi **UnitType** memberikan kemampuan untuk menyesuaikan skala ketika properti Width dan Height tidak disetel. Di bawah ini adalah cuplikan kode yang disediakan untuk menunjukkan cara menggunakan **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
