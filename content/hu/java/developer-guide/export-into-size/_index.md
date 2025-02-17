---
title: DWG/DXF rajz és elrendezések exportálása meghatározott méretbe
type: docs
weight: 40
url: /hu/java/developer-guide/export-into-size/
---

## **Model és minden elrendezés exportálása A4-es PDF méretre**

Az Aspose.CAD API lehetővé teszi a DWG/DXF fájl összes lapjának exportálását megadott fizikai PDF méretbe.
Az alábbi minta kód beállítja a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) objektum méretét a kívánt PDF méret eléréséhez.
Az A4-es papírlap mérete 210x297 milliméter vagy 8,27x11,69 hüvelyk, és ezeket az értékeket használják a kódban.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **CAD elrendezések exportálása PDF-be különböző méretekben**

Néha szükséges az elrendezést fizikai méretében exportálni. Az alábbi példa bemutatja a rajz exportálását többlapos PDF-be, ahol minden egyes oldal elrendezésének tartalma saját fizikai PDF mérettel rendelkezik. Ez a példa a [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) tulajdonságot használja.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
