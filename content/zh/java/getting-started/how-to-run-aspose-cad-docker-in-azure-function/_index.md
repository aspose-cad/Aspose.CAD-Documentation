---
title: 如何在 Azure Function 中运行 Aspose.CAD Docker 镜像
type: docs
description: "在 Azure Function 中运行 Aspose.CAD Docker 镜像。"
weight: 71
url: /zh/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## 前提条件
- 你的系统上必须安装 Docker。有关如何在 Windows 或 Mac 上安装 Docker 的信息，请参考“另见”部分中的链接。
- IntelliJ IDEA。
- IntelliJ 的 Azure 工具包。
- Postman。

## Azure Function

在这个示例中，你创建一个简单的转换函数，将 CAD 文件转换为图像并保存。然后可以在 Docker 中构建该应用程序并在 Azure Function 中运行。

## 创建 Azure Function

要创建 Azure Function 程序，请按照以下步骤操作：
1. 一旦安装了 Docker，确保它使用 Linux 容器（默认）。如有必要，请从 Docker 桌面菜单中选择切换到 Linux 容器选项。
1. 在 IntelliJ IDEA 中创建 Azure Function 项目。<br>
![创建 Azure Function 项目](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![创建 Azure Function 项目 - 最终](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. 工具->Azure->登录并选择 OAuth 2.0 认证。<br>
![Azure 登录](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. 在浏览器中登录。
1. 选择订阅名称。
1. 添加 Docker 支持。<br>
![Azure 登录](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. 按照 <a href="#configuring-a-dockerfile">配置 Dockerfile</a> 部分中的内容编辑 DockerFile。
1. 在 pom.xml 中为存储库 aspose.cad 添加块。
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. 当所有必需的依赖项都已添加时，编写一个简单的程序，该程序创建一个椭圆并将其保存为图像：<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * 该函数在端点 "/api/HttpExample" 监听。使用 "curl" 命令在 bash 中调用它有两种方式：
     * 1. curl -d "HTTP 正文" {你的主机}/api/HttpExample
     * 2. curl "{你的主机}/api/HttpExample?name=HTTP%20查询"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP 触发器处理了请求。");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### 配置 Dockerfile

下一步是在根项目文件夹中创建并配置 Dockerfile。

1. 在 Dockerfile 中指定：
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

上述是一个简单的 Dockerfile，其中包含以下指令：

- 要使用的 SDK 镜像。当构建运行时，Docker 将下载它。SDK 的版本作为标签指定。
- 工作目录，在下一行中指定。
- 将所有内容复制到容器、发布应用程序并指定入口点的命令。

## Docker Hub
1. 登录 Docker Hub
1. 创建公共存储库

## 在 Docker 中构建和运行应用程序

现在可以在 Docker 中构建并运行应用程序。打开你喜欢的命令提示符，将目录更改为应用程序所在的文件夹（解决方案文件和 Dockerfile 所在的文件夹），并运行以下命令：

1. 控制台中构建 dockerfile 命令
{{< highlight plain >}}
//示例
docker build -t <用户名称>/<存储库名称> .

docker build -t user/asposefunction .
{{< /highlight >}}

1. 第一次运行此命令时，可能需要更长时间，因为 Docker 需要下载必要的镜像。前一个命令完成后，运行以下命令将映像推送到 docker hub。
{{< highlight plain >}}
//示例
docker push <用户名称>/<存储库名称>:标签名

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. 在 IDE 中运行 dockerfile，然后推送到 docker hub。<br>
![在 IDE 中运行 docker](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. 输入图像的名称，如 Docker Hub 存储库中的名称一样。<br>
![在 IDE 中运行 docker - 下一步](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. 等待结束。

## Azure

1. 登录 Azure。
1. 选择 Azure 服务。
1. 选择 Function App 并创建一个函数。<br>
![Azure 创建函数按钮](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. 按照以下图像重复基本设置。<br>
![Azure 创建函数设置](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. 点击 '审核 + 创建' -> 创建。
1. 等待部署完成。
1. 点击 '转到资源' 按钮。<br>
![资源按钮](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. 停止 aspose-cad-docker-example 函数。<br>
![停止容器](/cad/_assets/java/java-azure/stop-container.png)<br>
1. 转到部署中心菜单并进行相应设置。<br>
![部署中心](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. 保存设置。
1. 从部署中心设置中复制 Webhook URL。<br>
![Webhook URL](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. 转到 Docker Hub，选择你的存储库并选择 webhook。
1. 将 Azure 的 'Webhook URL' 粘贴到 Docker Hub webhook URL 中并设置名称。<br>
![Docker 中的 Webhook 设置](/cad/_assets/java/java-azure/webhook.png)<br>
1. 点击创建按钮。
1. 返回到 Azure Function 的概述并启动容器。<br>
![概述菜单](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
函数可能需要几分钟才能启动。
{{% /alert %}}

## 执行示例

1. Postman 设置。<br>
![概述菜单](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. 选择任何 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 点击发送按钮。
1. 保存结果
![保存响应](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
如果回答成功，点击保存到文件，你将收到转换为 png 格式的文件。
{{% /alert %}}

## 更多示例

有关如何在 Docker 中使用 Aspose.CAD 的更多示例，请参阅 [示例](https://github.com/aspose-cad/Aspose.CAD-Documentation)。

## 另见

- [在 Windows 上安装 Docker Desktop](https://docs.docker.com/docker-for-windows/install/)
- [在 Mac 上安装 Docker Desktop](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [切换到 Linux 容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 选项
