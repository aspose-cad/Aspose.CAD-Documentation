---
title: Automatikus Kódoldal Észlelés
type: docs
weight: 10
url: /hu/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatikus Kódoldal Észlelés**

Aspose.CAD támogatja az automatikus kódoldal-észlelést a [DWG](https://docs.fileformat.com/cad/dwg/) és [DWF](https://docs.fileformat.com/cad/dwf/) fájlok esetében. Ha nem kívánja használni ezt a funkciót, felülbírálhatja az alábbi [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) osztály tulajdonságainak beállításával.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): meghatározza a szöveges adatok olvasásához használt kódolást nem-Unicode DXF és DWG formátumokból. Alapértelmezés szerint automatikusan észlelésre kerül.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): meghatározza a CJK kódolások MIF-kódolt szimbólumainak olvasásához használt kódolást (M+nXXXX formátum). Alapértelmezés szerint automatikusan észlelésre kerül.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): meghatározza, hogy a CIF (U+XXXX) és MIF-kódolt karakterek dekódolásra kerülnek-e, ha nem rendelkeznek megfelelő AutoCAD formázással (az AutoCAD ezeket a szimbólumokat hátrafelé kereszthellyel előzi meg). Alapértelmezés szerint dekódolják őket.

## Minta Kód

Az alábbi kód példája bemutatja, hogyan lehet felülbírálni az automatikus kódoldal-észlelést az Aspose.CAD-ben.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
