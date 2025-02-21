---
title: 自动代码页检测
type: docs
weight: 10
url: /zh/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **自动代码页检测**

Aspose.CAD 支持对 [DWG](https://docs.fileformat.com/cad/dwg/) 和 [DWF](https://docs.fileformat.com/cad/dwf/) 文件的自动代码页检测。如果您不希望使用此功能，可以通过设置 **LoadOptions** 类的以下属性来覆盖它。

- **specified_encoding**: 设置从非 Unicode DXF 和 DWG 格式读取文本数据时使用的编码。默认情况下会自动检测。
- **specified_mif_encoding**: 设置用于读取 CJK 编码的 MIF 编码符号（M+nXXXX 格式）时使用的编码。默认情况下会自动检测。
- **recover_malformed_cif_mif**: 定义如果 CIF (U+XXXX) 和 MIF 编码字符没有适当的 AutoCAD 格式（AutoCAD 用反斜杠前置这些符号）时，是否将其解码。默认情况下，它们会被解码。

## 示例代码

下面的代码示例展示了如何在 Aspose.CAD 中覆盖自动代码页检测。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
