---
title: 导出 SHX 字体
type: docs
weight: 40
url: /zh/net/developer-guide/export-shx-fonts/
---

## **为 DXF/DWG 图纸导出 SHX 字体**

一些图纸可能包含特殊 SHX 格式的字体，该格式以形状的形式存储字体符号。此格式需要为图纸中使用的每个字体加载额外的程序。Apose.CAD 可以导出包含用 SHX 编写的文本的图纸，并且有不同的选项来实现这一点。最简单的实现方法是使用 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) 属性 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 对象。
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts 示例.cs">}}


可以通过以下示例避免设置多个 SHX 字体的所有路径：

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "带文件夹的 ShxFonts 示例.cs">}}
	
每个 SHX 字体都有对应的代码页。已知并部分嵌入 Aspose.CAD 中的这些关联用于已知的 SHX 字体。
在使用某些自定义 SHX 字体的情况下，可以应用 ShxCodePages 属性并设置 SHX 文件的路径和相应的代码页。 

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages 示例.cs">}}
