---
title: Insert DXF/DWG drawing inside DXF
type: docs
weight: 39
url: /net/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **How to insert DXF/DWG drawing inside DXF**

**Issue:** How to insert DXF/DWG drawing inside DXF.

**Tips:** To do this, you must first create a CadInsertObject with the necessary values, then get all the blocks in the CadBlockDictionary, create a new CadBlockEntity block and add it to the CadBlockDictionary, add the CadBlockDictionary to the BlockEntities of the drawing, add a CadInsertObject to the entities of the drawing for the array.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}