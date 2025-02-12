---
title: SVG Zeichnungen
type: docs
weight: 170
url: /de/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportieren von SVG-Formaten nach PDF**

Aspose.CAD für Python ermöglicht Entwicklern, eine [SVG](https://docs.fileformat.com/page-description-language/svg/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von [SVG](https://docs.fileformat.com/page-description-language/svg/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die SVG-Zeichnungsdatei mit der **Image.load** Fabrikmethode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **VectorRasterizationOptions**.
1. Rufen Sie **Image.save** auf, wobei Sie ein Objekt von **PdfOptions** als zweiten Parameter übergeben.

## Beispielcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
