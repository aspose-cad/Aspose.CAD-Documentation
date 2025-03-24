---
title: 如何在 Google Cloud 中运行 Aspose.CAD Docker 镜像
type: docs
description: "在 Google Cloud 中运行 Aspose.CAD Docker 镜像。"
weight: 75
url: /zh/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## 前提条件

- 必须在您的系统上安装 Docker。有关如何在 Windows 或 Mac 上安装 Docker 的信息，请参阅“另请参阅”部分中的链接。
- Visual Studio 2022。
- Google CLI。
- 示例中使用 .NET Core 3.1 SDK。
- Postman

## Google Cloud Run 功能

Cloud Run 是一个完全托管的计算环境，可用于部署和扩展无服务器 HTTP 容器，而无需担心机器的配置、集群的配置或自动缩放。

- 无供应商锁定 - 由于 Cloud Run 使用标准 OCI 容器并实现标准 Knative Serving API，因此您可以轻松将应用程序移植到本地或任何其他云环境。
- 快速自动缩放 - 部署在 Cloud Run 中的微服务根据传入的请求数量自动扩展，无需您配置或管理完整的 Kubernetes 集群。 如果没有请求，Cloud Run 将扩展到零——即不使用任何资源。
- 流量拆分 - Cloud Run 使您能够在多个修订之间拆分流量，因此您可以执行逐步推出，如金丝雀部署或蓝绿部署。
- 自定义域名 - 您可以在 Cloud Run 中设置自定义域名映射，系统将为您的域名提供 TLS 证书。
- 自动冗余 - Cloud Run 提供自动冗余，因此您无需担心为高可用性创建多个实例。

Cloud Run 和 Cloud Functions 都是完全托管的服务，运行在 Google Cloud 的无服务器基础设施上，自动扩展，并处理 HTTP 请求或事件。 但是，它们有一些重要的区别：

- Cloud Functions 允许您使用有限的编程语言集部署代码片段（函数），而 Cloud Run 允许您使用您选择的编程语言部署容器镜像。
- Cloud Run 还支持您应用程序中的任何工具或系统库； Cloud Functions 不允许您使用自定义可执行文件。
- Cloud Run 提供最长可达 60 分钟的请求超时，而 Cloud Functions 的请求超时可以设置为高达 9 分钟。
- Cloud Functions 每次仅向每个函数实例发送一个请求，而默认情况下，Cloud Run 被配置为在每个容器实例上发送多个并发请求。 如果您预期有大量请求，这有助于提高延迟并降低成本。

## 创建 Google Cloud Function 项目

{{% alert color="primary" %}} 
确保您有足够的权限在 Artifact Registry 存储库中创建 Google Cloud Run 功能和图像。
{{% /alert %}}

要创建 Google Cloud Function 程序，请按照以下步骤操作：

1. 安装 .NET Core SDK 3.1。
1. 安装模板包：
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. 接下来，为您的项目创建一个目录，并使用 dotnet new 创建一个新的 HTTP 函数：
{{< highlight plain >}}
mkdir AsposeFunctions //创建文件夹
cd AsposeFunctions //进入文件夹 AsposeFunctions
dotnet new gcf-http //创建具有 http 触发器的 Google Cloud Function 项目
{{< /highlight >}}
{{% alert color="primary" %}} 
这将在当前目录中创建 AsposeFunctions.csproj 和 Function.cs，打开 Function.cs 来查看代码，并提供自定义消息（如果需要）。
{{% /alert %}}
1. csproj 文件的代码示例（AsposeFunctions.csproj）。
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. 将 cad 图像转换为 png 文件的代码示例（Function.cs）。
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// 您的函数逻辑在这里。
        /// </summary>
        /// <param name="context">包含请求和响应的 HTTP 上下文。</param>
        /// <returns>表示异步操作的任务。</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //表单文件
                var file = context.Request.Body; //二进制数据
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. 本地构建您的函数：
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. 一旦服务器运行，请浏览到 http://localhost:8080 以调用该函数。 在控制台中按 Ctrl-C 停止服务器。

## 将 Docker 镜像部署到 Google Cloud

1. 登录 Google Cloud。
1. 如果项目不存在，请创建一个项目。
1. 转到“Artifact Registry”并创建一个存储库。<br>
![创建 Artifact 存储库](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. 在 Artifact Registry 中选择新存储库。
![选择 artifact 存储库](/cad/_assets/showcases/google/select-artifact.png)<br>
1. 单击“设置说明”，然后复制“配置 Docker”命令。<br>
![设置说明](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. 向 Docker 的配置文件添加一个 Docker credHelper 条目，或者在如果文件不存在的情况下创建该文件。
{{< highlight plain >}}
//示例
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. 在项目根目录中创建一个 Dockerfile，并根据<a href="#configuring-a-dockerfile">配置 Dockerfile</a>部分编辑 DockerFile。
1. 启动 Docker Desktop。
1. 使用云存储库路径构建 Docker 镜像。
{{< highlight plain >}}
//示例
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. 将图像推送到 Google Cloud Artifact Registry
{{< highlight plain >}}
//示例
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## 创建 Google Gloud Run 服务 

1. 转到 Cloud Run。
1. 创建 Cloud Run 服务。<br>
![创建 Cloud Run 服务](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. 在容器镜像 URL 字段中，从“ARTIFACT REGISTRY”中选择容器。<br>
![容器镜像 URL](/cad/_assets/showcases/google/container-url.png)<br>
1. 检查以下其他设置。<br>
![设置服务](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. 等待部署完成。
1. 服务 URL 以便与转换应用程序一起使用。<br>
![服务 URL](/cad/_assets/showcases/google/url-service.png)<br>

### 配置 Dockerfile

下一个步骤是在项目中编辑配置 Dockerfile。

1. 在 Dockerfile 中指定：

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

上述是一个简单的 Dockerfile，包含以下指令：

- 要使用的 SDK 镜像。这里是 .NET Core 3.1 镜像。 Docker 在构建时会下载它。 SDK 版本作为标签指定。
- 之后，您可能需要安装字体，因为 SDK 镜像包含的字体非常少。 另外，您可以使用复制到 Docker 镜像的本地字体。
- 工作目录，在下一行中指定。
- 将所有内容复制到容器、发布应用程序并指定入口点的命令。

## 执行示例

1. Postman 设置。<br>
![概览菜单](/cad/_assets/showcases/google/postman-settings.png)<br>
1. 选择任意 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 点击发送按钮。

{{% alert color="primary" %}} 
如果响应成功，点击“保存到文件”，您将收到转换为 png 格式的文件
{{% /alert %}}

## 更多示例

有关您如何在 Docker 中使用 Aspose.CAD 的更多示例，请参见 [示例](https://github.com/aspose-cad/Aspose.CAD-Documentation)。

## 另请参阅。

- [在 Windows 上安装 Docker Desktop](https://docs.docker.com/docker-for-windows/install/)
- [在 Mac 上安装 Docker Desktop](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022，.NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [切换到 Linux 容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 选项
- 有关 [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) 的其他信息
