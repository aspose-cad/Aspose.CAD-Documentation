---
title: Auto Codepage Detection
type: docs
weight: 10
url: /java/auto-codepage-detection/
---

## **Auto Codepage Detection**

Aspose.CAD supports auto codepage detection for [DWG](https://docs.fileformat.com/cad/dwg/) and [DWF](https://docs.fileformat.com/cad/dwf/) files. If you do not wish to use this feature, you can override this by setting the following properties of the [**LoadOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad/LoadOptions) class.

- [**SpecifiedEncoding**](https://apireference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): sets encoding used to read text data from non-Unicode DXF and DWG formats. It is autodetected by default.
- [**SpecifiedMifEncoding**](https://apireference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): sets encoding used to read MIF-encoded symbols of CJK encodings (M+nXXXX format). It is autodetected by default.
- [**RecoverMalformedCifMif**](https://apireference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): defines whether CIF (U+XXXX) and MIF-encoded characters will be decoded if they do not have proper AutoCAD formatting (AutoCAD precedes these symbols with a backslash). By default, they are decoded.

## Sample Code

The code sample below shows how to how to override auto codepage detection in Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
