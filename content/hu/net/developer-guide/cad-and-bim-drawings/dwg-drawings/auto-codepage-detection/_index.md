---
title: Automatikus kódoldal-észlelés
type: docs
weight: 10
url: /hu/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatikus kódoldal-észlelés**

Az Aspose.CAD támogatja az automatikus kódoldal-észlelést a [DWG](https://docs.fileformat.com/cad/dwg/) és [DWF](https://docs.fileformat.com/cad/dwf/) fájlokhoz. Ha nem szeretné használni ezt a funkciót, felülbírálhatja ezt a következő tulajdonságok beállításával a [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) osztályban.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): beállítja a szöveges adatok olvasásához használt kódolást nem Unicode DXF és DWG formátumokból. Alapértelmezés szerint automatikusan észlelve.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): beállítja a MIF-kódolt CJK kódolások szimbólumainak olvasásához használt kódolást (M+nXXXX formátum). Alapértelmezés szerint automatikusan észlelve.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): meghatározza, hogy a CIF (U+XXXX) és MIF-kódolt karakterek dekódolva lesznek-e, ha nem rendelkeznek megfelelő AutoCAD formázással (az AutoCAD ezeket a szimbólumokat egy visszafelé perjel megelőzi). Alapértelmezés szerint dekódolva vannak.

## Mintakód

Az alábbi kódminta bemutatja, hogyan lehet felülbírálni az automatikus kódoldal-észlelést az Aspose.CAD-ban.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
