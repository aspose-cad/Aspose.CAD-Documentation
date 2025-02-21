---
title: 예제 실행 방법
type: docs
weight: 70
url: /ko/java/getting-started/how-to-run-the-examples/
---

## **GitHub에서 다운로드**

Aspose.CAD for Java의 모든 예제는 [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java)에 호스팅되어 있습니다. 좋아하는 Github 클라이언트를 사용하여 저장소를 클론하거나 [여기](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip)에서 ZIP 파일을 다운로드할 수 있습니다.

ZIP 파일의 내용을 컴퓨터의 아무 폴더에 추출합니다. 모든 예제는 **Examples** 폴더에 있습니다.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**그림: Aspose.CAD 예제 디렉터리**|

## **IDE에 예제 가져오기**

프로젝트는 Maven 빌드 시스템을 사용합니다. 모든 최신 IDE는 프로젝트와 그 종속성을 쉽게 열거나 가져올 수 있습니다. 아래에서는 인기 있는 IDE를 사용하여 예제를 빌드하고 실행하는 방법을 보여줍니다.

### **IntelliJ IDEA**

**파일** 메뉴를 클릭하고 **열기**를 선택합니다. 프로젝트 폴더로 이동하여 **pom.xml** 파일을 선택합니다.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**그림: 가져올 파일 또는 디렉터리 선택**|
프로젝트가 열리고 종속성이 자동으로 다운로드됩니다. 프로젝트 탭에서 **src/main/java** 폴더의 예제를 탐색합니다. 예제를 실행하려면 파일을 마우스 오른쪽 버튼으로 클릭하고 "실행 .."을 선택하면 예제가 실행되고 출력이 내장 콘솔 출력 창에 표시됩니다.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**그림: 예제 실행**|

### **Eclipse**

**파일** 메뉴를 클릭하고 **가져오기**를 선택합니다. **Maven** - 기존 Maven 프로젝트를 선택합니다.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**그림: 가져오기**|
GitHub에서 클론하거나 다운로드한 폴더로 이동하여 **pom.xml** 파일을 선택합니다. 프로젝트가 열리고 종속성이 자동으로 다운로드됩니다. 패키지 탐색기 탭에서 **src/main/java** 폴더의 예제를 탐색합니다. 예제를 실행하려면 파일을 마우스 오른쪽 버튼으로 클릭하고 **실행 구성** - **Java 애플리케이션**을 선택하면 예제가 실행되고 출력이 내장 콘솔 출력 창에 표시됩니다.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**그림: 예제 실행**|

### **NetBeans**

**파일** 메뉴를 클릭하고 **프로젝트 열기**를 선택합니다. GitHub에서 클론하거나 다운로드한 폴더로 이동합니다. **Examples** 폴더의 아이콘이 Maven 프로젝트임을 표시합니다. Examples를 선택하고 열어주세요.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**그림: 프로젝트 열기**|
프로젝트가 열리고 종속성이 자동으로 다운로드됩니다. 프로젝트 탭에서 **소스 패키지**의 예제를 탐색합니다. 예제를 실행하려면 파일을 마우스 오른쪽 버튼으로 클릭하고 **파일 실행**을 선택하면 예제가 실행되고 출력이 내장 콘솔 출력 창에 표시됩니다.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**그림: 예제 실행**|

## **Maven 로컬 저장소에 Aspose.CAD 라이브러리 추가하기**

**Aspose.CAD 예제** 프로젝트를 IDE에 가져오면 Maven이 자동으로 [Aspose Maven Repository](https://releases.aspose.com/java/repo/)에서 aspose.cad JAR 파일을 다운로드합니다. 인터넷에 액세스할 수 없는 경우 로컬 저장소에 JAR 파일을 수동으로 추가할 수 있습니다.

### **mvn install**

[aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/)를 다운로드하고, 추출한 후 aspose.cad-version.jar를 다른 곳, 예를 들어 c 드라이브에 복사합니다. 다음 명령어를 입력합니다:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

이제 **aspose.cad** jar가 Maven 로컬 저장소에 복사되었습니다.

### **pom.xml**

설치 후 pom.xml에 **aspose.cad** 좌표를 선언합니다.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **완료**

빌드하면 이제 **aspose.cad** jar가 Maven 로컬 저장소에서 검색 가능합니다.

## **기여하기**

예제를 추가하거나 개선하고 싶다면 프로젝트에 기여해 주시기 바랍니다. 이 리포지토리의 모든 예제와 쇼케이스 프로젝트는 오픈 소스이며 귀하의 애플리케이션에서 자유롭게 사용할 수 있습니다.

기여하려면 리포지토리를 포크하고 소스 코드를 편집한 후 Pull Request를 제출할 수 있습니다. 변경 사항을 검토하고 도움이 되면 리포지토리에 포함하겠습니다.
