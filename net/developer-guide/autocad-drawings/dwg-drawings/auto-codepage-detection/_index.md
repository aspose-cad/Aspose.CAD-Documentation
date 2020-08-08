---
title: Auto Codepage Detection
type: docs
weight: 10
url: /net/auto-codepage-detection/
---

## **Auto Codepage Detection**
Aspose.CAD supports auto codepage detection for [**DWG**](https://wiki.fileformat.com/cad/dwg/) and [**DWF**](https://wiki.fileformat.com/cad/dwf/) files. If you do not wish to use this feature, you can override this by setting the following properties of the [**LoadOptions**](https://apireference.aspose.com/net/cad/aspose.cad/loadoptions) class.

- SpecifiedEncoding: sets encoding used to read text data from non-Unicode DXF and DWG formats. It is autodetected by default.
- SpecifiedMifEncoding: sets encoding used to read MIF-encoded symbols of CJK encodings (M+nXXXX format). It is autodetected by default.
- RecoverMalformedCifMif: defines whether CIF (U+XXXX) and MIF-encoded characters will be decoded if they do not have proper AutoCAD formatting (AutoCAD precedes these symbols with a backslash). By default, they are decoded.

The code sample below shows how to how to override auto codepage detection in Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
