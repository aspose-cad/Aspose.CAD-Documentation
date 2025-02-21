---
title: 如何运行示例
type: docs
weight: 70
url: /zh/net/showcases/how-to-run-the-examples/
---

## **软件要求**

请确保在下载和运行示例之前满足以下要求。

1. Visual Studio 2010 或更高版本
1. 在 Visual Studio 中安装 NuGet 包管理器。确保在 Visual Studio 中安装最新的 NuGet API 版本。有关如何安装 NuGet 包管理器的详细信息，请检查 https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. 转到 工具->选项->NuGet 包管理器->包源，并确保选中选项 **nuget.org**
1. 示例项目使用了 NuGet 自动包还原功能，因此您应该有一个有效的 Internet 连接。如果在执行示例的机器上没有有效的 Internet 连接，请检查 [安装](/zh/cad/net/installation/) 以在示例项目中添加对 Aspose.CAD.dll 的引用。

## **从 GitHub 下载**

所有 Aspose.CAD for .NET 的示例都托管在 [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET)。

- 您可以使用您喜欢的 GitHub 客户端克隆代码库，或从 [这里](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip) 下载 ZIP 文件。
- 将 ZIP 文件的内容提取到计算机上的任何文件夹中。所有示例都位于 **Examples** 文件夹中。
- 里面有一个 C# 的 Visual Studio 解决方案文件。
- 项目是在 Visual Studio 2013 中创建的，但解决方案文件与 Visual Studio 2010 SP1 及更高版本兼容。
- 在 Visual Studio 中打开解决方案文件并构建项目。
- 首次运行时，依赖项将通过 NuGet 自动下载。
- **Examples** 根文件夹中的 **Data** 文件夹包含 CSharp 示例所使用的输入文件。下载 **Data** 文件夹及其示例项目是强制性的。
- 打开 RunExamples.cs 文件，所有示例都从这里调用。
- 取消注释您想要在项目中运行的示例。

如果您在设置或运行示例时遇到任何问题，请随时通过我们的论坛与我们联系。

## **贡献**

如果您希望添加或改进某个示例，我们鼓励您为该项目做出贡献。该代码库中的所有示例和演示项目都是开源的，可以在您的应用程序中自由使用。

要贡献，您可以分叉代码库，编辑源代码并创建一个拉取请求。如果我们发现有帮助，我们将审核更改并将其纳入代码库。
