---
title: テキストの操作
type: docs
weight: 40
url: /ja/net/developer-guide/drawing-api/work-with-text/
---

## **テキストの操作**

ほとんどすべての図面にはテキストオブジェクトが含まれており、これらの例はそれらを操作する方法を示しています。 
DWG/DXF にはテキストを格納できる異なるタイプのエンティティがあります。それらは [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/)、 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/)、 
CadAttDef、CadAttribです。最後の2つのタイプは通常 [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
に関連しており、それに内蔵されているか、対応するブロックに格納されています。

ここでは、テキストの操作を説明するいくつかの例があります。

### **テキストの検索**

この例は、DWG/DXF ファイル内のテキスト値を見つける方法を示しており、テキスト値の置換にも使用できます。

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **新しいテキストおよびMTextアイテムの追加**

ここに、図面に新しいテキスト/MTextオブジェクトを追加する方法の例があります。 新しいエンティティを追加すると、図面のサイズが変更される可能性があるため、これらの操作の後に UpdateSize() を呼び出すことをお勧めします。

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
