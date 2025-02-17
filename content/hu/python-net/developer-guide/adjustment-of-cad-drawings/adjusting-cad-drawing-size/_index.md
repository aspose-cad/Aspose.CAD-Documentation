---
title: A CAD Rajz Méretének Beállítása
type: docs
weight: 10
url: /hu/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Az Aspose.CAD for Python könyvtár használatával a fejlesztők a CAD rajz méretét módosíthatják a támogatott formátumra történő konvertálás során. Ez a téma a méret automatikus vagy manuális beállításának megközelítését magyarázza el a **UnitType** enum és az **ImageOptions** osztály használatával.

{{% /alert %}}

## **A CAD rajz méretének beállítása**

Az Aspose.CAD for Python biztosítja a **UnitType** enumerációt a rajz méretének beállításához a CAD formátum konvertálása során. Két módja van a rajz méretének beállítására.

1. Automatikus méretbeállítás.
1. Méret beállítása a **UnitType** enumeráció használatával az **ImageOptions** osztályban.

Az automatikus méretbeállításhoz a fejlesztőknek nem kell megadniuk a **CadRasterizationOptions** osztály Szélesség és Magasság tulajdonságait. Az alábbi kódrészlet egy példa az automatikus méretezésre.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

A **UnitType** enumeráció lehetővé teszi a méretezés beállítását, amikor a Szélesség és Magasság tulajdonságokat nem állítják be. Az alábbi kódrészlet bemutatja, hogyan lehet használni a **UnitType**-ot.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
