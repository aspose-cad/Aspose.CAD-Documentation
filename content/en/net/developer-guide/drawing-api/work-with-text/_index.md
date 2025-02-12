---
title: Work with text
type: docs
weight: 40
url: /net/developer-guide/drawing-api/work-with-text/
---

## **Work with text**

Almost all drawings contain text objects and these examples show how to perform operations with them. 
There are different types of entities for DWG/DXF that can store text, they are [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Two last types are typically related 
to [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
and stored inside it or in the corresponding block.

Here are some examples describing operations with text.

### **Search for the text**

This example shows how to find text values in the DWG/DXF file and may be used also for replacing of text values.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Adding new Text and MText items**

Here is the example how to add new Text/Mtext objects to the drawing. Addition of new entities may change size of the drawing, so it is recommended
to call UpdateSize() after these operations.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
	