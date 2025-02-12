---
title: Insert DXF/DWG drawing inside DWG
type: docs
weight: 38
url: /net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **How to insert DXF/DWG drawing inside DWG**

**Issue:** How to insert DXF/DWG drawing inside DWG.

**Tips:** To do this, first create a CadInsertObject with the required values, then get all the blocks in a CadBlockDictionary, create a new CadBlockEntity block and add it to the CadBlockDictionary, add a CadBlockDictionary to the BlockEntities of the drawing, add a CadInsertObject to the drawing entity for the array, create a CadBlockTableObject by reference, then add a block to drawing.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}