---
title: CAD Rajz Méretének Beállítása
type: docs
weight: 10
url: /hu/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Az Aspose.CAD for .NET könyvtár használatával a fejlesztők beállíthatják a CAD rajz méretét bármely támogatott formátumba történő átkonvertálás során. Ez a téma magyarázza, hogyan lehet automatikusan vagy manuálisan beállítani a méretet az [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeráció használatával az [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) osztályban.

{{% /alert %}}

## **CAD rajz méretének beállítása**

Az Aspose.CAD for .NET biztosítja az [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) felsorolást a rajz méretének beállításához a CAD formátum átkonvertálása során. Két módja van a rajz méretének beállításának.

1. Automatikus méretbeállítás.
1. Méret beállítása az [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeráció használatával az [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) osztályban.

Az automatikus méretbeállításhoz a fejlesztőknek nem kell megadniuk a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) osztály Width és Height tulajdonságait. Az alábbi kódrészlet példát mutat az automatikus méretezésre.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Az [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeráció lehetővé teszi a méretezés beállítását, amikor a Width és Height tulajdonságok nincsenek beállítva. Az alábbi kódrészlet bemutatja, hogyan lehet használni az [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumerációt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
