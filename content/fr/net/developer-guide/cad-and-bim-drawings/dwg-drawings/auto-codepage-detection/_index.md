---
title: Détection automatique de la page de code
type: docs
weight: 10
url: /fr/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Détection automatique de la page de code**

Aspose.CAD prend en charge la détection automatique de la page de code pour les fichiers [DWG](https://docs.fileformat.com/cad/dwg/) et [DWF](https://docs.fileformat.com/cad/dwf/). Si vous ne souhaitez pas utiliser cette fonctionnalité, vous pouvez l'outrepasser en définissant les propriétés suivantes de la classe [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): définit l'encodage utilisé pour lire les données textuelles à partir des formats DXF et DWG non-Unicode. Il est autodétecté par défaut.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): définit l'encodage utilisé pour lire les symboles codés MIF des encodages CJK (format M+nXXXX). Il est autodétecté par défaut.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): définit si les caractères encodés CIF (U+XXXX) et MIF seront décodés s'ils n'ont pas un formatage AutoCAD approprié (AutoCAD précède ces symboles d'un antislash). Par défaut, ils sont décodés.

## Exemple de code

L'exemple de code ci-dessous montre comment outrepasser la détection automatique de la page de code dans Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
