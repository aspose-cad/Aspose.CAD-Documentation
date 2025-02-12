---
title: DWF-Zeichnungen
type: docs
weight: 20
url: /de/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Export von DWF-Zeichnungen in PDF**

Mit der Aspose.CAD für Java-API können AutoCAD-Zeichnungen im DWF-Format geladen und in PDF konvertiert werden. Dieses Thema erläutert die Verwendung der Aspose.CAD-API zur Konvertierung von DWF in das PDF-Format durch einfache Schritte, wie im Folgenden definiert.

### **Konvertieren von DWF-Dateien in PDF**

Die folgenden einfachen Schritte sind erforderlich, um DWF in PDF zu konvertieren.

1. Laden Sie die DWF-Datei in eine Instanz von [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) und [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Rufen Sie [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) auf und übergeben Sie als zweiten Parameter ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions).

Das folgende Codebeispiel zeigt, wie DWF-Zeichnungen in PDF exportiert werden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportierenCAD-ExportToPDF-ExportToPDF.java" >}}

### **Unterstützung von Ebenen in DWF**

Aspose.CAD bietet die Möglichkeit, AutoCAD DWF-Zeichenentitäten zu laden und diese als gesamte Zeichnung im JPG-Format zu rendern.

1. Laden Sie die DWF-Zeichnungsdatei mithilfe der Factory-Methode [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Fügen Sie gewünschte Ebenen hinzu.
1. Rufen Sie [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) auf und übergeben Sie als zweiten Parameter ein Objekt von [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions).

Das folgende Codebeispiel zeigt, wie eine Datei mit den Standardeinstellungen konvertiert wird.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-DWFZeichnungen-UnterstutzungVonEbenen-UnterstutzungVonEbenen.java" >}}
