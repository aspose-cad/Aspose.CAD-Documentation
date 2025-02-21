---
title: 저장 시 시간 제한 설정
type: docs
weight: 70
url: /ko/net/developer-guide/set-timeout-on-save/
---

## **저장 시 시간 제한 설정**

Aspose.CAD for .NET API를 사용하면 저장 시 시간 제한을 설정할 수 있습니다. 이는 저장 과정이 오랜 시간이 걸리거나 많은 메모리를 소모하는 경우에 유용할 수 있습니다. 이를 위해 API는 [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) 클래스를 제공합니다. [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) 클래스는 긴 작업을 중단하는 데 사용되는 토큰을 제공합니다.

## 샘플 코드

다음 코드 조각은 [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) 클래스를 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
