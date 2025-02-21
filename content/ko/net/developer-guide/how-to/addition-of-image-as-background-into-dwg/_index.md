---
title: DWG에 배경으로 이미지를 추가하는 방법
type: docs
weight: 15
url: /ko/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **DWG에 이미지를 배경으로 추가하는 방법**

**문제:** DWG에 이미지를 배경으로 추가하는 방법.

**팁:** 이렇게 하려면, 배경 이미지에 대한 CadRasterImageDef 객체를 생성하고, 도면의 배경을 삽입하기 위한 CadRasterImage 객체를 생성하며, 도면 객체에 CadRasterImage 객체를 추가하고, CadBaseObject를 생성하여 cadImage.Objects에 추가하고, 모든 작업을 CadBlockTableObject를 통해 처리합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
