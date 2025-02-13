---
title: Détection Automatique de Codepage
type: docs
weight: 10
url: /fr/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Détection Automatique de Codepage**

Aspose.CAD prend en charge la détection automatique de codepage pour les fichiers [DWG](https://docs.fileformat.com/cad/dwg/) et [DWF](https://docs.fileformat.com/cad/dwf/). Si vous ne souhaitez pas utiliser cette fonctionnalité, vous pouvez la remplacer en définissant les propriétés suivantes de la classe **LoadOptions**.

- **specified_encoding**: définit l'encodage utilisé pour lire les données textuelles à partir des formats DXF et DWG non-Unicode. Il est autodétecté par défaut.
- **specified_mif_encoding**: définit l'encodage utilisé pour lire les symboles encodés MIF des encodages CJK (format M+nXXXX). Il est autodétecté par défaut.
- **recover_malformed_cif_mif**: définit si les caractères encodés CIF (U+XXXX) et MIF seront décodés s'ils n'ont pas un formatage AutoCAD approprié (AutoCAD précède ces symboles par un backslash). Par défaut, ils sont décodés.

## Exemple de Code

L'exemple de code ci-dessous montre comment remplacer la détection automatique de codepage dans Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
