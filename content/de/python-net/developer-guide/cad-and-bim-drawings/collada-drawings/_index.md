---
title: COLLADA Zeichnungen
type: docs
weight: 20
url: /de/python-net/collada-drawings/
---

## **Exportieren des COLLADA-Formats nach PDF**

Aspose.CAD für Python ermöglicht Entwicklern den Export einer [COLLADA](https://docs.fileformat.com/3d/dae/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format. Der Ansatz zur Konvertierung von [COLLADA](https://docs.fileformat.com/3d/dae/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [COLLADA](https://docs.fileformat.com/3d/dae/) Zeichnungsdatei mit der **Image.load** Factory-Methode.
1. Erstellen Sie ein Objekt der **CadRasterizationOptions**-Klasse und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der **PdfOptions**-Klasse und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf, während Sie ein Objekt von **PdfOptions** als zweiten Parameter übergeben.

## Beispielcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
