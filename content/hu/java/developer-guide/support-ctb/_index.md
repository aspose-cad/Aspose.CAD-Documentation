---
title: CTB fájlok támogatása
type: docs
weight: 40
url: /hu/java/developer-guide/support-ctb/
---

## **CTB fájlok támogatása**

Néha a színek, vonalsúlyok és egyéb beállítások a rajzokhoz nemcsak a rajzokból, hanem külön CTB fájlokban található plot stílusokból is származhatnak. 
A legegyszerűbb módja ennek az információnak a használata, ha a megfelelő CTB fájlokat a DWG/DXF formátumú rajzfájl közelébe helyezzük, és az azokból származó információk automatikusan alkalmazásra kerülnek 
exportálás során.

Lehetséges az összes CTB fájl Stream formájában való betöltése is a 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) tulajdonság használatával a 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumban.

Íme egy példa, hogyan lehet ezt megtenni:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
