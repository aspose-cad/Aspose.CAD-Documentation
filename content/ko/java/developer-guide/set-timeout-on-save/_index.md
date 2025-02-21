---
title: 저장 시 타임아웃 설정
type: docs
weight: 70
url: /ko/java/developer-guide/set-timeout-on-save/
---

## **저장 시 타임아웃 설정**

Aspose.CAD for Java API를 사용하면 저장 시 타임아웃을 설정할 수 있습니다. 이는 저장 프로세스가 많은 시간이나 많은 메모리를 소모하는 경우에 유용할 수 있습니다. 이를 위해 API는 [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) 클래스를 제공합니다. [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) 클래스는 긴 작업을 중단하는 데 사용되는 토큰을 제공합니다.

## 샘플 코드

다음 코드 조각은 [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) 클래스의 사용을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
