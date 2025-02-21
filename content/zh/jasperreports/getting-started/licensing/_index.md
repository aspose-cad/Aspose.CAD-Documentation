---
title: 许可
type: docs
weight: 40
url: /zh/jasperreports/getting-started/licensing/
---
## **调用 setLicense**
要应用许可证：

将许可证文件保存到您计算机上的一个文件夹。例如 C:\Lic\Aspose.CAD.JasperReport.lic。
调用 License.setLicense(filename) 方法并将文件名作为参数传递。当调用此语句时，许可证将被设置，评估消息将不再出现在图像顶部。
以下代码片段为 Aspose.CAD for JasperReports 设置许可证。

{{< highlight java >}}

// 设置许可证

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

您只需在每个进程或应用程序中调用一次 setLicense() 方法。

{{% /alert %}}

## **在 applicationContext.xml 中设置许可证导出参数**
{{% alert color="primary" %}}
此方法适用于 JasperServer。
{{% /alert %}}
1. 将许可证下载到您的计算机并复制到 \apache-tomcat\webapps\jasperserver\WEB-INF 文件夹中，其中是 JasperServer 安装目录。
2. 找到 \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml 文件并添加以下行：
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
