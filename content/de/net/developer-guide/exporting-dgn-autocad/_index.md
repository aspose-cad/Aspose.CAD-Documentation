---
title: DGN AutoCAD exportieren
type: docs
weight: 50
url: /de/net/exporting-dgn-autocad/
---

## **Exportieren des DGN AutoCAD-Formats nach PDF**

Aspose.CAD für .NET API hat die Funktionalität eingeführt, eine DGN AutoCAD-Datei zu laden und sie in das PDF-Format zu konvertieren. Die [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) Klasse erfüllt diesen Zweck.

Sie müssen eine vorhandene DGN-Datei als [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) laden. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und übergeben Sie die [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Instanz. Rufen Sie nun die [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode der [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) Klasseninstanz auf.

### Beispielcode

Nachfolgend finden Sie die Code-Demonstration zum Konvertieren/Exportieren von [DGN](https://docs.fileformat.com/cad/dgn/) in das [PDF](https://docs.fileformat.com/pdf/) Format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exportieren des DGN AutoCAD-Formats in Rasterbildformat**

Aspose.CAD für .NET API hat die Funktionalität eingeführt, eine DGN AutoCAD-Datei zu laden und sie in ein Rasterbild zu konvertieren. Die [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) Klasse erfüllt diesen Zweck.

Sie müssen eine vorhandene DGN-Datei als [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) laden. Erstellen Sie eine Instanz der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) Klasse und übergeben Sie die [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Instanz. Rufen Sie nun die [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) Methode der [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) Klasseninstanz auf.

### Beispielcode

Nachfolgend finden Sie die Code-Demonstration zum Konvertieren/Exportieren von [DGN](https://docs.fileformat.com/cad/dgn/) in ein [JPEG](https://docs.fileformat.com/image/jpeg/) Bild.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **3D-Entitätenunterstützung für DGN v7**

Aspose.CAD für .NET API hat die Funktionalität eingeführt, eine [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-Datei zu laden und 3D-Entitäten für DGN v7 zu unterstützen. Die [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) Klasse erfüllt diesen Zweck. Jedes [DGN](https://docs.fileformat.com/cad/dgn/) Bild unterstützt 9 vordefinierte Ansichten. Diese sind von 1 bis 9 nummeriert. Wenn auf dem Export keine Ansicht definiert ist, werden für mehrseitige Ausgabeformate (wie PDF) alle Ansichten exportiert, jede auf einer separaten Seite. 3D-Entitäten werden für das DGN-Dateiformat unterstützt, ebenso wie 2D. Dazu wird die [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) verwendet, TypeOfEntities wird nicht mehr für das DGN-Format verwendet (sowohl 2D als auch 3D werden gleichzeitig unterstützt).

### Beispielcode

Nachfolgend finden Sie den Beispielcode, um die unterstützten DGN-Elemente anzuzeigen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
