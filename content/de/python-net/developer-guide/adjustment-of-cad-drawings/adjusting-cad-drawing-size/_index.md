---
title: Anpassung der CAD-Zeichnungsgröße
type: docs
weight: 10
url: /de/python-net/anpassung-der-cad-zeichnungsgröße/
---

{{% alert color="primary" %}}

Durch die Verwendung der Aspose.CAD-Bibliothek für Python können Entwickler die Größe der CAD-Zeichnung während der Konvertierung in ein unterstütztes Format anpassen. Dieses Thema erklärt den Ansatz zur automatischen oder manuellen Anpassung der Größe mithilfe der **UnitType**-Enumeration der **ImageOptions**-Klasse.

{{% /alert %}}

## **Anpassung der CAD-Zeichnungsgröße**

Aspose.CAD für Python bietet die **UnitType**-Enumeration zur Anpassung der Größe der Zeichnung während der Konvertierung des CAD-Formats. Es gibt zwei Möglichkeiten, die Größe der Zeichnung anzupassen.

1. Automatische Größenanpassung.
1. Größe mithilfe der **UnitType**-Enumeration der **ImageOptions**-Klasse anpassen.

Für die automatische Größenanpassung müssen Entwickler die Eigenschaften Width und Height der **CadRasterizationOptions**-Klasse nicht angeben. Der unten angegebene Codeausschnitt ist ein Beispiel für die automatische Größenanpassung.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Die **UnitType**-Enumeration ermöglicht die Anpassung der Skalierung, wenn die Eigenschaften Width und Height nicht gesetzt sind. Der unten angegebene Codeausschnitt zeigt, wie man **UnitType** verwendet.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
