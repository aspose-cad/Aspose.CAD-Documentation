---
title: 导出和加载期间的回调错误
type: docs
weight: 40
url: /zh/net/developer-guide/callback-errors-during-export-and-loading/
---

## **导出和加载期间回调错误的回顾**

在导出或加载图纸时，我们可能会遇到与文件结构相关的错误 
（例如，文件中的某些部分现在是必需的，但之前不是）。 
其中一些是关键错误，在这种情况下会抛出异常，但我们也可以内部忽略其中一些，并使用回调消息通知。
无论如何，所有这些消息都需要关注，因为它们可能会解释例如导出结果中缺失的实体或其他效果。

### **导出期间的错误**

在 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 中有一个 RenderResult 字段，
它包含 IsRenderComplete 用于获取导出期间是否发生错误并打印相关信息：

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **加载期间的错误**

在导出过程开始之前，可能会观察到图纸的一些问题。 
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) 对象中的 [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) 属性用于存储有关它们的消息。
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) 属性对于决定是否 
在加载错误时抛出异常非常有用。 

这是 Errors 属性使用的示例：

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
