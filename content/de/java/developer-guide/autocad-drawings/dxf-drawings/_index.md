---
title: DXF-Zeichnungen
type: docs
weight: 60
url: /de/java/dxf-zeichnungen/
---

## **Exportieren von DXF-Zeichnungen als PDF**

Aspose.CAD bietet die Funktion, AutoCAD DXF-Zeichenentitäten zu laden und als gesamte Zeichnung im PDF-Format zu rendern. Der Ansatz zur DXF-zu-PDF-Konvertierung funktioniert wie folgt:

1. Laden Sie die DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) und [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) .
1. Rufen Sie Image.Save auf und übergeben Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) als zweiten Parameter.

Das folgende Codebeispiel zeigt, wie Sie eine Datei mit den Standardeinstellungen konvertieren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Unterstützte Formate**

Derzeit unterstützen wir vollständig AutoCAD DXF 2010 Dateiformate. Frühere DXF-Versionen sind nicht garantiert zu 100% gültig. Wir planen, in zukünftigen Aspose.CAD-Versionen mehr Formate und Funktionen einzuschließen.

### **Unterstützte Entitäten**

Derzeit unterstützen wir alle verbreiteten 2D-Entitäten und ihre grundlegenden Standardparameter wie folgt:

1. Ausgerichtete Dimension
1. Winkelabmessung
1. Bogen
1. Attribut
1. Blockreferenz
1. Kreis
1. Durchmessersdimension
1. Ellipse
1. Schraffur
1. Linie
1. Mehrzeiliger Text
1. Ordinatenabmessung
1. Punkt
1. Polylinie
1. Radialabmessung
1. Strahl
1. Gedrehte Dimension
1. Tabelle
1. Text
1. Xline

{{% alert color="primary" %}}

Wenn wir beim Parsen auf eine Entität oder Eigenschaft stoßen, die wir nicht unterstützen, wird die Entität oder Eigenschaft stillschweigend ignoriert.

{{% /alert %}}

### **Speicherverwaltung**

Die Eigenschaft [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) kann verwendet werden, um die Speicherneuzuweisung zu steuern. Eine Neuzuweisung erfolgt höchstwahrscheinlich für vorab allokierte Caches. Sie kann auftreten, wenn das System feststellt, dass der zugeteilte Speicherplatz nicht ausreicht.

- Wenn [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) auf den Standardwert, **False**, gesetzt ist, wird der Speicherplatz neu zugewiesen, um das gleiche Medium.
- Wenn es auf **True** gesetzt ist, darf die Neuzuweisung den maximal angegebenen Speicherplatz nicht überschreiten. In diesem Fall werden der vorhandene im Speicher allokierte Cache (der eine Neuzuweisung erfordert) freigegeben und zusätzlicher Speicherplatz wird auf der Festplatte allokiert.

## **Exportieren einer bestimmten Ebene von DXF-Zeichnungen als PDF**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) und [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) an.
1. Fügen Sie Ebenen zum Objekt von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) hinzu.
1. Erstellen Sie eine Instanz von [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportieren Sie die Zeichnung als PDF mithilfe der Methode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Das folgende Codebeispiel zeigt, wie Sie eine spezifische Ebene von DXF in PDF konvertieren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportieren einer bestimmten Ebene von DXF-Zeichnungen als Bild**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) und [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) an.
1. Fügen Sie Ebenen zum Objekt von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) hinzu.
1. Erstellen Sie eine Instanz von [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportieren Sie die Zeichnung als Bild mithilfe der Methode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Das folgende Codebeispiel zeigt, wie Sie eine spezifische Ebene von DXF in ein Bild konvertieren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **PDF-Dateien als Teil von DXF-Zeichnungen rendern**

Dieser Ansatz funktioniert folgendermaßen:

1. Laden Sie die DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und laden Sie PDF-Dateien.
1. Setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) und [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Rufen Sie [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) auf und speichern Sie die Datei.

Das folgende Codebeispiel zeigt, wie man PDF-Dateien als Teil von DXF-Zeichnungen rendert.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Exportieren von DXF nach WMF**

Dieser Ansatz funktioniert folgendermaßen:

1. Laden Sie die DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und laden Sie PDF-Dateien.
1. Setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) und [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Rufen Sie [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) auf und speichern Sie die Datei.

Das folgende Codebeispiel zeigt, wie man DXF nach WMF exportiert.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Unterstützung beim Speichern von DXF-Dateien**

Aspose.CAD bietet die Funktion, AutoCAD DXF-Dateien zu laden, Änderungen daran vorzunehmen und sie erneut als DXF-Datei zu speichern. Das folgende Codebeispiel zeigt, wie die angegebenen Anforderungen erreicht werden können

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Einbetten von DGN-Unterbau für das DXF-Format exportieren**

Aspose.CAD bietet die Funktion, AutoCAD DXF-Dateien zu laden und den eingebetteten DGN-Unterbau für das DXF-Format zu exportieren.

Das folgende Codebeispiel zeigt, wie die angegebenen Anforderungen erreicht werden können.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Spezifisches DXF-Layout in PDF exportieren**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und geben Sie die Eigenschaften [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) und [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) an.
1. Geben Sie die gewünschten Layoutnamen mit der Eigenschaft [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) an.
1. Erstellen Sie eine Instanz von [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportieren Sie die Zeichnung als PDF mithilfe der Methode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Das folgende Codebeispiel zeigt, wie Sie ein bestimmtes Layout von DXF in PDF konvertieren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Die Eigenschaft [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) ist vom Typ String-Array, daher können Sie mehr als ein Layout gleichzeitig für die mögliche Konvertierung in das PDF-Format angeben. Bei Angabe mehrerer Layouts für die Eigenschaft [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), würde das resultierende PDF multiple Seiten haben, wobei jede Seite ein individuelles AutoCAD-Layout repräsentiert.

{{% /alert %}}

## **Zugriff auf ATTRIB- und MTEXT-Objekte**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine DXF-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Greifen Sie auf die Entitäten innerhalb der CAD-Datei zu.
1. Überprüfen Sie die Entitäten [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) und [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Fügen Sie sie einer temporären Liste für weitere Verarbeitung hinzu

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Zerlegen von CAD-Insert-Objekten**

Dieser Ansatz funktioniert wie folgt:

1. Öffnen Sie eine **DXF**-Zeichnungsdatei mithilfe der [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) Factory-Methode.
1. Greifen Sie auf die Entitäten innerhalb der CAD-Datei zu.
1. Überprüfen Sie auf [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.as.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) Entitäten.
1. Überprüfen Sie die Liste vom Typ [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Verarbeiten Sie die Entitäten

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Unterstützung von Block-Clipping**

Aspose.CAD bietet die Funktion des Block-Clipping. Der Ansatz zum Block-Cl