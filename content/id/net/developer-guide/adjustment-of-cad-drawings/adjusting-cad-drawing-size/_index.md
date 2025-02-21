---
title: Menyesuaikan Ukuran Gambar CAD
type: docs
weight: 10
url: /id/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Dengan menggunakan pustaka Aspose.CAD untuk .NET, pengembang dapat menyesuaikan ukuran gambar CAD selama konversi ke format yang didukung. Topik ini menjelaskan pendekatan untuk menyesuaikan ukuran secara otomatis atau manual menggunakan enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) dari kelas [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Menyesuaikan ukuran gambar CAD**

Aspose.CAD untuk .NET menyediakan enumerasi [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) untuk menyesuaikan ukuran gambar selama konversi format CAD. Ada dua cara untuk menyesuaikan ukuran gambar.

1. Penyesuaian ukuran otomatis.
1. Menyesuaikan ukuran dengan menggunakan enumerasi [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) dari kelas [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Untuk menyesuaikan ukuran secara otomatis, pengembang tidak perlu menyediakan properti Width dan Height dari kelas [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Di bawah ini adalah cuplikan kode yang merupakan contoh penyesuaian ukuran otomatis.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Enumerasi [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) memberikan kemampuan untuk menyesuaikan skala ketika properti Width dan Height tidak diatur. Di bawah ini adalah cuplikan kode yang menunjukkan cara menggunakan [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
