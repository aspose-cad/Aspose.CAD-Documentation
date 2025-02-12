---
title: Auto Codepage Detection
type: docs
weight: 10
url: /python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Auto Codepage Detection**

Aspose.CAD supports auto codepage detection for [DWG](https://docs.fileformat.com/cad/dwg/) and [DWF](https://docs.fileformat.com/cad/dwf/) files. If you do not wish to use this feature, you can override this by setting the following properties of the **LoadOptions** class.

- **specified_encoding**: sets encoding used to read text data from non-Unicode DXF and DWG formats. It is autodetected by default.
- **specified_mif_encoding**: sets encoding used to read MIF-encoded symbols of CJK encodings (M+nXXXX format). It is autodetected by default.
- **recover_malformed_cif_mif**: defines whether CIF (U+XXXX) and MIF-encoded characters will be decoded if they do not have proper AutoCAD formatting (AutoCAD precedes these symbols with a backslash). By default, they are decoded.

## Sample Code

The code sample below shows how to how to override auto codepage detection in Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
