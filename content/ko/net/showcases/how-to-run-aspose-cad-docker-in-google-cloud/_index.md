---
title: Google Cloud에서 Aspose.CAD 도커 이미지를 실행하는 방법
type: docs
description: "Google Cloud에서 Aspose.CAD 도커 이미지를 실행합니다."
weight: 75
url: /ko/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## 전제 조건

- 시스템에 Docker가 설치되어 있어야 합니다. Windows 또는 Mac에 Docker를 설치하는 방법에 대한 정보는 "참조" 섹션의 링크를 참조하십시오.
- Visual Studio 2022.
- Google CLI.
- 예제에서 사용되는 NET Core 3.1 SDK.
- Postman

## Google Cloud Run 기능

Cloud Run은 서버리스 HTTP 컨테이너를 배포하고 확장하기 위한 완전 관리형 컴퓨팅 환경으로, 머신 프로비저닝, 클러스터 구성 또는 자동 확장에 대한 걱정 없이 사용할 수 있습니다.

- 공급업체 종속성 없음 - Cloud Run은 표준 OCI 컨테이너를 사용하고 표준 Knative Serving API를 구현하여 애플리케이션을 온프레미스 또는 기타 클라우드 환경으로 쉽게 포팅할 수 있습니다.
- 빠른 자동 확장 - Cloud Run에 배포된 마이크로서비스는 들어오는 요청 수에 따라 자동으로 확장되며, 사용자가 완전한 Kubernetes 클러스터를 구성하거나 관리할 필요가 없습니다. 요청이 없으면 Cloud Run은 자원을 사용하지 않고 0으로 확장됩니다.
- 트래픽 분할 - Cloud Run은 여러 수정 간에 트래픽을 분할할 수 있도록 하여 카나리아 배포 또는 블루/그린 배포와 같은 점진적 배포를 수행할 수 있습니다.
- 맞춤 도메인 - Cloud Run에서 맞춤 도메인 매핑을 설정할 수 있으며, 도메인에 대한 TLS 인증서를 프로비저닝합니다.
- 자동 중복성 - Cloud Run은 자동 중복성을 제공하므로 높은 가용성을 위해 여러 인스턴스를 생성하는 것에 대해 걱정할 필요가 없습니다.

Cloud Run과 Cloud Functions는 Google Cloud의 서버리스 인프라에서 실행되는 완전 관리형 서비스로, 자동 확장 및 HTTP 요청 또는 이벤트를 처리합니다. 하지만 중요한 차이점이 몇 가지 있습니다:

- Cloud Functions는 제한된 프로그래밍 언어 집합으로 작성된 코드 조각(함수)을 배포할 수 있는 반면, Cloud Run은 선택한 프로그래밍 언어를 사용하는 컨테이너 이미지를 배포할 수 있습니다.
- Cloud Run은 애플리케이션의 도구나 시스템 라이브러리 사용을 지원하지만, Cloud Functions는 사용자 지정 실행 파일을 사용할 수 없습니다.
- Cloud Run은 최대 60분의 요청 시간 초과 기간을 제공하는 반면, Cloud Functions의 요청 시간 초과는 최대 9분으로 설정할 수 있습니다.
- Cloud Functions는 각 함수 인스턴스에 대해 한 번에 하나의 요청만 전송하는 반면, 기본적으로 Cloud Run은 각 컨테이너 인스턴스에서 여러 동시 요청을 전송하도록 구성되어 있습니다. 이는 대량의 요청을 예상할 경우 지연 시간을 개선하고 비용을 줄이는 데 도움이 됩니다.

## Google Cloud Function 프로젝트 생성

{{% alert color="primary" %}} 
Google Cloud Run 기능 및 Artifact Registry 리포지토리에서 이미지를 생성할 수 있는 충분한 권한이 있는지 확인하십시오.
{{% /alert %}}

Google Cloud Function 프로그램을 생성하려면 아래 단계를 따르십시오:

