---
title: DWG Zeichnungen
type: docs
weight: 70
url: /de/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportieren von DWG Zeichnungen nach PDF**

Aspose.CAD für Python API kann AutoCAD-Zeichnungen im [DWG](https://docs.fileformat.com/cad/dwg/) Format laden und in [PDF](https://docs.fileformat.com/pdf/) konvertieren. Dieses Thema erklärt die Verwendung der Aspose.CAD API, um die Konvertierung von DWG in das PDF-Format durch einfache Schritte zu erreichen, die im Folgenden definiert sind.

{{% alert color="primary" %}}

Die API unterstützt die folgenden AutoCAD DWG Revisionen:

- DWG 2004 Version 16.0 Veröffentlichung 18
- DWG 2005 Version 16.1
- DWG 2010 Version 18.0
- DWG 2013 Version 19.0

{{% /alert %}}

### **DWG-Dateiformat**

Eine [DWG](https://docs.fileformat.com/cad/dwg/) ist eine Binärdatei, die Vektorgrafikdaten und Metadaten enthält. Die Vektorgrafikdaten geben der CAD-Anwendung Anweisungen, wie die DWG angezeigt werden soll; die Metadaten können eine Vielzahl von Informationen über die Datei enthalten, einschließlich ortsspezifischer Daten und auch Kundendaten. Offene Spezifikationen für das DWG-Dateiformat können [in diesem PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) gefunden werden.

### **DWG-Dateien in PDF konvertieren**

Die folgenden einfachen Schritte sind erforderlich, um [DWG](https://docs.fileformat.com/cad/dwg/) in [PDF](https://docs.fileformat.com/pdf/) zu konvertieren.

1. Laden Sie die DWG-Datei in eine Instanz von **Image**.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **VectorRasterizationOptions**.
1. Rufen Sie **Image.save** auf, während Sie ein Objekt von **PdfOptions** als zweiten Parameter übergeben.

Das folgende Codebeispiel zeigt, wie man DWG Zeichnungen nach PDF exportiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Unterstützte AutoCAD Primitives**

Die folgenden AutoCAD-Primitives werden unterstützt.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- BOGEN
- ELLIPSE
- HATCH
- FÜHRER
- PUNKT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- STRAHL
- KREIS
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- FORM
- SOLID
- SPLINE
- MLINE
- LINIE
- XLINE
- STIL
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exportieren eines bestimmten DWG-Layouts nach PDF**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der **Aspose.CAD.Image.load** Fabrikmethode.
1. Erstellen Sie eine Instanz der Klasse **CadRasterizationOptions** und setzen Sie die resultierende Seitenhöhe und -breite.
1. Setzen Sie die Eigenschaft **Layouts** für das **CadRasterizationOptions** Objekt.
1. Erstellen Sie eine Instanz der Klasse **PdfOptions** und setzen Sie deren **VectorRasterizationOptions** Eigenschaft.
1. Exportieren Sie das Bild nach PDF mit der Methode **Image.save()**.

Das folgende Codebeispiel zeigt, wie man ein bestimmtes Layout von DWG nach PDF konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Exportieren von DWG nach PDF/A und PDF/E**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie eine DWG-Datei mit der **Image.load** Fabrikmethode.
1. Erstellen Sie eine Instanz der Klasse **CadRasterizationOptions**.
1. Erstellen Sie eine Instanz der Klasse **PdfOptions** und setzen Sie deren **VectorRasterizationOptions** Eigenschaft.
1. Setzen Sie die PDF-Konformitätseigenschaft und speichern Sie sie.
1. Exportieren Sie das Bild nach PDF mit der Methode **Image.save()**.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in PDF/A und PDF/E konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG Zeichnungen in DXF konvertieren**

Aspose.CAD bietet die Möglichkeit, eine AutoCAD DWG-Datei zu laden und sie in das DXF-Format zu exportieren. Der Ansatz zur Konvertierung von DWG in DXF funktioniert wie folgt:

1. Laden Sie die DWG-Zeichnungsdatei mit der **Image.load** Fabrikmethode.
1. Exportieren Sie die DWG-Zeichnung in das DXF-Format mit der Methode **Image.save()**.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in das DXF-Format konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG Zeichnungen in SVG konvertieren**

Aspose.CAD für Python API kann AutoCAD-Zeichnungen im DWG-Format laden und in SVG konvertieren. Dieses Thema erklärt die Verwendung der Aspose.CAD API, um die Konvertierung von DWG in das SVG-Format durch einfache Schritte zu erreichen, die im Folgenden definiert sind.

1. Laden Sie die DWG-Datei in eine Instanz von **Image**.
1. Erstellen Sie ein Objekt der Klasse **SvgOptions** und setzen Sie die erforderlichen Eigenschaften.
1. Exportieren Sie die DWG-Zeichnung in SVG mit der Methode **Image.save()**.

Das folgende Codebeispiel zeigt, wie man eine DWG-Datei in das SVG-Format konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
