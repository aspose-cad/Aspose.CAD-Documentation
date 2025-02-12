---
title: Auto Codepage Detection
type: docs
weight: 10
url: /de/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Auto Codepage Detection**

Aspose.CAD unterstützt die automatische Erkennung der Codepage für [DWG](https://docs.fileformat.com/cad/dwg/) und [DWF](https://docs.fileformat.com/cad/dwf/) Dateien. Wenn Sie diese Funktion nicht nutzen möchten, können Sie dies umgehen, indem Sie die folgenden Eigenschaften der **LoadOptions** Klasse festlegen.

- **specified_encoding**: legt die Codierung fest, die zum Lesen von Textdaten aus nicht-Unicode DXF- und DWG-Formaten verwendet wird. Sie wird standardmäßig automatisch erkannt.
- **specified_mif_encoding**: legt die Codierung fest, die zum Lesen von MIF-kodierten Symbolen von CJK-Codierungen (M+nXXXX-Format) verwendet wird. Sie wird standardmäßig automatisch erkannt.
- **recover_malformed_cif_mif**: definiert, ob CIF (U+XXXX) und MIF-kodierte Zeichen dekodiert werden, wenn sie nicht über die richtige AutoCAD-Formatierung verfügen (AutoCAD stellt diesen Symbolen einen Rückwärtsschrägstrich voran). Standardmäßig werden sie dekodiert.

## Beispielcode

Das folgende Codebeispiel zeigt, wie die automatische Erkennung der Codepage in Aspose.CAD überschrieben werden kann.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