1. .NET Core SDK 3.1을 설치합니다.
1. 템플릿 패키지를 설치합니다:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. 다음으로, 프로젝트를 위한 디렉토리를 생성하고 dotnet new를 사용하여 새로운 HTTP 기능을 생성합니다:
{{< highlight plain >}}
mkdir AsposeFunctions //폴더 생성
cd AsposeFunctions //AsposeFunctions 폴더로 이동
dotnet new gcf-http //http 트리거로 Google Cloud Function 프로젝트 생성
{{< /highlight >}}
{{% alert color="primary" %}} 
이 작업은 현재 디렉토리에 AsposeFunctions.csproj 및 Function.cs를 생성합니다. 코드를 검토하려면 Function.cs를 열고 원하는 경우 사용자 정의 메시지를 제공하십시오.
{{% /alert %}}
1. csproj 파일(AsposeFunctions.csproj) 코드 예제.
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
1. cad 이미지를 png 파일로 변환하는 코드 예제(Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// 함수의 논리가 여기에 작성됩니다.
        /// </summary>
        /// <param name="context">요청 및 응답을 포함하는 HTTP 컨텍스트입니다.</param>
        /// <returns>비동기 작업을 나타내는 작업입니다.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //폼 파일
                var file = context.Request.Body; //바이너리 데이터
                
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
1. 다음과 같이 로컬에서 함수를 빌드합니다:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. 서버가 실행 중일 때 http://localhost:8080에 브라우저를 열어 함수를 호출합니다. 콘솔에서 Ctrl-C를 눌러 서버를 중지합니다.

## Google Cloud에 도커 이미지 배포

1. Google Cloud에 로그인합니다.
1. 프로젝트가 존재하지 않으면 생성합니다.
1. 'Artifact Registry'로 이동하여 리포지토리를 생성합니다.<br>
![Create Artifact Repository](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Artifact Registry에서 새로운 리포지토리를 선택합니다.
![Select artifact repository](/_assets/showcases/google/select-artifact.png)<br>
1. 'SETUP INSTRUCTION'을 클릭하고 'Configure Docker' 명령을 복사합니다.<br>
![SETUP INSTRUCTION](/_assets/showcases/google/setup-instruction.png)<br>
1. Docker의 구성 파일에 Docker credHelper 항목을 추가하거나, 존재하지 않을 경우 파일을 생성합니다.
{{< highlight plain >}}
//예제
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. 프로젝트 루트 디렉토리에 Dockerfile을 생성하고 <a href="#configuring-a-dockerfile">Dockerfile 구성</a> 섹션과 같이 DockerFile을 편집합니다.
1. Docker Desktop을 시작합니다.
1. 클라우드 리포지토리 경로로 도커 이미지를 빌드합니다.
{{< highlight plain >}}
//예제
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Google Cloud Artifact Registry에 이미지를 푸시합니다.
{{< highlight plain >}}
//예제
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Cloud Run 서비스 생성

1. Cloud Run으로 이동합니다.
1. Cloud Run 서비스를 생성합니다.<br>
![Create Cloud Run service](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Container Image URL 필드에서 'ARTIFACT REGISTRY'의 컨테이너를 선택합니다.<br>
![Container Image URL](/_assets/showcases/google/container-url.png)<br>
1. 아래와 같이 다른 설정을 확인합니다.<br>
![Settings service](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. 배포가 완료될 때까지 기다립니다.
1. 변환 애플리케이션과 함께 작업할 서비스 URL.<br>
![Url service](/_assets/showcases/google/url-service.png)<br>

### Dockerfile 구성

다음 단계는 프로젝트에서 Dockerfile을 편집하여 구성하는 것입니다.

1. Dockerfile에서 다음을 지정합니다:

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
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

위의 간단한 Dockerfile에는 다음 지침이 포함되어 있습니다:

- 사용될 SDK 이미지입니다. 여기서는 Net Core 3.1 이미지입니다. 빌드가 실행될 때 Docker가 이를 다운로드합니다. SDK 버전은 태그로 지정됩니다.
- 이후, SDK 이미지에는 매우 적은 수의 글꼴이 포함되어 있으므로 글꼴을 설치해야 할 수 있습니다. 또한 도커 이미지에 복사된 로컬 글꼴을 사용할 수 있습니다.
- 다음 줄에 지정된 작업 디렉토리입니다.
- 모든 것을 컨테이너로 복사하고 애플리케이션을 게시하며, 진입점을 지정하는 명령입니다.

## 실행 예제

1. Postman 설정.<br>
![Overview menu](/_assets/showcases/google/postman-settings.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택합니다.
1. 전송 버튼을 클릭합니다.

{{% alert color="primary" %}} 
응답이 성공하면 파일을 저장을 클릭하여 png 형식으로 변환된 파일을 받을 수 있습니다.
{{% /alert %}}

## 더 많은 예제

Docker에서 Aspose.CAD를 사용하는 방법에 대한 더 많은 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하세요.

## 참조.

- [Windows에 Docker Desktop 설치](https://docs.docker.com/docker-for-windows/install/)
- [Mac에 Docker Desktop 설치](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
- [.NET Core SDK에 대한 추가 정보](https://hub.docker.com/_/microsoft-dotnet-sdk)
