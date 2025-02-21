---
title: **내보내기 및 로드 중 콜백 오류 검토**
type: docs
weight: 40
url: /ko/net/developer-guide/callback-errors-during-export-and-loading/
---

## **내보내기 및 로드 중 콜백 오류 검토**

도면을 내보내거나 로드하는 동안 파일 구조와 관련된 오류가 발생할 수 있습니다 
(예: 파일의 섹션이 현재는 필요하지만 이전에는 필요하지 않았음). 
이들 중 일부는 치명적이며 이러한 경우 예외가 발생하지만, 
내부적으로 무시할 수 있는 것들도 있으며 콜백 메시지를 사용하여 이에 대해 알릴 수 있습니다.
어쨌든, 이러한 모든 메시지는 주의를 요하며, 예를 들어 내보내기 결과에서 누락된 엔티티나 
다른 영향에 대한 설명이 될 수 있습니다.

### **내보내기 중 오류**

[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/)에는 RenderResult 필드가 있으며,
이 필드는 내보내기 중 오류가 있었는지 확인하기 위해 IsRenderComplete를 포함하고 
그에 대한 정보를 출력합니다:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **로드 중 오류**

도면과 관련된 문제는 내보내기 프로세스가 시작되기 전에 관찰될 수 있습니다. 
[**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) 속성은
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) 객체에서 이들에 대한 메시지를 저장하는 데 사용됩니다.
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) 속성은 
로드 오류에 대해 예외를 발생시킬지 여부를 결정하는 데 유용합니다.

여기 Errors 속성 사용의 예가 있습니다:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
