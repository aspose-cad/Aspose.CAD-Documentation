---
title: FBX 도면
type: docs
weight: 70
url: /ko/javascript-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX 포맷을 PNG로 내보내기**

Angular의 Aspose.CAD는 개발자가 [FBX](https://docs.fileformat.com/3d/fbx/) 파일을 [PNG](https://docs.fileformat.com/image/png/) 형식으로 내보낼 수 있도록 합니다.
[FBX](https://docs.fileformat.com/3d/fbx/) 을 [PNG](https://docs.fileformat.com/image/png/) 형식으로 변환하는 접근 방식은 다음과 같이 작동합니다:

1. **Image.load** 메서드를 사용하여 [FBX](https://docs.fileformat.com/3d/fbx/) 도면 파일을 불러옵니다.
1. 두 번째 매개변수로 **PngOptions** 객체를 전달하면서 **Image.save**를 호출합니다.

## 샘플 코드

아래 코드는 Aspose.CAD for JavaScript를 사용하여 동일한 목표를 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-FBX-to-PNG-Export.js" >}}
