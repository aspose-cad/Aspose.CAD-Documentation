---
title: Ajuster la taille du dessin CAD
type: docs
weight: 10
url: /fr/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

En utilisant la bibliothèque Aspose.CAD pour Python, les développeurs peuvent ajuster la taille du dessin CAD lors de la conversion vers n'importe quel format pris en charge. Ce sujet explique l'approche pour ajuster la taille automatiquement ou manuellement en utilisant l'énumération **UnitType** de la classe **ImageOptions**.

{{% /alert %}}

## **Ajustement de la taille du dessin CAD**

Aspose.CAD pour Python fournit l'énumération **UnitType** pour ajuster la taille du dessin lors de la conversion du format CAD. Il existe deux façons d'ajuster la taille du dessin.

1. Ajustement de taille automatique.
1. Ajuster la taille en utilisant l'énumération **UnitType** de la classe **ImageOptions**.

Pour ajuster automatiquement la taille, les développeurs n'ont pas besoin de fournir les propriétés Width et Height de la classe **CadRasterizationOptions**. Le code ci-dessous est un exemple de taille automatique.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

L'énumération **UnitType** permet d'ajuster l'échelle lorsque les propriétés Width et Height ne sont pas définies. Le code ci-dessous montre comment utiliser **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
