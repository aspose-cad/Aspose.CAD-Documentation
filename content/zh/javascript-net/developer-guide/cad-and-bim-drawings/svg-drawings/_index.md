---
title: SVG 绘图
type: docs
weight: 70
url: /zh/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **导出 SVG 格式为 PNG**

Aspose.CAD for Javascript in Angular 允许开发者将 [SVG](https://docs.fileformat.com/page-description-language/svg/) 文件导出为 [PNG](https://docs.fileformat.com/image/png/) 格式。
[SVG](https://docs.fileformat.com/page-description-language/svg/) 到 [PNG](https://docs.fileformat.com/image/png/) 的转换方法如下：

1. 使用 **Image.load** 方法加载 [SVG](https://docs.fileformat.com/page-description-language/svg/) 绘图文件。
1. 调用 **Image.save**，同时将 **PngOptions** 的对象作为第二个参数传入。

## 示例代码

以下代码展示了如何使用 Aspose.CAD for JavaScript 实现相同的目标

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
