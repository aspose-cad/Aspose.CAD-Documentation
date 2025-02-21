---
title: 예제 실행 방법
type: docs
weight: 70
url: /ko/net/showcases/how-to-run-the-examples/
---

## **소프트웨어 요구 사항**

예제를 다운로드하고 실행하기 전에 다음 요구 사항을 충족하는지 확인하십시오.

1. Visual Studio 2010 이상
1. Visual Studio에 NuGet 패키지 관리자가 설치되어 있어야 합니다. 최신 NuGet API 버전이 Visual Studio에 설치되어 있는지 확인하십시오. NuGet 패키지 관리자를 설치하는 방법에 대한 자세한 내용은 https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools를 확인하십시오.
1. Tools->Options->NuGet Package Manager->Package Sources로 이동하여 **nuget.org** 옵션이 선택되어 있는지 확인하십시오.
1. 예제 프로젝트는 NuGet 자동 패키지 복원 기능을 사용하므로 활성 인터넷 연결이 있어야 합니다. 예제를 실행할 머신에 활성 인터넷 연결이 없는 경우 [설치](/ko/cad/net/installation/)를 확인하여 예제 프로젝트에서 Aspose.CAD.dll에 참조를 추가하십시오.

## **GitHub에서 다운로드**

Aspose.CAD for .NET의 모든 예제는 [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET)에 호스팅되어 있습니다.

- 좋아하는 GitHub 클라이언트를 사용하여 저장소를 복제하거나 [여기](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip)에서 ZIP 파일을 다운로드할 수 있습니다.
- ZIP 파일의 내용을 컴퓨터의 아무 폴더로 추출하십시오. 모든 예제는 **Examples** 폴더에 위치해 있습니다.
- C#용 Visual Studio 솔루션 파일이 있습니다.
- 프로젝트는 Visual Studio 2013에서 생성되었지만 솔루션 파일은 Visual Studio 2010 SP1 이상과 호환됩니다.
- Visual Studio에서 솔루션 파일을 열고 프로젝트를 빌드하십시오.
- 첫 번째 실행 시 의존성은 NuGet을 통해 자동으로 다운로드됩니다.
- **Examples**의 루트 폴더에 있는 **Data** 폴더는 CSharp 예제가 사용하는 입력 파일을 포함하고 있습니다. 예제 프로젝트와 함께 **Data** 폴더를 다운로드하는 것은 필수입니다.
- RunExamples.cs 파일을 열고 모든 예제가 여기에서 호출됩니다.
- 프로젝트 내에서 실행할 예제를 주석 해제하십시오.

설정이나 실행에 대한 문제가 있는 경우 언제든지 포럼을 통해 문의해 주십시오.

## **기여**

예제를 추가하거나 개선하고 싶으시다면 프로젝트에 기여하시기를 권장합니다. 이 저장소의 모든 예제 및 쇼케이스 프로젝트는 오픈 소스이며 귀하의 애플리케이션에서 자유롭게 사용할 수 있습니다.

기여하려면 저장소를 포크하고 소스 코드를 편집한 후 풀 요청을 생성할 수 있습니다. 변경 사항을 검토하고 유용하다고 판단되면 저장소에 포함하겠습니다.
