---
title: FBX Zeichnungen
type: docs
weight: 110
url: /de/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX-Format nach PDF exportieren**

Aspose.CAD für Python ermöglicht Entwicklern, eine [FBX](https://docs.fileformat.com/3d/fbx/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von [FBX](https://docs.fileformat.com/3d/fbx/) zu [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [FBX](https://docs.fileformat.com/3d/fbx/) Zeichnungsdatei mit der **Image.load** Factory-Methode.
1. Erstellen Sie ein Objekt der **CadRasterizationOptions** Klasse und setzen Sie die Eigenschaften **PageHeight** und **PageWidth**.
1. Erstellen Sie ein Objekt der **PdfOptions** Klasse und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt von **PdfOptions** als zweiten Parameter.

## Beispielcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
