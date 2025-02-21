---
title: 如何在 Docker 中运行 Aspose.CAD
type: docs
description: "在 Linux、Windows Server 和任何操作系统的 Docker 容器中运行 Aspose.CAD。"
weight: 71
url: /zh/net/showcases/how-to-run-aspose-cad-in-docker/
---

## 先决条件
- 您的系统上必须安装 Docker。有关如何在 Windows 或 Mac 上安装 Docker 的信息，请参阅“另见”部分中的链接。
- Visual Studio 2022。
- 示例中使用了 .NET 6 SDK。

## Hello World 应用程序

在此示例中，您将创建一个简单的 Hello World 控制台应用程序，该程序绘制一个椭圆并将其保存为图像。然后可以在 Docker 中构建和运行该应用程序。

## 创建控制台应用程序

要创建 Hello World 程序，请按照以下步骤操作：
1. 安装 Docker 后，请确保它使用 Linux 容器（默认）。如有必要，从 Docker Desktop 菜单中选择“切换到 Linux 容器”选项。
1. 在 Visual Studio 中，创建一个 .NET 6 控制台应用程序。<br>
![A NET 6 console application project dialog](/_assets/showcases/docker/1.png)<br>
1. 从 NuGet 安装最新的 Aspose.CAD 版本。<br>
![Aspose.CAD on NuGet](/_assets/showcases/docker/2.png)<br>
1. 由于该应用程序将在 Linux 上运行，您可能需要安装额外的字体。您可以选择 ttf-mscorefonts-installer。
1. 添加所有必需的依赖项后，编写一个简单的程序，该程序创建一个椭圆并将其保存为图像：<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

请注意，“TestOut”文件夹被指定为保存输出文档的输出文件夹。在 Docker 中运行应用程序时，主机机器上的文件夹将被挂载到容器中的此文件夹。这样可以轻松查看在 Docker 容器中由 Aspose.CAD 生成的输出。

### 配置 Dockerfile

下一步是创建和配置 Dockerfile。

1. 创建 Dockerfile 并将其放在应用程序的解决方案文件旁边。保持此文件名没有扩展名（默认）。
1. 在 Dockerfile 中，指定：

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

上述是一个简单的 Dockerfile，其中包含以下指令：

- 要使用的 SDK 镜像。在这里，它是 .NET 6 镜像。Docker 将在运行构建时下载它。SDK 的版本指定为标签。
- 此外，您可能需要安装字体，因为 SDK 镜像包含的字体非常少。此外，您可以使用复制到 Docker 镜像中的本地字体。
- 在下一行中指定工作目录。
- 复制所有内容到容器中的命令，发布应用程序并指定入口点。

## 在 Docker 中构建和运行应用程序
 
现在可以在 Docker 中构建和运行应用程序。打开您喜欢的命令提示符，将目录更改为包含应用程序的文件夹（解决方案文件和 Dockerfile 所在的文件夹），然后运行以下命令：

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

第一次执行此命令时可能会花费更长时间，因为 Docker 需要下载所需的镜像。完成上述命令后，运行以下命令：

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
请注意挂载参数，因为前面提到过，主机机器上的文件夹被挂载到容器的文件夹中，以便轻松查看应用程序执行的结果。Linux 中的路径区分大小写。
{{% /alert %}}

## 更多示例

有关如何在 Docker 中使用 Aspose.CAD 的更多示例，请参阅 [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation)。

## 另见

- [在 Windows 上安装 Docker Desktop](https://docs.docker.com/docker-for-windows/install/)
- [在 Mac 上安装 Docker Desktop](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022，.NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [切换到 Linux 容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 选项
- 有关 [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) 的附加信息
