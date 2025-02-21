---
title: 계량 라이센스
type: docs
weight: 60
url: /ko/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD는 개발자가 계량 키를 적용할 수 있도록 허용합니다. 이것은 새로운 라이센스 메커니즘입니다. 새로운 라이센스 메커니즘은 기존 라이센스 방법과 함께 사용됩니다. API 기능의 사용량에 따라 청구되기를 원하는 고객은 계량 라이센스를 사용할 수 있습니다. 자세한 내용은 [계량 라이센스 FAQ](https://purchase.aspose.com/faqs/licensing/metered) 섹션을 참조하세요.

{{% /alert %}} 
## **계량 라이센스**
계량 클래스를 사용하는 간단한 단계는 다음과 같습니다.

1. Metered 클래스의 인스턴스를 생성합니다.
1. setMeteredKey 메서드에 공개 및 비공개 키를 전달합니다.
1. 처리 작업을 수행합니다.
1. Metered 클래스의 getConsumptionQuantity 메서드를 호출합니다.
1. 지금까지 소비한 API 요청의 양/수량을 반환합니다.

다음은 계량 공개 및 비공식 키를 설정하는 방법을 보여주는 샘플 코드입니다:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
