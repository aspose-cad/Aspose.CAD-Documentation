---
title: 许可证
type: docs
weight: 50
url: /zh/java/getting-started/licensing/
---

{{% alert color="primary" %}}

您可以从 [其下载页面](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) 下载 **Aspose.CAD** for Java 的评估版本。评估版本提供与产品的授权版本绝对相同的功能。此外，当您购买许可证并添加几行代码以应用许可证时，评估版本会立即变为授权版本。

一旦您对 **Aspose.CAD** 的评估满意，您可以在 Aspose 网站上 [购买许可证](https://purchase.aspose.com/buy)。请了解提供的不同订阅类型。如果您有任何问题，请随时联系 Aspose 销售团队。

每个 Aspose 许可证都附带一年的免费升级订阅，适用于在此期间发布的任何新版本或修复。技术支持是免费的且没有限制，提供给授权用户和评估用户。

{{% /alert %}}

如果您想在没有评估版本限制的情况下测试 **Aspose.CAD**，请申请一个 30 天的临时许可证。有关更多信息，请参阅 [如何获取临时许可证？](https://purchase.aspose.com/temporary-license)

## **设置许可证**

许可证是一个纯文本的 XML 文件，包含产品名称、授权的开发人员数量、订阅到期日期等详细信息。该文件经过数字签名，因此请不要修改文件；甚至不小心添加额外的换行符也会使其失效。

在对 AutoCAD 文件执行任何操作之前，您需要设置许可证。每个应用程序或进程只需设置一次许可证。

许可证可以从以下位置的流或文件加载：

1. 明确路径。
1. 包含 Aspose.CAD.jar 的文件夹。

使用 License.setLicense() 方法为组件授权。设置许可证的最简单方法通常是将许可证文件放在与 Aspose.CAD.jar 相同的文件夹中，并仅指定文件名而不加路径，如下例所示：

### **示例 1**

在此示例中， **Aspose.CAD** 将尝试在包含您应用程序 JAR 的文件夹中查找许可证文件。

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **示例 2**

从流中初始化许可证。

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **验证许可证**

可以验证许可证是否已正确设置。 License 类具有 isLicensed 字段，如果许可证已正确设置，则返回 true。

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("许可证已设置！");

}

{{< /highlight >}}
