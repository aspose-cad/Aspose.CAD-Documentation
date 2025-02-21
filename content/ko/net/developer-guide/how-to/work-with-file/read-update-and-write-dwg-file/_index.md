---
title: DWG 파일 읽기, 업데이트 및 쓰기
type: docs
weight: 11
url: /ko/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **DWG 파일 읽기, 업데이트 및 쓰기 방법**

**문제:** DWG 파일을 읽고, 업데이트하며 쓰는 방법.

**팁:** 이를 위해 load 메소드를 사용하여 파일을 가져오고, 필요한 엔티티를 가져와서 시작 및 끝 점이나 선의 두께와 같은 변경을 할 수 있습니다.

**참고:** 이 코드 스니펫은 dwg 파일을 읽고 객체를 변경하는 예를 보여줍니다: 선, 원, 텍스트 값의 위치 (읽기/쓰기가 지원되는 다른 객체 및 해당 값에 대한 변경을 추가할 수 있음) 그리고 새 파일에 저장합니다. 그러므로 AutoCAD에서 새 파일을 열고 변경된 값의 객체를 볼 수 있습니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
