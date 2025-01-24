---
title: Automatische Codepage-Erkennung
type: docs
weight: 10
url: /de/net/auto-codepage-detection/
---

## **Automatische Codepage-Erkennung**

Aspose.CAD unterstützt die automatische Codepage-Erkennung für [DWG](https://docs.fileformat.com/cad/dwg/) und [DWF](https://docs.fileformat.com/cad/dwf/) Dateien. Wenn Sie diese Funktion nicht verwenden möchten, können Sie dies überschreiben, indem Sie die folgenden Eigenschaften der [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) Klasse festlegen.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): legt die Kodierung fest, die zum Lesen von Textdaten aus nicht-Unicode DXF- und DWG-Formaten verwendet wird. Sie wird standardmäßig automatisch erkannt.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): legt die Kodierung fest, die zum Lesen von MIF-kodierten Symbolen von CJK-Kodierungen (M+nXXXX-Format) verwendet wird. Sie wird standardmäßig automatisch erkannt.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): definiert, ob CIF (U+XXXX) und MIF-kodierte Zeichen decodiert werden, wenn sie keine richtige AutoCAD-Formatierung haben (AutoCAD bezeichnet diese Symbole mit einem Rückwärtsschrägstrich). Standardmäßig werden sie decodiert.

## Beispielcode

Das folgende Codesample zeigt, wie die automatische Codepage-Erkennung in Aspose.CAD überschrieben werden kann.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
