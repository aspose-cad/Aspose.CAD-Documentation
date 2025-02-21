---
title: OBJ 파일 형식 작업
type: docs
weight: 120
url: /ko/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD는 이제 OBJ 파일 형식을 지원합니다. OBJ 파일 형식은 텍스처 맵, 3D 좌표, 다각형 면 및 기타 객체 정보를 포함하는 3D 기하학입니다.

{{% /alert %}}

## **OBJ 형식을 PNG로 내보내기**

Angular에서 Aspose.CAD는 개발자가 [OBJ](https://docs.fileformat.com/3d/obj/) 파일을 [PNG](https://docs.fileformat.com/image/png/) 형식으로 내보낼 수 있게 해줍니다.
[OBJ](https://docs.fileformat.com/3d/obj/) 에서 [PNG](https://docs.fileformat.com/image/png/)로의 변환 접근법은 다음과 같이 작동합니다:

1. **Image.load** 메서드를 사용하여 [OBJ](https://docs.fileformat.com/3d/obj/) 드로잉 파일을 로드합니다.
1. 두 번째 매개변수로 **PngOptions** 객체를 전달하면서 **Image.save**를 호출합니다.

## 샘플 코드

아래 코드는 JavaScript용 Aspose.CAD를 사용하여 동일한 목표를 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
