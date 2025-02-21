---
title: CF2 도면
type: docs
weight: 110
url: /ko/javascript-net/developer-guide/cad-and-bim-drawings/cf2-drawings/
---

## **CF2 형식을 PNG로 내보내기**

Aspose.CAD for Javascript in Angular는 개발자가 [CF2](https://docs.fileformat.com/cad/cf2/) 파일을 [PNG](https://docs.fileformat.com/image/png/) 형식으로 내보낼 수 있도록 허용합니다.
[CF2](https://docs.fileformat.com/cad/cf2/)에서 [PNG](https://docs.fileformat.com/image/png/)로의 변환 방법은 다음과 같습니다:

1. **Image.load** 메서드를 사용하여 [CF2](https://docs.fileformat.com/cad/cf2/) 도면 파일을 로드합니다.
2. 두 번째 매개변수로 **PngOptions** 객체를 넘어가면서 **Image.save**를 호출합니다.

## 샘플 코드

아래 코드는 Aspose.CAD for JavaScript를 사용하여 동일한 목표를 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-CF2-to-PNG-Export.js" >}}
