---
title: 라이선스
type: docs
weight: 50
url: /ko/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Aspose.CAD for .NET의 평가가 만족스러우면, Aspose 웹사이트에서 라이선스를 구매하세요: [구매 포털](https://purchase.aspose.com/buy). 사용 가능한 다양한 라이선스 유형에 익숙해지세요. 질문이 있으시면, [Aspose 영업팀에 문의하세요](https://about.aspose.com/contact) 그들이 기꺼이 도와드릴 것입니다.

모든 Aspose 라이선스는 무료 업그레이드를 위한 1년 구독 기간이 포함되어 있습니다. 우리는 라이선스 사용자와 평가 사용자 모두에게 무료 및 무제한 기술 지원을 제공합니다.

라이선스는 제품 이름, 라이선스 개발자 수, 구독 만료일 등의 세부정보를 포함하는 평문 XML 파일입니다. 파일은 디지털 서명되어 있으므로 파일을 수정하지 마세요: 파일에 줄 바꿈을 추가하는 것만으로도 파일이 무효화됩니다.

{{% /alert %}}

## **라이선스를 적용할 때**

다음 간단한 규칙을 따르세요:

- 라이선스는 애플리케이션 도메인당 한 번만 설정하면 됩니다.
- 다른 Aspose.CAD 클래스를 사용하기 전에 라이선스를 설정해야 합니다.
- SetLicense를 여러 번 호출해도 해롭지는 않지만, 프로세서 시간을 낭비하게 됩니다.
- Windows Forms 또는 콘솔 애플리케이션을 개발하는 경우, Aspose.CAD 클래스를 사용하기 전에 시작 코드에서 SetLicense를 호출하세요.
- ASP.NET 애플리케이션을 개발할 때는 Application_Start 보호 방법에서 Global.asax.cs (Global.asax.vb) 파일에서 SetLicense를 호출하세요. 애플리케이션이 시작될 때 한 번 호출됩니다.
- 웹 페이지가 로드될 때마다 라이선스가 로드되므로 Page_Load 메서드 내에서 SetLicense를 호출하지 마세요.
- 클래스 라이브러리를 개발하는 경우, Aspose.CAD를 사용하는 클래스의 정적 생성자에서 SetLicense를 호출합니다. 정적 생성자는 클래스의 인스턴스가 생성되기 전에 실행되므로 Aspose.CAD 라이선스가 올바르게 설정됩니다.

## **파일 또는 스트림 객체를 사용하여 라이선스 적용하기**

구성 요소에 라이선스를 부여하려면 **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** 메서드를 사용하십시오. 라이선스를 설정하는 가장 쉬운 방법은 라이선스 파일을 Aspose.CAD.dll과 동일한 폴더에 놓고 아래와 같이 경로 없이 파일 이름을 지정하는 것입니다.

### **파일에서 라이선스 로드하기**

이 코드 스니펫은 파일 또는 포함된 리소스에 저장된 라이선스를 초기화합니다.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **스트림 객체에서 라이선스 로드하기**

이 코드 스니펫은 스트림에서 라이선스를 초기화합니다.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
