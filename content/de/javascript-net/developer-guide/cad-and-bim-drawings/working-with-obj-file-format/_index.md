---
title: Arbeiten mit dem OBJ-Dateiformat
type: docs
weight: 120
url: /de/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD unterstützt jetzt das OBJ-Dateiformat. Das OBJ-Dateiformat ist eine 3D-Geometrie, die Texturkarten, 3D-Koordinaten, polygonale Flächen und andere Objektinformationen enthält.

{{% /alert %}}

## **Exportieren des OBJ-Formats als PNG**

Aspose.CAD für JavaScript in Angular ermöglicht Entwicklern, eine [OBJ](https://docs.fileformat.com/3d/obj/) Datei in das [PNG](https://docs.fileformat.com/image/png/) Format zu exportieren.
Die Konvertierung von [OBJ](https://docs.fileformat.com/3d/obj/) nach [PNG](https://docs.fileformat.com/image/png/) erfolgt wie folgt:

1. Laden Sie die [OBJ](https://docs.fileformat.com/3d/obj/) Zeichnungsdatei mit der Methode **Image.load**.
2. Rufen Sie **Image.save** auf und übergeben Sie als zweiten Parameter ein Objekt von **PngOptions**.

## Beispielcode

Der folgende Code zeigt, wie das gleiche Ziel mit Aspose.CAD für JavaScript erreicht werden kann

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
