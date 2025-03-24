---
title: Azure Function에서 Aspose.CAD Docker 이미지 실행 방법
type: docs
description: "Azure Function에서 Aspose.CAD Docker 이미지를 실행합니다."
weight: 73
url: /ko/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## 필수 조건
- 시스템에 Docker가 설치되어 있어야 합니다. Windows 또는 Mac에 Docker를 설치하는 방법에 대한 정보는 “참조” 섹션의 링크를 참조하십시오.
- Visual Studio 2022.
- 예제에서는 .NET 6 SDK가 사용됩니다.
- Postman

## Azure Function

이 예제에서는 CAD 파일을 변환하고 이미지를 저장하는 간단한 변환 함수를 생성합니다. 이후 응용 프로그램은 Docker에서 빌드되고 Azure Function에서 실행될 수 있습니다.

## Azure Function 생성

Azure Function 프로그램을 생성하려면 아래 단계를 따르십시오:
1. Docker가 설치되면 Linux 컨테이너(기본값)를 사용하도록 설정되어 있는지 확인하십시오. 필요한 경우 Docker Desktop 메뉴에서 Linux 컨테이너로 전환 옵션을 선택하십시오.
1. Visual Studio에서 .NET 6 Azure Function을 생성하십시오.<br>
![.NET 6 Azure Function 프로젝트 대화상자](/cad/_assets/showcases/azure/Create-project.png)<br>
1. 추가 정보입니다.<br>
![.NET 6 Azure Function 프로젝트 대화상자](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. NuGet에서 최신 Aspose.CAD 버전을 설치하십시오.<br>
![NuGet에서의 Aspose.CAD](/cad/_assets/showcases/azure/NuGet.png)<br>
1. 애플리케이션이 Linux에서 실행되므로 추가 글꼴을 설치해야 할 수도 있습니다. ttf-mscorefonts-installer를 선택할 수 있습니다.
1. 모든 필수 종속성이 추가되면 타원을 생성하고 이미지를 저장하는 간단한 프로그램을 작성하십시오:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP 트리거 함수가 요청을 처리했습니다.");
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

### Dockerfile 구성

다음 단계는 루트 프로젝트 폴더에서 Dockerfile을 생성하고 구성하는 것입니다.

1. Dockerfile을 생성하고 애플리케이션의 솔루션 파일 옆에 배치하십시오. 이 파일 이름은 확장자가 없는 기본 이름으로 유지하십시오.
![루트 프로젝트 폴더](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Dockerfile에서 다음을 지정하십시오:

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

위의 Dockerfile은 다음 명령을 포함하는 간단한 Dockerfile입니다:

- 사용될 SDK 이미지입니다. 여기서는 .NET 6 이미지입니다. Docker는 빌드가 실행될 때 이를 다운로드합니다. SDK의 버전은 태그로 지정됩니다.
- 이후, SDK 이미지에는 글꼴이 매우 적기 때문에 글꼴을 설치해야 할 수도 있습니다. 또한, 도커 이미지에 복사된 로컬 글꼴을 사용할 수 있습니다.
- 다음 줄에서 지정된 작업 디렉터리입니다.
- 컨테이너로 모든 것을 복사하고 애플리케이션을 게시하며 진입점을 지정하는 명령입니다.

## Docker Hub
1. Docker Hub에 로그인하십시오.
1. 공개 리포지토리를 생성하십시오.

## Docker에서 애플리케이션 빌드 및 실행

이제 애플리케이션을 Docker에서 빌드하고 실행할 수 있습니다. 좋아하는 명령 프롬프트를 열고 애플리케이션이 있는 폴더(솔루션 파일과 Dockerfile이 배치된 폴더)로 디렉토리를 변경한 후 다음 명령을 실행하십시오:

{{< highlight plain >}}
//예시
docker build -t <사용자 이름>/<리포지토리 이름> .

docker build -t user/asposefunction .
{{< /highlight >}}

이 명령을 처음 실행할 때는 Docker가 필요한 이미지를 다운로드해야 하므로 시간이 더 걸릴 수 있습니다. 이전 명령이 완료되면 이미지를 Docker Hub에 푸시하기 위해 다음 명령을 실행하십시오:
 
{{< highlight plain >}}
//예시
docker push <사용자 이름>/<리포지토리 이름>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Azure에 로그인하십시오.
1. Azure 서비스를 선택하십시오.
1. Function App을 선택하고 함수를 생성하십시오.<br>
![Azure 함수 생성 버튼](/cad/_assets/showcases/azure/create-function.png)<br>
1. 아래 이미지처럼 기본 설정을 반복하십시오.<br>
![Azure 함수 생성 설정](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. '검토 + 생성' 클릭 -> 생성합니다.
1. 배포가 완료될 때까지 기다립니다.
1. '리소스로 이동' 버튼을 클릭하십시오.<br>
![리소스 버튼](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. aspose-cad-docker-example 함수를 중지합니다.<br>
![컨테이너 중지](/cad/_assets/showcases/azure/stop-container.png)<br>
1. 배포 센터 메뉴로 이동하여 적절한 설정을 합니다.<br>
![배포 센터](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. 설정을 저장합니다.
1. 배포 센터 설정에서 Webhook URL을 복사합니다.<br>
![Webhook url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Docker Hub로 이동하여 리포지토리를 선택하고 웹 후크를 선택합니다.
1. Azure에서 가져온 'Webhook url'을 Docker Hub 웹 후크 URL에 붙여넣고 이름을 설정합니다.<br>
![Docker의 웹 후크 설정](/cad/_assets/showcases/azure/webhook.png)<br>
1. 생성 버튼을 클릭합니다.
1. Azure 함수 개요로 돌아가서 컨테이너를 시작합니다.<br>
![개요 메뉴](/cad/_assets/showcases/azure/overview.png)<br>

## 실행 예제

1. Postman 설정입니다.<br>
![개요 메뉴](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택합니다.
1. 보내기 버튼을 클릭합니다.

{{% alert color="primary" %}} 
응답이 성공적이라면 파일에 저장을 클릭하면 png 형식으로 변환된 파일을 받을 수 있습니다.
{{% /alert %}}

## 더 많은 예제

Docker에서 Aspose.CAD를 사용할 수 있는 더 많은 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하십시오.

## 참조

- [Windows에 Docker Desktop 설치](https://docs.docker.com/docker-for-windows/install/)
- [Mac에 Docker Desktop 설치](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
- [.NET Core SDK에 대한 추가 정보](https://hub.docker.com/_/microsoft-dotnet-sdk)
