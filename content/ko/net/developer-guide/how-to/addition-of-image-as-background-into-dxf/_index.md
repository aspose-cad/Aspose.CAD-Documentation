---
title: DXF에 배경으로 이미지를 추가하는 방법
type: docs
weight: 16
url: /ko/net/developer-guide/how-to/addition-of-image-as-background-into-dxf/
---

## **DXF에 배경 이미지를 추가하는 방법**

**문제:** DXF에 배경으로 이미지를 추가하는 방법.

**팁:** 이를 위해 배경 이미지의 CadRasterImageDef 객체를 생성하고, 도면을 위한 배경을 삽입할 CadRasterImage 객체를 생성하며, 도면 엔티티에 CadRasterImage 객체를 추가합니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dxf.cs" >}}
