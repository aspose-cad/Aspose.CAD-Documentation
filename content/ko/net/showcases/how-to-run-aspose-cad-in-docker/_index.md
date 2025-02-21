---
title: Aspose.CAD를 Docker에서 실행하는 방법
type: docs
description: "Linux, Windows Server 및 모든 OS에 대해 Docker 컨테이너에서 Aspose.CAD를 실행합니다."
weight: 71
url: /ko/net/showcases/how-to-run-aspose-cad-in-docker/
---

## 필수 조건
- 시스템에 Docker가 설치되어 있어야 합니다. Windows 또는 Mac에 Docker를 설치하는 방법에 대한 정보는 "참조" 섹션의 링크를 참조하십시오.
- Visual Studio 2022.
- 예제에서는 .NET 6 SDK가 사용됩니다.

## 헬로 월드 애플리케이션

이 예제에서는 타원을 그려서 이미지를 저장하는 간단한 헬로 월드 콘솔 애플리케이션을 만듭니다. 그런 다음 애플리케이션을 Docker에서 빌드하고 실행할 수 있습니다.

## 콘솔 애플리케이션 만들기

헬로 월드 프로그램을 만들기 위해 아래 단계를 따르십시오:
1. Docker가 설치되면 Linux 컨테이너를 사용하고 있는지 확인하십시오(기본값). 필요한 경우 Docker 데스크탑 메뉴에서 Linux 컨테이너로 전환 옵션을 선택합니다.
1. Visual Studio에서 .NET 6 콘솔 애플리케이션을 만듭니다.<br>
![.NET 6 콘솔 애플리케이션 프로젝트 대화상자](/_assets/showcases/docker/1.png)<br>
1. NuGet에서 최신 Aspose.CAD 버전을 설치합니다.<br>
![NuGet의 Aspose.CAD](/_assets/showcases/docker/2.png)<br>
1. 애플리케이션이 Linux에서 실행되므로 추가 글꼴을 설치해야 할 수 있습니다. ttf-mscorefonts-installer를 선호할 수 있습니다.
1. 모든 필수 종속성이 추가되면 타원을 만들고 이미지를 저장하는 간단한 프로그램을 작성하십시오:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

“TestOut” 폴더는 출력 문서를 저장하기 위한 출력 폴더로 지정되어 있습니다. Docker에서 애플리케이션을 실행할 때, 호스트 머신의 폴더가 컨테이너의 이 폴더에 마운트됩니다. 이를 통해 Docker 컨테이너 내에서 Aspose.CAD가 생성한 출력을 쉽게 볼 수 있습니다.

### Dockerfile 구성

다음 단계는 Dockerfile을 생성하고 구성하는 것입니다.

1. Dockerfile을 만들고 애플리케이션의 솔루션 파일 옆에 두십시오. 이 파일 이름은 확장자 없이 유지합니다(기본값).
1. Dockerfile에서 다음을 지정하십시오:


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
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

위의 내용은 다음 지침을 포함하고 있는 간단한 Dockerfile입니다:

- 사용될 SDK 이미지. 여기서는 .NET 6 이미지입니다. 빌드 실행 시 Docker가 이를 다운로드합니다. SDK 버전은 태그로 지정됩니다.
- 그 후, SDK 이미지에는 매우 적은 수의 글꼴이 포함되어 있으므로 글꼴 설치가 필요할 수 있습니다. 또한 Docker 이미지에 복사된 로컬 글꼴을 사용할 수 있습니다.
- 다음 줄에 지정된 작업 디렉토리입니다.
- 컨테이너에 모든 것을 복사하고 애플리케이션을 게시하고 진입점을 지정하는 명령입니다.


## Docker에서 애플리케이션 빌드 및 실행
 
이제 애플리케이션을 Docker에서 빌드하고 실행할 수 있습니다. 좋아하는 명령 프롬프트를 열고, 애플리케이션이 있는 폴더(솔루션 파일과 Dockerfile이 있는 폴더)로 디렉토리를 변경한 후 다음 명령을 실행합니다:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

이 명령을 처음 실행할 때는 Docker가 필요한 이미지를 다운로드해야 하므로 시간이 더 걸릴 수 있습니다. 이전 명령이 완료되면 다음 명령을 실행하십시오:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
마운트 인수에 주의하십시오. 앞서 언급했듯이 호스트 머신의 폴더가 컨테이너의 폴더에 마운트되어 애플리케이션 실행 결과를 쉽게 확인할 수 있습니다. Linux의 경로는 대소문자를 구분합니다.
{{% /alert %}}

## 더 많은 예제

Docker에서 Aspose.CAD를 사용할 수 있는 방법에 대한 추가 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하십시오.


## 참조

- [Windows에 Docker Desktop 설치](https://docs.docker.com/docker-for-windows/install/)
- [Mac에 Docker Desktop 설치](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
- [.NET Core SDK에 대한 추가 정보](https://hub.docker.com/_/microsoft-dotnet-sdk)
