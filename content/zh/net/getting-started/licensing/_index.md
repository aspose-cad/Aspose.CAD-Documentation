---
title: 许可
type: docs
weight: 50
url: /zh/net/getting-started/licensing/
---

{{% alert color="primary" %}}

一旦您对 Aspose.CAD for .NET 进行评估感到满意，请在 Aspose 网站上购买许可证：[购买门户](https://purchase.aspose.com/buy)。熟悉可用的不同许可证类型。如果您有任何问题，请[联系 Aspose 销售团队](https://about.aspose.com/contact)，他们将乐于为您提供帮助。

每个 Aspose 许可证都附带一年的免费升级订阅，适用于在此期间发布的任何新版本或修复。我们为持证用户和评估用户提供免费和无限制的技术支持。

许可证是一个纯文本 XML 文件，包含产品名称、授权开发人员数量、订阅到期日期等详细信息。该文件经过数字签名，因此请勿修改该文件：即使是向文件添加额外的换行符也会使其失效。

{{% /alert %}}

## **何时应用许可证**

遵循以下简单规则：

- 每个应用程序域只需要设置一次许可证。
- 必须在使用任何其他 Aspose.CAD 类之前设置许可证。
- 多次调用 SetLicense 不会造成损害，但会浪费处理器时间。
- 如果您正在开发 Windows 窗体或控制台应用程序，请在启动代码中调用 SetLicense，然后使用 Aspose.CAD 类。
- 在开发 ASP.NET 应用程序时，请从 Global.asax.cs (Global.asax.vb) 文件中的 Application_Start 受保护的方法中调用 SetLicense。它在应用程序启动时调用一次。
- 不要在 Page_Load 方法内调用 SetLicense，因为这意味着每次加载网页时都会加载许可证。
- 如果您正在开发类库，请在使用 Aspose.CAD 的类的静态构造函数中调用 SetLicense。静态构造函数在创建类的实例之前执行，确保 Aspose.CAD 许可证被正确设置。

## **使用文件或流对象应用许可证**

使用 **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** 方法为组件授权。设置许可证的最简单方法是将许可证文件放在与 Aspose.CAD.dll 相同的文件夹中，并指定文件名，不带路径，如下所示。

### **从文件加载许可证**

此代码片段初始化存储在文件或嵌入资源中的许可证。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **从流对象加载许可证**

此代码片段从流中初始化许可证。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
