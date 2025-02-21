---
title: 与文本一起工作
type: docs
weight: 40
url: /zh/python-net/developer-guide/drawing-api/work-with-text/
---

## **与文本一起工作**

几乎所有的绘图都包含文本对象，这些示例展示了如何对它们执行操作。 
DWG/DXF 中有不同类型的实体可以存储文本，它们是 **CadText**, **CadMText**, CadAttDef, CadAttrib。最后两种类型通常与 
**CadInsertObject** 相关，并存储在其中或对应的块中。

以下是一些描述与文本操作的示例。

### **搜索文本**

此示例演示了如何在 DWG/DXF 文件中查找文本值，也可用于替换文本值。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
