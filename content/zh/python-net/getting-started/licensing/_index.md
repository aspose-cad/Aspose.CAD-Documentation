---
title: 许可证
type: docs
weight: 40
url: /zh/python-net/getting-started/licensing/
---
## **调用 setLicense**
要应用许可证：

将许可证文件保存到磁盘上的文件夹。例如 C:\Lic\Aspose.CAD.Python.lic。
调用 License.set_license(filename) 方法并将文件名作为参数传递。当调用此语句时，许可证被设置，评估消息将不再出现在图像顶部。
以下代码片段为 Aspose.CAD for Python 设置许可证。

{{< highlight java >}}

// 设置许可证

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

您在每个进程或应用程序中仅需调用一次 set_license() 方法。

{{% /alert %}}

## **在 applicationContext.xml 中设置许可证导出参数**
{{% alert color="primary" %}}
此方法适用于 JasperServer。
{{% /alert %}}
1. 将许可证下载到您的计算机，然后将其复制到 \apache-tomcat\webapps\jasperserver\WEB-INF 文件夹中，该文件夹代表 JasperServer 安装目录。
2. 找到 \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml 文件并添加以下行：
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
