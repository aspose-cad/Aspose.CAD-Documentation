---
title: Automatische Codepagina Detectie
type: docs
weight: 10
url: /nl/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatische Codepagina Detectie**

Aspose.CAD ondersteunt automatische codepagina detectie voor [DWG](https://docs.fileformat.com/cad/dwg/) en [DWF](https://docs.fileformat.com/cad/dwf/) bestanden. Als u deze functie niet wilt gebruiken, kunt u dit overschrijven door de volgende eigenschappen van de [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) klasse in te stellen.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): stelt de codering in die wordt gebruikt om tekstgegevens van niet-Unicode DXF- en DWG-formaten te lezen. Het wordt standaard automatisch gedetecteerd.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): stelt de codering in die wordt gebruikt om MIF-gecodeerde symbolen van CJK-coderingen (M+nXXXX-indeling) te lezen. Het wordt standaard automatisch gedetecteerd.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): bepaalt of CIF (U+XXXX) en MIF-gecodeerde tekens zullen worden gedecodeerd als ze geen juiste AutoCAD-indeling hebben (AutoCAD staat deze symbolen voor met een backslash). Standaard worden ze gedecodeerd.

## Voorbeeldcode

Het onderstaande codevoorbeeld laat zien hoe u de automatische codepagina detectie in Aspose.CAD kunt overschrijven.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
