---
title: 使用 OBJ 文件格式
type: docs
weight: 120
url: /zh/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD 现在支持 OBJ 文件格式。OBJ 文件格式是一种 3D 几何图形，包含纹理图、3D 坐标、多边形面和其他对象信息。

{{% /alert %}}

## **将 OBJ 格式导出为 PNG**

在 Angular 中，Aspose.CAD for Javascript 允许开发人员将 [OBJ](https://docs.fileformat.com/3d/obj/) 文件导出为 [PNG](https://docs.fileformat.com/image/png/) 格式。
[OBJ](https://docs.fileformat.com/3d/obj/) 到 [PNG](https://docs.fileformat.com/image/png/) 的转换方法如下：

1. 使用 **Image.load** 方法加载 [OBJ](https://docs.fileformat.com/3d/obj/) 绘图文件。
1. 在调用 **Image.save** 时，将 **PngOptions** 的对象作为第二个参数传递。

## 示例代码

下面的代码显示了使用 Aspose.CAD for JavaScript 达成相同目标的方法

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
