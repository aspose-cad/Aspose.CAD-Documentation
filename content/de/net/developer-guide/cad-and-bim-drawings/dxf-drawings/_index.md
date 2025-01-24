---
title: DXF Zeichnungen
type: docs
weight: 60
url: /de/net/dxf-drawings/
---

## **Exportieren von DXF Zeichnungen nach PDF**

Aspose.CAD bietet die Möglichkeit, AutoCAD DXF Zeichnungselemente zu laden und sie als gesamte Zeichnung im PDF-Format zu rendern. Der Ansatz für die DXF-zu-PDF-Konvertierung funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter.

Das folgende Code-Beispiel zeigt, wie man eine Datei mit den Standardeinstellungen konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Unterstützte Formate**

Im Moment unterstützen wir voll zur AutoCAD DXF 2010-Dateiformate. Die vorherigen DXF-Versionen sind nicht garantiert 100% gültig. Wir planen, in zukünftigen Aspose.CAD-Versionen weitere Formate und Funktionen hinzuzufügen.

### **Unterstützte Elemente**

Momentan unterstützen wir alle weit verbreiteten 2D-Elemente und ihre grundlegenden Standardparameter wie folgt:

1. Ausgerichtete Dimension
1. Winkelmaß
1. Bogen
1. Attribut
1. Blockreferenz
1. Kreis
1. Durchmessermaß
1. Ellipse
1. Schraffur
1. Linie
1. Mehrzeiliger Text
1. Ordinate
1. Punkt
1. Polyline
1. Radialmaß
1. Strahl
1. Rotierte Dimension
1. Tabelle
1. Text
1. Xline

{{% alert color="primary" %}}

Wenn wir beim Parsen auf ein Element oder eine Eigenschaft stoßen, die wir nicht unterstützen, wird das Element oder die Eigenschaft stillschweigend ignoriert.

{{% /alert %}}

### **Speicherverwaltung**

Die Eigenschaft [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) der [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) Klasse kann verwendet werden, um die Speicherneuzuweisung zu steuern. Eine Neuzuweisung erfolgt höchstwahrscheinlich für vorzugewiesene Caches. Dies kann geschehen, wenn das System erkennt, dass der zugewiesene Platz nicht ausreicht.

- Wenn [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) auf den Standardwert, **False**, gesetzt ist, wird der Platz auf demselben Medium neu zugewiesen.
- Wenn es auf **True** gesetzt ist, darf die Neu­zu­weisung den maximal angegebenen Platz nicht überschreiten. In diesem Fall wird der vorhandene zugewiesene In-Memory-Cache (der eine Neuzuweisung erfordert) freigegeben und zusätzlicher Platz auf der Festplatte zugewiesen.

## **Exportieren einer bestimmten Ebene von DXF Zeichnungen nach PDF**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) an.
1. Fügen Sie Ebenen zum Objekt von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) hinzu.
1. Erstellen Sie eine Instanz von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Rufen Sie die [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode auf und übergeben Sie das Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter.

Das folgende Code-Beispiel zeigt, wie man eine bestimmte Ebene von DXF nach PDF konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **PDF-Dateien als Teil von DXF Zeichnungen rendern**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und laden Sie PDF-Dateien.
1. Setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und speichern Sie die Datei.

Das folgende Code-Beispiel zeigt, wie man PDF-Dateien als Teil von DXF Zeichnungen rendert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Exportieren des eingebetteten DGN-Unterlageformats für DXF**

Aspose.CAD bietet die Möglichkeit, AutoCAD DXF-Dateien zu laden und eingebettete DGN-Unterlagen für DXF-Formate zu exportieren.

Das folgende Code-Beispiel zeigt, wie die spezifizierten Anforderungen erreicht werden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Unterstützung für das Speichern von DXF-Dateien**

Aspose.CAD bietet die Funktion, AutoCAD DXF-Dateien zu laden, Änderungen darin vorzunehmen und sie erneut als DXF-Datei zu speichern.

Das folgende Code-Beispiel zeigt, wie die spezifizierten Anforderungen erreicht werden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF in WMF exportieren**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und laden Sie PDF-Dateien.
1. Setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und speichern Sie die Datei.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportieren einer bestimmten DXF-Anordnung nach PDF**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) an.
1. Geben Sie die gewünschten Layoutnamen mit der [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) Eigenschaft an.
1. Erstellen Sie eine Instanz von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Exportieren Sie die Zeichnung nach PDF, indem Sie die [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode aufrufen und das Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter übergeben.

Das folgende Code-Beispiel zeigt, wie man eine bestimmte DXF-Anordnung nach PDF konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Die Eigenschaft [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) ist vom Typ String-Array, sodass Sie mehr als ein Layout gleichzeitig für die mögliche Konvertierung in PDF-Format angeben können. Bei der Angabe mehrerer Layouts für die [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) Eigenschaft würde das resultierende PDF mehrere Seiten haben, wobei jede Seite ein individuelles AutoCAD-Layout darstellt.

{{% /alert %}}

## **Unterstützung von Block-Clipping**

Aspose.CAD bietet die Funktion des Block-Clippings. Der Block-Clipping-Ansatz funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und laden Sie PDF-Dateien.
1. Setzen Sie die gewünschten Eigenschaften von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter und speichern Sie die Datei.

Das folgende Code-Beispiel zeigt, wie Block-Clipping funktioniert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Bilder in DXF exportieren**

Mit Aspose.CAD können Sie Bilder im DXF-Format exportieren. Mit diesem Ansatz können Sie die folgenden Aktionen ausführen:

1. Neue Schriftart festlegen
1. Elemente ausblenden
1. Text aktualisieren

Das folgende Code-Snippet zeigt Ihnen, wie Sie die oben genannten Aktionen ausführen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportieren einer bestimmten Ebene von DXF Zeichnungen nach Bild**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) und [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) an.
1. Fügen Sie Ebenen zum Objekt von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) hinzu.
1. Erstellen Sie eine Instanz von [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) und setzen Sie deren [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Exportieren Sie die Zeichnung nach PDF mit der [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Code-Beispiel zeigt, wie man eine bestimmte Ebene von DXF nach Bild konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}