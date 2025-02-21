---
title: Automatische Codepagina Detectie
type: docs
weight: 10
url: /nl/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatische Codepagina Detectie**

Aspose.CAD ondersteunt automatische codepagina detectie voor [DWG](https://docs.fileformat.com/cad/dwg/) en [DWF](https://docs.fileformat.com/cad/dwf/) bestanden. Als je deze functie niet wilt gebruiken, kun je dit overschrijven door de volgende eigenschappen van de [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) klasse in te stellen.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): stelt de codering in die wordt gebruikt om tekstgegevens te lezen uit niet-Unicode DXF- en DWG-indelingen. Het wordt standaard automatisch gedetecteerd.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): stelt de codering in die wordt gebruikt om MIF-gecodeerde symbolen van CJK-coderingen (M+nXXXX-indeling) te lezen. Het wordt standaard automatisch gedetecteerd.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): bepaalt of CIF (U+XXXX) en MIF-gecodeerde karakters zullen worden gedecodeerd als ze geen juiste AutoCAD-opmaak hebben (AutoCAD plaatst deze symbolen voorafgaand met een backslash). Standaard worden ze gedecodeerd.

## Voorbeeldcode

Het onderstaande codevoorbeeld toont hoe je de automatische codepagina detectie in Aspose.CAD kunt overschrijven.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
