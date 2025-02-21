---
title: 텍스트 작업
type: docs
weight: 40
url: /ko/python-net/developer-guide/drawing-api/work-with-text/
---

## **텍스트 작업**

거의 모든 도면에는 텍스트 객체가 포함되어 있으며, 이 예제는 텍스트 객체로 작업하는 방법을 보여줍니다. 
DWG/DXF에서 텍스트를 저장할 수 있는 다양한 유형의 객체가 있으며, 이들은 **CadText**, **CadMText**, CadAttDef, CadAttrib입니다. 마지막 두 유형은 일반적으로 **CadInsertObject**와 관련이 있으며, 그 안에 또는 해당 블록 안에 저장됩니다.

텍스트로 작업하는 예제를 몇 가지 소개합니다.

### **텍스트 검색**

이 예제는 DWG/DXF 파일에서 텍스트 값을 찾는 방법을 보여주며, 텍스트 값 교체에도 사용할 수 있습니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
