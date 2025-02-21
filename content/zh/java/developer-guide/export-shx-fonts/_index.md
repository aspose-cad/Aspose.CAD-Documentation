---
title: 导出 SHX 字体
type: docs
weight: 40
url: /zh/java/developer-guide/export-shx-fonts/
---

## **为 DXF/DWG 图纸导出 SHX 字体**

一些图纸可能包含特殊的 SHX 格式字体，该格式以形状的形式存储字体符号。
该格式要求在图纸中使用的每种字体都需要额外的加载程序。
Apose.CAD 可以导出带有 SHX 字体的文本的图纸，并且具有不同的导出选项。
最简单的方法是直接使用 [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 属性，该属性属于 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

每个 SHX 字体都有适当的代码页与之关联。这些关联是已知的，并且部分嵌入到 Aspose.CAD 中用于已知 SHX 字体。
在使用某些自定义 SHX 字体的情况下，可以应用 **setShxCodePages** 属性并设置 SHX 文件的路径以及相应的代码页。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
