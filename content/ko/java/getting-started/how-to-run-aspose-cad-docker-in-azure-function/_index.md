---
title: Azure Function에서 Aspose.CAD Docker 이미지 실행하기
type: docs
description: "Azure Function에서 Aspose.CAD Docker 이미지를 실행합니다."
weight: 71
url: /ko/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## 필수 조건
- 시스템에 Docker가 설치되어 있어야 합니다. Windows 또는 Mac에서 Docker 설치 방법에 대한 정보는 "참조" 섹션의 링크를 참조하십시오.
- IntelliJ IDEA.
- IntelliJ용 Azure Toolkit.
- Postman.

## Azure Function

이 예제에서는 CAD 파일을 변환하고 이미지를 저장하는 간단한 변환 함수를 생성합니다. 그런 다음 애플리케이션을 Docker에서 빌드하고 Azure Function에서 실행할 수 있습니다.

## Azure Function 만들기

Azure Function 프로그램을 생성하려면 아래 단계를 따르십시오:
1. Docker가 설치되면 Linux 컨테이너(기본값)를 사용하고 있는지 확인하십시오. 필요에 따라 Docker Desktop 메뉴에서 Linux 컨테이너로 전환 옵션을 선택하십시오.
1. IntelliJ IDEA에서 Azure Function 프로젝트를 생성하십시오.<br>
![Create azure function project](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->로그인하고 OAuth 2.0 인증을 선택하십시오.<br>
![Azure sign In](/_assets/java/java-azure/sign-in-azure.png)<br>
1. 브라우저에서 로그인하십시오.
1. 구독 이름을 선택하십시오.
1. Docker 지원을 추가하십시오.<br>
![Azure sign In](/_assets/java/java-azure/add-docker-support.png)<br>
1. <a href="#configuring-a-dockerfile">Dockerfile 구성</a> 섹션과 같이 DockerFile을 편집하십시오.
1. pom.xml에서 리포지토리 aspose.cad용 블록을 추가하십시오.
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

1. 필요한 모든 종속성이 추가되면 타원을 생성하고 이미지를 저장하는 간단한 프로그램을 작성하십시오:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * 이 함수는 "/api/HttpExample" 끝점에서 수신 대기합니다. "curl" 명령어를 사용하여 호출하는 두 가지 방법:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP 트리거가 요청을 처리합니다.");

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

### Dockerfile 구성

다음 단계는 루트 프로젝트 폴더에서 Dockerfile을 생성하고 구성하는 것입니다.

1. Dockerfile에서 다음을 지정하십시오:
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

위의 내용은 다음 지침을 포함하는 간단한 Dockerfile입니다:

- 사용할 SDK 이미지. 빌드가 실행될 때 Docker가 이를 다운로드합니다. SDK 버전은 태그로 지정됩니다.
- 다음 줄에서 지정된 작업 디렉토리.
- 모든 것을 컨테이너로 복사하고, 애플리케이션을 게시하고, 진입점을 지정하는 명령.

## Docker Hub
1. Docker Hub에 로그인하십시오.
1. 공개 리포지토리를 만드십시오.

## Docker에서 애플리케이션 빌드 및 실행
 
이제 애플리케이션을 Docker에서 빌드하고 실행할 수 있습니다. 좋아하는 명령 프롬프트를 열고 애플리케이션이 있는 폴더(솔루션 파일과 Dockerfile이 있는 폴더)로 디렉터리를 변경한 후 다음 명령을 실행하십시오:

1. 콘솔에서 dockerfile 빌드 명령
{{< highlight plain >}}
//예시
docker build -t <사용자 이름>/<리포지토리 이름> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. 이 명령을 처음 실행할 때는 Docker가 필요한 이미지를 다운로드해야 하므로 더 오래 걸릴 수 있습니다. 이전 명령이 완료된 후 이미지를 Docker Hub에 푸시하려면 다음 명령을 실행하십시오.
{{< highlight plain >}}
//예시
docker push <사용자 이름>/<리포지토리 이름>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. IDE에서 dockerfile을 실행한 후 Docker Hub에 푸시하십시오.<br>
![Run docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Docker Hub 리포지토리에서와 같이 이미지 이름을 입력하십시오.<br>
![Run docker in ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. 완료될 때까지 기다리십시오.

## Azure

1. Azure에 로그인하십시오.
1. Azure 서비스를 선택하십시오.
1. Function App을 선택하고 함수를 생성하십시오.<br>
![Azure create function button](/_assets/java/java-azure/create-function-azure.png)<br>
1. 아래 이미지와 같이 기본 설정을 반복하십시오.<br>
![Azure create function settings](/_assets/java/java-azure/create-function-settings.png)<br>
1. '검토 + 생성'을 클릭한 다음 '생성'을 클릭하십시오.
1. 배포가 완료될 때까지 기다리십시오.
1. '리소스로 이동' 버튼을 클릭하십시오.<br>
![Resource button](/_assets/java/java-azure/go-to-resource.png)<br>
1. aspose-cad-docker-example 함수를 중지하십시오.<br>
![Stop conteiner](/_assets/java/java-azure/stop-container.png)<br>
1. 배포 센터 메뉴로 이동하고 적절한 설정을 만드십시오.<br>
![Deployment center](/_assets/java/java-azure/deployment-center.png)<br>
1. 설정을 저장하십시오.
1. 배포 센터 설정의 Webhook URL을 복사하십시오.<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Docker Hub로 이동하여 리포지토리를 선택한 다음 웹후크를 선택하십시오.
1. Azure의 'Webhook url'을 Docker Hub 웹후크 URL에 붙여넣고 이름을 지정하십시오.<br>
![Webhook settings in docker](/_assets/java/java-azure/webhook.png)<br>
1. 생성 버튼을 클릭하십시오.
1. Azure Function 개요로 돌아가서 컨테이너를 시작하십시오.<br>
![Overview menu](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
함수가 시작되는 데 몇 분 정도 걸릴 수 있습니다.
{{% /alert %}}

## 실행 예제

1. Postman 설정.<br>
![Overview menu](/_assets/java/java-azure/postman-settings.png)<br>
1.任意의 DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일을 선택하십시오.
1. 전송 버튼을 클릭하십시오.
1. 결과 저장
![Save responce](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
응답이 성공적이면 파일에 저장을 클릭하면 png 형식으로 변환된 파일을 받을 수 있습니다.
{{% /alert %}}

## 더 많은 예제

Docker에서 Aspose.CAD를 사용하는 방법에 대한 더 많은 샘플은 [예제](https://github.com/aspose-cad/Aspose.CAD-Documentation)를 참조하십시오.


## 참조

- [Windows에 Docker Desktop 설치하기](https://docs.docker.com/docker-for-windows/install/)
- [Mac에 Docker Desktop 설치하기](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Linux 컨테이너로 전환](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 옵션
