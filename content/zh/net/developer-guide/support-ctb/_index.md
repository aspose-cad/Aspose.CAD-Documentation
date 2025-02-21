---
title: CTB 文件的支持
type: docs
weight: 40
url: /zh/net/developer-guide/support-ctb/
---

## **CTB 文件的支持**

有时，绘图的颜色、线宽和其他一些选项不仅可以从绘图本身使用，还可以从单独的 CTB 文件中的绘图样式中使用。 
使用这些信息的最简单方法是将相应的 CTB 文件放在 DWG/DXF 格式的绘图文件旁边，来自它们的信息将在导出过程中自动应用。

还可以通过 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) 属性以 Stream 的形式加载所有 CTB 文件，使用 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 对象。

以下是如何做到这一点的示例：
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
