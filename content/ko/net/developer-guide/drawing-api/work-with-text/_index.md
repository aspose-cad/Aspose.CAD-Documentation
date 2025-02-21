---
title: 텍스트 작업
type: docs
weight: 40
url: /ko/net/developer-guide/drawing-api/work-with-text/
---

## **텍스트 작업**

거의 모든 그림은 텍스트 객체를 포함하고 있으며, 이 예제는 그것들과 함께 작업하는 방법을 보여줍니다. 
DWG/DXF에서 텍스트를 저장할 수 있는 다양한 유형의 엔티티가 있으며, 이들은 [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/), 
CadAttDef, CadAttrib입니다. 마지막 두 유형은 일반적으로 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)와 관련이 있으며, 
그 안이나 해당 블록에 저장됩니다.

다음은 텍스트와의 작업을 설명하는 몇 가지 예제입니다.

### **텍스트 검색**

이 예제에서는 DWG/DXF 파일에서 텍스트 값을 찾는 방법을 보여주며, 텍스트 값 교체에도 사용할 수 있습니다.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **새 텍스트 및 MText 항목 추가**

여기에는 새 텍스트/MText 객체를 그림에 추가하는 방법의 예가 있습니다. 새 엔티티를 추가하면 그림의 크기가 변경될 수 있으므로, 
이 작업 후에 UpdateSize()를 호출하는 것이 권장됩니다.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
