---
title: DWF Zeichnungen
type: docs
weight: 20
url: /de/net/dwf-zeichnungen/
---

## **Exportieren von DWF-Zeichnungen in PDF**

Aspose.CAD bietet die Möglichkeit, AutoCAD-[DWF](https://docs.fileformat.com/cad/dwf/)-Zeichnungsentitäten zu laden und sie als gesamte Zeichnung im [PDF](https://docs.fileformat.com/pdf/)-Format darzustellen. Der Ansatz zur Konvertierung von DWF in PDF funktioniert wie folgt:

1. Laden Sie die DWF-Zeichnungsdatei mithilfe der Factory-Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und legen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) fest.
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und legen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) fest.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

### Beispielcode

Der folgende Codeausschnitt zeigt, wie eine Datei mit den Standardeinstellungen konvertiert wird.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extrahieren von Ebenen aus DWF-Zeichnungen**

Aspose.CAD bietet die Möglichkeit, AutoCAD-[DWF](https://docs.fileformat.com/cad/dwf/)-Zeichnungsentitäten zu laden und sie als gesamte Zeichnung im [JPEG](https://docs.fileformat.com/image/jpeg/)-Format darzustellen.

1. Laden Sie die DWF-Zeichnungsdatei mithilfe der Factory-Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Extrahieren Sie die Ebenennamen mithilfe des [JPEG](https://docs.fileformat.com/image/jpeg/)-Objekts.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).

### Beispielcode

Der folgende Codeausschnitt zeigt, wie eine Datei mit den Standardeinstellungen konvertiert wird.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Unterstützung von Ebenen in DWF-Zeichnungen**

Aspose.CAD bietet die Möglichkeit, AutoCAD-[DWF](https://docs.fileformat.com/cad/dwf/)-Zeichnungsentitäten zu laden und sie als gesamte Zeichnung im [JPEG](https://docs.fileformat.com/image/jpeg/)-Format darzustellen.

1. Laden Sie die DWF-Zeichnungsdatei mithilfe der Factory-Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Fügen Sie gewünschte Ebenen hinzu.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).

### Beispielcode

Der folgende Codeausschnitt zeigt, wie eine Datei mit den Standardeinstellungen konvertiert wird.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportieren von DWF-Zeichnungen in BMP**

Aspose.CAD bietet die Möglichkeit, AutoCAD-[DWF](https://docs.fileformat.com/cad/dwf/)-Zeichnungsentitäten zu laden und sie als gesamte Zeichnung im [BMP](https://docs.fileformat.com/image/bmp/)-Format darzustellen. Der Ansatz zur Konvertierung von DWF in BMP funktioniert wie folgt:

1. Laden Sie die DWF-Zeichnungsdatei mithilfe der Factory-Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und legen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) fest.
1. Erstellen Sie ein Objekt der Klasse [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) und legen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) fest.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions).

### Beispielcode

Der folgende Codeausschnitt zeigt, wie eine DWF-Datei in BMP unter Verwendung der Standardeinstellungen konvertiert wird.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
