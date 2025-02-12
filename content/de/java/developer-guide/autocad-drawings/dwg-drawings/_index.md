---
title: DWG-Zeichnungen
type: docs
weight: 40
url: /de/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG-Zeichnungen in PDF exportieren**

Die Aspose.CAD for Java API kann AutoCAD-Zeichnungen im DWG-Format laden und in PDF konvertieren. Dieses Thema erläutert die Verwendung der Aspose.CAD API zur Umwandlung von DWG in das PDF-Format durch einfache Schritte, die im Folgenden beschrieben sind.

{{% alert color="primary" %}}

Die API unterstützt die folgenden AutoCAD DWG-Versionen:

- DWG 2004 Version 16.0 Veröffentlichung 18
- DWG 2005 Version 16.1
- DWG 2010 Version 18.0
- DWG 2013 Version 19.0

{{% /alert %}}

### **DWG-Dateiformat**

Eine DWG-Datei ist eine Binärdatei, die Vektorbilddaten und Metadaten enthält. Die Vektorbilddaten enthalten Anweisungen an die CAD-Anwendung, wie die DWG angezeigt werden soll; die Metadaten können eine Vielzahl von Informationen über die Datei enthalten, einschließlich ortsbezogener Daten sowie Kundeninformationen. Die Open Specifications für das DWG-Dateiformat finden Sie [in diesem PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **DWG-Dateien in PDF konvertieren**

Die folgenden einfachen Schritte sind erforderlich, um DWG in PDF umzuwandeln.

1. Laden Sie die DWG-Datei in eine Instanz von [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und legen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) fest.
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Rufen Sie die Methode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) auf und übergeben Sie das Objekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) als zweiten Parameter.

Das folgende Codebeispiel zeigt, wie DWG-Zeichnungen in PDF exportiert werden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}