---
title: 按需许可
type: docs
weight: 60
url: /zh/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD 允许开发人员应用按需密钥。这是一种新的许可机制。新的许可机制将与现有的许可方法一起使用。那些希望根据 API 功能的使用情况进行计费的客户可以使用按需许可。有关更多详细信息，请参阅 [按需许可常见问题解答](https://purchase.aspose.com/faqs/licensing/metered) 部分。

{{% /alert %}} 
## **按需许可**
以下是使用 Metered 类的简单步骤。

1. 创建 Metered 类的实例。
1. 将公钥和私钥传递给 SetMeteredKey 方法。
1. 进行处理（执行任务）。
1. 调用 Metered 类的 GetConsumptionQuantity 方法。
1. 它将返回到目前为止您已使用的 API 请求的数量。

以下是演示如何设置按需公钥和私钥的示例代码。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
