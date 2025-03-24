---
title: 安装
type: docs
weight: 30
url: /zh/net/getting-started/installation/
---

## **通过 NuGet 安装 Aspose.CAD for .NET**

NuGet 是下载和安装 Aspose .NET API 的最简单方式。打开 Microsoft Visual Studio 和 NuGet 包管理器。搜索“aspose”以找到所需的 Aspose API。单击“安装”，选择的 API 将被下载并在您的项目中引用。

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **从 .NET 项目引用 Aspose.CAD**

按照以下步骤操作（假设您使用 Microsoft Visual Studio）：

1. 在 **解决方案资源管理器**中，展开您希望添加引用的项目节点。
1. 右键单击该项目的 **引用** 节点，并从快捷菜单中选择 **添加引用**。
1. 在 **添加引用** 对话框中浏览到 DLL 文件位置。
1. 选择 *Aspose.CAD* DLL 文件并单击 **确定** 按钮。
1. *Aspose.CAD* 引用将出现在您项目的 **引用** 节点下。

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **使用包管理器控制台安装或更新 Aspose.CAD**

您可以按照以下步骤使用包管理器控制台引用 [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/)：

1. 在 Visual Studio 中打开您的解决方案/项目。
1. 从菜单中选择工具 -> 库包管理器 -> 包管理器控制台以打开包管理器控制台。

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

输入命令“**Install-Package Aspose.CAD**”并按回车安装最新的完整版本到您的应用程序中。或者，您可以在命令中添加“**-prerelease**”后缀，以指定要安装最新的包含热修复的版本。

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

您将看到“正在下载 Aspose.CAD...”的提示出现在窗口左下方，表示下载正在进行中。

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

下载完成后，您将看到以下确认消息。如果您对 [Aspose EULA](https://about.aspose.com/legal/eula) 不熟悉，最好阅读 URL 中引用的许可证。

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

您现在应该发现 Aspose.CAD 已成功添加并在您的应用程序中引用。

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

在包管理器控制台中，您还可以使用命令“**Update-Package Aspose.CAD**”并按回车检查 Aspose.CAD 包的任何更新并安装它们（如果存在）。您还可以添加“-prerelease”后缀以更新最新版本。

## **在共享服务器环境中运行时的考虑事项**

所有 Aspose .NET 组件建议在完全信任的权限集下运行。这是因为 Aspose .NET 组件有时需要访问注册表设置和位于虚拟目录以外位置的文件，例如阅读字体等。此外，Aspose.NET 组件基于核心 .NET 系统类，其中一些在某些情况下还需要完全信任的权限才能运行。

托管来自不同公司的多个应用程序的互联网服务提供商通常执行中等信任安全级别。在 .NET 2.0 的情况下，这种安全级别可能会设置以下约束，这可能会影响 Aspose.CAD 正常执行的能力。

- **RegistryPermission** 不可用。这意味着您无法访问注册表，而这在呈现文档时需要枚举安装的字体。
- **FileIOPermission** 受到限制。这意味着您只能访问应用程序虚拟目录层次结构中的文件。这可能意味着在导出期间无法读取字体。

基于上述原因，建议在完全信任权限下运行 Aspose.CAD。您可能会发现，在中等信任下执行不同任务时，库的某些功能将正常工作，而某些功能则不行（例如渲染），这可能与对 GDI+ 图像处理的调用有关。

## **系统要求**

### **操作系统**

Aspose.CAD for .NET 支持任何安装了 .NET 或 Mono 框架的 32 位或 64 位操作系统，包括但不限于：

- Microsoft Windows 桌面（XP、Vista、7、8、10）和服务器操作系统（2003、2008、2012）
- Windows Azure
- Linux（Ubuntu、openSUSE、CentOS 等）
- Mac OS X

### **框架**

Aspose.CAD for .NET 支持：

- 从 2.0 到 4.5 的 .NET Framework 版本，包括客户端配置文件版本
- .NET Core
- Mono 2.6.7 或更高版本

### **开发环境**

您可以在任何以 .NET 为目标的平台的开发环境中使用 Aspose.CAD for .NET 开发应用程序，但以下环境是明确支持的：

- Microsoft Visual Studio 2010 或更高版本
- MonoDevelop 2.4 及更高版本
