---
title: STP Zeichnungen
type: docs
weight: 160
url: /de/python-net/stp-drawings/
---

## **Exportieren im STP-Format nach PDF**

Aspose.CAD für Python ermöglicht Entwicklern den Export einer [STP](https://docs.fileformat.com/3d/stp/) Datei im [PDF](https://docs.fileformat.com/pdf/) Format. Der Ansatz zur Konvertierung von [STP](https://docs.fileformat.com/3d/stp/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [STP](https://docs.fileformat.com/3d/stp/) Zeichnungsdatei mit der **Image.load** Fabrikmethode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf und übergeben Sie ein Objekt der **PdfOptions** als zweiten Parameter.

## Beispielcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
