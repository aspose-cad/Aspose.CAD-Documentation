---
title: 계량 라이선스
type: docs
weight: 40
url: /ko/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD는 개발자가 계량 키를 적용할 수 있도록 합니다. 이것은 새로운 라이선스 메커니즘입니다. 새로운 라이선스 메커니즘은 기존 라이선스 방법과 함께 사용됩니다. API 기능 사용에 기반하여 청구되기를 원하는 고객은 계량 라이선스를 사용할 수 있습니다. 추가 정보는 [계량 라이선스 FAQ](https://purchase.aspose.com/faqs/licensing/metered) 섹션을 참조하십시오.

{{% /alert %}} 
## **계량 라이선스**
계량 클래스를 사용하기 위한 간단한 단계는 다음과 같습니다.

1. Metered 클래스의 인스턴스를 만듭니다.
1. SetMeteredKey 메서드에 공개 키 및 비공개 키를 전달합니다.
1. 처리 작업을 수행합니다.
1. Metered 클래스의 GetConsumptionQuantity 메서드를 호출합니다.
1. 지금까지 소비한 API 요청의 양/수량을 반환합니다.

다음은 계량 공개 키와 비공개 키를 설정하는 방법을 보여주는 샘플 코드입니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
