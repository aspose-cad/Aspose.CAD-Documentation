---
title: DWF-Zeichnungen
type: docs
weight: 50
url: /de/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Export von DWF-Zeichnungen nach PDF**

Aspose.CAD bietet die Funktion, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) Zeichnungseinheiten zu laden und sie als gesamte Zeichnung im [PDF](https://docs.fileformat.com/pdf/) Format zu rendern. Der Ansatz zur Konvertierung von [DWF](https://docs.fileformat.com/cad/dwf/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [DWF](https://docs.fileformat.com/cad/dwf/) Zeichnungsdatei mit der Methode **Image.load**.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt von **PdfOptions** als zweiten Parameter.

### Beispielcode

Das folgende Codebeispiel zeigt, wie man eine Datei mit den Standardeinstellungen konvertiert.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Export von DWF-Zeichnungen nach BMP**

Aspose.CAD bietet die Funktion, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) Zeichnungseinheiten zu laden und sie als gesamte Zeichnung im [BMP](https://docs.fileformat.com/image/bmp/) Format zu rendern. Der Ansatz zur Konvertierung von [DWF](https://docs.fileformat.com/cad/dwf/) nach [BMP](https://docs.fileformat.com/image/bmp/) funktioniert wie folgt:

1. Laden Sie die [DWF](https://docs.fileformat.com/cad/dwf/) Zeichnungsdatei mit der Methode **Image.load**.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **BmpOptions** und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt von **BmpOptions** als zweiten Parameter.

### Beispielcode

Das folgende Codebeispiel zeigt, wie man eine [DWF](https://docs.fileformat.com/cad/dwf/) Datei mit den Standardeinstellungen in [BMP](https://docs.fileformat.com/image/bmp/) konvertiert.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
