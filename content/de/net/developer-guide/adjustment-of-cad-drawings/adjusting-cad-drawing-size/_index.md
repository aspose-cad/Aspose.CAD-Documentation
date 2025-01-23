---
title: Anpassen der Größe von CAD-Zeichnungen
type: docs
weight: 10
url: /de/net/anpassen-der-groesse-von-cad-zeichnungen/
---

{{% alert color="primary" %}}

Durch die Verwendung der Aspose.CAD für die .NET-Bibliothek können Entwickler die Größe von CAD-Zeichnungen bei der Konvertierung in ein beliebiges unterstütztes Format anpassen. Dieses Thema erläutert den Ansatz zur automatischen oder manuellen Anpassung der Größe unter Verwendung des [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) Enums der [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) Klasse.

{{% /alert %}}

## Anpassen der Größe von CAD-Zeichnungen

Aspose.CAD für .NET bietet die [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) Aufzählung, um die Größe der Zeichnung während der Konvertierung des CAD-Formats anzupassen. Es gibt zwei Möglichkeiten, die Zeichnungsgröße anzupassen.

1. Automatische Größenanpassung.
1. Größe anpassen unter Verwendung der [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) Aufzählung der [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) Klasse

Für eine automatische Anpassung der Größe müssen Entwickler nicht die Breiten- und Höhen-Eigenschaften der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) Klasse angeben. Der unten bereitgestellte Codeausschnitt ist ein Beispiel für die automatische Größenanpassung.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Die [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) Aufzählung ermöglicht eine Anpassung der Skalierung, wenn die Breiten- und Höhen-Eigenschaften nicht festgelegt sind. Der unten bereitgestellte Codeausschnitt zeigt, wie man [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) verwendet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
