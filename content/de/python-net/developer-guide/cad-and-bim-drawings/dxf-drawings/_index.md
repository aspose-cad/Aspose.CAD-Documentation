---
title: DXF Zeichnungen
type: docs
weight: 10
url: /de/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportieren von DXF Zeichnungen nach PDF**

Aspose.CAD bietet die Möglichkeit, AutoCAD DXF Zeichnungselemente zu laden und sie als gesamte Zeichnung im PDF-Format darzustellen. Der Ansatz zur Umwandlung von DXF in PDF funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der **Image.load** Factory-Methode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **VectorRasterizationOptions**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt von **PdfOptions** als zweiten Parameter.

Das folgende Beispiel zeigt, wie man eine Datei mit den Standardeinstellungen konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Unterstützte Formate**

Im Moment unterstützen wir vollständig die AutoCAD DXF 2010-Dateiformate. Die vorherigen DXF-Versionen sind nicht garantiert 100 % gültig. Wir planen, in zukünftigen Versionen von Aspose.CAD weitere Formate und Funktionen einzubeziehen.

### **Unterstützte Elemente**

Im Moment unterstützen wir alle verbreiteten 2D-Elemente und deren grundlegende Standardparameter wie folgt:

1. Ausgerichtete Dimension
1. Winkel-Dimension
1. Bogen
1. Attribut
1. Blockreferenz
1. Kreis
1. Durchmesser-Dimension
1. Ellipse
1. Füllung
1. Linie
1. Mehrzeiliger Text
1. Ordinate-Dimension
1. Punkt
1. Polylinie
1. Radialdimension
1. Strahl
1. Rotierte Dimension
1. Tabelle
1. Text
1. Xline

{{% alert color="primary" %}}

Wenn wir während des Parsens auf ein Element oder eine Eigenschaft stoßen, die wir nicht unterstützen, wird das Element oder die Eigenschaft stillschweigend ignoriert.

{{% /alert %}}

## **Export eingebetteter DGN-Hinterlage für DXF-Format**

Aspose.CAD bietet die Möglichkeit, AutoCAD DXF-Dateien zu laden und die eingebettete DGN-Hinterlage für das DXF-Format zu exportieren.

Das folgende Beispiel zeigt, wie man die angegebenen Anforderungen erfüllen kann.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Unterstützung für das Speichern von DXF-Dateien**

Aspose.CAD bietet die Möglichkeit, AutoCAD DXF-Dateien zu laden, Änderungen daran vorzunehmen und sie dann erneut als DXF-Datei zu speichern.

Das folgende Beispiel zeigt, wie man die angegebenen Anforderungen erfüllen kann.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **DXF nach WMF exportieren**

Dieser Ansatz funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mit der **Image.load** Factory-Methode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und laden Sie PDF-Dateien.
1. Setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Rufen Sie **Image.save** auf und speichern Sie die Datei.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
