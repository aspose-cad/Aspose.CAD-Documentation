---
title: 按量许可
type: docs
weight: 40
url: /zh/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD 允许开发者使用按量密钥。这是一种新的许可机制。新的许可机制将与现有的许可方法一起使用。希望根据 API 功能的使用量进行收费的客户可以使用按量许可。有关更多详情，请参阅 [按量许可常见问题解答](https://purchase.aspose.com/faqs/licensing/metered) 部分。

{{% /alert %}} 
## **按量许可**
以下是使用 Metered 类的简单步骤。

1. 创建 Metered 类的实例。
1. 将公钥和私钥传递给 SetMeteredKey 方法。
1. 进行处理（执行任务）。
1. 调用 Metered 类的 GetConsumptionQuantity 方法。
1. 它将返回到目前为止您消耗的 API 请求量/数量。

以下是示例代码，演示如何设置按量的公钥和私钥。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
