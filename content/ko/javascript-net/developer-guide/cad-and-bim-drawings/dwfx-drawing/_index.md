---
title: DWFx 도면
type: docs
weight: 30
url: /ko/javascript-net/developer-guide/cad-and-bim-drawings/dwfx-drawing/
---

## **DWFX 형식을 PNG로 내보내기**

Aspose.CAD for Javascript in Angular는 개발자가 [DWFX](https://docs.fileformat.com/cad/dwfx/) 파일을 [PNG](https://docs.fileformat.com/image/png/) 형식으로 내보낼 수 있도록 합니다.
[DWFX](https://docs.fileformat.com/cad/dwfx/) 에서 [PNG](https://docs.fileformat.com/image/png/)로 변환하는 접근 방식은 다음과 같습니다:

1. **Image.load** 메서드를 사용하여 [DWFX](https://docs.fileformat.com/cad/dwfx/) 도면 파일을 로드합니다.
2. **PngOptions** 객체를 두 번째 매개변수로 전달하면서 **Image.save**를 호출합니다.

## 샘플 코드

아래 코드는 Aspose.CAD for JavaScript를 사용하여 동일한 목표를 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWFX-to-PNG-Export.js" >}}
