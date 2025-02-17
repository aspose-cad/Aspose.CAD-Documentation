---
title: Automatikus Kódoldal Felismerés
type: docs
weight: 10
url: /hu/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatikus Kódoldal Felismerés**

Az Aspose.CAD támogatja az automatikus kódoldal-felismerést a [DWG](https://docs.fileformat.com/cad/dwg/) és [DWF](https://docs.fileformat.com/cad/dwf/) fájlok esetében. Ha nem szeretné használni ezt a funkciót, felülbírálhatja ezt a **LoadOptions** osztály következő tulajdonságainak beállításával.

- **specified_encoding**: beállítja a nem Unicode DXF és DWG formátumokból származó szöveges adatok olvasásához használt kódolást. Alapértelmezés szerint automatikusan észleli.
- **specified_mif_encoding**: beállítja a MIF-kódolt CJK kódolások szimbólumainak olvasásához használt kódolást (M+nXXXX formátumban). Alapértelmezés szerint automatikusan észleli.
- **recover_malformed_cif_mif**: meghatározza, hogy a CIF (U+XXXX) és MIF-kódolt karaktereket dekódolják-e, ha nem rendelkeznek megfelelő AutoCAD formázással (az AutoCAD ezek elé egy fordított perjelet tesz). Alapértelmezés szerint dekódolják.

## Példa Kód

Az alábbi kódminta azt mutatja be, hogyan lehet felülbírálni az automatikus kódoldal-felismerést az Aspose.CAD-ben.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
