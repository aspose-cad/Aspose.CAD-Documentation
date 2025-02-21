---
title: CTB 文件的支持
type: docs
weight: 40
url: /zh/java/developer-guide/support-ctb/
---

## **CTB 文件的支持**

有时，图纸的颜色、线宽和其他一些选项不仅可以从图纸本身使用，还可以从单独的 CTB 文件中的绘图样式中使用。 
使用此信息的最简单方法是将相应的 CTB 文件放在 DWG/DXF 格式的图纸文件附近，这样它们的信息将在导出时自动应用。

也可以使用 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) 属性以流的形式加载所有 CTB 文件，来自 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 对象。

以下是如何做到这一点的示例：

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
