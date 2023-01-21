---
title: Auto Codepage Detection
type: docs
weight: 10
url: /python/auto-codepage-detection/
---

## **Auto Codepage Detection**

Aspose.CAD supports auto codepage detection for [DWG](https://docs.fileformat.com/cad/dwg/) and [DWF](https://docs.fileformat.com/cad/dwf/) files. If you do not wish to use this feature, you can override this by setting the following properties of the [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) class.

- [**specified_encoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): sets encoding used to read text data from non-Unicode DXF and DWG formats. It is autodetected by default.
- [**specified_mif_encoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): sets encoding used to read MIF-encoded symbols of CJK encodings (M+nXXXX format). It is autodetected by default.
- [**recover_malformed_cif_mif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): defines whether CIF (U+XXXX) and MIF-encoded characters will be decoded if they do not have proper AutoCAD formatting (AutoCAD precedes these symbols with a backslash). By default, they are decoded.

## Sample Code

The code sample below shows how to how to override auto codepage detection in Aspose.CAD.

import aspose.cad as cad;

if __name__ == '__main__':
   loadOption = cad.LoadOptions()
loadOption.specified_encoding = cad.CodePages.JAPANESE
loadOption.specified_mif_encoding = cad.MifCodePages.JAPANESE
loadOption.recover_malformed_cif_mif = False

cadImage = cad.Image.load("file.dwg", loadOption)

//do export or something else with cadImage

DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
