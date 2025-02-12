---
title: Automatische Codepage-Erkennung
type: docs
weight: 10
url: /de/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatische Codepage-Erkennung**

Aspose.CAD unterstützt die automatische Codepage-Erkennung für [DWG](https://docs.fileformat.com/cad/dwg/) und [DWF](https://docs.fileformat.com/cad/dwf/) Dateien. Wenn Sie diese Funktion nicht verwenden möchten, können Sie dies überschreiben, indem Sie die folgenden Eigenschaften der Klasse [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) festlegen.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): Legt die Codierung fest, die zum Lesen von Textdaten aus Nicht-Unicode-DXF- und DWG-Formaten verwendet wird. Standardmäßig wird dies automatisch erkannt.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): Legt die Codierung fest, die zum Lesen von durch MIF codierten Symbolen von CJK-Codierungen (M+nXXXX-Format) verwendet wird. Standardmäßig wird dies automatisch erkannt.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): Definiert, ob CIF (U+XXXX) und MIF-codierte Zeichen decodiert werden, wenn sie nicht über die richtige AutoCAD-Formatierung verfügen (AutoCAD stellt diesen Symbolen standardmäßig einen Backslash voran). Standardmäßig werden sie decodiert.

## Beispielcode

Der folgende Code zeigt, wie Sie die automatische Codepage-Erkennung in Aspose.CAD überschreiben können.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
