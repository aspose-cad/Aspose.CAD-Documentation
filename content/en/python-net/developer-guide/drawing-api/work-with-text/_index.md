---
title: Work with text
type: docs
weight: 40
url: /python-net/developer-guide/drawing-api/work-with-text/
---

## **Work with text**

Almost all drawings contain text objects and these examples show how to perform operations with them. 
There are different types of entities for DWG/DXF that can store text, they are **CadText**,**CadMText**,CadAttDef, CadAttrib. Two last types are typically related 
to **CadInsertObject** and stored inside it or in the corresponding block.

Here are some examples describing operations with text.

### **Search for the text**

This example shows how to find text values in the DWG/DXF file and may be used also for replacing of text values.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
	