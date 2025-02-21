---
title: 라이센스
type: docs
weight: 50
url: /ko/java/getting-started/licensing/
---

{{% alert color="primary" %}}

당신은 [다운로드 페이지](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/)에서 **Aspose.CAD**의 평가판을 다운로드할 수 있습니다. 평가판은 이 제품의 라이센스 버전과 동일한 기능을 제공합니다. 게다가, 평가판은 라이센스를 구매하고 라이센스를 적용하기 위한 몇 줄의 코드를 추가할 때 자동으로 라이센스 버전으로 전환됩니다.

**Aspose.CAD**의 평가에 만족하면 Aspose 웹사이트에서 [라이센스를 구매](https://purchase.aspose.com/buy)할 수 있습니다. 제공되는 다양한 구독 유형에 익숙해지세요. 질문이 있는 경우 Aspose 영업 팀에 문의해 주십시오.

모든 Aspose 라이센스는 새로운 버전이나 수정 사항에 대한 무료 업그레이드를 위한 1년 구독을 포함합니다. 기술 지원은 무료이며 무제한으로 제공되며, 라이센스 사용자와 평가판 사용자 모두에게 제공됩니다.

{{% /alert %}}

**Aspose.CAD**를 평가판 제한 없이 테스트하고 싶다면 30일 임시 라이센스를 요청하십시오. 더 많은 정보는 [임시 라이센스 받기](https://purchase.aspose.com/temporary-license)를 참조하십시오.

## **라이센스 설정하기**

라이센스는 제품 이름, 라이센스가 부여된 개발자의 수, 구독 만료 날짜 등의 세부 정보를 포함하는 일반 텍스트 XML 파일입니다. 이 파일은 디지털 서명되어 있으므로 파일을 수정하지 마십시오. 파일에 추가 줄 바꿈을 무심코 추가하는 경우에도 해당 파일은 무효화됩니다.

AutoCAD 파일로 작업을 수행하기 전에 라이센스를 설정해야 합니다. 애플리케이션이나 프로세스당 한 번만 라이센스를 설정하면 됩니다.

라이센스는 다음 위치에서 스트림 또는 파일로 로드할 수 있습니다:

1. 명시적 경로.
1. Aspose.CAD.jar가 포함된 폴더.

License.setLicense() 메서드를 사용하여 구성 요소에 라이센스를 설정하십시오. 라이센스를 설정하는 가장 쉬운 방법은 라이센스 파일을 Aspose.CAD.jar와 같은 폴더에 두고 경로 없이 파일 이름만 지정하는 것입니다. 다음 예제를 참조하십시오:

### **예제 1**

이 예제에서 **Aspose.CAD**는 애플리케이션의 JAR가 포함된 폴더에서 라이센스 파일을 찾으려고 시도합니다.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **예제 2**

스트림에서 라이센스를 초기화합니다.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **라이센스 검증하기**

라이센스가 올바르게 설정되었는지 확인할 수 있습니다. License 클래스에는 라이센스가 올바르게 설정되었을 경우 true를 반환하는 isLicensed 필드가 있습니다.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("라이센스가 설정되었습니다!");

}

{{< /highlight >}}
