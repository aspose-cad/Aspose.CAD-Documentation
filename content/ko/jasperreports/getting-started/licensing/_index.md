---
title: 라이센스
type: docs
weight: 40
url: /ko/jasperreports/getting-started/licensing/
---
## **setLicense 호출**
라이센스를 적용하려면:

라이센스 파일을 디스크의 폴더에 저장합니다. 예를 들어 C:\Lic\Aspose.CAD.JasperReport.lic.
License.setLicense(filename) 메서드를 호출하고 파일 이름을 인수로 전달합니다. 이 문장이 호출되면 라이센스가 설정되고 평가 메시지가 더 이상 이미지 상단에 나타나지 않습니다.
다음 코드 스니펫은 Aspose.CAD for JasperReports의 라이센스를 설정합니다.

{{< highlight java >}}

// 라이센스 설정

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

setLicense() 메서드는 프로세스나 애플리케이션당 한 번만 호출하면 됩니다.

{{% /alert %}}

## **applicationContext.xml에서 라이센스 Exporter 매개변수 설정**
{{% alert color="primary" %}}
이 방법은 JasperServer와 함께 사용할 수 있습니다.
{{% /alert %}}
1. 라이센스를 컴퓨터에 다운로드하고 \apache-tomcat\webapps\jasperserver\WEB-INF 폴더에 복사합니다. 여기서 는 JasperServer 설치 디렉토리를 나타냅니다.
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml 파일을 찾아 다음 줄을 추가합니다:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
