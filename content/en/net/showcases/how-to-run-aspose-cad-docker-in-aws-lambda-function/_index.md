---
title: How to Run Aspose.CAD Docker image in AWS Lambda Function
type: docs
description: "Run Aspose.CAD Docker image in AWS Lambda Function."
weight: 74
url: /net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Prerequisites
- Docker must be installed on your system. For information on how to install Docker on Windows or Mac, refer to the links in the “See Also” section.
- Visual Studio 2022.
- AWS Toolkit for Visual Studio 2022.
- NET 6 SDK is used in the example.
- Postman

## AWS Lambda Function

Lambda is a compute service that lets you run code without provisioning or managing servers. Lambda runs your code on a high-availability compute infrastructure and performs all of the administration of the compute resources, including server and operating system maintenance, capacity provisioning and automatic scaling, and logging. With Lambda, you can run code for virtually any type of application or backend service.

## Creating the AWS Lambda Function

{{% alert color="primary" %}} 
Make sure you have sufficient rights to create AWS Lambda functions and images in the Amazon Elastic Container Registry.
{{% /alert %}}

To create the AWS Lambda Function program, follow the steps below:
1. Create AWS Lambda Project.<br>
![Create AWS function button](/cad/_assets/showcases/aws/create-project.png)<br>
1. Select .NET 6(Container Image) and click 'Finish' button.<br>
![Create container function button](/cad/_assets/showcases/aws/create-container.png)<br>
1. Open AWS Explorer in Visual Studio(View->AWS Explorer).
1. Add AWS credentials profile in AWS Explorer.<br>
![Credential profile](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Enter Access Key ID and Secret Access Key, you can get these keys in Security credentials or contact the administrator and get a csv file for authorization.<br>
![Acount profile settings](/cad/_assets/showcases/aws/account-profile.png)<br>
1. Install the latest libraries from NuGet.<br>
![NuGet Manager](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. Code example for convert cad image to pdf file.
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
1. Edit the DockerFile as in the <a href="#configuring-a-dockerfile">Configuring a Dockerfile</a> section.
1. Start Docker Desktop.
1. Publish to AWS Lambda.<br>
![AWS lambda publish](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. Edit upload configuration.<br>
![Upload aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Click 'Upload' button.<br>
![Upload aws lambda last](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Go to AWS and select Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Select your new function and create url function.<br>
![Configuration url function](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. Select auth type
- AWS_IAM - Only authenticated IAM users and roles can make requests to your function URL.
- NONE - Lambda won't perform IAM authentication on requests to your function URL. The URL endpoint will be public unless you implement your own authorization logic in your function.

### Configuring a Dockerfile

 The next step is to edit configure the Dockerfile in project.

1. In the Dockerfile, specify:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 The above is a simple Dockerfile, which contains the following instructions:

- The SDK image to be used. Here it is the Net 6 image. Docker will download it when the build is run. The version of SDK is specified as a tag.
- After, you may need to install Fonts because the SDK image contains very few fonts. Also, you can use local fonts copied to docker image.
- The working directory, which is specified in the next line.
- The command to copy everything to container, publish the application, and specify the entry point.

## Execution example

1. Postman settings.<br>
![Overview menu](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. Click the send button.

{{% alert color="primary" %}} 
If the answer is successful, click Save to file and you will receive the converted file in pdf format
{{% /alert %}}

## More Examples

For more samples of how you can use Aspose.CAD in Docker, see the [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## See Also.

- [Install AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Install Docker Desktop on Windows](https://docs.docker.com/docker-for-windows/install/)
- [Install Docker Desktop on Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
- Additional information on [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)