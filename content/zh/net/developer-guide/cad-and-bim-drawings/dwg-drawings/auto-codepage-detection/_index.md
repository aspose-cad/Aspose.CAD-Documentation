---
title: 自动代码页检测
type: docs
weight: 10
url: /zh/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **自动代码页检测**

Aspose.CAD 支持对 [DWG](https://docs.fileformat.com/cad/dwg/) 和 [DWF](https://docs.fileformat.com/cad/dwf/) 文件进行自动代码页检测。如果您不希望使用此功能，可以通过设置 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) 类的以下属性来覆盖此设置。

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): 设置用于从非 Unicode DXF 和 DWG 格式读取文本数据的编码。默认情况下，它是自动检测的。
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): 设置用于读取 CJK 编码的 MIF 编码符号（M+nXXXX 格式）的编码。默认情况下，它是自动检测的。
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): 定义如果 CIF (U+XXXX) 和 MIF 编码字符没有正确的 AutoCAD 格式（AutoCAD 用反斜杠前置这些符号），是否会被解码。默认情况下，它们会被解码。

## 示例代码

下面的代码示例显示了如何在 Aspose.CAD 中覆盖自动代码页检测。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
