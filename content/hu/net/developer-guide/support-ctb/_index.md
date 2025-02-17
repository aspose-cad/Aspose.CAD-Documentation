---
title: CTB fájlok támogatása
type: docs
weight: 40
url: /hu/net/developer-guide/support-ctb/
---

## **CTB fájlok támogatása**

Néha a színek, vonalsúlyok és egyéb lehetőségek a rajzokhoz nemcsak magukból a rajzokból, hanem külön CTB fájlok plot stílusaiból is származhatnak. 
A legegyszerűbb módja ennek az információnak a felhasználására az, ha a megfelelő CTB fájlokat a DWG/DXF formátumú rajzfájl mellett helyezzük el, így az információ automatikusan alkalmazásra kerül
exportáláskor.

Lehetséges az összes CTB fájl betöltése Stream formájában is, az 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) tulajdonság használatával 
a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektumban.

Itt egy példa arra, hogyan lehet ezt megtenni:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
