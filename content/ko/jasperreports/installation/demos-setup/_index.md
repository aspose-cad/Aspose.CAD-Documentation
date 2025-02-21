---
title: 데모 설정
type: docs
weight: 40
url: /ko/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports는 시작하는 데 도움이 되는 여러 데모 프로젝트를 포함합니다.

Aspose.CAD for JasperReports와 함께 제공되는 데모는 새로운 내보내기 도구의 사용을 보여주기 위해 수정된 표준 JasperReports 데모입니다.

{{% /alert %}}

Aspose.CAD for JasperReports 데모를 실행하려면 다음 단계를 수행하세요:

1. JasperReports를 다운로드합니다 (예: https://sourceforge.net/projects/jasperreports/files/archive/). 소스 코드와 데모가 포함된 전체 아카이브 프로젝트를 다운로드해야 하며, 단일 JAR 파일만 다운로드하지 마세요.
1. 아카이브된 프로젝트를 하드 드라이브의 임의의 위치, 예를 들어 C:\에 압축 해제합니다.
1. **aspose-cad-xx.x.zip**의 \samples 폴더에서 모든 데모 폴더를 **\InstallDir\demo\samples**로 복사합니다. 여기서 "\InstallDir"은 JasperReports를 압축 해제한 위치입니다. 이 단계는 데모 빌드 스크립트가 JasperReports의 폴더 구조에 의존하기 때문에 필요합니다. 그렇지 않으면 빌드 스크립트를 수정해야 합니다.
1. **aspose-cad-jasperreports-xx.x.jar**를 **aspose-cad-jasperreports-xx.x.zip**의 \lib 폴더에서 **\InstallDir\lib**로 복사합니다.
1. Ant Build Tool과 Ivy Dependency Manager를 준비합니다. **\InstallDir\readme.txt**를 참조하세요.
1. **\InstallDir\demo\samples**에 있는 **build.xml**을 수정하여 클래스 경로에 aspose-cad-jasperreports-xx.x.jar를 추가합니다:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. 현재 디렉토리를 **\InstallDir\demo\hsqldb**로 변경하고 다음 명령어를 실행합니다:
   **Ant runServer**
1. 현재 디렉토리를 Aspose.CAD for JasperReports 데모 중 하나로 변경합니다. 예를 들어 **\InstallDir\demo\samples\charts.ai**로 변경하고 명령줄에서 다음 명령을 실행합니다:
   **ant test** - 보고서 파일을 생성합니다.
1. 결과 문서 중 하나를 열어 보세요. 예를 들어 **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**를 열어 보세요.
