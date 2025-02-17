---
title: A CAD Rajz Méretének Beállítása
type: docs
weight: 10
url: /hu/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Az Aspose.CAD for Java használatával a fejlesztők módosíthatják a rajz méretét a CAD formátum átalakítása során. Ez a téma magyarázza a méret automatikus beállításának vagy a méret beállításának megközelítését a [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum segítségével a [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) osztályban.

{{% /alert %}}

## **A CAD rajz méretének beállítása**

Az Aspose.CAD for Java a [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumerációt biztosít a rajz méretének beállításához a CAD formátum átalakítása során. Két módja van a rajz méretének beállításának.

1. Automatikus méretbeállítás
1. Méret beállítása a [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeráció használatával a [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) osztályban

Az automatikus méretbeállításhoz a fejlesztőknek nem szükséges megadni a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály Width és Height tulajdonságait. Az alábbi kódrészlet példát mutat az automatikus méretbeállításra.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

A [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeráció lehetőséget ad a méretezés beállítására, amikor a Width és Height tulajdonságok nincsenek megadva. Az alábbi kódrészlet bemutatja, hogyan használhatjuk a [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) -t.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
