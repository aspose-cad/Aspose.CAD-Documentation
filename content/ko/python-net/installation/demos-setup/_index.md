---
title: 데모 설정
type: docs
weight: 40
url: /ko/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for Python에는 시작하는 데 도움이 되는 여러 데모 프로젝트가 포함되어 있습니다.

Aspose.CAD for Python과 함께 제공되는 데모는 새로운 내보내기 프로그램의 사용을 시연하도록 수정된 표준 Python 데모입니다.

{{% /alert %}}

Aspose.CAD for Python 데모를 실행하려면 다음 단계를 수행하십시오:

1. Pythons를 다운로드합니다 (예: https://sourceforge.net/projects/python-net/files/archive/). 소스 코드와 데모를 포함한 전체 아카이브 프로젝트를 다운로드해야 하며, 단일 JAR만 다운로드해서는 안 됩니다.
1. 아카이브된 프로젝트를 하드 디스크의 일부 위치, 예를 들어 C:\ 에 압축 풉니다.
1. **aspose-cad-xx.x.zip**의 \samples 폴더에서 모든 데모 폴더를 **\InstallDir\demo\samples**로 복사합니다. 여기서 "\InstallDir"은 Pythons를 압축 푼 위치입니다. 이 단계는 데모 빌드 스크립트가 Pythons의 폴더 구조에 의존하기 때문에 필요하며, 그렇지 않으면 빌드 스크립트를 수정해야 합니다.
1. **aspose-cad-pythons-xx.x.jar**를 **aspose-cad-pythons-xx.x.zip**의 \lib 폴더에서 **\InstallDir\lib**로 복사합니다.
1. Ant 빌드 도구 및 Ivy 종속성 관리자를 준비합니다. **\InstallDir\readme.txt**를 참조하십시오.
1. **\InstallDir\demo\samples**의 **build.xml**을 수정하고 aspose-cad-pythons-xx.x.jar를 클래스패스에 추가합니다:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. 현재 디렉토리를 **\InstallDir\demo\hsqldb**로 변경하고 다음 명령어를 실행합니다:
   **ant runServer**
1. 현재 디렉토리를 Aspose.CAD for Python 데모 중 하나로 변경합니다. 예를 들어 **\InstallDir\demo\samples\charts.ai**로 변경하고 명령줄에서 다음 명령을 실행합니다:
   **ant test** - 보고서 파일을 생성합니다.
1. 생성된 문서 중 하나를 열어보십시오. 예를 들어 **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**를 열어보십시오.
