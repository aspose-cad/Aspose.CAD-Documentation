---
title: Auto Codepage Detectie
type: docs
weight: 10
url: /nl/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Auto Codepage Detectie**

Aspose.CAD ondersteunt automatische codepage detectie voor [DWG](https://docs.fileformat.com/cad/dwg/) en [DWF](https://docs.fileformat.com/cad/dwf/) bestanden. Als je deze functie niet wilt gebruiken, kun je dit overschrijven door de volgende eigenschappen van de **LoadOptions** klasse in te stellen.

- **specified_encoding**: stelt de codering in die gebruikt wordt om tekstgegevens te lezen uit niet-Unicode DXF en DWG indelingen. Het wordt standaard automatisch gedetecteerd.
- **specified_mif_encoding**: stelt de codering in die gebruikt wordt om MIF-gecodeerde symbolen van CJK-coderingen (M+nXXXX formaat) te lezen. Het wordt standaard automatisch gedetecteerd.
- **recover_malformed_cif_mif**: definieert of CIF (U+XXXX) en MIF-gecodeerde tekens gedecodeerd zullen worden als ze geen juiste AutoCAD opmaak hebben (AutoCAD gaat deze symbolen voor met een backslash). Standaard worden ze gedecodeerd.

## Voorbeeldcode

Het onderstaande codevoorbeeld laat zien hoe je de automatische codepage detectie in Aspose.CAD kunt overschrijven.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
