---
title: AWS Lambda 함수에서 Aspose.CAD 도커 이미지 실행 방법
type: docs
description: "AWS Lambda 함수에서 Aspose.CAD 도커 이미지를 실행합니다."
weight: 74
url: /ko/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## 전제 조건
- 시스템에 Docker가 설치되어 있어야 합니다. Windows 또는 Mac에 Docker를 설치하는 방법에 대한 정보는 "참고" 섹션의 링크를 참조하십시오.
- Visual Studio 2022.
- Visual Studio 2022용 AWS 툴킷.
- 예제에서는 NET 6 SDK가 사용됩니다.
- Postman

## AWS Lambda 함수

Lambda는 서버를 프로비저닝하거나 관리하지 않고 코드 실행을 가능하게 하는 컴퓨팅 서비스입니다. Lambda는 높은 가용성의 컴퓨팅 인프라에서 코드를 실행하고 서버 및 운영 체제 유지 관리, 용량 프로비저닝 및 자동 확장, 로깅 등 컴퓨팅 리소스의 모든 관리 작업을 수행합니다. Lambda를 사용하면 거의 모든 유형의 애플리케이션 또는 백엔드 서비스에 대한 코드를 실행할 수 있습니다.

## AWS Lambda 함수 만들기

{{% alert color="primary" %}} 
AWS Lambda 함수 및 이미지를 Amazon Elastic Container Registry에 생성할 충분한 권한이 있는지 확인하십시오.
{{% /alert %}}

AWS Lambda 함수 프로그램을 만들려면 아래 단계를 따르십시오:
1. AWS Lambda 프로젝트를 생성합니다.<br>
![AWS 함수 생성 버튼](/_assets/showcases/aws/create-project.png)<br>
1. .NET 6(컨테이너 이미지)를 선택하고 '완료' 버튼을 클릭합니다.<br>
![컨테이너 함수 생성 버튼](/_assets/showcases/aws/create-container.png)<br>
1. Visual Studio에서 AWS 탐색기를 엽니다(보기->AWS 탐색기).
1. AWS 탐색기에 AWS 자격 증명 프로필을 추가합니다.<br>
![자격 증명 프로필](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Access Key ID 및 Secret Access Key를 입력합니다. 이러한 키는 보안 자격 증명에서 얻거나 관리자를 통해 인증을 위한 CSV 파일을 요청할 수 있습니다.<br>
![계정 프로필 설정](/_assets/showcases/aws/account-profile.png)<br>
1. NuGet에서 최신 라이브러리를 설치합니다.<br>
![NuGet 관리자](/_assets/showcases/aws/nuget-manager.png)<br>
1. CAD 이미지를 PDF 파일로 변환하는 코드 예제입니다.
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
1. <a href="#configuring-a-dockerfile">Dockerfile 구성</a> 섹션과 같이 DockerFile을 편집합니다.
1. Docker Desktop을 시작합니다.
1. AWS Lambda에 게시합니다.<br>
![AWS lambda 게시](/_assets/showcases/aws/publish-aws.png)<br>
1. 업로드 구성을 편집합니다.<br>
![AWS Lambda 업로드](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. '업로드' 버튼을 클릭합니다.<br>
![AWS Lambda 마지막 업로드](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. AWS로 이동하여 Lambda를 선택합니다.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. 새 함수를 선택하고 함수 URL을 생성합니다.<br>
![URL 함수 구성](/_assets/showcases/aws/create-function-url.png)<br>
1. 인증 유형 선택
- AWS_IAM - 인증된 IAM 사용자 및 역할만 함수 URL에 요청을 할 수 있습니다.
- NONE - Lambda에서는 함수 URL에 대한 요청에서 IAM 인증을 수행하지 않습니다. 함수에 고유한 인증 논리를 구현하지 않는 한 URL 끝점은 공개적입니다.

### Dockerfile 구성

다음 단계는 프로젝트의 Dockerfile을 편집하여 구성하는 것입니다.

1. Dockerfile에 다음을 지정합니다:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

위의 내용은 다음 지침을 포함하는 간단한 Dockerfile입니다:

- 사용되는 SDK 이미지입니다. 여기서는 Net 6 이미지입니다. 빌드가 실행될 때 Docker가 다운로드합니다. SDK의 버전은 태그로 지정됩니다.
- SDK 이미지에 글꼴이 거의 없으므로 글꼴을 설치해야 할 수도 있습니다. 또한 도커 이미지에 복사된 로컬 글꼴을 사용할 수 있습니다.
- 다음 줄에 지정된 작업 디렉토리입니다.
- 컨테이너에 모든 것을 복사하고 응용 프로그램을 게시하고 진입점을 지정하는 명령입니다.

## 실행 예제

1. Postman 설정.<br>
![개요 메뉴](/_assets/showcases/aws/postman-settings.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택합니다.
1. 전송 버튼을 클릭합니다.

{{% alert color="primary" %}} 
응답이 성공하면 파일로 저장을 클릭하면 PDF 형식으로 변환된 파일을 받을 수 있습니다.
{{% /alert %}}

## 추가 예제

Docker에서 Aspose.CAD를 사용하는 방법에 대한 추가 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하십시오.


## 참고

- [Visual Studio 2022용 AWS 툴킷 설치](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows에 Docker Desktop 설치](https://docs.docker.com/docker-for-windows/install/)
- [Mac에 Docker Desktop 설치](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
- [.NET Core SDK에 대한 추가 정보](https://hub.docker.com/_/microsoft-dotnet-sdk)
