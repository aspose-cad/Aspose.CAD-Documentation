---
title: 如何在 Azure Function 中运行 Aspose.CAD Docker 镜像
type: docs
description: "在 Azure Function 中运行 Aspose.CAD Docker 镜像。"
weight: 73
url: /zh/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## 前提条件
- 必须在您的系统上安装 Docker。有关如何在 Windows 或 Mac 上安装 Docker 的信息，请参阅“另请参阅”部分中的链接。
- Visual Studio 2022。
- 示例中使用了 NET 6 SDK。
- Postman

## Azure Function

在本示例中，您将创建一个简单的转换函数，该函数将 CAD 文件转换并保存为图像。然后可以在 Docker 中构建该应用程序并在 Azure Function 中运行。

## 创建 Azure Function

要创建 Azure Function 程序，请按照以下步骤操作：
1. 安装 Docker 后，请确保它使用的是 Linux 容器（默认）。如果需要，请从 Docker Desktop 菜单中选择切换到 Linux 容器选项。
1. 在 Visual Studio 中创建一个 NET 6 Azure Function。<br>
![NET 6 Azure Function 项目对话框](/_assets/showcases/azure/Create-project.png)<br>
1. 附加信息。<br>
![NET 6 Azure Function 项目对话框](/_assets/showcases/azure/Additional-information.png)<br>
1. 从 NuGet 安装最新版本的 Aspose.CAD。<br>
![Aspose.CAD 在 NuGet 上](/_assets/showcases/azure/NuGet.png)<br>
1. 由于应用程序将在 Linux 上运行，您可能需要安装其他字体。您可以选择 ttf-mscorefonts-installer。
1. 当所有必需的依赖项添加后，编写一个简单的程序，该程序创建一个椭圆并将其保存为图像：<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP 触发器函数处理了请求。");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### 配置 Dockerfile

下一步是在根项目文件夹中创建和配置 Dockerfile。

1. 创建 Dockerfile 并将其放置在您的应用程序解决方案文件旁边。保持此文件名不带扩展名（默认）。
![根项目文件夹](/_assets/showcases/azure/root-folder.png)<br>
1. 在 Dockerfile 中指定：

{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

上述是一个简单的 Dockerfile，包含以下指令：

- 要使用的 SDK 镜像。这里是 NET 6 镜像。Docker 在运行构建时会下载它。SDK 的版本作为标签指定。
- 之后，您可能需要安装字体，因为 SDK 镜像中包含的字体非常少。此外，您还可以使用复制到 Docker 镜像的本地字体。
- 工作目录，在下一行中指定。
- 复制所有内容到容器、发布应用程序并指定入口点的命令。

## Docker Hub
1. 登录 Docker Hub
1. 创建公共存储库

## 在 Docker 中构建和运行应用程序
 
现在可以在 Docker 中构建和运行应用程序。打开您最喜欢的命令提示符，将目录更改为包含应用程序的文件夹（解决方案文件和 Dockerfile 所在的文件夹），然后运行以下命令：

{{< highlight plain >}}
//示例
docker build -t <用户名称>/<存储库名称> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
第一次运行此命令时，它可能需要更长时间，因为 Docker 需要下载所需的镜像。前一个命令完成后，运行以下命令将镜像推送到 Docker Hub：
 
{{< highlight plain >}}
//示例
docker push <用户名称>/<存储库名称>:标签名

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. 登录 Azure。
1. 选择 Azure 服务。
1. 选择 Function App 并创建一个函数。<br>
![Azure 创建函数按钮](/_assets/showcases/azure/create-function.png)<br>
1. 重复基本设置，如下图所示。<br>
![Azure 创建函数设置](/_assets/showcases/azure/create-function-setting.png)<br>
1. 点击“审核 + 创建” -> 创建。
1. 等待部署完成。
1. 点击“转到资源”按钮。<br>
![资源按钮](/_assets/showcases/azure/go-to-resource.png)<br>
1. 停止 aspose-cad-docker-example 函数。<br>
![停止容器](/_assets/showcases/azure/stop-container.png)<br>
1. 转到部署中心菜单并进行相应设置。<br>
![部署中心](/_assets/showcases/azure/deployment-center.png)<br>
1. 保存设置
1. 从部署中心设置中复制 Webhook URL。<br>
![Webhook URL](/_assets/showcases/azure/webhook-url.png)<br>
1. 转到 Docker Hub，选择您的存储库并选择 webhooks。
1. 将 Azure 的“Webhook URL”粘贴到 Docker Hub webhook URL 中并设置名称。<br>
![Docker 中的 Webhook 设置](/_assets/showcases/azure/webhook.png)<br>
1. 点击创建按钮。
1. 返回概览 Azure 函数并启动容器。<br>
![概览菜单](/_assets/showcases/azure/overview.png)<br>

## 执行示例

1. Postman 设置。<br>
![概览菜单](/_assets/showcases/azure/postman-settings.png)<br>
1. 选择任何 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 点击发送按钮。

{{% alert color="primary" %}} 
如果响应成功，请点击“保存到文件”，您将收到以 png 格式转换的文件
{{% /alert %}}

## 更多示例

有关如何在 Docker 中使用 Aspose.CAD 的更多示例，请参阅 [示例](https://github.com/aspose-cad/Aspose.CAD-Documentation)。

## 另请参阅

- [在 Windows 上安装 Docker Desktop](https://docs.docker.com/docker-for-windows/install/)
- [在 Mac 上安装 Docker Desktop](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [切换到 Linux 容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 选项
- 有关 [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) 的附加信息
