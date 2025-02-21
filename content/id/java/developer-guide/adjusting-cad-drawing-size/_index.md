---
title: Menyesuaikan Ukuran Gambar CAD
type: docs
weight: 10
url: /id/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Dengan menggunakan Aspose.CAD untuk Java, pengembang dapat menyesuaikan ukuran gambar selama konversi format CAD. Topik ini menjelaskan pendekatan untuk penyesuaian otomatis atau menyesuaikan ukuran menggunakan enum [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) dari kelas [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Menyesuaikan Ukuran Gambar CAD**

Aspose.CAD untuk Java menyediakan enumerasi [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) untuk menyesuaikan ukuran gambar selama konversi format CAD. Ada dua cara untuk menyesuaikan ukuran gambar.

1. Penyesuaian ukuran otomatis
1. Menyesuaikan ukuran dengan menggunakan enumerasi [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) dari kelas [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Untuk penyesuaian ukuran otomatis, pengembang tidak perlu menyediakan properti Width dan Height dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Berikut adalah cuplikan kode yang diberikan sebagai contoh penyesuaian ukuran otomatis.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Enumerasi [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) memberikan kemampuan untuk menyesuaikan skala ketika properti Width dan Height tidak disetel. Berikut adalah cuplikan kode yang diberikan untuk mendemonstrasikan cara menggunakan [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
