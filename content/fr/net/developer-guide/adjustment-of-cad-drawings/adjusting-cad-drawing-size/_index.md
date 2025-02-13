---
title: Ajustement de la taille des dessins CAD
type: docs
weight: 10
url: /fr/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

En utilisant la bibliothèque Aspose.CAD pour .NET, les développeurs peuvent ajuster la taille des dessins CAD lors de la conversion vers n'importe quel format supporté. Ce sujet explique l'approche pour ajuster la taille automatiquement ou manuellement en utilisant l'énumération [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) de la classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Ajustement de la taille des dessins CAD**

Aspose.CAD pour .NET fournit l'énumération [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) pour ajuster la taille du dessin lors de la conversion du format CAD. Il existe deux manières d'ajuster la taille du dessin.

1. Ajustement automatique de la taille.
1. Ajuster la taille en utilisant l'énumération [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) de la classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Pour ajuster automatiquement la taille, les développeurs n'ont pas besoin de fournir les propriétés Width et Height de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Le code ci-dessous est un exemple de redimensionnement automatique.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

L'énumération [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) offre la possibilité d'ajuster l'échelle lorsque les propriétés Width et Height ne sont pas définies. Le code ci-dessous démontre comment utiliser [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
