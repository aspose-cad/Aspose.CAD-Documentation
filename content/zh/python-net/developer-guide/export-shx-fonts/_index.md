---
title: 导出 SHX 字体
type: docs
weight: 40
url: /zh/python-net/developer-guide/export-shx-fonts/
---

## **将 SHX 字体导出为 DXF/DWG 图纸**

某些图纸可能包含特殊 SHX 格式的字体，这种格式以形状的形式存储字体的符号。此格式需要为图纸中使用的每种字体额外加载程序。Apose.CAD 可以导出带有 SHX 文本的图纸，并提供不同的选项来实现此目的。最简单的方法是使用 
**CadRasterizationOptions** 对象的 **ShxFonts** 属性。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
