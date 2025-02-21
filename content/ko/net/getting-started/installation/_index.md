---
title: 설치
type: docs
weight: 30
url: /ko/net/getting-started/installation/
---

## **NuGet을 통한 Aspose.CAD for .NET 설치**

NuGet은 Aspose APIs for .NET을 다운로드하고 설치하는 가장 쉬운 방법입니다. Microsoft Visual Studio와 NuGet 패키지 관리자를 엽니다. "aspose"를 검색하여 원하는 Aspose API를 찾습니다. "설치"를 클릭하면 선택한 API가 다운로드되어 프로젝트에 참조됩니다.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **.NET 프로젝트에서 Aspose.CAD 참조하기**

다음 단계를 따르세요 (Microsoft Visual Studio를 사용하는 경우):

1. **솔루션 탐색기**에서 참조를 추가할 프로젝트 노드를 확장합니다.
1. 프로젝트의 **참조** 노드를 마우스 오른쪽 버튼으로 클릭하고 바로 가기 메뉴에서 **참조 추가**를 선택합니다.
1. **참조 추가** 대화 상자에서 DLL 파일 위치를 찾아봅니다.
1. *Aspose.CAD* DLL 파일을 선택하고 **확인** 버튼을 클릭합니다.
1. *Aspose.CAD* 참조가 프로젝트의 **참조** 노드 아래에 나타납니다.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **패키지 관리자 콘솔을 사용하여 Aspose.CAD 설치 또는 업데이트하기**

패키지 관리자 콘솔을 사용하여 [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/)를 참조하려면 아래 단계를 따르세요:

1. Visual Studio에서 솔루션/프로젝트를 엽니다.
1. 메뉴에서 도구 -> 라이브러리 패키지 관리자 -> 패키지 관리자 콘솔을 선택하여 패키지 관리자 콘솔을 엽니다.

![todo:image_alt_text](/_assets/install/installation_3.png)

“**Install-Package Aspose.CAD**”라는 명령을 입력하고 Enter를 눌러 최신 전체 릴리스를 애플리케이션에 설치합니다. 또는 최신 릴리스에 핫픽스를 포함하여 설치하도록 명령에 "**-prerelease**" 접미사를 추가할 수 있습니다.

![todo:image_alt_text](/_assets/install/installation_4.png)

"다운로드 중인 Aspose.CAD..."라는 팁이 창의 왼쪽 하단에 나타나며 다운로드가 진행 중임을 나타냅니다. 

![todo:image_alt_text](/_assets/install/installation_5.png)

다운로드가 완료되면 다음 확인 메시지를 볼 수 있습니다. [Aspose EULA](https://about.aspose.com/legal/eula)에 익숙하지 않은 경우 URL에 참조된 라이센스를 읽는 것이 좋습니다.

![todo:image_alt_text](/_assets/install/installation_6.png)

이제 Aspose.CAD가 애플리케이션에 성공적으로 추가되고 참조된 것을 확인할 수 있습니다.

![todo:image_alt_text](/_assets/install/installation_7.png)

패키지 관리자 콘솔에서 “**Update-Package Aspose.CAD**”라는 명령을 입력하고 Enter를 눌러 Aspose.CAD 패키지의 업데이트를 확인하고, 존재하는 경우 설치할 수 있습니다. 또한 "-prerelease" 접미사를 추가하여 최신 릴리스를 업데이트할 수 있습니다.

## **공유 서버 환경에서 실행 시 고려사항**

모든 Aspose .NET 구성 요소는 전체 신뢰 권한 집합으로 실행하는 것이 권장됩니다. 이는 Aspose .NET 구성 요소가 때때로 레지스트리 설정과 가상 디렉토리 외의 위치에 있는 파일에 접근할 필요가 있기 때문입니다. 예를 들면 폰트를 읽는 등의 작업이 가능합니다. 또한 Aspose.NET 구성 요소는 일부가 실행하기 위해 전체 신뢰 권한이 필요한 .NET 시스템 클래스를 기반으로 합니다.

여러 업체의 애플리케이션을 호스팅하는 인터넷 서비스 제공업체는 대부분 중간 신뢰 보안 수준을 적용합니다. .NET 2.0의 경우, 이러한 보안 수준은 Aspose.CAD가 제대로 작동하는 능력에 영향을 줄 수 있는 다음과 같은 제약 조건을 설정할 수 있습니다.

- **RegistryPermission** 사용 불가. 이는 레지스트리에 접근할 수 없음을 의미하며, 문서를 렌더링할 때 설치된 폰트를 열거하는 데 필요합니다.
- **FileIOPermission** 제한됨. 이는 애플리케이션의 가상 디렉토리 계층에서만 파일에 접근할 수 있음을 의미합니다. 이는 내보내기 중 폰트를 읽을 수 없음을 의미할 수 있습니다.

위에서 지정한 이유로, Aspose.CAD는 전체 신뢰 권한으로 실행하는 것이 권장됩니다. 라이브러리의 일부 기능은 중간 신뢰를 수행할 때 작동하지만 일부는 작동하지 않을 수 있습니다 (예를 들어 렌더링 등)은 GDI+ 이미지 처리 호출로 인해 발생할 수 있습니다.

## **시스템 요구 사항**

### **운영 체제**

Aspose.CAD for .NET은 .NET 또는 Mono 프레임워크가 설치된 32비트 또는 64비트 운영 체제를 지원합니다. 다음 포함하되 이에 국한되지 않습니다:

- Microsoft Windows 데스크톱 (XP, Vista, 7, 8, 10) 및 서버 운영 체제 (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS 등)
- Mac OS X

### **프레임워크**

Aspose.CAD for .NET은 다음을 지원합니다:

- 클라이언트 프로필 버전을 포함한 .NET Framework 버전 2.0~4.5
- .NET Core
- Mono 2.6.7 또는 그 이후 버전

### **개발 환경**

Aspose.CAD for .NET을 사용하여 .NET 플랫폼을 대상으로 하는 모든 개발 환경에서 애플리케이션을 개발할 수 있지만, 다음 환경은 명시적으로 지원됩니다:

- Microsoft Visual Studio 2010 이상
- MonoDevelop 2.4 및 그 이후 버전
