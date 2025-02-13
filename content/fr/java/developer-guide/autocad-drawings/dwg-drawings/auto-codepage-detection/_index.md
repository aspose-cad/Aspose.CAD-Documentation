---
title: Détection automatique de la page de code
type: docs
weight: 10
url: /fr/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Détection automatique de la page de code**

Aspose.CAD prend en charge la détection automatique de la page de code pour les fichiers [DWG](https://docs.fileformat.com/cad/dwg/) et [DWF](https://docs.fileformat.com/cad/dwf/). Si vous ne souhaitez pas utiliser cette fonctionnalité, vous pouvez la remplacer en définissant les propriétés suivantes de la classe [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): définit l'encodage utilisé pour lire les données textuelles à partir des formats DXF et DWG non-Unicode. Il est autodétecté par défaut.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): définit l'encodage utilisé pour lire les symboles encodés en MIF des encodages CJK (format M+nXXXX). Il est autodétecté par défaut.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): définit si les caractères encodés CIF (U+XXXX) et MIF seront décodés s'ils n'ont pas un formatage AutoCAD approprié (AutoCAD précède ces symboles d'un antislash). Par défaut, ils sont décodés.

## Exemple de code

L'exemple de code ci-dessous montre comment remplacer la détection automatique de la page de code dans Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
