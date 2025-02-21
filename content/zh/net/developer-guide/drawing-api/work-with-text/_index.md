---
title: 与文本合作
type: docs
weight: 40
url: /zh/net/developer-guide/drawing-api/work-with-text/
---

## **与文本合作**

几乎所有的图形都包含文本对象，这些例子展示了如何对它们执行操作。
DWG/DXF 中有不同类型的实体可以存储文本，它们是 [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/)，
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/)，
CadAttDef，CadAttrib。最后两种类型通常与 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
相关，并存储在其中或相应的块中。

以下是一些描述与文本操作的示例。

### **搜索文本**

这个例子展示了如何在 DWG/DXF 文件中查找文本值，也可用于替换文本值。

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **添加新的文本和 MText 项目**

以下示例展示了如何向绘图中添加新的文本/MText 对象。添加新实体可能会改变绘图的大小，因此建议在这些操作后调用 UpdateSize()。

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
