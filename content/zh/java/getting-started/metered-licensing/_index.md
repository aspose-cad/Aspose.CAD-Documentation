---
title: 计量许可
type: docs
weight: 60
url: /zh/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD 允许开发者使用计量密钥。这是一种新的许可机制。新的许可机制将与现有的许可方法一起使用。希望根据 API 功能的使用情况进行计费的客户可以使用计量许可。有关更多详细信息，请参阅 [计量许可常见问题](https://purchase.aspose.com/faqs/licensing/metered) 部分。

{{% /alert %}} 
## **计量许可**
以下是使用 Metered 类的简单步骤。

1. 创建 Metered 类的实例。
1. 将公钥和私钥传递给 setMeteredKey 方法。
1. 进行处理（执行任务）。
1. 调用 Metered 类的 getConsumptionQuantity 方法。
1. 它将返回您迄今为止消耗的 API 请求的数量。

以下是示例代码，演示如何设置计量公钥和私钥：

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
