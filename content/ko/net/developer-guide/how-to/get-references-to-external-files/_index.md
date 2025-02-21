---
title: 외부 파일에 대한 참조 가져오기
type: docs
weight: 36
url: /ko/net/developer-guide/how-to/get-references-to-external-files/
---

## **외부 파일에 대한 참조 가져오는 방법**

**문제:** 외부 파일에 대한 참조를 가져오는 방법 (CADNET-110).

**팁:** 엔티티 블록의 도면에 대한 외부 파일의 참조를 얻으려면 래스터 이미지에 대한 XRef PathName 필드가 있으며 CadRasterImage Def는 외부 하위 레이아웃에 사용되고 CadDgnUnderlay는 하위 레이아웃 및 해당 UnderlayPath 필드에 사용됩니다.

**예시:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
