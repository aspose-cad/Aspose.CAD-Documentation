---
title: 계량 면허
type: docs
weight: 60
url: /ko/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD는 개발자가 계량 키를 적용할 수 있도록 해줍니다. 이는 새로운 라이센스 메커니즘입니다. 새로운 라이센스 메커니즘은 기존의 라이센스 방법과 함께 사용됩니다. API 기능 사용량에 따라 청구받고 싶은 고객은 계량 라이센스를 사용할 수 있습니다. 자세한 내용은 [계량 라이센스 FAQ](https://purchase.aspose.com/faqs/licensing/metered) 섹션을 참조하십시오.

{{% /alert %}} 
## **계량 면허**
Metered 클래스를 사용하기 위한 간단한 단계는 다음과 같습니다.

1. Metered 클래스의 인스턴스를 생성합니다.
1. SetMeteredKey 메서드에 공개 및 비공식 키를 전달합니다.
1. 처리를 수행합니다 (작업 수행).
1. Metered 클래스의 GetConsumptionQuantity 메서드를 호출합니다.
1. 지금까지 사용한 API 요청의 양/수량을 반환합니다.

다음은 계량 공개 및 비공식 키를 설정하는 방법을 보여주는 샘플 코드입니다.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
