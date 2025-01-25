---
title: Exportieren von DGN AutoCAD
type: docs
weight: 50
url: /de/python-net/exporting-dgn-autocad/
---

## **Exportieren des DGN AutoCAD-Formats in PDF**

Aspose.CAD für die Python-API hat die Funktionalität eingeführt, eine DGN AutoCAD-Datei zu laden und in das PDF-Format zu konvertieren. Die **CadImage**-Klasse dient diesem Zweck.

Sie müssen eine vorhandene DGN-Datei als **CadImage** laden. Erstellen Sie eine Instanz der **CadRasterizationOptions**-Klasse und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der **PdfOptions**-Klasse und übergeben Sie die **CadRasterizationOptions**-Instanz. Rufen Sie jetzt die **save**-Methode der **CadImage**-Instanz auf.

### Beispielcode

Nachfolgend finden Sie die Code-Demonstration zur Konvertierung/Export von [DGN](https://docs.fileformat.com/cad/dgn/) in das [PDF](https://docs.fileformat.com/pdf/)-Format.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportieren des DGN AutoCAD-Formats in Rasterbildformat**

Aspose.CAD für die Python-API hat die Funktionalität eingeführt, eine DGN AutoCAD-Datei zu laden und in ein Rasterbild zu konvertieren. Die **CadImage**-Klasse dient diesem Zweck.

Sie müssen eine vorhandene DGN-Datei als **CadImage** laden. Erstellen Sie eine Instanz der **CadRasterizationOptions**-Klasse und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der **JpegOptions**-Klasse und übergeben Sie die **CadRasterizationOptions**-Instanz. Rufen Sie jetzt die **save**-Methode der **CadImage**-Instanz auf.

### Beispielcode

Nachfolgend finden Sie die Code-Demonstration zur Konvertierung/Export von [DGN](https://docs.fileformat.com/cad/dgn/) in das [JPEG](https://docs.fileformat.com/image/jpeg/)-Bild.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Unterstützung von 3D-Entitäten für DGN v7**

Aspose.CAD für die Python-API hat die Funktionalität eingeführt, eine [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-Datei zu laden und 3D-Entitäten für DGN v7 zu unterstützen. Die **CadImage**-Klasse dient diesem Zweck. Jedes [DGN](https://docs.fileformat.com/cad/dgn/) Bild unterstützt 9 vordefinierte Ansichten. Diese sind von 1 bis 9 enumeriert. Wenn keine Ansicht beim Export definiert ist, werden für mehrseitige Ausgabeformate (wie PDF) alle Ansichten exportiert, jede auf einer separaten Seite. 3D-Entitäten werden im DGN-Dateiformat sowie 2D unterstützt. Dafür wird **VectorRasterizationOptions** verwendet, TypeOfEntities wird im DGN-Format (sowohl 2D als auch 3D werden gleichzeitig unterstützt) nicht mehr verwendet.

### Beispielcode

Nachfolgend finden Sie den Beispielcode, um sich die unterstützten DGN-Elemente anzusehen.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
