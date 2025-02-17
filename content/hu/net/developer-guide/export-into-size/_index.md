---
title: DWG/DXF rajz és elrendezések exportálása meghatározott méretbe
type: docs
weight: 40
url: /hu/net/developer-guide/export-into-size/
---

## **Exportálás A4-es PDF méretű modellből és minden elrendezésből**

Az Aspose.CAD API lehetővé teszi, hogy az DWG/DXF fájl összes lapját egy megadott fizikai PDF méretbe exportáljuk.

A következő példakód beállítja a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektum méretét a kívánt PDF méret eléréséhez.
Az A4-es papírlap mérete 210x297 milliméter vagy 8,27x11,69 hüvelyk, és ezeket az értékeket használja a kód.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **CAD elrendezések exportálása PDF-be eltérő méretben**

Néha szükséges az elrendezést annak fizikai méretében exportálni. Az alábbi példa bemutatja a rajz exportálását egy többoldalas PDF-be, ahol minden oldal, amely elrendezés tartalmát tartalmazza, saját fizikai PDF mérettel rendelkezik. Ez a példa a [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) tulajdonságot használja.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
