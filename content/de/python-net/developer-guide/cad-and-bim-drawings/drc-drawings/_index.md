---
title: DRC Zeichnungen
type: docs
weight: 40
url: /de/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC-Format nach PDF exportieren**

Aspose.CAD für Python ermöglicht Entwicklern, eine [DRC](https://docs.fileformat.com/3d/drc/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von [DRC](https://docs.fileformat.com/3d/drc/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die DRC-Zeichnungsdatei mit der **Image.load** Fabrikmethode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **VectorRasterizationOptions**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt von **PdfOptions** als zweiten Parameter.

## Beispielcode


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
