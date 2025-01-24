---
title: DWG Zeichnungen
type: docs
weight: 40
url: /de/net/dwg-drawings/
---

## **Exportieren von DWG Zeichnungen nach PDF**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im [DWG](https://docs.fileformat.com/cad/dwg/) Format laden und in [PDF](https://docs.fileformat.com/pdf/) konvertieren. Dieses Thema erklärt die Verwendung der Aspose.CAD API, um die Konvertierung von DWG in PDF-Format durch einfache Schritte zu erreichen, wie im Folgenden definiert.

{{% alert color="primary" %}}

Die API unterstützt die folgenden AutoCAD DWG Revisionen:

- DWG 2004 Version 16.0 Veröffentlichung 18
- DWG 2005 Version 16.1
- DWG 2010 Version 18.0
- DWG 2013 Version 19.0

{{% /alert %}}

### **DWG-Dateiformat**

Eine [DWG](https://docs.fileformat.com/cad/dwg/) ist eine Binärdatei, die Vektorbilder und Metadaten enthält. Die Vektorbilder geben der CAD-Anwendung Anweisungen, wie die DWG angezeigt werden soll; die Metadaten können verschiedene Informationen über die Datei enthalten, einschließlich standortspezifischer Daten und auch Kundendaten. Offene Spezifikationen für das DWG-Dateiformat können [in diesem PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) gefunden werden.

### **DWG-Dateien in PDF konvertieren**

Die folgenden einfachen Schritte sind erforderlich, um [DWG](https://docs.fileformat.com/cad/dwg/) in [PDF](https://docs.fileformat.com/pdf/) zu konvertieren.

1. Laden Sie die DWG-Datei in eine Instanz von [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) auf, während Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter übergeben.

Das folgende Codebeispiel zeigt, wie man DWG Zeichnungen in PDF exportiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Einzelnes PDF mit unterschiedlichen Layoutgrößen erstellen**

Aspose.CAD für .NET ermöglicht es, eine DWG-Datei in ein einzelnes PDF mit unterschiedlichen Layoutgrößen zu konvertieren. Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die resultierende Seitenhöhe und -breite.
1. Fügen Sie erforderliche [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) für das [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Objekt hinzu.
1. Erstellen Sie eine Instanz der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Exportieren Sie das Bild in PDF mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das Codebeispiel zeigt, wie man ein einzelnes [PDF](https://docs.fileformat.com/pdf/) mit unterschiedlichen Layouts erstellt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Unterstützte AutoCAD-Primitiven**

Die folgenden AutoCAD-Primitiven werden unterstützt.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exportieren eines spezifischen DWG-Layouts nach PDF**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die resultierende Seitenhöhe und -breite.
1. Setzen Sie die [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) Eigenschaft für das [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Objekt.
1. Erstellen Sie eine Instanz der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Exportieren Sie das Bild in PDF mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Codebeispiel zeigt, wie man ein spezifisches Layout von DWG in PDF konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Rendern von DWG-Dokumenten durch Angabe von Koordinaten**

Aspose.CAD für .NET API bietet jetzt die Möglichkeit, DWG-Dokumente zu rendern, indem die Breite und Höhe des Dokuments angegeben wird.

Das folgende Codebeispiel zeigt, wie man ein DWG-Dokument rendert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportieren von DWG nach Raster oder PDF mit fester Größe**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und in PDF oder Raster mit fester Größe konvertieren.

Das folgende Codebeispiel zeigt, wie man diese Funktion implementiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportieren von DWG nach PDF/A und PDF/E**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse.
1. Erstellen Sie eine Instanz der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Setzen Sie die PDF-Konformitätseigenschaft und speichern Sie sie.
1. Exportieren Sie das Bild in PDF mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in PDF/A und PDF/E konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Unterstützung runder, verborgener Linien beim Exportieren von DWG/DXF nach BMP und PDF**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die resultierende Seitenhöhe und -breite.
1. Erstellen Sie eine Instanz der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie ihre [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) Eigenschaft.
1. Exportieren Sie das Bild in PDF mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Codebeispiel zeigt, wie man diese Funktion implementiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Unterstützung für das Festlegen des Druckbereichs für DWG-Bilder im exportierten PDF**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und in PDF konvertieren. Dieses Thema erklärt die Verwendung der Aspose.CAD API, um die Unterstützung für das Festlegen eines Druckbereichs für das DWG-Bild im exportierten PDF zu erreichen.

Das folgende Codebeispiel zeigt, wie man diese Funktion implementiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Unterstützung für das Lesen von XREF-Metadaten für DWG-Dateien**

1. Laden Sie eine DWG-Datei mit der [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Durchlaufen Sie jedes Bildelement.
1. Wenn ein Element ein CadUnderlay ist, dann XREF-Element mit Metadaten.

Das folgende Codebeispiel zeigt, wie man diese Funktion erreicht.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Die Eigenschaft [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) ist vom Typ String-Array, sodass Sie mehrere Layouts gleichzeitig für eine mögliche Konvertierung in PDF-Format angeben können. Wenn mehrere Layouts für die [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) Eigenschaft angegeben werden, hat das resultierende PDF mehrere Seiten, wobei jede Seite ein individuelles AutoCAD-Layout darstellt.

### **Alle Layouts auflisten**

Sie können alle in einer AutoCAD-Zeichnung vorhandenen Layouts mit dem folgenden Code-Snippet auflisten.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Zugriff auf Unterlagenflags für das DWG-Format**

Aspose.CAD für .NET hat die Unterlagenflags für das DWG-Format implementiert und ermöglicht es Entwicklern, auf sie zuzugreifen. Folgendes ist die einfache Code-Demonstration.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Unterstützung für DWG-Elemente**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und unterstützt verschiedene Elemente, mit denen gearbeitet werden kann.

### **Unterstützung für die MLeader-Entität**

Eine DWG ist eine Binärdatei, die Vektorbilder und Metadaten enthält. Es gibt verschiedene Elemente in einer DWG-Datei. Der folgende Abschnitt beschreibt ein Beispiel für die Arbeit mit der MLeader-Entität in der DWG-Datei.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Unterstützung für den Export von DWG-Elementen nach Bild**

Eine DWG ist eine Binärdatei, die Vektorbilder und Metadaten enthält. Es gibt verschiedene Elemente in einer DWG-Datei. Der folgende Abschnitt beschreibt ein Beispiel für den Export eines bestimmten DWG-Elements in das Bild.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Unterstützung für das Hinzufügen von Text in DWG**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und unterstützt verschiedene Elemente, mit denen gearbeitet werden kann. Eine DWG ist eine Binärdatei, die Vektorbilder und Metadaten enthält. Es gibt verschiedene Elemente in einer DWG-Datei. Der folgende Abschnitt beschreibt, wie man Text in die DWG-Datei hinzufügen kann.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Unterstützung für das Importieren von Bildern in DWG-Dateien**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und unterstützt verschiedene Elemente, mit denen gearbeitet werden kann. Eine DWG ist eine Binärdatei, die Vektorbilder und Metadaten enthält. Es gibt verschiedene Elemente in einer DWG-Datei. Der folgende Abschnitt beschreibt, wie man Bilder in die DWG-Datei importieren kann.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Unterstützung für Mesh in DWG**

Aspose.CAD für .NET API kann jetzt auf die Elemente zugreifen, die Mesh unterstützen, einschließlich [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) und [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) Typen. Das folgende Beispiel beschreibt, wie man auf die Mesh-Typen zugreifen kann.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG-Zeichnungen in DXF konvertieren**

Aspose.CAD bietet die Funktion, eine AutoCAD DWG-Datei zu laden und sie in das DXF-Format zu exportieren. Der Ansatz für die DWG-zu-DXF-Konvertierung funktioniert wie folgt:

1. Laden Sie die DWG-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) Fabrikmethode.
1. Exportieren Sie die DWG-Zeichnung in DXF mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in das DXF-Format konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG-Zeichnungen in SVG konvertieren**

Aspose.CAD für .NET API kann AutoCAD Zeichnungen im DWG-Format laden und in SVG konvertieren. Dieses Thema erklärt die Verwendung der Aspose.CAD API, um die Konvertierung von DWG in SVG-Format durch einfache Schritte zu erreichen, wie unten definiert.

1. Laden Sie die DWG-Datei in eine Instanz von [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Erstellen Sie ein Objekt der [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) Klasse und setzen Sie die erforderlichen Eigenschaften.
1. Exportieren Sie die DWG-Zeichnung in SVG mit der [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in das SVG-Format konvertiert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Große DWG-Datei laden**

Aspose.CAD für .NET bietet die Möglichkeit, sehr große DWG-Dateien mit der [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) Klasse zu öffnen. Jetzt können Sie große Dateien ganz einfach mit Hilfe des folgenden Beispielcodes öffnen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}