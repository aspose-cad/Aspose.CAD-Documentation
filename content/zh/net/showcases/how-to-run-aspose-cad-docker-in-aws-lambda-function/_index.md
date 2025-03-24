---
title: 如何在AWS Lambda函数中运行Aspose.CAD Docker镜像
type: docs
description: "在AWS Lambda函数中运行Aspose.CAD Docker镜像。"
weight: 74
url: /zh/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## 先决条件
- 必须在系统上安装Docker。有关如何在Windows或Mac上安装Docker的信息，请参阅“另请参阅”部分中的链接。
- Visual Studio 2022。
- AWS Toolkit for Visual Studio 2022。
- 示例中使用了.NET 6 SDK。
- Postman

## AWS Lambda函数

Lambda是一种计算服务，可让您在无需配置或管理服务器的情况下运行代码。Lambda在高可用性计算基础架构上运行您的代码，并执行计算资源的所有管理，包括服务器和操作系统维护、容量配置和自动扩展以及日志记录。使用Lambda，您几乎可以为任何类型的应用程序或后端服务运行代码。

## 创建AWS Lambda函数

{{% alert color="primary" %}} 
确保您拥有创建AWS Lambda函数和在Amazon Elastic Container Registry中创建镜像的足够权限。
{{% /alert %}}

要创建AWS Lambda函数程序，请按照以下步骤操作：
1. 创建AWS Lambda项目。<br>
![创建AWS函数按钮](/cad/_assets/showcases/aws/create-project.png)<br>
1. 选择.NET 6（容器镜像）并单击“完成”按钮。<br>
![创建容器函数按钮](/cad/_assets/showcases/aws/create-container.png)<br>
1. 在Visual Studio中打开AWS Explorer（视图->AWS Explorer）。
1. 在AWS Explorer中添加AWS凭证配置文件。<br>
![凭证配置文件](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. 输入访问密钥ID和秘密访问密钥，您可以在安全凭据中获取这些密钥或联系管理员并获取授权的csv文件。<br>
![账户配置文件设置](/cad/_assets/showcases/aws/account-profile.png)<br>
1. 从NuGet安装最新的库。<br>
![NuGet管理器](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. 将cad图像转换为pdf文件的代码示例。
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. 按照<a href="#configuring-a-dockerfile">配置Dockerfile</a>部分的说明编辑DockerFile。
1. 启动Docker Desktop。
1. 发布到AWS Lambda。<br>
![AWS lambda发布](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. 编辑上传配置。<br>
![上传AWS Lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. 点击“上传”按钮。<br>
![上传AWS Lambda最后](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. 转到AWS并选择Lambda。<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. 选择您的新函数并创建URL函数。<br>
![配置URL函数](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. 选择身份验证类型
- AWS_IAM - 只有经过身份验证的IAM用户和角色才能请求您的函数URL。
- NONE - Lambda不会对请求您的函数URL进行IAM身份验证。除非您在函数中实现自己的授权逻辑，否则URL端点将是公开的。

### 配置Dockerfile

下一步是在项目中编辑配置Dockerfile。

1. 在Dockerfile中指定：

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

上述是一个简单的Dockerfile，其中包含以下指令：

- 要使用的SDK镜像。在这里它是.NET 6镜像。Docker将在构建运行时下载它。SDK的版本作为标签指定。
- 之后，您可能需要安装字体，因为SDK镜像包含的字体非常少。此外，您可以使用复制到Docker镜像的本地字体。
- 在下一行中指定的工作目录。
- 将所有内容复制到容器、发布应用程序并指定入口点的命令。

## 执行示例

1. Postman设置。<br>
![概述菜单](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. 选择任何DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG文件。
1. 点击发送按钮。

{{% alert color="primary" %}} 
如果返回成功，点击“保存到文件”，您将收到转换后的pdf格式文件
{{% /alert %}}

## 更多示例

有关如何在Docker中使用Aspose.CAD的更多示例，请参阅[示例](https://github.com/aspose-cad/Aspose.CAD-Documentation)。

## 另请参阅。

- [安装AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [在Windows上安装Docker Desktop](https://docs.docker.com/docker-for-windows/install/)
- [在Mac上安装Docker Desktop](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022，.NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [切换到Linux容器](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)选项
- 有关[.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)的附加信息
