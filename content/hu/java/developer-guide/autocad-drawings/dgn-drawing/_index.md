---
title: DGN Rajz
type: docs
weight: 10
url: /hu/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **DGN formátumú rajz mint a DWG része**

Az Aspose.CAD Java-hoz lehetővé teszi a fejlesztők számára, hogy DGN alátétet beágyazott DWG fájlt exportáljanak. Az alábbi kód bemutatja, hogyan lehet hozzáférni a DGN alátéthez egy DWG fájl exportálása során.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **3D entitások támogatása a DGN v7-hez**

Az Aspose.CAD Java API bevezette a funkciót, amely lehetővé teszi egy DGN AutoCAD fájl betöltését és a 3D entitások támogatását a DGN v7-hez. A [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) osztály szolgál erre a célra. Minden DGN kép 9 előre definiált nézetet támogat. Ezek száma 1-től 9-ig terjed. Ha a nézet nincs definiálva az exportálás során, a többoldalas kimeneti formátumokhoz (például PDF) minden nézet exportálva lesz, mindegyik külön oldalon. A DGN fájlformátumnál támogatott a 3D entitások, valamint a 2D entitások is.
A VectorRasterizationOptions.TypeOfEntities már nem használható a DGN formátum esetében (a 2D és 3D egyidejűleg támogatott).

Minta kód a támogatott DGN elemek megtekintéséhez.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
